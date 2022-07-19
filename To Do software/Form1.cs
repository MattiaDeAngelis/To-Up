namespace To_Do_software
{
    public partial class Form1 : Form
    {
        App app = new App();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            app.Add(textBox1.Text,checkedListBox1);
            textBox1.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            app.remove(checkedListBox1);
        }
    }
}