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

namespace delo
{
    public partial class Add_dogovor : DevExpress.XtraEditors.XtraForm
    {
        bool but_clik = false;
        bool but_clik1 = false;
        
        object kode_sektor;
        object id_org;
        object id_tip_doc;
        object id_type_doc;
        int? id_doc = 0;
        object id_otdel;
        object id_dolj;
        object dolj;
        public Add_dogovor()
        {
            InitializeComponent();
        }

        private void Add_dogovor_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dataSet1.SC23' table. You can move, or remove it, as needed.
            this.sC23TableAdapter.Fill(this.dataSet1.SC23);
            // TODO: This line of code loads data into the 'dataSet1.DH225' table. You can move, or remove it, as needed.
            this.dH225TableAdapter.Fill(this.dataSet1.DH225);
            // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
            this.spr_slujbiTableAdapter.FillBySlujby(this.deloDataSet.spr_slujbi);
            // TODO: This line of code loads data into the 'deloDataSet.spr_doljnostei' table. You can move, or remove it, as needed.
            this.spr_doljnosteiTableAdapter.Fill(this.deloDataSet.spr_doljnostei);
            // TODO: This line of code loads data into the 'deloDataSet.spr_doc' table. You can move, or remove it, as needed.
            this.spr_docTableAdapter.Fill_dogovor(this.deloDataSet.spr_doc);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org' table. You can move, or remove it, as needed.
            this.spr_orgTableAdapter.Fill_pos(this.deloDataSet.spr_org);
            // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
         
