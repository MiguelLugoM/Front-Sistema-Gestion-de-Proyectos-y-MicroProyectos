using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Presupuesto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El proyecto es obligatorio.")]
        public int IdProyecto { get; set; }

        [Required(ErrorMessage = "El monto solicitado es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto solicitado debe ser mayor a 0.")]
        public decimal MontoSolicitado { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio.")]
        [StringLength(20)]
        public string Estado { get; set; } = "Pendiente";

        [Range(0, double.MaxValue, ErrorMessage = "El monto aprobado no puede ser negativo.")]
        public decimal? MontoAprobado { get; set; }

        public int? PeriodoAnio { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaSolicitud { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaAprobacion { get; set; }

        public string? Observaciones { get; set; }
    }

    public class RespuestaApiPresupuesto<T>
    {
        public string? Tabla { get; set; }
        public string? Esquema { get; set; }
        public int? Total { get; set; }
        public T? Datos { get; set; }
    }
}
