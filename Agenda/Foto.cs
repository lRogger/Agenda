
using System.Drawing.Imaging;
using Datos;
using Entidades;

namespace Visual
{
    public partial class Foto : Form
    {

        
        public Foto()
        {
            InitializeComponent();
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            pbImg.ImageLocation = tbLink.Text;
        }


        private async void btnSubir_Click(object sender, EventArgs e)
        {

            //SUBIR IMAGEN
            Image img = pbImg.Image;
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }
            Persona p = new Persona();
            Imgur imgur = new Imgur();

            p.Imagen = await imgur.SubirImagen(imageBytes);
            MessageBox.Show(p.Imagen.ToString());
            p.Nombre = "Rogger Parraga";
            p.Cedula = "0930555420";
            p.Correo = "roggerp98@gmail.com";
            p.Edad = 24;
            p.Password = "Hola";
            p.Admin = true;
            p.Imagen = imgur.Json;


            DataBase db = new DataBase();
            db.Insertar(p);
        }


        //Borrar imagen, subir imagen
        private async void button1_Click(object sender, EventArgs e)
        {
            // Obtén la clave de cliente de tu aplicación Agenda en Imgur
            string clientId = "f84f7d23f1f95ec";
            string deleteHash = tbHash.Text;

            // Elimina una imagen específica de tu cuenta de Imgur
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Client-ID " + clientId);

                var response = await client.DeleteAsync("https://api.imgur.com/3/image/" + deleteHash);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Image deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Error deleting image: " + response.ReasonPhrase);
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            pbImg.ImageLocation = tbLink.Text;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "JPG files (*.jpg)|*.jpg";

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pbImg.ImageLocation = abrirImagen.FileName;
                pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
