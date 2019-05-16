using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace delo
{
    public partial class authentification : DevExpress.XtraEditors.XtraForm
    {
        public authentification()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           Form f = new Vhodyashie();
           f.Show();
        }

        private void authentification_Load(object sender, EventArgs e)
        {
            labelControl3.Visible = false;
        }

       
    }
}