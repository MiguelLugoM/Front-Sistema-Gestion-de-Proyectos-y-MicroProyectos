using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class DistribucionPresupuesto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required]
        public int IdPresupuestoPadre { get; set; }

        [Required]
        public int IdProyectoHijo { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto asignado debe ser mayor a 0.")]
        public decimal MontoAsignado { get; set; }
    }

    public class RespuestaApiDistribucion<T>
    {
        public T? Datos { get; set; }
    }
}
