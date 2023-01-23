
using RestSharp;



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
            pbFoto.ImageLocation = tbLink.Text;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            // Obtener la imagen del control PictureBox
            var image = pbFoto.Image;

            // Crear un flujo de memoria para la imagen
            var stream = new MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            stream.Position = 0;

            // Crear una solicitud para subir la imagen
            var client = new RestClient("https://api.imgur.com/3/image");
            var request = new RestRequest(Method.Post.ToString());
            request.AddHeader("Authorization", "Client-ID f84f7d23f1f95ec");
            request.AddFile("image", stream.ToArray(), "image.jpg");

            // Ejecutar la solicitud
            var response = client.Execute(request);

            MessageBox.Show(response.Content.ToString());

            if (response.IsSuccessful)
            {
                // El código de estado es 200 (OK)
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
                var url = json.data.link;
                MessageBox.Show("La imagen se ha subido con éxito. URL: " + url);
            }
            else
            {
                // El código de estado no es 200 (OK)
                int statusCode = (int)response.StatusCode;
                string content = response.Content;
                // aqui puedes tratar el error, o mostrar un mensaje al usuario
                MessageBox.Show(response.StatusCode.ToString());
            }

        }
    }
}
