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
    public partial class Add_vnutr_doc : DevExpress.XtraEditors.XtraForm
    {
        bool but_clik = false;
        bool but_clik1 = false;
        object id_tip_doc;
        object kode_sektor;
        object id_slujbi;
        object id_type_doc;
        int? id_doc = 0;
        object dolj;
        object tabel;
        string Number;
        int days;
       int den1 = 0;
       int id_vnutr_doc;
        public Add_vnutr_doc(int id)
        {
            id_vnutr_doc = id;
            InitializeComponent();
        }

        private void Add_vnutr_doc_Load(object sender, EventArgs e)
        {
            gridControl1.Visible = false; 
            // TODO: This line of code loads data into the 'deloDataSet.View_all_vnutr_doc' table. You can move, or remove it, as needed.
            this.view_all_vnutr_docTableAdapter.FillBy(this.deloDataSet.View_all_vnutr_doc);
            if (Globals.id_slujbi == 23)
            {
                this.users_programmTableAdapter.Fill_rukovod(this.deloDataSet.users_programm);
                // TODO: This line of code loads data into the 'dataSet1.SC23' table. You can move, or remove it, as needed.
                this.sC23TableAdapter.Fill(this.dataSet1.SC23);
                // TODO: This line of code loads data into the 'dataSet1.DH225' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'deloDataSet.spr_doc' table. You can move, or remove it, as needed.
                this.spr_docTableAdapter.FillByProtkolaMetrologii(this.deloDataSet.spr_doc);
                // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
                this.spr_slujbiTableAdapter.Fill(this.deloDataSet.spr_slujbi);
                dateEdit2.Text = DateTime.Now.ToString();
                checkEdit1.Checked = true;
                groupControl2.Visible = false;
                checkEdit3.Visible = false;
                dateEdit1.Text = DateTime.Now.Date.ToString();
                dateEdit3.Text = DateTime.Now.Date.ToString();
            }

            else{
            // TODO: This line of code loads data into the 'deloDataSet.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.Fill_rukovod(this.deloDataSet.users_programm);
            // TODO: This line of code loads data into the 'dataSet1.SC23' table. You can move, or remove it, as needed.
            this.sC23TableAdapter.Fill(this.dataSet1.SC23);
            // TODO: This line of code loads data into the 'dataSet1.DH225' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'deloDataSet.spr_doc' table. You can move, or remove it, as needed.
            this.spr_docTableAdapter.Fill_vnutr_doc(this.deloDataSet.spr_doc);
            // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
            this.spr_slujbiTableAdapter.Fill(this.deloDataSet.spr_slujbi);
            dateEdit2.Text = DateTime.Now.ToString();
            checkEdit1.Checked = true;
            groupControl2.Visible = false;
            checkEdit3.Visible = false;
            dateEdit1.Text = DateTime.Now.Date.ToString();
            dateEdit3.Text = DateTime.Now.Date.ToString();}
         


        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(id_tip_doc) == 13 || Convert.ToInt32(id_tip_doc) == 16 || Convert.ToInt32(id_tip_doc) == 17 || Convert.ToInt32(id_tip_doc) == 18 || Convert.ToInt32(id_tip_doc) == 25 || Convert.ToInt32(id_tip_doc) == 26 || Convert.ToInt32(id_tip_doc) == 32)
            {
                if (Convert.ToInt32(id_tip_doc) == 13)
                { Globals.en_delegate_raport(); }
                if (Convert.ToInt32(id_tip_doc) == 16)
                { Globals.en_delegate_ukazy(); }
                if (Convert.ToInt32(id_tip_doc) == 18)
                { Globals.en_delegate_akty(); }
                if (Convert.ToInt32(id_tip_doc) == 17)
                { Globals.en_delegate_kom(); }
                if (Convert.ToInt32(id_tip_doc) == 25)
                { Globals.en_delegate_prikazy(); }
                if (Convert.ToInt32(id_tip_doc) == 26)
                { Globals.en_delegate_kadr_prikazy(); }
                if (Convert.ToInt32(id_tip_doc) == 32)
                { Globals.en_delegate_metrol_prikazy(); }
                Close();
            }
            else
            {
                if (Globals.click_menu == 2) { Close(); }
                else { 
                Globals.en_delegate();
                Close();}
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            if (checkEdit3.Checked == true)
            {
                if (lookUpEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit1.Text != "" && textEdit2.Text != "" && textEdit4.Text != "" && dateEdit1.Text != "" && dateEdit3.Text != "" && lookUpEdit4.Text != "")
                {
                    if (!but_clik)
                    {
                        string dd = Convert.ToString(kode_sektor);
                        but_clik = true;
                        if (dd == "" || Convert.ToInt32(id_slujbi)==0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                        else
                        {
                            this.queriesTableAdapter1.insert_vnutr_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), Convert.ToBoolean(checkEdit2.EditValue), Convert.ToBoolean(checkEdit1.EditValue), Convert.ToInt32(id_slujbi), Convert.ToString(lookUpEdit3.Text), Convert.ToString(memoEdit1.Text), textEdit6.Text, textEdit11.Text, lookUpEdit5.Text, lookUpEdit6.Text, textEdit8.Text, comboBoxEdit2.Text, ref id_doc,ref Number);
                            if (checkEdit4.Checked==true)
                            {
                                for (int i = 0; i <= gridView1.RowCount; i++)
                                {
                                    var check = gridView1.GetRowCellValue(i, "Check");
                                    if (Convert.ToString(check) != "")
                                    {
                                        if (Convert.ToBoolean(check) == true)
                                        {
                                            int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "id"));
                                           // string duble = Convert.ToString(gridView1.GetRowCellValue(i, "number"));
                                            this.queriesTableAdapter1.zakryt_vnutr_doc(id, Number, Convert.ToDateTime(dateEdit2.EditValue));


                                        }
                                    }
                                }
                               
                            }
                        Globals.id_doc = Convert.ToInt32(id_doc);

                        if (textEdit7.Text == "")
                        { den1 = 0; }
                        else
                        { den1 = Convert.ToInt32(textEdit7.Text); }
                        this.queriesTableAdapter1.insert_kom_udost(Globals.id_doc, textEdit2.Text, Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit3.EditValue), lookUpEdit3.Text, textEdit1.Text, Convert.ToInt32(textEdit3.Text), textEdit4.Text, textEdit5.Text, lookUpEdit4.Text, Convert.ToInt32(id_slujbi), Convert.ToDateTime(dateEdit5.EditValue), Convert.ToDateTime(dateEdit4.EditValue), den1);
                        MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");
                        
                        simpleButton2.Enabled = false;
                        simpleButton3.Enabled = false;
                        MainFrame mf = new MainFrame();
                        mf.Show();}

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
            else { 
            if ((checkEdit1.Checked == true || checkEdit2.Checked == true) && lookUpEdit1.Text != "" && lookUpEdit2.Text != "" && dateEdit2.Text != "")
            {
                //but_clik = false;
                if (!but_clik)
                {
                    string dd = Convert.ToString(kode_sektor);
                    but_clik = true;
                    if (dd == "" || Convert.ToInt32(id_slujbi) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                    else
                    {
                        this.queriesTableAdapter1.insert_vnutr_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), Convert.ToBoolean(checkEdit2.EditValue), Convert.ToBoolean(checkEdit1.EditValue), Convert.ToInt32(id_slujbi), Convert.ToString(lookUpEdit3.Text), Convert.ToString(memoEdit1.Text), textEdit6.Text, textEdit11.Text, lookUpEdit5.Text, lookUpEdit6.Text, textEdit8.Text, comboBoxEdit2.Text, ref id_doc,ref Number);
                        if (checkEdit4.Checked == true)
                        {
                            for (int i = 0; i <= gridView1.RowCount; i++)
                            {
                                var check = gridView1.GetRowCellValue(i, "Check");
                                if (Convert.ToString(check) != "")
                                {
                                    if (Convert.ToBoolean(check) == true)
                                    {
                                        int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "id"));
                                      //  string duble = Convert.ToString(gridView1.GetRowCellValue(i, "number"));
                                        this.queriesTableAdapter1.zakryt_vnutr_doc(id, Number, Convert.ToDateTime(dateEdit2.EditValue));


                                    }
                                }
                            }

                        }
                    MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");
                    Globals.id_doc = Convert.ToInt32(id_doc);
                    simpleButton2.Enabled = false;
                    simpleButton3.Enabled = false;
                    MainFrame mf = new MainFrame();
                    mf.Show();}

                }
                else
                {
                    simpleButton2.Enabled = false;
                    MainFrame mf = new MainFrame();
                    mf.Show();
                }
            }
            else { MessageBox.Show("Ни все поля заполнены"); }}
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (checkEdit3.Checked == true)
            {
                if (lookUpEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit1.Text != "" && textEdit2.Text != "" && textEdit4.Text != "" && dateEdit1.Text != "" && dateEdit3.Text != "" && lookUpEdit4.Text != "")
                {
                    if (!but_clik)
                    {
                        string dd = Convert.ToString(kode_sektor);
                        but_clik = true;
                        if (dd == "" || Convert.ToInt32(id_slujbi) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                        else
                        {
                            this.queriesTableAdapter1.insert_vnutr_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), Convert.ToBoolean(checkEdit2.EditValue), Convert.ToBoolean(checkEdit1.EditValue), Convert.ToInt32(id_slujbi), Convert.ToString(lookUpEdit3.Text), Convert.ToString(memoEdit1.Text), textEdit6.Text, textEdit11.Text, lookUpEdit5.Text, lookUpEdit6.Text, textEdit8.Text, comboBoxEdit2.Text, ref id_doc,ref Number);
                            if (checkEdit4.Checked == true)
                            {
                                for (int i = 0; i <= gridView1.RowCount; i++)
                                {
                                    var check = gridView1.GetRowCellValue(i, "Check");
                                    if (Convert.ToString(check) != "")
                                    {
                                        if (Convert.ToBoolean(check) == true)
                                        {
                                            int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "id"));
                                        //    string duble = Convert.ToString(gridView1.GetRowCellValue(i, "number"));
                                            this.queriesTableAdapter1.zakryt_vnutr_doc(id, Number, Convert.ToDateTime(dateEdit2.EditValue));


                                        }
                                    }
                                }

                            }
                        Globals.id_doc = Convert.ToInt32(id_doc);
                        if (textEdit7.Text == "")
                        { den1 = 0; }
                        else
                        { den1 = Convert.ToInt32(textEdit7.Text); }
                        this.queriesTableAdapter1.insert_kom_udost(Globals.id_doc, textEdit2.Text, Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit3.EditValue), lookUpEdit3.Text, textEdit1.Text, Convert.ToInt32(textEdit3.Text), textEdit4.Text, textEdit5.Text, lookUpEdit4.Text, Convert.ToInt32(id_slujbi), Convert.ToDateTime(dateEdit5.EditValue), Convert.ToDateTime(dateEdit4.EditValue), den1);
                        MessageBox.Show("Документ успешно зарегистрирован, далее прикрепите файл к этому документу!!!");

                        simpleButton1.Enabled = false;
                        simpleButton3.Enabled = false;
                        ofdInput.ShowDialog();} 

                    }
                    else
                    {
                        simpleButton1.Enabled = false;
                        ofdInput.ShowDialog();
                    }
                }
                else { MessageBox.Show("Ни все поля заполнены"); }

            }
            else { 
            if ((checkEdit1.Checked == true || checkEdit2.Checked == true) && lookUpEdit1.Text != "" && lookUpEdit2.Text != "" && dateEdit2.Text != "")
            {
                if (!but_clik1)
                {
                    
                    string dd = Convert.ToString(kode_sektor);
                    but_clik1 = true;
                    if (dd == "" || Convert.ToInt32(id_slujbi) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                    else
                    {
                        this.queriesTableAdapter1.insert_vnutr_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), Convert.ToBoolean(checkEdit2.EditValue), Convert.ToBoolean(checkEdit1.EditValue), Convert.ToInt32(id_slujbi), Convert.ToString(lookUpEdit3.Text), Convert.ToString(memoEdit1.Text), textEdit6.Text, textEdit11.Text, lookUpEdit5.Text, lookUpEdit6.Text, textEdit8.Text, comboBoxEdit2.Text, ref id_doc,ref Number);
                        if (checkEdit4.Checked == true)
                        {
                            for (int i = 0; i <= gridView1.RowCount; i++)
                            {
                                var check = gridView1.GetRowCellValue(i, "Check");
                                if (Convert.ToString(check) != "")
                                {
                                    if (Convert.ToBoolean(check) == true)
                                    {
                                        int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "id"));
                                   //     string duble = Convert.ToString(gridView1.GetRowCellValue(i, "number"));
                                        this.queriesTableAdapter1.zakryt_vnutr_doc(id, Number, Convert.ToDateTime(dateEdit2.EditValue));


                                    }
                                }
                            }

                        }
                    MessageBox.Show("Документ успешно зарегистрирован, далее прикрепите файл к этому документу!!!");
                    Globals.id_doc = Convert.ToInt32(id_doc);
                    simpleButton1.Enabled = false;
                    simpleButton3.Enabled = false;
                    ofdInput.ShowDialog();}

                }
                else
                {
                    simpleButton1.Enabled = false;
                    ofdInput.ShowDialog();
                }
            }
            else { MessageBox.Show("Ни все поля заполнены"); }}
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (checkEdit3.Checked == true)
            {
                if (lookUpEdit2.Text != "" && lookUpEdit3.Text != "" && textEdit1.Text != "" && textEdit2.Text != "" && textEdit4.Text != "" && dateEdit1.Text != "" && dateEdit3.Text != "" && lookUpEdit4.Text != "")
                {
                    try
                    {
                        string dd = Convert.ToString(kode_sektor);
                        if (dd == "" || Convert.ToInt32(id_slujbi) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                        else
                        {
                            this.queriesTableAdapter1.insert_vnutr_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), Convert.ToBoolean(checkEdit2.EditValue), Convert.ToBoolean(checkEdit1.EditValue), Convert.ToInt32(id_slujbi), Convert.ToString(lookUpEdit3.Text), Convert.ToString(memoEdit1.Text), textEdit6.Text, textEdit11.Text, lookUpEdit5.Text, lookUpEdit6.Text, textEdit8.Text, comboBoxEdit2.Text, ref id_doc,ref Number);
                            if (checkEdit4.Checked == true)
                            {
                                for (int i = 0; i <= gridView1.RowCount; i++)
                                {
                                    var check = gridView1.GetRowCellValue(i, "Check");
                                    if (Convert.ToString(check) != "")
                                    {
                                        if (Convert.ToBoolean(check) == true)
                                        {
                                            int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "id"));

                                            this.queriesTableAdapter1.zakryt_vnutr_doc(id, Number, Convert.ToDateTime(dateEdit2.EditValue));


                                        }
                                    }
                                }

                            }
                        Globals.id_doc = Convert.ToInt32(id_doc);
                        if (textEdit7.Text == "")
                        { den1 = 0; }
                        else
                        { den1 = Convert.ToInt32(textEdit7.Text); }
                        this.queriesTableAdapter1.insert_kom_udost(Globals.id_doc, textEdit2.Text, Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit3.EditValue), lookUpEdit3.Text, textEdit1.Text, Convert.ToInt32(textEdit3.Text), textEdit4.Text, textEdit5.Text, lookUpEdit4.Text, Convert.ToInt32(id_slujbi), Convert.ToDateTime(dateEdit5.EditValue), Convert.ToDateTime(dateEdit4.EditValue), den1);
                        MessageBox.Show("Данные успешно сохранены!!!");}
                    }
                    catch { MessageBox.Show("Данные не сохранились!!!"); }
                    if (Convert.ToInt32(id_tip_doc) == 13)
                    { Globals.en_delegate_raport(); }
                    if (Convert.ToInt32(id_tip_doc) == 16)
                    { Globals.en_delegate_ukazy(); }
                    if (Convert.ToInt32(id_tip_doc) == 17)
                    { Globals.en_delegate_kom(); }
                    if (Convert.ToInt32(id_tip_doc) == 18)
                    { Globals.en_delegate_akty(); }
                    if (Convert.ToInt32(id_tip_doc) == 25)
                    { Globals.en_delegate_prikazy(); }
                    if (Convert.ToInt32(id_tip_doc) == 26)
                    { Globals.en_delegate_kadr_prikazy(); }
                    if (Convert.ToInt32(id_tip_doc) == 32)
                    { Globals.en_delegate_metrol_prikazy(); }
                    Close();    

                   
                }
                else { MessageBox.Show("Ни все поля заполнены"); }
            }
            else
            {

                if ((checkEdit1.Checked == true || checkEdit2.Checked == true) && lookUpEdit1.Text != "" && lookUpEdit2.Text != "" && dateEdit2.Text != "")
                {
                    try
                    {
                        string dd = Convert.ToString(kode_sektor);
                        if (dd == "" || Convert.ToInt32(id_slujbi) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                        else
                        {
                            this.queriesTableAdapter1.insert_vnutr_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToDateTime(dateEdit2.EditValue), Convert.ToBoolean(checkEdit2.EditValue), Convert.ToBoolean(checkEdit1.EditValue), Convert.ToInt32(id_slujbi), Convert.ToString(lookUpEdit3.Text), Convert.ToString(memoEdit1.Text), textEdit6.Text, textEdit11.Text, lookUpEdit5.Text, lookUpEdit6.Text, textEdit8.Text, comboBoxEdit2.Text, ref id_doc,ref Number );
                            if (checkEdit4.Checked == true)
                            {
                                for (int i = 0; i <= gridView1.RowCount; i++)
                                {
                                    var check = gridView1.GetRowCellValue(i, "Check");
                                    if (Convert.ToString(check) != "")
                                    {
                                        if (Convert.ToBoolean(check) == true)
                                        {
                                            int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "id"));
                                            
                                            this.queriesTableAdapter1.zakryt_vnutr_doc(id, Number, Convert.ToDateTime(dateEdit2.EditValue));


                                        }
                                    }
                                }

                            }
                        MessageBox.Show("Данные успешно сохранены!!!");}
                    }
                    catch 
                    { MessageBox.Show("Данные не сохранились!!!"); }
                    if (Convert.ToInt32(id_tip_doc) == 13)
                    { Globals.en_delegate_raport(); }
                    if (Convert.ToInt32(id_tip_doc) == 16)
                    { Globals.en_delegate_ukazy(); }
                    if (Convert.ToInt32(id_tip_doc) == 17)
                    { Globals.en_delegate_kom(); }
                    if (Convert.ToInt32(id_tip_doc) == 18)
                    { Globals.en_delegate_akty(); }
                    if (Convert.ToInt32(id_tip_doc) == 25)
                    { Globals.en_delegate_prikazy(); }
                    if (Convert.ToInt32(id_tip_doc) == 26)
                    { Globals.en_delegate_kadr_prikazy(); }
                    if (Convert.ToInt32(id_tip_doc) == 32)
                    { Globals.en_delegate_metrol_prikazy(); }
                    Close();
                }
                else { MessageBox.Show("Ни все поля заполнены"); }
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

                    this.queriesTableAdapter1.insert_file(Globals.id_doc, outlen, file_name, memoEdit1.Text, Globals.id_user);
                    MessageBox.Show("Файл успешно прикреплен ;) ");
                }
            }

            catch 
            {
                MessageBox.Show("Данные не сохранились");
            }
        }

        private void lookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_tip_doc = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("int");
                kode_sektor = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("index_sectora");
                id_type_doc = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_tip_doc");

            }
            if (Convert.ToInt32(id_tip_doc) == 17)
            { checkEdit3.Visible = true; }
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_slujbi = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_slujbi");


            }
        }

        private void checkEdit1_Click(object sender, EventArgs e)
        {
            CheckEdit ch = sender as CheckEdit;
            if (ch.Name == "checkEdit1")
            { checkEdit2.Checked = false;
           
            }
            else { checkEdit1.Checked = false;
            
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

        private void checkEdit3_Click(object sender, EventArgs e)
        {
          
         
         
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit3.Checked == true) { groupControl2.Visible = true; labelControl3.Text = "Работник:";
            textEdit5.Visible = true; labelControl14.Visible = true;
            }
            else { groupControl2.Visible = false; }
        }

        private void dateEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
           days=(Convert.ToDateTime(dateEdit3.Text) - Convert.ToDateTime(dateEdit1.Text)).Days;
           textEdit3.Text = days.ToString();
        }

        private void dateEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            days = (Convert.ToDateTime(dateEdit3.Text) - Convert.ToDateTime(dateEdit1.Text)).Days;
            textEdit3.Text = days.ToString();
        }

        private void checkEdit4_Click(object sender, EventArgs e)
        {
            if (checkEdit4.Checked == false)
            { gridControl1.Visible = true; }
            else { gridControl1.Visible = false; }
        }

        
       
    }
}