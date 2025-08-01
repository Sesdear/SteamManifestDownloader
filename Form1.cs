namespace SteamGamesTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
            appIdTextBox.Enter += appIdTextBox_Enter;
            appIdTextBox.Leave += appIdTextBox_Leave;
        }
        //------------PlaceHolder--------------
        private void appIdTextBox_Enter(object sender, EventArgs e)
        {
            if (appIdTextBox.Text == "Enter App Id...")
            {
                appIdTextBox.Text = "";
                appIdTextBox.ForeColor = Color.Black; // »ли ваш цвет по умолчанию
            }
        }

        private void appIdTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(appIdTextBox.Text))
            {
                appIdTextBox.Text = "Enter App Id...";
                appIdTextBox.ForeColor = Color.Gray; // ÷вет плейсхолдера
            }
        }

        private void Form1_Load()
        {
            appIdTextBox.Text = "Enter App Id...";
            appIdTextBox.ForeColor = Color.Gray; // ÷вет плейсхолдера
        }

        //-------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.DownloadManifest(appIdTextBox.Text);
        }
    }
}
