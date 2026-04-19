using System

using System.Text.Json.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = "https://jsonplaceholder.typicode.com/posts/1";
            try {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode) {
                    string json = await response.Content.ReadAsStringAsync();
                    Post post = JsonSerializer.Deserialize<Post>(json);

                    textbox1.Text = $"Title: {post.title}\n" + $"Body: {post.body}"
                }
                else {
                    textBox1.Text = $"Hiba az API hívásnál: {response.StatusCode}";
                }

            }
            catch (Exception ex) { 
                TextBox1.text = ex.Message;
            }
        }
    }
}
