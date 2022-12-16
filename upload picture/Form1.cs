namespace upload_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() ==  System.Windows.Forms.DialogResult.OK ) 
            { 
                pictureBox1.ImageLocation = ofd.FileName;

            }
        }
    }
}