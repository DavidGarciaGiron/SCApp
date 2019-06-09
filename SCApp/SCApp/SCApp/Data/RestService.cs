using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SCApp.Models;

namespace SCApp.Data
{
    public class RestService: IRestService
    {
        HttpClient _client;
        public List<Usuario> Items { get; private set; }
        public RestService()
        {
            _client = new HttpClient();
        }
        public async Task<List<Usuario>> RefreshDataAsync()
        {
            var Users = new List<Usuario>();
            var uri = new Uri(String.Format(Constants.usuarioUrl, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Users = JsonConvert.DeserializeObject<List<Usuario>>(content);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Users;
        }
        public async Task SaveUsuarioAsync(Usuario user, bool isNewUser = false)
        {
            var uri = new Uri(string.Format(Constants.usuarioUrl, string.Empty));
            try
            {
                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                if (isNewUser)
                {
                    response = await _client.PostAsync(uri, content);
                }
                else
                {
                    response = await _client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tUsuario successfully saved.");
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        public async Task DeleteTodoItemAsync(string id)
        {
            var uri = new Uri(string.Format(Constants.usuarioUrl, id));
            try
            {
                var response = await _client.DeleteAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tTodoItem successfully deleted.");
                }
            } catch (Exception ex) {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        public Task DeleteUsuarioAsync(int id_usuario)
        {
            throw new NotImplementedException();
        }
    }
}