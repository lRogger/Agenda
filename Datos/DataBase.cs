using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class DataBase
    {
        private string server, user, pass, db, strCon;
        private DataSet ds;

        public DataBase()
        {
            this.server = "db4free.net";
            this.user = "lrogger98";
            this.pass = "Rogger123";
            this.db = "agendaug";

            this.strCon = "server=" + server +
                    ";user id=" + user + ";password=" + pass + ";database=" + db + ";";
        }

        public void Insertar(Object o)
        {
            if (o is Persona)
            {
                Persona persona = (Persona)o;

                using (MySqlConnection connection = new MySqlConnection(strCon))
                {
                    connection.Open();

                    string query = "INSERT INTO User (Cedula, Nombre, Edad, Password, Correo, Admin, Imagen) " +
                        "VALUES (@Cedula, @Nombre, @Edad, @Password, @Correo, @Admin, @Imagen)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cedula", persona.Cedula);
                        command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                        command.Parameters.AddWithValue("@Edad", persona.Edad);
                        command.Parameters.AddWithValue("@Password", persona.Password);
                        command.Parameters.AddWithValue("@Correo", persona.Correo);
                        command.Parameters.AddWithValue("@Admin", persona.Admin);
                        command.Parameters.AddWithValue("@Imagen", JsonConvert.SerializeObject(persona.Imagen));

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public async Task<DataSet> consultar(string cmd)
        {

            DataSet ds = new DataSet();

            try
            {

                await using (MySqlConnection connection = new MySqlConnection(strCon))
                {
                    connection.Open();
                    MySqlDataAdapter dp = new MySqlDataAdapter(cmd, connection);
                    dp.Fill(ds);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);

            }
            return ds;
        }
    }
}
