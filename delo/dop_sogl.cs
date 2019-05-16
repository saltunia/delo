using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace delo
{
    public partial class dop_sogl : DevExpress.XtraEditors.XtraForm
    {
        object id_slujba;
        object kod_slujba;
        bool but_clik = false;
        bool but_clik1 = false;
        
        object id_org; object id_ruk;
        int? id_doc;

        object dolj;
        public dop_sogl()
        {
            InitializeComponent();
        }

        private void dop_sogl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iFRSforSeverelectroDataSet._Reference71' table. You can move, or remove it, as needed.
            this._Reference71TableAdapter.Fill(this.iFRSforSeverelectroDataSet._Reference71);
            // TODO: This line of code loads data into the 'dataSet2.SC488' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'deloDataSet.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.Fill_rukovod(this.deloDataSet.users_programm);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org_ruk' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dataSet1.SC23' table. You can move, or remove it, as needed.
            this.sC23TableAdapter.Fill(this.dataSet1.SC23);
            // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
            this.spr_slujbiTableAdapter.Fill_kod(this.deloDataSet.spr_slujbi);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org' table. You can move, or remove it, as needed.
          
            this.Text = "Дополнительное соглашение к договору №" + Globals.name_dog_post;
            dateEdit2.Text = DateTime.Now.ToString();
        }

        private void lookUpEdit5_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            
        }

        private void lookUpEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_slujba = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_slujbi");
                kod_slujba = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("kode_severelectro");
                textEdit1.Text = kod_slujba.ToString();
            }
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                dolj = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Expr1");
                textEdit2.Text = dolj.ToString();

            }
        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_ruk = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("user_id");

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((gridLookUpEdit1.Text != "" || textEdit5.Text != "") && lookUpEdit4.Text != "" && lookUpEdit2.Text != "" && textEdit1.Text != "" && comboBoxEdit1.Text != "" && dateEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit4.Text!="" && comboBoxEdit2.Text != "")
            {
                //but_clik = false;
                if (!but_clik)
                {
                    string dd = Convert.ToString(kod_slujba);
                    but_clik = true;

                    this.queriesTableAdapter1.insert_dop_sogl(
                        Globals.id_doc,
                        Globals.id_user, dd,
                        Convert.ToDateTime(dateEdit2.Text),
                       Convert.ToString(id_org),
                        Convert.ToDecimal(textEdit4.Text),
                        Convert.ToString(comboBoxEdit2.Text),
                        Convert.ToString(comboBoxEdit1.Text),
                        Convert.ToInt32(id_ruk),
                        Convert.ToInt32(id_slujba),
                        Convert.ToString(lookUpEdit2.Text),
                        Convert.ToString(textEdit2.Text),
                         Convert.ToString(textEdit5.Text),
                        ref id_doc);
                    MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");
                    simpleButton2.Enabled = false;
                    simpleButton3.Enabled = false;
                    MainFrame mf = new MainFrame();
                    mf.Show();

                }
                else
                {
                    simpleButton2.Enabled = false;
                    MainFrame mf = new MainFrame();
                    mf.Show();
                }
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((gridLookUpEdit1.Text != "" || textEdit5.Text != "") && lookUpEdit4.Text != "" && lookUpEdit2.Text != "" && textEdit1.Text != "" && comboBoxEdit1.Text != "" && dateEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit4.Text != "" && comboBoxEdit2.Text != "")
            {
                if (!but_clik1)
                {

                    string dd = Convert.ToString(kod_slujba);
                    but_clik1 = true;
                    this.queriesTableAdapter1.insert_dop_sogl(
                       Globals.id_doc,
                       Globals.id_user, dd,
                       Convert.ToDateTime(dateEdit2.Text),
                       Convert.ToString(id_org),
                       Convert.ToDecimal(textEdit4.Text),
                       Convert.ToString(comboBoxEdit2.Text),
                       Convert.ToString(comboBoxEdit1.Text),
                       Convert.ToInt32(id_ruk),
                       Convert.ToInt32(id_slujba),
                       Convert.ToString(lookUpEdit2.Text),
                       Convert.ToString(textEdit2.Text),
                         Convert.ToString(textEdit5.Text),
                       ref id_doc);
                    MessageBox.Show("Документ успешно зарегистрирован, далее прикрепите файл к этому документу!!!");

                    simpleButton1.Enabled = false;
                    simpleButton3.Enabled = false;
                    ofdInput.ShowDialog();

                }
                else
                {
                    simpleButton1.Enabled = false;
                    ofdInput.ShowDialog();
                }
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void ofdInput_FileOk(object sender, CancelEventArgs e)
        {
            string inFile = ofdInput.FileName;
            string file_name = Path.GetFileName(inFile);
            try
            {

                byte[] outlen;
                using (var fs = File.Open(inFile, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    if (fs.Length > 100000000)
                    {
                        MessageBox.Show("файл слишком большой для сохранения");
                        return;
                    }
                    outlen = new byte[fs.Length];
                    fs.Read(outlen, 0, Convert.ToInt32(fs.Length));

                }
                if (outlen.Length != 0)
                {

                    this.queriesTableAdapter1.insert_file(Globals.id_doc, outlen, file_name, comboBoxEdit1.Text, Globals.id_user);
                    MessageBox.Show("Файл успешно прикреплен ;) ");
                }
            }

            catch (IOException ioex)
            {
                MessageBox.Show("Данные не сохранились");
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if ((gridLookUpEdit1.Text != "" || textEdit5.Text != "") && lookUpEdit4.Text != "" && lookUpEdit2.Text != "" && textEdit1.Text != "" && comboBoxEdit1.Text != "" && dateEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit4.Text != "" && comboBoxEdit2.Text != "")
            {
                try
                {
                    string dd = Convert.ToString(kod_slujba);
                    this.queriesTableAdapter1.insert_dop_sogl(
                      Globals.id_doc,
                      Globals.id_user, dd,
                      Convert.ToDateTime(dateEdit2.Text),
                      Convert.ToString(id_org),
                      Convert.ToDecimal(textEdit4.Text),
                      Convert.ToString(comboBoxEdit2.Text),
                      Convert.ToString(comboBoxEdit1.Text),
                      Convert.ToInt32(id_ruk),
                      Convert.ToInt32(id_slujba),
                      Convert.ToString(lookUpEdit2.Text),
                      Convert.ToString(textEdit2.Text),
                        Convert.ToString(textEdit5.Text),
                      ref id_doc);
                    MessageBox.Show("Данные успешно сохранены!!!");
                }
                catch (Exception ex)
                { MessageBox.Show("Данные не сохранились!!!"); }

                Globals.en_delegate_dog_post();
                Close();
            }
            else { MessageBox.Show("Ни все поля заполнены"); }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Globals.en_delegate_dog_post();
            Close();
        }

        private void gridLookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {  
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                object vid = (sender as DevExpress.XtraEditors.GridLookUpEdit).GetSelectedDataRow();
                DataRowView ff = (DataRowView)vid;
                var hh = ff.Row[6].ToString();
                id_org = Convert.ToString(hh);

            }
        }
    }
}