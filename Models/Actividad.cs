using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Actividad
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El entregable es obligatorio.")]
        public int IdEntregable { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(255)]
        public string Titulo { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFinPrevista { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaModificacion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFinalizacion { get; set; }

        public int? Prioridad { get; set; }

        public int? PorcentajeAvance { get; set; }
    }

    // Clase genérica para deserializar la respuesta de la API
    public class RespuestaApiActividad<T>
    {
        public string? Tabla { get; set; }
        public string? Esquema { get; set; }
        public int? Total { get; set; }
        public T? Datos { get; set; }
    }
}
