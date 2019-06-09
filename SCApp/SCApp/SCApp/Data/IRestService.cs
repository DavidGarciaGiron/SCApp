using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SCApp.Models;

namespace SCApp.Data
{
    public interface IRestService
    {
        Task<List<Usuario>> RefreshDataAsync();
        Task SaveUsuarioAsync(Usuario user, bool isNewUser);
        Task DeleteUsuarioAsync(int id_usuario);
    }
}
