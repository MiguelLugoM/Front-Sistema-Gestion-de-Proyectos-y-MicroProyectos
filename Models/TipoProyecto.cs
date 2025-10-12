using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class TipoProyecto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(255)]
        public string Descripcion { get; set; } = string.Empty;
    }

    public class RespuestaApiTipoProyecto<T>
    {
        public T? Datos { get; set; }
    }
}
