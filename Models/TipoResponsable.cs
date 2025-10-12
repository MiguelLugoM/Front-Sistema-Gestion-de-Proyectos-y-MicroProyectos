using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class TipoResponsable
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Titulo { get; set; } = string.Empty;

        [Required, StringLength(255)]
        public string Descripcion { get; set; } = string.Empty;
    }

    public class RespuestaApiTipoResponsable<T>
    {
        public T? Datos { get; set; }
    }
}
