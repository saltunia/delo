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
using delo.Properties;

namespace delo
{
    public partial class authentification : DevExpress.XtraEditors.XtraForm
    {
        
        public authentification()
        {
          
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
           
        }
      
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //this.usersTableAdapter.Fill("jjj", "jjj");
                this.users_selectTableAdapter.Fill(this.deloDataSet.users_select, textBoxLogin.Text.Trim(), textBoxPass.Text.Trim());
                if (deloDataSet != null && deloDataSet.users_select.Count() > 0)
                {
                    Settings.Default.UserNowName = textBoxLogin.Text;
                    Globals.id_user = (int)((DataRowView)users_selectBindingSource.Current).Row["user_id"];
                    Globals.name_user = (string)((DataRowView)users_selectBindingSource.Current).Row["fio"];
                    
                    Globals.id_slujbi = (int)((DataRowView)users_selectBindingSource.Current).Row["id_slujbi"];
                    Globals.name_slujbi = (string)((DataRowView)users_selectBindingSource.Current).Row["nazv_slujbi"];
                    Globals.id_doljnost = (int)((DataRowView)users_selectBindingSource.Current).Row["id_doljnost"];
                    if (((DataRowView)(users_selectBindingSource.Current)).Row["prava_mod_spravochnika"].ToString() != "")
                    {  Globals.prava_mod_spr = (int)((DataRowView)users_selectBindingSource.Current).Row["prava_mod_spravochnika"];}
                    else { Globals.prava_mod_spr = 2; }
                    if (Globals.id_slujbi == 130 && Globals.id_doljnost==131)
                    {
                        Globals.iii = 0;
                    //    Form main=new Main();
                    //main.Show(); 
                         Settings.Default.Save();
                         //Application.Run(new Main());
                    Close();
                    }
                    else { 
                    if (Globals.id_slujbi == 1)
                    {
                        Globals.iii = 2;
                        //    Form main=new Main();
                        //main.Show(); 
                        Settings.Default.Save();
                        //Application.Run(new Main());
                        Close();
                    }
                    else
                    {
                        Globals.iii = 1;
                        Settings.Default.Save();
                        //Application.Run(new Main());
                        Close();
                    }
                   
                    }

                }
                else
                {
                    textBoxLogin.SelectAll();
                    //textBoxPass.();
                    textBoxLogin.Focus();
                    labelControl3.Visible = true;
                    pictureBox1.Visible = false;
                }
              
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
           // this.Enabled = false;
           //Form f = new Main();
           //f.Show();
           //Globals.en_delegate();
        }

        private void authentification_Load(object sender, EventArgs e)
        {
            labelControl3.Visible = false;
              textBoxLogin.Text=Settings.Default.UserNowName;
        }

        private void simpleButton2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
               if (e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(null, null);
            }
        }

       

       
    }
}