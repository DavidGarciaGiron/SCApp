using JSIStudios.SimpleRESTServices.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SCApp.Models;

namespace SCApp.Data
{
    class UsuarioManager
    {
        IRestService restService;

        public UsuarioManager (IRestService service)
        {
            restService = service;
        }
        public Task<List<Usuario>> GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }
        public Task SaveTaskAsync (Usuario user, bool isNewUser = false)
        {
            return restService.SaveUsuarioAsync(user, isNewUser);
        }
        public Task DeleteTaskAsync (Usuario user)
        {
            return restService.DeleteUsuarioAsync(user.id_usuario);
        }

    }
}
