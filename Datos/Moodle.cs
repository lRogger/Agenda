using MySqlX.XDevAPI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



namespace Datos
{
    public class Moodle
    {
        private readonly string moodleUrl = "https://campusvirtual2.ug.edu.ec";

        private string token;
        public string Token { get => token; set => token = value; }

        public Moodle() { 
            this.Token="";
            
        }


        //CLASES INTERNAS PARA ABSTRAER JSON
        public class MoodleToken
        {
            public string token { get; set; }
        }

        public class MoodleEvent
        {
            public string name { get; set; }
            public int timestart { get; set; }
        }
        //-----------------------

        public async void IniciarSesion(string user, string pwd)
        {
            try
            {
                var loginData = new Dictionary<string, string>
            {
               { "wsfunction", "core_user_login" },
               { "username", user },
               { "password", pwd }
            };

                var loginContent = new FormUrlEncodedContent(loginData);


                using (var cliente = new HttpClient())
                {
                    
                    var loginResponse = await cliente.PostAsync(moodleUrl + "/login", new FormUrlEncodedContent(loginData));
                    Debug.WriteLine(await loginResponse.Content.ReadAsStringAsync());
                    var loginJson = JsonConvert.DeserializeObject<MoodleToken>(await loginResponse.Content.ReadAsStringAsync());

                    if (loginJson?.token == null)
                    {
                        throw new Exception("Contraseña Incorrecta");
                    }

                    Token = loginJson.token;
                    
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            

        }

        public async Task<List<MoodleEvent>> GetUserEvents()
        {

            using (var cliente = new HttpClient())
            {
                cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);
                var eventsResponse = await cliente.GetAsync(moodleUrl + "/userevents");
                var eventsJson = JsonConvert.DeserializeObject<List<MoodleEvent>>(await eventsResponse.Content.ReadAsStringAsync());
                return eventsJson;
            }

        }
    }
}
