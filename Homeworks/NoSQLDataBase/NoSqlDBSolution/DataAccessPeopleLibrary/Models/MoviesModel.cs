using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessPeopleLibrary.Models
{
    public class MoviesModel
    {
        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NameMovie { get; set; }
        public string Year { get; set; }
        public string DescriptionMovie { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
