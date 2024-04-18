
using Newtonsoft.Json;

namespace CheckIn_Event
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private string apiUrl = "https://api2.livespo.vn/v1/api/getCustomerEcoparkRunner";

        public Form1()
        {
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;
            //FormBorderStyle = FormBorderStyle.None;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3700;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            await CallApi();
            
        }

        private async Task CallApi()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseBody);

                    string url = "https://api2.livespo.vn/v1/api/updateCustomerEcoparkRunner/";

                    string token = "YRMHetweG7VdddTEryR4OonddddSN7XYVC5uJjNeheX3jTiUs";

                    foreach (var item in apiResponse.Data)
                    {
                        if (item.Status == false && item.TextRead != null)
                        {
                            using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
                            {
                                player.SoundLocation = item.TextRead;
                                player.Play();
                            }

                            string fullUrl = url + item.Id + '?' + "access_token=" + token;
                            await PostDataAsync(client, fullUrl);
                            return;
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi thực hiện yêu cầu API: {ex.Message}\nInner Exception: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static async Task PostDataAsync(HttpClient client, string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsync(fullUrl, null);

                response.EnsureSuccessStatusCode();

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

    }

    public class ApiResponse
    {
        public bool Status { get; set; }
        public List<DataItem> Data { get; set; }
    }

    public class DataItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }


        [JsonProperty("text_read")]
        public string TextRead { get; set; }

        [JsonProperty("status")]

        public bool Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}