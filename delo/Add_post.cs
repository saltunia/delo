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
    public partial class Add_post : DevExpress.XtraEditors.XtraForm
    {
        object id_slujba;
        object kod_slujba;
        bool but_clik = false;
        bool but_clik1 = false;
        object id_tip_doc;
        object id_type_doc;
        object id_org; object id_ruk;
        int? id_doc;
        
        object dolj;
        public Add_post()
        {
            InitializeComponent();
        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(id_tip_doc) == 19)
            {
               
                if (Convert.ToInt32(id_tip_doc) == 19)
                { Globals.en_delegate_dog_post(); }
                Close();
            }
            else
            {
                Globals.en_delegate();
                Close();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DateTime? s;
            DateTime? po;

            if (lookUpEdit1.Text != "" && (gridLookUpEdit1.Text != "" || textEdit5.Text != "") && lookUpEdit4.Text != "" && lookUpEdit2.Text != "" && textEdit1.Text != "" && comboBoxEdit1.Text != "" && dateEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit4.Text != "" && comboBoxEdit2.Text != "")
            {

                if (dateEdit1.Text == "")
                { s = null; }
                else { s = Convert.ToDateTime(dateEdit1.Text); }
                if (dateEdit3.Text == "")
                { po = null; }
                else { po = Convert.ToDateTime(dateEdit3.Text); }
                try
                {
                    string dd = Convert.ToString(kod_slujba);
                    this.queriesTableAdapter1.insert_dog_post(
                             Convert.ToInt32(id_tip_doc),
                             Convert.ToInt32(id_type_doc),
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
                               s,
                            po,
                             ref id_doc);
                    MessageBox.Show("Данные успешно сохранены!!!");
                }
                catch 
                { MessageBox.Show("Данные не сохранились!!!"); }

                Globals.en_delegate_dog_post();
                Close();
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DateTime? s;
            DateTime? po;
            if (lookUpEdit1.Text != "" && (gridLookUpEdit1.Text != "" || textEdit5.Text != "") && lookUpEdit4.Text != "" && lookUpEdit2.Text != "" && textEdit1.Text != "" && comboBoxEdit1.Text != "" && dateEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit4.Text != "" && comboBoxEdit2.Text != "")
 {
     if (!but_clik1)
     {

         string dd = Convert.ToString(kod_slujba);
         but_clik1 = true;
         if (dateEdit1.Text == "")
         { s = null; }
         else { s = Convert.ToDateTime(dateEdit1.Text); }
         if (dateEdit3.Text == "")
         { po = null; }
         else { po = Convert.ToDateTime(dateEdit3.Text); }
         this.queriesTableAdapter1.insert_dog_post(
                             Convert.ToInt32(id_tip_doc),
                             Convert.ToInt32(id_type_doc),
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime? s;
            DateTime? po;

            if (lookUpEdit1.Text != "" && (gridLookUpEdit1.Text != "" || textEdit5.Text != "") && lookUpEdit4.Text != "" && lookUpEdit2.Text != "" && textEdit1.Text != "" && comboBoxEdit1.Text != "" && dateEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit4.Text != "" && comboBoxEdit2.Text != "")
                 {
                     if (dateEdit1.Text == "")
                     { s = null; }
                     else { s = Convert.ToDateTime(dateEdit1.Text); }
                     if (dateEdit3.Text == "")
                     { po = null; }
                     else { po = Convert.ToDateTime(dateEdit3.Text); }
                     if (!but_clik)
                     {
                         string dd = Convert.ToString(kod_slujba);
                         but_clik = true;
                        
                         this.queriesTableAdapter1.insert_dog_post(
                             Convert.ToInt32(id_tip_doc), 
                             Convert.ToInt32(id_type_doc), 
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
        

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void Add_post_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iFRSforSeverelectroDataSet._Reference71' table. You can move, or remove it, as needed.
            this._Reference71TableAdapter.Fill(this.iFRSforSeverelectroDataSet._Reference71);
            // TODO: This line of code loads data into the 'iFRSforSeverelectroDataSet._Reference71' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'dataSet2.SC488' table. You can move, or remove it, as needed.
           // this.sC488TableAdapter.Fill(this.dataSet2.SC488);
            // TODO: This line of code loads data into the 'dataSet1.SC23' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'deloDataSet.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.Fill_rukovod(this.deloDataSet.users_programm);
            // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
            this.spr_slujbiTableAdapter.Fill_kod(this.deloDataSet.spr_slujbi);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org' table. You can move, or remove it, as needed.
            this.spr_orgTableAdapter.Fill_pos(this.deloDataSet.spr_org);
            // TODO: This line of code loads data into the 'deloDataSet.spr_doc' table. You can move, or remove it, as needed.
            this.spr_docTableAdapter.Fill_dog_post(this.deloDataSet.spr_doc);
            this.sC23TableAdapter.Fill(this.dataSet1.SC23);
            dateEdit2.Text = DateTime.Now.ToString();
            //comboBoxEdit1.Text = "";

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

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_tip_doc = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("int");
                id_type_doc = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_tip_doc");
            }
        }

        private void lookUpEdit5_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
           

        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_ruk= (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("user_id");

            }
        }

       

        private void lookUpEdit2_Closed_1(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {  if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                dolj = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Expr1");
                textEdit2.Text = dolj.ToString();

            }

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

            catch 
            {
                MessageBox.Show("Данные не сохранились");
            }
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