using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class EjecucionPresupuesto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required]
        public int IdPresupuesto { get; set; }

        [Required]
        public int Anio { get; set; }

        public decimal? MontoPlaneado { get; set; }
        public decimal? MontoEjecutado { get; set; }
        public string? Observaciones { get; set; }
    }

    public class RespuestaApiEjecucion<T>
    {
        public T? Datos { get; set; }
    }
}
