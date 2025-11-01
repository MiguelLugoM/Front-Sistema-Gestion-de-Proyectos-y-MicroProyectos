using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class ObjetivoEstrategico
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una variable estratégica.")]
        public int IdVariable { get; set; }

        [Required, StringLength(255)]
        public string Titulo { get; set; } = string.Empty;

        public string? Descripcion { get; set; }
    }

    public class RespuestaApiObjetivoEstrategico<T>
    {
        public T? Datos { get; set; }
    }
}
