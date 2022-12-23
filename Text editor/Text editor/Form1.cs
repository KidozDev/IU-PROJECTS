using System.DirectoryServices.ActiveDirectory;
using System.Security.Cryptography;

namespace Text_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text Files (.txt) |*.txt" ;
            ofd.Title = "open a file ...";

            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text= sr.ReadToEnd();
                sr .Close();

            }


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf= new SaveFileDialog();
            svf.Filter = "text Files (.txt) |*.txt";
            svf.Title = "Save file ...";

            if (svf.ShowDialog() == DialogResult.OK) 
            {
                System.IO.StreamWriter sw = new StreamWriter(svf.FileName);
                sw.Write(richTextBox1.Text); 
                sw.Close();
            }

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();

        }
    }
}