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
using System.Diagnostics;

namespace delo
{
    public partial class Add_ishod_doc : DevExpress.XtraEditors.XtraForm
    {
        bool but_clik = false;
        bool but_clik1 = false;
        object id_tip_doc;
        object kode_otdela;
        object id_otdela;
        object id_org;
        object id_org2;
        object id_org3;
        object id_type_doc;
        object id_rukovod;
        int? id_doc = 0;
         string Number;
         string nomer;
         int id_dpc_prikr = 0;
        public Add_ishod_doc()
        {
            InitializeComponent();
            
            string str0 = delo.Properties.Settings.Default.strVvodSetting;
            string str1 = "";

            if (str0.Length == 0)

                return;
            while (str0.Length > 1)
            {

                str1 = str0.Substring(0, str0.IndexOf(';'));
                str0 = str0.Substring(str0.IndexOf(';') + 1, str0.Length - str0.IndexOf(';') - 1);
                comboBoxEdit1.Properties.Items.Add(str1);
            }


            string str2 = delo.Properties.Settings.Default.strVvodSetting1;
            string str3 = "";

            if (str2.Length == 0)

                return;
            while (str2.Length > 1)
            {

                str3 = str2.Substring(0, str2.IndexOf(';'));
                str2 = str2.Substring(str2.IndexOf(';') + 1, str2.Length - str2.IndexOf(';') - 1);
                comboBoxEdit2.Properties.Items.Add(str3);
            }
        }

