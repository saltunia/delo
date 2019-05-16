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
using System.IO;
using System.Collections;
using System.Collections.Specialized;


namespace delo
{
    public partial class Skaner : DevExpress.XtraEditors.XtraForm
    {
        int? id_doc = 0;
        bool but_clik = false;
        bool but_clik1 = false;
        object id_tip_doc;
        object kode_sektor;
        object id_org;
        object id_type_doc;
        object vhod_numb;
        object id_org2;
        object id_org3;
        object id_org4;
        string jal = "";
        int id_org_real;


        public Skaner()
        {

            InitializeComponent();
            //delo.Properties.Settings.Default.strVvodSetting = "";
            //delo.Properties.Settings.Default.Save();
            string str0 = delo.Properties.Settings.Default.strVvodSetting;
            string str1 = "";
         
            if (str0.Length == 0)

                return;
            while(str0.Length > 1)
            {
                
                str1 = str0.Substring(0, str0.IndexOf(';'));
                str0 = str0.Substring(str0.IndexOf(';')+1, str0.Length - str0.IndexOf(';')-1);
                comboBoxEdit1.Properties.Items.Add(str1);
            }
          
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime? srok_do;
            DateTime? srok_pd;
            if (dateEdit1.Text == "")
            { srok_pd = null; }
            else { srok_pd = Convert.ToDateTime(dateEdit1.Text); }
            if (jal == "ok")
            { id_org_real = Convert.ToInt32(id_org) ;}
            else{id_org_real=540;}
            if (dateEdit3.Text == "")
            { srok_do = null; }
            else { srok_do = Convert.ToDateTime(dateEdit3.Text); }
            if ((checkEdit1.Checked == true || checkEdit2.Checked == true) && lookUpEdit1.Text != "" && (lookUpEdit2.Text != "" || textEdit4.Text != "") && textEdit2.Text != ""  && dateEdit2.Text != "")
            {

                //but_clik = false;
                if (!but_clik)
                {
                    string dd = Convert.ToString(kode_sektor);
                    but_clik = true;

                    this.queriesTableAdapter1.insert_vhod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), textEdit2.Text, srok_pd, Convert.ToBoolean(checkEdit2.EditValue), Convert.ToBoolean(checkEdit1.EditValue), Convert.ToBoolean(checkEdit3.EditValue), textEdit1.Text, id_org_real, comboBoxEdit1.Text, memoEdit1.Text, textEdit3.Text, Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), Convert.ToInt32(id_org4), textEdit4.Text, Convert.ToBoolean(checkEdit4.EditValue), srok_do, textEdit5.Text, textEdit6.Text, textEdit7.Text,comboBoxEdit2.Text, ref id_doc);
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
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

            catch (IOException )
            {
                MessageBox.Show("Данные не сохранились");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DateTime? srok_do;
            DateTime? srok_pd;
            if (dateEdit1.Text == "")
            { srok_pd = null; }
            else { srok_pd = Convert.ToDateTime(dateEdit1.Text); }
            if (jal == "ok")
            { id_org_real = Convert.ToInt32(id_org); }
            else { id_org_real = 540; }
            if (dateEdit3.Text == "")
            { srok_do = null; }
            else { srok_do = Convert.ToDateTime(dateEdit3.Text); }
            if ((checkEdit1.Checked == true || checkEdit2.Checked == true) && lookUpEdit1.Text != "" && (lookUpEdit2.Text != "" || textEdit4.Text != "") && textEdit2.Text != ""  && dateEdit2.Text != "")
            {
                if (!but_clik1)
                {

                    string dd = Convert.ToString(kode_sektor);
                    but_clik1 = true;
                    this.queriesTableAdapter1.insert_vhod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), textEdit2.Text, srok_pd, Convert.ToBoolean(checkEdit2.EditValue), Convert.ToBoolean(checkEdit1.EditValue), Convert.ToBoolean(checkEdit3.EditValue), textEdit1.Text, id_org_real, comboBoxEdit1.Text, memoEdit1.Text, textEdit3.Text, Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), Convert.ToInt32(id_org4), textEdit4.Text, Convert.ToBoolean(checkEdit4.EditValue), srok_do, textEdit5.Text, textEdit6.Text, textEdit7.Text, comboBoxEdit2.Text, ref id_doc);
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

