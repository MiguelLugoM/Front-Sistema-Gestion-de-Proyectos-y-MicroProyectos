using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Entregable
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [StringLength(50)]
        public string? Codigo { get; set; }

        [Required, StringLength(255)]
        public string Titulo { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFinPrevista { get; set; }

        // La asignamos SIEMPRE desde el sistema (crear/actualizar)
        [DataType(DataType.Date)]
        public DateTime? FechaModificacion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFinalizacion { get; set; }
    }

    public class RespuestaApiEntregable<T>
    {
        public T? Datos { get; set; }
    }
}
