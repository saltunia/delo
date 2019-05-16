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
    public partial class add_agent_dog : DevExpress.XtraEditors.XtraForm
    {
        bool but_clik = false;
        bool but_clik1 = false;

        object kode_sektor;
        object id_ruk;
        object id_tip_doc;
        object id_type_doc;
        int? id_doc = 0;
        public add_agent_dog()
        {
            InitializeComponent();
        }

        private void add_agent_dog_Load(object sender, EventArgs e)
        {
            this.spr_docTableAdapter.FillByAgent_dog(this.deloDataSet.spr_doc);
            this.users_programmTableAdapter.Fill_rukovod(this.deloDataSet.users_programm);
        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_tip_doc = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("int");
                kode_sektor = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("index_sectora");
                id_type_doc = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_tip_doc");
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
            DateTime? s;
            DateTime? po;

            if (lookUpEdit1.Text != "" && textEdit4.Text != "" && lookUpEdit3.Text != "" && dateEdit2.Text != "")
            {
                if (dateEdit1.Text == "")
                { s = null; }
                else { s = Convert.ToDateTime(dateEdit1.Text); }
                if (dateEdit3.Text == "")
                { po = null; }
                else { po = Convert.ToDateTime(dateEdit3.Text); }
                if (!but_clik)
                {

                    but_clik = true;

                    this.queriesTableAdapter1.insert_dog_agent(
                        Convert.ToInt32(id_tip_doc),
                        Convert.ToInt32(id_type_doc),
                        Globals.id_user,
                        Convert.ToDateTime(dateEdit2.Text),
                        textEdit4.Text,
                        textEdit1.Text,
                        textEdit2.Text,
                        textEdit3.Text,
                        textEdit6.Text,
                        textEdit7.Text,
                        textEdit8.Text,
                        memoEdit1.Text,
                        Convert.ToInt32(id_ruk),
                       s,
                       po,
                        ref id_doc);
                    MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");
                    Globals.id_doc = Convert.ToInt32(id_doc);
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
            DateTime? s;
            DateTime? po;
            if (lookUpEdit1.Text != "" && textEdit4.Text != "" && lookUpEdit3.Text != "" && dateEdit2.Text != "")
            {
                if (dateEdit1.Text == "")
                { s = null; }
                else { s = Convert.ToDateTime(dateEdit1.Text); }
                if (dateEdit3.Text == "")
                { po = null; }
                else { po = Convert.ToDateTime(dateEdit3.Text); }
                if (!but_clik)
                {

                    but_clik = true;

                    this.queriesTableAdapter1.insert_dog_agent(
                        Convert.ToInt32(id_tip_doc),
                        Convert.ToInt32(id_type_doc),
                        Globals.id_user,
                        Convert.ToDateTime(dateEdit2.Text),
                        textEdit4.Text,
                        textEdit1.Text,
                        textEdit2.Text,
                        textEdit3.Text,
                        textEdit6.Text,
                        textEdit7.Text,
                        textEdit8.Text,
                        memoEdit1.Text,
                        Convert.ToInt32(id_ruk),
                       s,
                       po,
                        ref id_doc);
                    MessageBox.Show("Документ успешно зарегистрирован, далее прикрепите файл к этому документу!!!");
                    Globals.id_doc = Convert.ToInt32(id_doc);
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

                    this.queriesTableAdapter1.insert_file(Globals.id_doc, outlen, file_name, memoEdit1.Text, Globals.id_user);
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
            DateTime? s;
            DateTime? po;
            if (lookUpEdit1.Text != "" && textEdit4.Text != "" && lookUpEdit3.Text != "" && dateEdit2.Text != "")
            {
                if (dateEdit1.Text == "")
                { s = null; }
                else { s = Convert.ToDateTime(dateEdit1.Text); }
                if (dateEdit3.Text == "")
                { po = null; }
                else { po = Convert.ToDateTime(dateEdit3.Text); }
                if (!but_clik)
                {

                    but_clik = true;

                    this.queriesTableAdapter1.insert_dog_agent(
                        Convert.ToInt32(id_tip_doc),
                        Convert.ToInt32(id_type_doc),
                        Globals.id_user,
                        Convert.ToDateTime(dateEdit2.Text),
                        textEdit4.Text,
                        textEdit1.Text,
                        textEdit2.Text,
                        textEdit3.Text,
                        textEdit6.Text,
                        textEdit7.Text,
                        textEdit8.Text,
                        memoEdit1.Text,
                        Convert.ToInt32(id_ruk),
                       s,
                       po,
                        ref id_doc);
                    MessageBox.Show("Данные успешно сохранены!!!");


                    Globals.en_delegate_dog_agent();
                    Close();
                }
                else { MessageBox.Show("Ни все поля заполнены"); }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Globals.en_delegate_dog_agent(); 
                Close();
        }
    }
}