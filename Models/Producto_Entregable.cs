using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Producto_Entregable
    {
        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int IdEntregable { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaAsociacion { get; set; }
    }

    public class RespuestaApiProductoEntregable<T>
    {
        public string? Tabla { get; set; }
        public string? Esquema { get; set; }
        public int? Total { get; set; }
        public T? Datos { get; set; }
    }
}
