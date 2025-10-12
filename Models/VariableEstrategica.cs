using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class VariableEstrategica
    {
        // No enviar el Id cuando se crea (IDENTITY)
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Titulo { get; set; } = string.Empty;

        // La columna en DB permite NULL, así que el modelo también
        public string? Descripcion { get; set; }
    }
    public class RespuestaApiVariableEstrategica<T>
    {
        public T? Datos { get; set; }
    }
}
