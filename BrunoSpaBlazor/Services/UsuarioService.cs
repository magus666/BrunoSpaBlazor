using BrunoSpaBlazor.Models;

namespace BrunoSpaBlazor.Services
{
    public class UsuarioService
    {
        private List<UsuarioModel> usuarios = new List<UsuarioModel>();
        private int nextId = 1;

        public List<UsuarioModel> ObtenerUsuarios()
        {
            return usuarios;
        }

        public void AgregarUsuario(UsuarioModel usuario)
        {
            usuario.IdUsuario = nextId++;
            usuarios.Add(usuario);
        }
        public void EditarUsuario(UsuarioModel usuario)
        {
            var usuarioExistente = (from x in usuarios
                                    where x.IdUsuario == usuario.IdUsuario
                                    select x).FirstOrDefault();
            if (usuarioExistente != null)
            {
                usuarioExistente.NombreUsuario = usuario.NombreUsuario;
                usuarioExistente.ApellidoUsuario = usuario.ApellidoUsuario;
                usuarioExistente.EdadUsuario = usuario.EdadUsuario;
                usuarioExistente.FechaNacimientoUsuario = usuario.FechaNacimientoUsuario;
            }
        }

        public void EliminarUsuario(int idUsuario)
        {
            var Usuario = (from x in usuarios
                           where x.IdUsuario == idUsuario
                           select x).FirstOrDefault();
            if (Usuario != null)
            {
                usuarios.Remove(Usuario);
            }
        }
    }
}
