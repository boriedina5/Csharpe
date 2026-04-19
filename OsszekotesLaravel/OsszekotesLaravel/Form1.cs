using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
namespace OsszekotesLaravel
{
    public partial class Form1 : Form
    {
        public class Leprechaun
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Gold { get; set; }
        }
        public class ApiResponse {
            
            public List<Leprechaun> leprechauns { get; set; }
            public string msg { get; set; }//ugyanaz a nev mint a laravel visszad

        }

        public HttpClient  client = new HttpClient();
        private string token = "My Auth Token From Tomorrow";

        public Form1()
        {
            InitializeComponent();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        private async Task button1_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://localhost:8000/api/leprechauns";
                var response =await client.GetAsync(url);

                if (response.IsSuccessStatusCode == false) { //Error handling 
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"API error:\n{response.StatusCode}\n\n{error}");
                    return;
                }

                //válaszfeldolgozás és deszérializálás
                string kapottValszObj = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<ApiResponse>(kapottValszObj); //visszaalakílatás = deszerializálás, index részt fejtjük vissza C# értelmezhetõen

                MessageBox.Show(result.msg);

                dataGridView1.DataSource = result.leprechauns; //adatok megjelenítése a DataGridView-ben

            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
