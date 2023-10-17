using AuthorizationFormDemo.DataAccess;
using System.ComponentModel.DataAnnotations;

namespace AuthorizationFormDemo.Models;

public class PersonModel
{
    public int Id { get; set; }
    [Required]
    [Range(1, 1000000000000000, ErrorMessage = "Tiene que ser un numero positivo")]
    public int? Cedula { get; set; } = null;
    [Required(ErrorMessage = "Campo Obligatorio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "Campo Obligatorio")]
    public string Apellido { get; set; }
    [Required(ErrorMessage = "Campo Obligatorio")]
    public string Celular { get; set; }

    [MustHaveTwoElements(ErrorMessage = "Se necesita minimo 2 Canales")]
    public IEnumerable<string> CanalesAutorizados { get; set; } = Enumerable.Empty<string>();

    [Required(ErrorMessage = "Campo Obligatorio")]
    public string Agencia { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    [Range(typeof(bool), "true", "true", ErrorMessage = "Tiene que Acpetar")]
    public bool EsAutorizado { get; set; }
    public DateTime FechaRegistro { get; set; }
    public string Ip { get; set; }
    public string token { get; set; }
    public string tokenVerificacion { get; set; }
    [Required]
    [EmailAddress(ErrorMessage = "Correo Invalido")]
    public string correo { get; set; }


}
