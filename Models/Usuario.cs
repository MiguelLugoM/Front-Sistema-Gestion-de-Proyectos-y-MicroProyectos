using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FrontendBlazorApi.Models
{
    public class Usuario
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [Required, StringLength(150)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // No siempre querrás mandarla en update si queda vacía
        [StringLength(255)]
        public string? Contrasena { get; set; }

        public string? RutaAvatar { get; set; }

        public bool Activo { get; set; } = true;
    }

    public class UsuarioCreateDto
    {
        [Required, StringLength(150)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(255)]
        public string Contrasena { get; set; } = string.Empty;

        public string? RutaAvatar { get; set; }
        public bool Activo { get; set; } = true;
    }

    public class UsuarioUpdateDto
    {
        // Email podría ser editable o no según tu negocio
        [Required, StringLength(150)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // Password opcional en update: si es null/vacía, no cambiarla
        public string? Contrasena { get; set; }

        public string? RutaAvatar { get; set; }
        public bool Activo { get; set; }
    }

    public class RespuestaApiUsuarios<T> { public T? Datos { get; set; } }
}
