using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace delo
{
    public partial class zakryt_pismo : DevExpress.XtraEditors.XtraForm
    {
        public zakryt_pismo()
        {
            InitializeComponent();
        }

       

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Globals.en_delegate();
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try {
            queriesTableAdapter1.zakryt_pismo(Globals.id_doc, memoEdit1.Text);
            MessageBox.Show("Данные успешно сохранены");
            Globals.en_delegate();
            this.Close();
            }
            catch { MessageBox.Show("Данные не сохранились"); }
        }

        private void zakryt_pismo_Load(object sender, EventArgs e)
        {

        }
    }
}