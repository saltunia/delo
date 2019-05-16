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
    public partial class Add_pol_instruc : DevExpress.XtraEditors.XtraForm
    {
        int? id_doc = 0;
        bool but_clik = false;
        bool but_clik1 = false;
        int i=0;
        public Add_pol_instruc()
        {
            InitializeComponent();
        }

        private void checkEdit1_Click(object sender, EventArgs e)
        {
            CheckEdit ch = sender as CheckEdit;
            if (ch.Name == "checkEdit1")
            { checkEdit2.Checked = false; }
            else { checkEdit1.Checked = false; }
        }

        private void Add_pol_instruc_Load(object sender, EventArgs e)
        {
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((checkEdit1.Checked == true || checkEdit2.Checked == true) )//&& textEdit1.Text != "" && textEdit2.Text != "" && textEdit3.Text != "" && textEdit4.Text != "" && dateEdit1.Text != "")
            {
               
                if (!but_clik)
                {
                    
                    but_clik = true;
                    if (checkEdit1.Checked == true)
                    { i = 5; }
                    else
                    { i = 6; }
                    this.queriesTableAdapter1.insert_pol_ins(
                        textEdit1.Text, 
                        Convert.ToDateTime(dateEdit1.EditValue),
                        memoEdit1.Text,
                        i,
                        Globals.id_sl_pol_ins, 
                        Globals.id_user,
                        textEdit2.Text, 
                        textEdit3.Text, 
                        textEdit4.Text,
                        ref id_doc);
                    MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");
                    Globals.id_doc2 = Convert.ToInt32(id_doc);
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
            else{MessageBox.Show("Ни все поля заполнены");}
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((checkEdit1.Checked == true || checkEdit2.Checked == true))// && textEdit1.Text != "" && textEdit2.Text != "" && textEdit3.Text != "" && textEdit4.Text != "" && dateEdit1.Text != "")
            {
                if (!but_clik1)
                {

                    if (checkEdit1.Checked == true)
                    { i = 5; }
                    else
                    { i = 6; }
                    but_clik1 = true;
                    this.queriesTableAdapter1.insert_pol_ins(
                         textEdit1.Text,
                         Convert.ToDateTime(dateEdit1.EditValue),
                         memoEdit1.Text,
                         i,
                         Globals.id_sl_pol_ins,
                         Globals.id_user,
                         textEdit2.Text,
                         textEdit3.Text,
                         textEdit4.Text,
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
                   
                    outlen = new byte[fs.Length];
                    fs.Read(outlen, 0, Convert.ToInt32(fs.Length));

                }
                if (outlen.Length != 0)
                {

                    this.queriesTableAdapter1.insert_file_pol_ins(Globals.id_doc, outlen, file_name, memoEdit1.Text, Globals.id_user);
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
            if ((checkEdit1.Checked == true || checkEdit2.Checked == true))// && textEdit1.Text != "" && textEdit2.Text != "" && textEdit3.Text != "" && textEdit4.Text != "" && dateEdit1.Text != "")
            {
                try
                {

                    if (checkEdit1.Checked == true)
                    { i = 5; }
                    else
                    { i = 6; }
                    this.queriesTableAdapter1.insert_pol_ins(
                         textEdit1.Text,
                         Convert.ToDateTime(dateEdit1.EditValue),
                         memoEdit1.Text,
                         i,
                         Globals.id_sl_pol_ins,
                         Globals.id_user,
                         textEdit2.Text,
                         textEdit3.Text,
                         textEdit4.Text,
                         ref id_doc);
                   MessageBox.Show("Данные успешно сохранены!!!");

                }
                catch 
                { MessageBox.Show("Данные не сохранились!!!"); }
                Globals.en_delegate_pol_ins();
                Close();
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Globals.en_delegate_pol_ins();
            Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Globals.en_delegate_pol_ins();
            Close();
        }
    }
}