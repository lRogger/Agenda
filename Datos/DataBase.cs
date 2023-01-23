using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
    public class DataBase
    {
        private string server, user, pass, db, strCon;
        private DataSet ds;

        public DataBase()
        {
            this.server = "db4free.net";
            this.user = "lrogger";
            this.pass = "Tokio123";
            this.db = "chichar";

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

                    string query = "INSERT INTO persona (Cedula, Nombre, Edad, Password, Correo, Admin, Imagen) " +
                        "VALUES (@Cedula, @Nombre, @Edad, @Password, @Correo, @Admin, @Imagen)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cedula", persona.Cedula);
                        command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                        command.Parameters.AddWithValue("@Edad", persona.Edad);
                        command.Parameters.AddWithValue("@Password", persona.Edad);
                        command.Parameters.AddWithValue("@Correo", persona.Edad);
                        command.Parameters.AddWithValue("@Admin", persona.Edad);
                        command.Parameters.AddWithValue("@Imagen", persona.Edad);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
