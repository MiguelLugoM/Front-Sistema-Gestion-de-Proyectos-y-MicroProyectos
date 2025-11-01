using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Responsable
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de responsable.")]
        public int IdTipoResponsable { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un usuario.")]
        public int IdUsuario { get; set; }

        [Required, StringLength(255)]
        public string Nombre { get; set; } = string.Empty;
    }

    public class RespuestaApiResponsable<T>
    {
        public T? Datos { get; set; }
    }
}
