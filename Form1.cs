using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challengeweek15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            Button but1 = (Button)sender;
            screen.Text = screen.Text + (but1.Text);
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            string sementara = "";
            string hapus = Convert.ToString(screen.Text);
            char[] penghapus = hapus.ToCharArray();
            for (int i = 0; i < penghapus.Length-1; i++)
            {
                sementara = sementara + penghapus[i]; 
               
            
            }
            screen.Text = sementara;
        }
    }
}
