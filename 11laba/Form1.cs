namespace _11laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            new FormEnter().ShowDialog();
        }

        private void registarionButton_Click(object sender, EventArgs e)
        {
            new FormRegistration().ShowDialog();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}