using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class MetaEstrategica
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un objetivo estratégico.")]
        public int IdObjetivo { get; set; }

        [Required, StringLength(255)]
        public string Titulo { get; set; } = string.Empty;

        public string? Descripcion { get; set; }
    }

    public class RespuestaApiMetaEstrategica<T>
    {
        public T? Datos { get; set; }
    }
}
