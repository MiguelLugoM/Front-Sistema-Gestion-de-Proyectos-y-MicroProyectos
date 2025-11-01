using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Estado_Proyecto
    {
        [Required]
        public int IdProyecto { get; set; }

        [Required]
        public int IdEstado { get; set; }
    }

    public class RespuestaApiEstadoProyecto<T>
    {
        public T? Datos { get; set; }
    }
}
