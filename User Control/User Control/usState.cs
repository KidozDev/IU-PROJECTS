using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control
{
    public partial class usState : UserControl
    {
        public usState()
        {
            InitializeComponent();
        }

        public States SelectedState
        {
            get
            {
                return (States)cboState.SelectedItem; 

            }
        }

        private void usState_Load(object sender, EventArgs e)
        {
            List<State> list = new List<State> (); 
            list.Add(new Control.State () { ID= 1 , Name = "Delhi"});
            list.Add(new Control.State() { ID = 2, Name =  "Bihar" });
            list.Add(new Control.State() { ID = 3, Name =  "punjab" });
            list.Add(new Control.State() { ID = 4, Name =  "up" });
            cboState.DataSource = list;
            cboState.ValueMember = "ID"; 
            cboState.DisplayMember= "Name";



        }
    }
}
