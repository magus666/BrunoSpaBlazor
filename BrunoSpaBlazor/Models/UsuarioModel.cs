﻿using System.ComponentModel.DataAnnotations;

namespace BrunoSpaBlazor.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; } = 1;

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string ApellidoUsuario { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "La edad debe ser mayor que 0.")]
        public int EdadUsuario { get; set; } = 0;

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateOnly FechaNacimientoUsuario { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
