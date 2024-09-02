using System.ComponentModel.DataAnnotations;

namespace BrunoSpaBlazor.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; } = 1;

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras.")]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras.")]
        public string ApellidoUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Solo se permiten Numero.")]
        public string DocumentoUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Correo Electronico es obligatorio.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Por favor, introduce un correo electrónico válido.")]
        public string CorreoElectronicoUsuario { get; set; } = string.Empty;

        [Range(1, 100, ErrorMessage = "La edad debe ser mayor que 0 y menor o igual a 100.")]
        public int EdadUsuario { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateOnly FechaNacimientoUsuario { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
