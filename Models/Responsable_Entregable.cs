using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Responsable_Entregable
    {
        [Required]
        public int IdResponsable { get; set; }

        [Required]
        public int IdEntregable { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaAsociacion { get; set; }
    }

    public class RespuestaApiResponsableEntregable<T>
    {
        public string? Tabla { get; set; }
        public string? Esquema { get; set; }
        public int? Total { get; set; }
        public T? Datos { get; set; }
    }
}