        private void Skaner_Load(object sender, EventArgs e)
        {
           
            try
            {
                // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
                this.spr_slujbiTableAdapter.Fill(this.deloDataSet.spr_slujbi);

                // TODO: This line of code loads data into the 'deloDataSet.spr_org_ruk' table. You can move, or remove it, as needed.
                this.spr_org_rukTableAdapter.Fill(this.deloDataSet.spr_org_ruk);
                // TODO: This line of code loads data into the 'deloDataSet.spr_org' table. You can move, or remove it, as needed.
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                // TODO: This line of code loads data into the 'deloDataSet.spr_doc' table. You can move, or remove it, as needed.
                this.spr_docTableAdapter.Fill_vhod(this.deloDataSet.spr_doc);
                dateEdit2.Text = DateTime.Now.ToString();
                checkEdit1.Checked = true;
                comboBoxEdit1.Text = "";
                this.view_all_inbox_doc1TableAdapter.Fill(this.deloDataSet.View_all_inbox_doc1);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }


        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DateTime? srok_do;
            DateTime? srok_pd;
            if (dateEdit1.Text == "")
            { srok_pd = null; }
            else { srok_pd = Convert.ToDateTime(dateEdit1.Text); }
            if (jal == "ok")
            { id_org_real = Convert.ToInt32(id_org); }
            else { id_org_real = 540; }
            if (dateEdit3.Text == "")
            { srok_do = null; }
            else { srok_do = Convert.ToDateTime(dateEdit3.Text); }
            if ((checkEdit1.Checked == true || checkEdit2.Checked == true) && lookUpEdit1.Text != "" && (lookUpEdit2.Text != "" || textEdit4.Text != "") && textEdit2.Text != ""  && dateEdit2.Text != "")
            {
                try
                {
                    string dd = Convert.ToString(kode_sektor);
                    this.queriesTableAdapter1.insert_vhod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), textEdit2.Text, srok_pd, Convert.ToBoolean(checkEdit2.EditValue), Convert.ToBoolean(checkEdit1.EditValue), Convert.ToBoolean(checkEdit3.EditValue), textEdit1.Text, id_org_real, comboBoxEdit1.Text, memoEdit1.Text, textEdit3.Text, Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), Convert.ToInt32(id_org4), textEdit4.Text, Convert.ToBoolean(checkEdit4.EditValue), srok_do, textEdit5.Text, textEdit6.Text, textEdit7.Text, comboBoxEdit2.Text, ref id_doc);
                    comboBoxEdit1.Properties.Items.Add(comboBoxEdit1.Text);
                    string allStr = "";
                    foreach (string str in comboBoxEdit1.Properties.Items)
                    {
                        allStr += str + ';';
                    }
                    delo.Properties.Settings.Default.strVvodSetting = allStr;
                    delo.Properties.Settings.Default.Save();
                    MessageBox.Show("Данные успешно сохранены!!!");

                }
                catch 
                { MessageBox.Show("Данные не сохранились!!!"); }
                Globals.en_delegate();
                Close();
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
            comboBoxEdit1.Properties.Items.Add(comboBoxEdit1.Text);
            string allStr = "";
            foreach(string str in comboBoxEdit1.Properties.Items)
            {
                allStr += str + ';';
            }
            delo.Properties.Settings.Default.strVvodSetting = allStr;
            delo.Properties.Settings.Default.Save();
            Globals.en_delegate();
            Close();
           

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

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            jal = "ok";
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_org = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");


            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ch = sender as CheckEdit;
            if (ch.Name == "checkEdit1")
            { checkEdit2.Checked = false; checkEdit4.Checked = false; }
            else { checkEdit1.Checked = false; }

            if (ch.Name == "checkEdit3")
            {
                checkEdit2.Checked = true;
                checkEdit1.Checked = false;
                checkEdit4.Checked = false;
            }
            else { checkEdit3.Checked = false; }

            if (ch.Name == "checkEdit4")
            {
                checkEdit2.Checked = false;
                checkEdit1.Checked = false;
                checkEdit3.Checked = false;
            }
            else { checkEdit4.Checked = false; }
        }

      

      

        private void dateEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try { 
DateTime pp = Convert.ToDateTime(dateEdit1.Text);
            DateTime now = DateTime.Now;
            if (pp >= now)
            {
                MessageBox.Show("Дата входящего документа больше чем дата регистрации");
                dateEdit1.Text = "";
            }}
            catch { }
        }

        private void dateEdit1_Enter(object sender, EventArgs e)
        {
            try { 
            DateTime pp = Convert.ToDateTime(dateEdit1.Text);
            DateTime now = DateTime.Now;
            if (pp >= now)
            {
                MessageBox.Show("Дата входящего документа больше чем дата регистрации");
                dateEdit1.Text = "";
            }
}
            catch { }
        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
               vhod_numb = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("number");
               textEdit3.Text = vhod_numb.ToString();

            }
        }

        private void lookUpEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                vhod_numb = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("number");
               textEdit3.Text = vhod_numb.ToString();

            }
        }

        private void lookUpEdit5_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_org2 = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");


            }
        }

        private void lookUpEdit6_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_org3 = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");


            }
        }

        private void lookUpEdit7_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_org4 = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_slujbi");


            }
        }

       

       

       
    }
}