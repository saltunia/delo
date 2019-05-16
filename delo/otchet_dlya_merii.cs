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
    public partial class otchet_dlya_merii : DevExpress.XtraEditors.XtraForm
    {
        public otchet_dlya_merii()
        {
            InitializeComponent();
        }

        private void otchet_dlya_merii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deloDataSet.svedenia' table. You can move, or remove it, as needed.
            

            //this.reportViewer1.RefreshReport();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           this.svedeniaTableAdapter.Fill(this.deloDataSet.svedenia,Convert.ToDateTime(dateEdit1.Text),Convert.ToDateTime(dateEdit2.EditValue));
           this.reportViewer1.RefreshReport();
        }
    }
}