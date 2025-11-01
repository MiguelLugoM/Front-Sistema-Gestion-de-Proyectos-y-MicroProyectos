using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Meta_Proyecto
    {
        [Required]
        public int IdMeta { get; set; }

        [Required]
        public int IdProyecto { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaAsociacion { get; set; }
    }

    public class RespuestaApiMetaProyecto<T>
    {
        public T? Datos { get; set; }
    }
}
