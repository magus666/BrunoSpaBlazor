using BrunoSpaBlazor.Models;

namespace BrunoSpaBlazor.Services
{
    public class EstadoUsuarioService
    {
        public event Action OnChange;
        private List<UsuarioModel> usuarios = new List<UsuarioModel>();

        public List<UsuarioModel> ObtenerUsuarios() => usuarios;

        public void AgregarUsuario(UsuarioModel usuario)
        {
            usuarios.Add(usuario);
            NotifyStateChanged();
        }

        public void EliminarUsuario(int idUsuario)
        {
            var usuario = usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