            textEdit2.Text = "";
            dateEdit2.Text = DateTime.Now.ToString();
        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            groupControl1.Visible = true;
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_tip_doc = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("int");
                kode_sektor = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("index_sectora");
                id_type_doc = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_tip_doc");
            }
            if (Convert.ToInt32(id_tip_doc) == 14)
            {

                

                labelControl3.Visible = true;
                labelControl5.Visible = true;
                lookUpEdit5.Visible = true;
                textEdit2.Visible = true;
                lookUpEdit4.Visible = true;
                labelControl8.Visible = true;

            }
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(id_tip_doc) == 14 || Convert.ToInt32(id_tip_doc) == 19)
            {
                if (Convert.ToInt32(id_tip_doc) == 14)
                { Globals.en_delegate_dog_mat(); }
                if (Convert.ToInt32(id_tip_doc) == 19)
                { Globals.en_delegate_dog_post(); }
                Close();
            }
            else { Globals.en_delegate();
            Close();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(id_tip_doc) == 14){
            if (lookUpEdit1.Text != "" && lookUpEdit5.Text != "" && lookUpEdit4.Text != "" && textEdit2.Text != ""  && dateEdit2.Text != "")
            {
                try
                {
                    string dd = Convert.ToString(kode_sektor);
                    this.queriesTableAdapter1.insert_dog_mat_otv(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, Convert.ToDateTime(dateEdit2.EditValue), lookUpEdit5.Text, textEdit2.Text, Convert.ToInt32(id_otdel), memoEdit1.Text, ref id_doc);
                    MessageBox.Show("Данные успешно сохранены!!!");
                }
                catch (Exception ex)
                { MessageBox.Show("Данные не сохранились!!!"); }
               
                 Globals.en_delegate_dog_mat(); 
               
                Close();
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
            }

            //if (Convert.ToInt32(id_tip_doc) == 19)
            //{
            //    if (lookUpEdit2.Text != "" &&  textEdit1.Text != "" && comboBoxEdit1.Text != "" && dateEdit2.Text != "")
            //{
            //    try
            //    {
            //        string dd = Convert.ToString(kode_sektor);
            //        this.queriesTableAdapter1.insert_dog_post(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue),Convert.ToInt32(id_org), Convert.ToDecimal(textEdit1.Text), comboBoxEdit1.Text, memoEdit1.Text, ref id_doc);
            //        MessageBox.Show("Данные успешно сохранены!!!");
            //    }
            //    catch (Exception ex)
            //    { MessageBox.Show("Данные не сохранились!!!"); }
               
            //    Globals.en_delegate_dog_post(); 
            //    Close();
            //}
            //else { MessageBox.Show("Ни все поля заполнены"); }
            //}
        }

        private void lookUpEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {

            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_otdel = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_slujbi");
               
            }
        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {

            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_dolj = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_doljnosti");

            }
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_org = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(id_tip_doc) == 14)
            {
                if (lookUpEdit1.Text != "" && lookUpEdit5.Text != "" && lookUpEdit4.Text != "" && textEdit2.Text != "" && dateEdit2.Text != "")
                {
                    if (!but_clik1)
                    {

                        string dd = Convert.ToString(kode_sektor);
                        but_clik1 = true;
                        this.queriesTableAdapter1.insert_dog_mat_otv(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user,  Convert.ToDateTime(dateEdit2.EditValue), lookUpEdit5.Text, textEdit2.Text, Convert.ToInt32(id_otdel), memoEdit1.Text, ref id_doc);
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

            //if (Convert.ToInt32(id_tip_doc) == 19)
            //{
            //    if (lookUpEdit2.Text != "" && textEdit1.Text != "" && comboBoxEdit1.Text != "" && dateEdit2.Text != "")
            //    {
            //        if (!but_clik1)
            //        {

            //            string dd = Convert.ToString(kode_sektor);
            //            but_clik1 = true;
            //            this.queriesTableAdapter1.insert_dog_post(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), Convert.ToInt32(id_org), Convert.ToDecimal(textEdit1.Text), comboBoxEdit1.Text, memoEdit1.Text, ref id_doc);
            //            MessageBox.Show("Документ успешно зарегистрирован, далее прикрепите файл к этому документу!!!");
            //            Globals.id_doc = Convert.ToInt32(id_doc);
            //            simpleButton1.Enabled = false;
            //            simpleButton3.Enabled = false;
            //            ofdInput.ShowDialog();

            //        }
            //        else
            //        {
            //            simpleButton1.Enabled = false;
            //            ofdInput.ShowDialog();
            //        }
            //    }
            //    else { MessageBox.Show("Ни все поля заполнены"); }
            //}

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

            catch (IOException ioex)
            {
                MessageBox.Show("Данные не сохранились");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
             if (Convert.ToInt32(id_tip_doc) == 14)
             {
                 if (lookUpEdit1.Text != "" && lookUpEdit5.Text != "" && lookUpEdit4.Text != "" && textEdit2.Text != "" && dateEdit2.Text != "")
                 {
                     //but_clik = false;
                     if (!but_clik)
                     {
                         string dd = Convert.ToString(kode_sektor);
                         but_clik = true;

                         this.queriesTableAdapter1.insert_dog_mat_otv(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user,  Convert.ToDateTime(dateEdit2.EditValue), lookUpEdit5.Text, textEdit2.Text, Convert.ToInt32(id_otdel), memoEdit1.Text, ref id_doc);
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
             //if (Convert.ToInt32(id_tip_doc) == 19)
             //{
             //    if (lookUpEdit2.Text != "" && textEdit1.Text != "" && comboBoxEdit1.Text != "" && dateEdit2.Text != "")
             //    {
             //        //but_clik = false;
             //        if (!but_clik)
             //        {
             //            string dd = Convert.ToString(kode_sektor);
             //            but_clik = true;

             //            this.queriesTableAdapter1.insert_dog_post(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), Convert.ToInt32(id_org), Convert.ToDecimal(textEdit1.Text), comboBoxEdit1.Text, memoEdit1.Text, ref id_doc);
             //            MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");
             //            Globals.id_doc = Convert.ToInt32(id_doc);
             //            simpleButton2.Enabled = false;
             //            simpleButton3.Enabled = false;
             //            MainFrame mf = new MainFrame();
             //            mf.Show();

             //        }
             //        else
             //        {
             //            simpleButton2.Enabled = false;
             //            MainFrame mf = new MainFrame();
             //            mf.Show();
             //        }
             //    }
             //    else { MessageBox.Show("Ни все поля заполнены"); }
             //}

        }

        private void lookUpEdit5_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                dolj = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Expr1");

            }
            try
            {
                textEdit2.Text = dolj.ToString();
            }
            catch { }

        }
   }
}