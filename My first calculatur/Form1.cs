namespace My_first_calculatur
{
    public partial class Form1 : Form
    {
        double resultvalue = 0;
        string operationperformed = "";
        bool isoperationperformed = false ;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if(tbDisblayResult.Text=="0" || (isoperationperformed))
                tbDisblayResult.Clear();
            isoperationperformed = false; 
            Button button =  (Button)sender;
            if (button.Text == ".")

            {
                if (!tbDisblayResult.Text.Contains("."))
                    tbDisblayResult.Text += button.Text;

            }
            else {
                tbDisblayResult.Text += button.Text;
            } 

            {

            }
                
            }

        private void oprerator_click(object sender, EventArgs e)
        {
            Button button = (Button )sender;

            operationperformed = button.Text;
            resultvalue = double.Parse(tbDisblayResult.Text);
            lbCurrentOp.Text = resultvalue + "" + operationperformed;
            isoperationperformed = true; 





        }

        private void button18_Click(object sender, EventArgs e)
        {
            tbDisblayResult.Text = "0";
            resultvalue = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbDisblayResult.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (operationperformed == "+" )
            {
                tbDisblayResult.Text = (resultvalue + double.Parse(tbDisblayResult.Text)).ToString();
            }
            else if(operationperformed== "-" )
            {
                tbDisblayResult.Text = (resultvalue - double.Parse(tbDisblayResult.Text)).ToString();

            }
            else if (operationperformed== "*" ) 
            {
                tbDisblayResult.Text = (resultvalue *double.Parse(tbDisblayResult.Text)).ToString();

            }
            else
            {
                tbDisblayResult.Text = (resultvalue / double.Parse(tbDisblayResult.Text)).ToString();

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tbDisblayResult.Text.Length > 0)
                tbDisblayResult.Text = tbDisblayResult.Text.Remove(tbDisblayResult.Text.Length - 1, 1);

            if (tbDisblayResult.Text == "")
                tbDisblayResult.Text = "0";


        }
    }
}