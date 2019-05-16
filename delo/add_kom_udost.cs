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

namespace delo
{
    public partial class add_kom_udost : DevExpress.XtraEditors.XtraForm
    {
        bool but_clik = false;
       
        object id_slujbi;
       
        object dolj;
        object tabel;
        int days;
        int days1;
        int den1;
        public add_kom_udost()
        {
            InitializeComponent();
        }

        private void add_kom_udost_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deloDataSet.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.Fill_rukovod(this.deloDataSet.users_programm);
            // TODO: This line of code loads data into the 'dataSet1.SC23' table. You can move, or remove it, as needed.
            this.sC23TableAdapter.Fill(this.dataSet1.SC23);
            // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
            this.spr_slujbiTableAdapter.Fill(this.deloDataSet.spr_slujbi);
            this.Text = "Командировочное удостоверение к приказу №" + Globals.name_prikaz;
            dateEdit1.Text = DateTime.Now.Date.ToString();
            dateEdit3.Text = DateTime.Now.Date.ToString();
            dateEdit2.Text = DateTime.Now.ToString();
            dateEdit5.Text = DateTime.Now.Date.ToString();
            dateEdit4.Text = DateTime.Now.Date.ToString();
        }

        private void dateEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            days = (Convert.ToDateTime(dateEdit3.Text) - Convert.ToDateTime(dateEdit1.Text)).Days;
            textEdit3.Text = days.ToString();
        }

        private void dateEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            days = (Convert.ToDateTime(dateEdit3.Text) - Convert.ToDateTime(dateEdit1.Text)).Days+1;
            textEdit3.Text = days.ToString();
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_slujbi = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_slujbi");


            }
        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                dolj = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Expr1");
                textEdit1.Text = dolj.ToString();
                tabel = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Code");
                textEdit5.Text = tabel.ToString();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (lookUpEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit1.Text != "" && textEdit2.Text != "" && textEdit4.Text != "" && dateEdit1.Text != "" && dateEdit3.Text != "" && lookUpEdit4.Text != ""&& dateEdit2.Text != "" )
            {
                if (!but_clik)
                {
                   
                    but_clik = true;
                    if (textEdit6.Text == "")
                    { den1 = 0; }
                    else
                    { den1 = Convert.ToInt32(textEdit6.Text); }
                    this.queriesTableAdapter1.insert_kom_udost(Globals.id_doc, textEdit2.Text, Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit3.EditValue), lookUpEdit3.Text, textEdit1.Text, Convert.ToInt32(textEdit3.Text), textEdit4.Text, textEdit5.Text, lookUpEdit4.Text, Convert.ToInt32(id_slujbi), Convert.ToDateTime(dateEdit5.EditValue), Convert.ToDateTime(dateEdit4.EditValue), den1);
                    MessageBox.Show("Успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");

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
            if (lookUpEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit1.Text != "" && textEdit2.Text != "" && textEdit4.Text != "" && dateEdit1.Text != "" && dateEdit3.Text != "" && lookUpEdit4.Text != "" && dateEdit2.Text != "")
            {
                if (!but_clik)
                {
                   
                    but_clik = true;

                    if (textEdit6.Text == "")
                    { den1 = 0; }
                    else
                    { den1 = Convert.ToInt32(textEdit6.Text); }
                    this.queriesTableAdapter1.insert_kom_udost(Globals.id_doc, textEdit2.Text, Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit3.EditValue), lookUpEdit3.Text, textEdit1.Text, Convert.ToInt32(textEdit3.Text), textEdit4.Text, textEdit5.Text, lookUpEdit4.Text, Convert.ToInt32(id_slujbi), Convert.ToDateTime(dateEdit5.EditValue), Convert.ToDateTime(dateEdit4.EditValue), den1);
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

                    this.queriesTableAdapter1.insert_file(Globals.id_doc, outlen, file_name, textEdit4.Text, Globals.id_user);
                    MessageBox.Show("Файл успешно прикреплен ;) ");
                }
            }

            catch 
            {
                MessageBox.Show("Данные не сохранились");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (lookUpEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit1.Text != "" && textEdit2.Text != "" && textEdit4.Text != "" && dateEdit1.Text != "" && dateEdit3.Text != "" && lookUpEdit4.Text != "" && dateEdit2.Text != "")
            {
                try
                {
                    if (textEdit6.Text == "")
                    { den1 = 0; }
                    else
                    { den1 = Convert.ToInt32(textEdit6.Text); }
                    this.queriesTableAdapter1.insert_kom_udost(Globals.id_doc, textEdit2.Text, Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit3.EditValue), lookUpEdit3.Text, textEdit1.Text, Convert.ToInt32(textEdit3.Text), textEdit4.Text, textEdit5.Text, lookUpEdit4.Text, Convert.ToInt32(id_slujbi),Convert.ToDateTime(dateEdit5.EditValue), Convert.ToDateTime(dateEdit4.EditValue), den1);
                    MessageBox.Show("Данные успешно сохранены!!!");
                }
                catch { MessageBox.Show("Данные не сохранились!!!"); }
              
                Globals.en_delegate_kom();
                Close();


            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
                Globals.en_delegate_kom();
                Close();
          
        }

        private void lookUpEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit5_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            days1 = (Convert.ToDateTime(dateEdit4.Text) - Convert.ToDateTime(dateEdit5.Text)).Days;
            textEdit6.Text = days1.ToString();
        }

        private void dateEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            days1 = (Convert.ToDateTime(dateEdit4.Text) - Convert.ToDateTime(dateEdit5.Text)).Days + 1;
            textEdit6.Text = days1.ToString();
        }

       
    }
}