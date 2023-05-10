namespace taskMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private async void buttonCounter_Click(object sender, EventArgs e)
        {
            await Task.Run(counter);
            MessageBox.Show("Bitti");
        }
        async Task counter() 
        {
            for (int i = 0; i <= 10000; i++)
            {
                progressBar1.Value = i / 100;
                labelCounter.Text = i.ToString();
            }
            //return Task.CompletedTask;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show");
        }
    }
}