        private void Add_ishod_doc_Load(object sender, EventArgs e)
        {
            queriesTableAdapter1.por_number(ref nomer);
            textEdit2.Text = nomer.ToString();
            
            if(Globals.form_ishod==1)
            { gridControl1.Visible = false; }
            // TODO: This line of code loads data into the 'deloDataSet.View_all_inbox_doc' table. You can move, or remove it, as needed.
            this.view_all_inbox_docTableAdapter.FillByZakryt(this.deloDataSet.View_all_inbox_doc);
          
            // TODO: This line of code loads data into the 'dataSet1.DH225' table. You can move, or remove it, as needed.
            this.dH225TableAdapter.Fill(this.dataSet1.DH225);
            // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
            this.spr_slujbiTableAdapter.Fill_kod(this.deloDataSet.spr_slujbi);
            // TODO: This line of code loads data into the 'deloDataSet.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.Fill_rukovod(this.deloDataSet.users_programm);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org_ruk' table. You can move, or remove it, as needed.
            this.spr_org_rukTableAdapter.Fill(this.deloDataSet.spr_org_ruk);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org' table. You can move, or remove it, as needed.
            this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
            // TODO: This line of code loads data into the 'deloDataSet.spr_doc' table. You can move, or remove it, as needed.
            this.spr_docTableAdapter.Fill_ishod_doc(this.deloDataSet.spr_doc);
            dateEdit2.Text = DateTime.Now.ToString();
           // lookUpEdit1.EditValue = lookUpEdit1.Properties.GetKeyValueByDisplayText("Журнал регистрации исходящей корреспонденции");
            lookUpEdit3.Visible = false;
            lookUpEdit6.Visible = false;
            labelControl5.Visible = false;
            labelControl10.Visible = false;
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
            if (lookUpEdit1.Text != "" && (lookUpEdit2.Text != "" ||textEdit1.Text!="") && lookUpEdit5.Text != "" && dateEdit2.Text != "")
            {
                //but_clik = false;
                if (!but_clik)
                {
                    string dd = Convert.ToString(kode_otdela);
                    but_clik = true;
                    if (Globals.form_ishod == 2)
                   {
                       if (dd == "" || Convert.ToInt32(id_otdela) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                       else {
                           if ((int)id_tip_doc == 15) { 
                           this.queriesTableAdapter1.insert_ishod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text,comboBoxEdit3.Text, ref Number);
                   }
                           if ((int)id_tip_doc == 34)
                           {
                               this.queriesTableAdapter1.insert_ishod_protokol(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                           }
                           this.queriesTableAdapter1.zakryt_doc(Convert.ToString(Number), Convert.ToDateTime(dateEdit2.EditValue), Globals.id_vhod, Globals.id_vhod_dubl);
                    MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");
                  }}
                   else
                   {
                       if (checkEdit2.Checked == true)
                       {
                           if (dd == "" || Convert.ToInt32(id_otdela) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                           else
                           {
                               if ((int)id_tip_doc == 15)
                               {
                                   this.queriesTableAdapter1.insert_ishod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                               }
                               if ((int)id_tip_doc == 34)
                               {
                                   this.queriesTableAdapter1.insert_ishod_protokol(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                               }
                          
                           for (int i = 0; i <= gridView1.RowCount; i++)
                           {
                               var check = gridView1.GetRowCellValue(i, "Check");
                               if (Convert.ToString(check) != "")
                               {
                                   if (Convert.ToBoolean(check) == true)
                                   {
                                       int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "id"));
                                       string dubl = Convert.ToString(gridView1.GetRowCellValue(i, "number"));
                                       this.queriesTableAdapter1.zakryt_doc(Convert.ToString(Number), Convert.ToDateTime(dateEdit2.EditValue), id,dubl);


                                   }
                               }
                           }
                           MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!"); }
                       }

                       else
                       {
                           if (dd == "" || Convert.ToInt32(id_otdela) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                           else
                           {
                               if ((int)id_tip_doc == 15)
                               {
                                   this.queriesTableAdapter1.insert_ishod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                               }
                               if ((int)id_tip_doc == 34)
                               {
                                   this.queriesTableAdapter1.insert_ishod_protokol(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                               }

                               MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");
                           }
                       }
                   }  
                    Globals.id_doc = Convert.ToInt32(id_doc);
                    simpleButton2.Enabled = false;
                    simpleButton3.Enabled = false;
                    MainFrame mf = new MainFrame();
                    mf.Show();

                }
                else
                {
                    Globals.id_doc = Convert.ToInt32(id_doc);
                    simpleButton2.Enabled = false;
                    MainFrame mf = new MainFrame();
                    mf.Show();
                }
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
            
            if (lookUpEdit1.Text != "" && (lookUpEdit2.Text != "" || textEdit1.Text != "") && lookUpEdit5.Text != "" && dateEdit2.Text != "")
            {
                if (!but_clik1)
                {

                    string dd = Convert.ToString(kode_otdela);
                    but_clik1 = true;
                    if (Globals.form_ishod == 2)
                    {
                        if (dd == "" || Convert.ToInt32(id_otdela) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                        else
                        {

                            if ((int)id_tip_doc == 15)
                            {
                                this.queriesTableAdapter1.insert_ishod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                            }
                            if ((int)id_tip_doc == 34)
                            {
                                this.queriesTableAdapter1.insert_ishod_protokol(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                            }
                            this.queriesTableAdapter1.zakryt_doc(Convert.ToString(Number), Convert.ToDateTime(dateEdit2.EditValue), Globals.id_vhod, Globals.id_vhod_dubl);
                            MessageBox.Show("Документ успешно зарегистрирован, далее прикрепите файл к этому документу!!!");
                        }
                    }
                    else
                    {
                        if (checkEdit2.Checked == true)
                        {
                            if (dd == "" || Convert.ToInt32(id_otdela) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                            else
                            {
                                if ((int)id_tip_doc == 15)
                                {
                                    this.queriesTableAdapter1.insert_ishod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                                }
                                if ((int)id_tip_doc == 34)
                                {
                                    this.queriesTableAdapter1.insert_ishod_protokol(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                                }
                            
                            for (int i = 0; i <= gridView1.RowCount; i++)
                            {
                                var check = gridView1.GetRowCellValue(i, "Check");
                                if (Convert.ToString(check) != "")
                                {
                                    if (Convert.ToBoolean(check) == true)
                                    {
                                        int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "id"));
                                        string duble = Convert.ToString(gridView1.GetRowCellValue(i, "number"));
                                        this.queriesTableAdapter1.zakryt_doc(Convert.ToString(Number), Convert.ToDateTime(dateEdit2.EditValue), id,duble);


                                    }
                                }
                            }
                            MessageBox.Show("Документ успешно зарегистрирован, далее прикрепите файл к этому документу!!!");}
                        }
                        else
                        {
                            if (dd == "" || Convert.ToInt32(id_otdela) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                            else
                            {
                                this.queriesTableAdapter1.insert_ishod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                            

                        MessageBox.Show("Документ успешно зарегистрирован, далее прикрепите файл к этому документу!!!");}
}

                    }  
                    Globals.id_doc = Convert.ToInt32(id_doc);
                    simpleButton1.Enabled = false;
                    simpleButton3.Enabled = false;
                    ofdInput.ShowDialog();

                }
                else
                {
                    Globals.id_doc = Convert.ToInt32(id_doc);
                    simpleButton1.Enabled = false;
                    ofdInput.ShowDialog();
                }
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text != "" && (lookUpEdit2.Text != "" || textEdit1.Text != "") && lookUpEdit5.Text != "" && dateEdit2.Text != "")
            {
                try
                {
                    string dd = Convert.ToString(kode_otdela);
                    if (Globals.form_ishod == 2)
                    {
                        if (dd == "" || Convert.ToInt32(id_otdela) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                        else
                        {
                            if ((int)id_tip_doc == 15)
                            {
                                this.queriesTableAdapter1.insert_ishod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                            }
                            if ((int)id_tip_doc == 34)
                            {
                                this.queriesTableAdapter1.insert_ishod_protokol(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                            }
                       
                    this.queriesTableAdapter1.zakryt_doc(Convert.ToString(Number), Convert.ToDateTime(dateEdit2.EditValue), Globals.id_vhod, Globals.id_vhod_dubl);} }
                    else
                    {
                        if (dd == "" || Convert.ToInt32(id_otdela) == 0) { MessageBox.Show("Выберите отдел(подразделение)!!!"); }
                        else
                        {
                            if ((int)id_tip_doc == 15)
                            {
                                this.queriesTableAdapter1.insert_ishod_doc(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                            }
                            if ((int)id_tip_doc == 34)
                            {
                                this.queriesTableAdapter1.insert_ishod_protokol(Convert.ToInt32(id_tip_doc), Convert.ToInt32(id_type_doc), Globals.id_user, dd, Convert.ToInt32(id_org), Convert.ToInt32(id_org2), Convert.ToInt32(id_org3), comboBoxEdit1.Text, Convert.ToInt32(id_rukovod), Convert.ToInt32(id_otdela), comboBoxEdit2.Text, Convert.ToDateTime(dateEdit2.EditValue), memoEdit1.Text, ref id_doc, textEdit1.Text, textEdit3.Text, textEdit5.Text, textEdit6.Text, comboBoxEdit3.Text, ref Number);
                            }
                        
                        for (int i = 0; i <= gridView1.RowCount; i++)
                        {
                            var check = gridView1.GetRowCellValue(i, "Check");
                            if (Convert.ToString(check) != "")
                            {
                                if (Convert.ToBoolean(check) == true)
                                {
                                    int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "id"));
                                    string dubl = Convert.ToString(gridView1.GetRowCellValue(i, "number"));
                                    this.queriesTableAdapter1.zakryt_doc(Convert.ToString(Number), Convert.ToDateTime(dateEdit2.EditValue), id, dubl);
                                 

                                }
                            }
                        }

                    }  
                    comboBoxEdit1.Properties.Items.Add(comboBoxEdit1.Text);
                    string allStr = "";
                    foreach (string str in comboBoxEdit1.Properties.Items)
                    {
                        allStr += str + ';';
                    }
                    delo.Properties.Settings.Default.strVvodSetting = allStr;
                    delo.Properties.Settings.Default.Save();

                    comboBoxEdit2.Properties.Items.Add(comboBoxEdit2.Text);
                    string allStr1 = "";
                    foreach (string str in comboBoxEdit2.Properties.Items)
                    {
                        allStr1 += str + ';';
                    }
                    delo.Properties.Settings.Default.strVvodSetting1 = allStr1;
                    delo.Properties.Settings.Default.Save();
                    MessageBox.Show("Данные успешно сохранены!!!");}
                   
                    
                }
                catch 
                { MessageBox.Show("Данные не сохранились!!!"); }
                if ((int)id_tip_doc == 15)
                {
                    Globals.en_delegate1();
                }
                if ((int)id_tip_doc == 34)
                {
                    Globals.en_delegate2();
                }
                Close();
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.Add(comboBoxEdit1.Text);
            string allStr = "";
            foreach (string str in comboBoxEdit1.Properties.Items)
            {
                allStr += str + ';';
            }
            delo.Properties.Settings.Default.strVvodSetting = allStr;
            delo.Properties.Settings.Default.Save();


            comboBoxEdit2.Properties.Items.Add(comboBoxEdit2.Text);
            string allStr1 = "";
            foreach (string str in comboBoxEdit2.Properties.Items)
            {
                allStr1 += str + ';';
            }
            delo.Properties.Settings.Default.strVvodSetting1 = allStr1;
            delo.Properties.Settings.Default.Save();
            if (id_tip_doc ==null)
            { Close(); 
                Globals.en_delegate1();
                }
            else { 
            if((int)id_tip_doc==15)
            { 
            Globals.en_delegate1();}
            if ((int)id_tip_doc == 34)
            {
                Globals.en_delegate2();
            }
            Close();}
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
                    if (fs.Length > 100000000000000000)
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
                id_type_doc = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_tip_doc");

            }
        }

        private void lookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_org = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id");

            }
        }

        private void lookUpEdit4_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_rukovod = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("user_id");

            }

        }

        private void lookUpEdit5_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
            {
                id_otdela=(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("id_slujbi");
                kode_otdela = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("kode_severelectro");

            }

        }

        

        private void checkEdit1_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == false)
            {
                lookUpEdit3.Visible = true;
                lookUpEdit6.Visible = true;
                labelControl5.Visible = true;
                labelControl10.Visible = true;
            }
            else
            {
                lookUpEdit3.Visible = false;
                lookUpEdit6.Visible = false;
                labelControl5.Visible = false;
                labelControl10.Visible = false;
            }
        }

        private void lookUpEdit3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
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

        private void checkEdit2_Click(object sender, EventArgs e)
        {
            if (checkEdit2.Checked == false)
            { gridControl1.Visible = true; }
            else { gridControl1.Visible = false; }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.doc_prikrep_fileTableAdapter.FillByid_doc(deloDataSet.doc_prikrep_file, id_dpc_prikr);
                byte[] b1 = ((byte[])((DataRowView)(docprikrepfileBindingSource.Current)).Row["prikr_file"]);
                string exens4grid = (string)((DataRowView)(docprikrepfileBindingSource.Current)).Row["name_file"];
                exens4grid = Path.GetExtension(exens4grid);
                string filename = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid);
                var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                bw.Write(b1);
                bw.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            { }
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          

        private void viewallinboxdocBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try { id_dpc_prikr = (int)((DataRowView)viewallinboxdocBindingSource.Current).Row["id"]; }
            catch { }
        }

        

       
    }
}