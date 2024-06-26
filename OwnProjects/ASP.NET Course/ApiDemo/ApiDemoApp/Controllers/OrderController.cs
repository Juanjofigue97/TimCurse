﻿using ApiDemoApp.Model;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderData _orderData;
        private readonly IFoodData _foodData;

        public OrderController(IOrderData orderData,IFoodData foodData) 
        {
            _orderData = orderData;
            _foodData = foodData;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(OrderModel order)
        {
            var food = await _foodData.GetFood();

            order.Total = order.Quantity * food.Where(x => x.Id == order.FoodId).First().Price;

            int id = await _orderData.CreateOrder(order);

            return Ok(new { Id =  id });
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id) 
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var order = await _orderData.GetOrderById(id);

            if(order != null)
            {
                var food = await _foodData.GetFood();
                var output = new
                {
                    Order = order,
                    ItemPurchased = food.Where(x => x.Id == order.FoodId).FirstOrDefault()?.Title
                };

                return Ok(output);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> Put([FromBody] OrderUpdateModel data)
        {
            await _orderData.UpdateOrderName(data.Id, data.OrderName);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            await _orderData.DeleteOrder(id);
            return Ok(new { Id = id });    
        }
    }
}
