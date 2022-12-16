namespace ToolStrip
{
    public partial class Form1 : Form
    {

        int size = 12;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.label1.Text = toolStripTextBox1.Text; 


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (size == 0)
            {
                size= 12;
            }
            this.label1.Font = new Font("tahoma", size);
            size += 4;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (size == 0)
            {
                size = 12;
            }

            this.label1.Font = new Font("tahoma", size);
            size -= 4;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}