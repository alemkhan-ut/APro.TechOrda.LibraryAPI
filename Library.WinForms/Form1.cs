using System.Text.Json;

namespace Library.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void ApiButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var message = await client.GetAsync("https://localhost:7270/api/library/books");

            if (message.IsSuccessStatusCode)
            {
                var result = await message.Content.ReadAsStringAsync(); // JSON


                // JsonConvert
                var books = JsonSerializer.Deserialize<List<Book>>(result);

                TitleText.Text = books[0].title;
                AuthorText.Text = books[0].author;
                DescText.Text = books[0].description;
                PublishDateText.Text = books[0].publishDate.ToString();
            }
        }
    }

    public class Book
    {
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public DateOnly publishDate { get; set; }
    }

}