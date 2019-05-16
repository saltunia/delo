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
using DevExpress.XtraEditors.Repository;
using delo.Properties;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;


namespace delo
{
    public partial class Main1 : DevExpress.XtraEditors.XtraForm
    {
        byte[] b1;
        string exens4grid;
        int i;
        int id_otv = 0;
        
        public Main1()
        {
            InitializeComponent();
        }

        private void Main1_Load(object sender, EventArgs e)
        {
            Globals.but_click = 0;
            this.Text = "Вы вошли как: " + Globals.name_user + "        Подразделение: " + Globals.name_slujbi;
            if (Globals.id_slujbi == 23) {
                xtraTabPage5.PageVisible = true;
                xtraTabPage6.PageVisible = true;
                xtraTabPage7.PageVisible = true;
               gToolStripMenuItem.Visible = true;
               отсканироватьДокументToolStripMenuItem.Visible = true;
               рассылкаПротоколаToolStripMenuItem.Visible = true;
               рассылкаToolStripMenuItem.Visible = true;
            // TODO: This line of code loads data into the 'deloDataSet.View_all_vnutr_doc' table. You can move, or remove it, as needed.
            this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc,32);
            navBarGroup6.Visible = true;
            // TODO: This line of code loads data into the 'deloDataSet.rassylka' table. You can move, or remove it, as needed.
           // this.rassylkaTableAdapter.Fill(this.deloDataSet.rassylka);
            // TODO: This line of code loads data into the 'deloDataSet.otv_prikrep_file' table. You can move, or remove it, as needed.
           }
            else {
                xtraTabPage5.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                рассылкаToolStripMenuItem.Visible = true;
            navBarGroup6.Visible = false;}
            if (Globals.id_slujbi == 41)
            { рассылкаToolStripMenuItem.Visible = true; }
            this.rassylkaTableAdapter.FillByRead(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count1 = rassylkaBindingSource.Count;
            navBarItem5.Caption = "Прочитанных всего " + "(" + count1 + ")";

            this.rassylkaTableAdapter.FillByControl(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count2 = rassylkaBindingSource.Count;
            navBarItem1.Caption = "На контроле " + "(" + count2 + ")";

            this.rassylkaTableAdapter.FillByForinfo(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count3 = rassylkaBindingSource.Count;
            navBarItem3.Caption = "К сведению " + "(" + count3 + ")"; ;
            // TODO: This line of code loads data into the 'deloDataSet.doc_prikrep_file' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
            this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org_ruk' table. You can move, or remove it, as needed.
            this.spr_org_rukTableAdapter.Fill(this.deloDataSet.spr_org_ruk);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org' table. You can move, or remove it, as needed.
            this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
            // TODO: This line of code loads data into the 'deloDataSet.spr_doc' table. You can move, or remove it, as needed.
            this.spr_docTableAdapter.Fill(this.deloDataSet.spr_doc);
            // TODO: This line of code loads data into the 'deloDataSet.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.Fill(this.deloDataSet.users_programm);
            // TODO: This line of code loads data into the 'deloDataSet.rassylka' table. You can move, or remove it, as needed.
            this.rassylkaTableAdapter.FillByUnread(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count = rassylkaBindingSource.Count;

          
            navBarItem2.Caption = "Входящие новых " + "(" + count + ")";
            this.rassylkaTableAdapter.FillByUnread(this.deloDataSet.rassylka, Globals.id_slujbi);

            RepositoryItemCheckEdit checkEdit = gridControl1.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

            checkEdit.PictureChecked = Resources.Read;

            checkEdit.PictureUnchecked = Resources.Unread;

            checkEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;

            advBandedGridView1.Columns["status"].ColumnEdit = checkEdit;
            Animation();
            Delegate.RemoveAll(Globals.en_delegate_otvety, Globals.en_delegate_otvety);
            Globals.en_delegate_otvety = visible_main1;
            Delegate.RemoveAll(Globals.en_delegate_metrol_prikazy, Globals.en_delegate_metrol_prikazy);
            Globals.en_delegate_metrol_prikazy = visible_main2;
        }

        public void visible_main2()
        {
            if (Globals.id_slujbi == 23)
            {
                xtraTabPage5.PageVisible = true;
                navBarGroup6.Visible = true;
                xtraTabPage6.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                gToolStripMenuItem.Visible = true;
                отсканироватьДокументToolStripMenuItem.Visible = true;
                рассылкаПротоколаToolStripMenuItem.Visible = true;
                // TODO: This line of code loads data into the 'deloDataSet.View_all_vnutr_doc' table. You can move, or remove it, as needed.
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 32);

                // TODO: This line of code loads data into the 'deloDataSet.rassylka' table. You can move, or remove it, as needed.
                // this.rassylkaTableAdapter.Fill(this.deloDataSet.rassylka);
                // TODO: This line of code loads data into the 'deloDataSet.otv_prikrep_file' table. You can move, or remove it, as needed.
            }
        }

        public void visible_main1()
        {
            Globals.but_click = 0;
            this.Text = "Вы вошли как: " + Globals.name_user + "        Подразделение: " + Globals.name_slujbi;
            try
            {
                if (Globals.id_slujbi == 23)
                {
                    xtraTabPage5.PageVisible = true;
                    xtraTabPage6.PageVisible = true;
                    xtraTabPage7.PageVisible = true;
                    navBarGroup6.Visible = true;
                    gToolStripMenuItem.Visible = true;
                    отсканироватьДокументToolStripMenuItem.Visible = true;
                    рассылкаПротоколаToolStripMenuItem.Visible = true;
                    // TODO: This line of code loads data into the 'deloDataSet.View_all_vnutr_doc' table. You can move, or remove it, as needed.
                    this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 32);

                    // TODO: This line of code loads data into the 'deloDataSet.rassylka' table. You can move, or remove it, as needed.
                    // this.rassylkaTableAdapter.Fill(this.deloDataSet.rassylka);
                    // TODO: This line of code loads data into the 'deloDataSet.otv_prikrep_file' table. You can move, or remove it, as needed.
                }
                else {
                    xtraTabPage5.PageVisible = false;
                    xtraTabPage6.PageVisible = false;
                    xtraTabPage7.PageVisible = false;
                navBarGroup6.Visible = false;}
                this.rassylkaTableAdapter.FillByRead(this.deloDataSet.rassylka, Globals.id_slujbi);
                int count1 = rassylkaBindingSource.Count;
                navBarItem5.Caption = "Прочитанных всего " + "(" + count1 + ")";

                this.rassylkaTableAdapter.FillByControl(this.deloDataSet.rassylka, Globals.id_slujbi);
                int count2 = rassylkaBindingSource.Count;
                navBarItem1.Caption = "На контроле " + "(" + count2 + ")";

                this.rassylkaTableAdapter.FillByForinfo(this.deloDataSet.rassylka, Globals.id_slujbi);
                int count3 = rassylkaBindingSource.Count;
                navBarItem3.Caption = "К сведению " + "(" + count3 + ")"; ;
                // TODO: This line of code loads data into the 'deloDataSet.doc_prikrep_file' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
                this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
                // TODO: This line of code loads data into the 'deloDataSet.spr_org_ruk' table. You can move, or remove it, as needed.
                this.spr_org_rukTableAdapter.Fill(this.deloDataSet.spr_org_ruk);
                // TODO: This line of code loads data into the 'deloDataSet.spr_org' table. You can move, or remove it, as needed.
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                // TODO: This line of code loads data into the 'deloDataSet.spr_doc' table. You can move, or remove it, as needed.
                this.spr_docTableAdapter.Fill(this.deloDataSet.spr_doc);
                // TODO: This line of code loads data into the 'deloDataSet.users_programm' table. You can move, or remove it, as needed.
                this.users_programmTableAdapter.Fill(this.deloDataSet.users_programm);
                // TODO: This line of code loads data into the 'deloDataSet.rassylka' table. You can move, or remove it, as needed.
                this.rassylkaTableAdapter.FillByInbox(this.deloDataSet.rassylka, Globals.id_slujbi);
                int count = rassylkaBindingSource.Count;

              
                navBarItem2.Caption = "Входящие новых " + "(" + count + ")";
                this.rassylkaTableAdapter.FillByAll(this.deloDataSet.rassylka, Globals.id_slujbi);
                RepositoryItemCheckEdit checkEdit = gridControl1.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

                checkEdit.PictureChecked = Resources.Read;

                checkEdit.PictureUnchecked = Resources.Unread;

                checkEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;

                advBandedGridView1.Columns["status"].ColumnEdit = checkEdit;
                Animation();
                this.Enabled = true;

            }
            catch { }
        }



        private void Animation()
        {    bool svod;
            Image img = Resources.high; // DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("C:\\Users\\saltanatk\\Desktop\\high12.gif", typeof(GridAnimations).Assembly);
            byte[] bb = DevExpress.XtraEditors.Controls.ByteImageConverter.ToByteArray(img, ImageFormat.Gif);
            Image img1 = Resources.low; // DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("C:\\Users\\saltanatk\\Desktop\\high12.gif", typeof(GridAnimations).Assembly);
            byte[] bb1 = DevExpress.XtraEditors.Controls.ByteImageConverter.ToByteArray(img1, ImageFormat.Gif);
            rassylkaBindingSource.MoveFirst();
            try
            {
                if (rassylkaBindingSource.Count > 0)
                {

                    for (int i = 0; i <= rassylkaBindingSource.Count; i++)
                    {
                        if (((DataRowView)(rassylkaBindingSource.Current)).Row["control"] is DBNull) { svod = false; }
                        else
                        {
                            svod = (bool)((DataRowView)(rassylkaBindingSource.Current)).Row["control"];
                        }
                        if (svod == true)
                        {

                            advBandedGridView1.SetRowCellValue(i, bandedGridColumn1, bb);

                        }
                        else
                        {
                            advBandedGridView1.SetRowCellValue(i, bandedGridColumn1, bb1);
                        }
                        rassylkaBindingSource.MoveNext();
                    }
                }
            }
            catch { }
            rassylkaBindingSource.MoveFirst();
        }

        

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void advBandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            simpleButton1_Click_1(sender, e);
        }

        private void rassylkaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_doc_protokol = (int)((DataRowView)rassylkaBindingSource.Current).Row["id_doc"];
                Globals.id_ras_viza = (int)((DataRowView)rassylkaBindingSource.Current).Row["id"];
                if (((DataRowView)rassylkaBindingSource.Current).Row["otvet"] is DBNull)
                {
                    Globals.otvet1 = "";
                }
                else
                {
                    Globals.otvet1 = (string)((DataRowView)rassylkaBindingSource.Current).Row["otvet"];
                }
                if (((DataRowView)rassylkaBindingSource.Current).Row["date_exec"] is DBNull)
                { Globals.date_otvet = null; }
                else
                {
                    Globals.date_otvet = (DateTime)((DataRowView)rassylkaBindingSource.Current).Row["date_exec"];
                }
            }
            catch  { }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
                { this.doc_prikrep_fileTableAdapter.FillByid_doc(this.deloDataSet.doc_prikrep_file, Globals.id_doc_protokol); }

                if (xtraTabControl1.SelectedTabPage == xtraTabPage5)
                { this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 32); }
                if (xtraTabControl1.SelectedTabPage == xtraTabPage3)
                {
                    this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
                    
                    // TODO: This line of code loads data into the 'deloDataSet.otvet' table. You can move, or remove it, as needed.
                    this.otvetTableAdapter.Fill(this.deloDataSet.otvet, Globals.id_doc_protokol);
                    this.otv_prikrep_fileTableAdapter.Fill(this.deloDataSet.otv_prikrep_file);
                }
                if (xtraTabControl1.SelectedTabPage == xtraTabPage4)
                { this.rassylka_vizaTableAdapter.FillByUser(this.deloDataSet.rassylka_viza, Globals.id_doc_protokol, Globals.id_user); }

                if (xtraTabControl1.SelectedTabPage == xtraTabPage6)
                {
                    this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);

                    this.doc_prikrep_fileTableAdapter.FillByid_doc(this.deloDataSet.doc_prikrep_file, Globals.id_doc);
                   
                }
                if (xtraTabControl1.SelectedTabPage == xtraTabPage7)
                { this.rassylka_vizaTableAdapter.FillByUser(this.deloDataSet.rassylka_viza, Globals.id_doc, Globals.id_user); }


                if (xtraTabControl1.SelectedTabPage == xtraTabPage8)
                { this.rassylka_vizaTableAdapter.Fill(this.deloDataSet.rassylka_viza, Globals.id_doc_protokol); }
                   

            }
            catch { }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            /*DateTime da = DateTime.Now;
            i = rassylkaBindingSource.Position;
            this.rassylkaTableAdapter.UpdateStatus(da,Globals.id_doc, Globals.id_slujbi);
            
            this.rassylkaTableAdapter.FillByRead(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count1 = rassylkaBindingSource.Count;
            navBarItem5.Caption = "Прочитанных всего " + "(" + count1 + ")"; ;

            this.rassylkaTableAdapter.FillByControl(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count2 = rassylkaBindingSource.Count;
            navBarItem1.Caption = "На контроле " + "(" + count2 + ")"; ;

            this.rassylkaTableAdapter.FillByForinfo(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count3 = rassylkaBindingSource.Count;
            navBarItem3.Caption = "К сведени " + "(" + count3 + ")"; ;
            this.rassylkaTableAdapter.FillByInbox(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count = rassylkaBindingSource.Count;
            navBarItem2.Caption = "Входящие новых " + "(" + count + ")"; 
         
            this.rassylkaTableAdapter.FillByAll(this.deloDataSet.rassylka, Globals.id_slujbi);
            
            RepositoryItemCheckEdit checkEdit = gridControl1.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

            checkEdit.PictureChecked = Resources.Read;

            checkEdit.PictureUnchecked = Resources.Unread;

            checkEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;

            advBandedGridView1.Columns["status"].ColumnEdit = checkEdit;
            Animation();

            rassylkaBindingSource.Position = i;*/
        }

        private void advBandedGridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //simpleButton1_Click_1( sender,  e);
        }

        private void advBandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            simpleButton1_Click_1(sender, e);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.rassylkaTableAdapter.FillByRead(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count1 = rassylkaBindingSource.Count;
            navBarItem5.Caption = "Прочитанных всего " + "(" + count1 + ")"; ;

            this.rassylkaTableAdapter.FillByControl(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count2 = rassylkaBindingSource.Count;
            navBarItem1.Caption = "На контроле " + "(" + count2 + ")"; ;

            this.rassylkaTableAdapter.FillByForinfo(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count3 = rassylkaBindingSource.Count;
            navBarItem3.Caption = "К сведению " + "(" + count3 + ")"; ;
            // TODO: This line of code loads data into the 'deloDataSet.doc_prikrep_file' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'deloDataSet.spr_slujbi' table. You can move, or remove it, as needed.
            this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org_ruk' table. You can move, or remove it, as needed.
            this.spr_org_rukTableAdapter.Fill(this.deloDataSet.spr_org_ruk);
            // TODO: This line of code loads data into the 'deloDataSet.spr_org' table. You can move, or remove it, as needed.
            this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
            // TODO: This line of code loads data into the 'deloDataSet.spr_doc' table. You can move, or remove it, as needed.
            this.spr_docTableAdapter.Fill(this.deloDataSet.spr_doc);
            // TODO: This line of code loads data into the 'deloDataSet.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.Fill(this.deloDataSet.users_programm);
            // TODO: This line of code loads data into the 'deloDataSet.rassylka' table. You can move, or remove it, as needed.
            this.rassylkaTableAdapter.FillByInbox(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count = rassylkaBindingSource.Count;

            this.Text = "Вы вошли как: " + Globals.name_user + "        Подразделение: " + Globals.name_slujbi;
            navBarItem2.Caption = "Входящие новых" + "(" + count + ")";
            this.rassylkaTableAdapter.FillByUnread(this.deloDataSet.rassylka, Globals.id_slujbi);
            RepositoryItemCheckEdit checkEdit = gridControl1.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

            checkEdit.PictureChecked = Resources.Read;

            checkEdit.PictureUnchecked = Resources.Unread;

            checkEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;

            advBandedGridView1.Columns["status"].ColumnEdit = checkEdit;

            //RepositoryItemCheckEdit checkEdit1 = gridControl1.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

            //checkEdit1.PictureChecked = Resources.high;

            //checkEdit1.PictureUnchecked = Resources.low;
            timer1.Start();
            //checkEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            //advBandedGridView1.Columns["status"].ColumnEdit = checkEdit1;
            Animation();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            this.rassylkaTableAdapter.FillByRead(this.deloDataSet.rassylka, Globals.id_slujbi);
            Animation();
            xtraTabPage1.Text = "Прочитанные";
            timer1.Stop();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.rassylkaTableAdapter.FillByControl(this.deloDataSet.rassylka, Globals.id_slujbi);
            Animation();
            xtraTabPage1.Text = "Документы которые на конроле";
            timer1.Stop();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.rassylkaTableAdapter.FillByForinfo(this.deloDataSet.rassylka, Globals.id_slujbi);
            Animation();
            xtraTabPage1.Text = "Документы к сведению";
            timer1.Stop();
        }

        private void ответитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.otvet = "otvet";
            this.rassylkaTableAdapter.UpdateStatus(DateTime.Now, Globals.id_doc, Globals.id_slujbi);
            this.Enabled = false;
            Form kk = new Add_otvet();
            kk.ShowDialog();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void otvetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                id_otv = (int)((DataRowView)otvetBindingSource.Current).Row["id_otvet"];
                this.otv_prikrep_fileTableAdapter.FillByID(this.deloDataSet.otv_prikrep_file, id_otv);

            }
            catch  { }
        }

        private void otvbindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {

                //b1 = ((byte[])((DataRowView)(otvbindingSource.Current)).Row["prikr_file"]);
                //exens4grid = (string)((DataRowView)(otvbindingSource.Current)).Row["name_file"];
            }
            catch  { }
               
        }

        private void advBandedGridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        { 
            //GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
              int f;
                bool? ll1;
                string otvet;
               // var ll = advBandedGridView1.GetRowCellDisplayText(e.RowHandle, "status");
                if (advBandedGridView1.GetRowCellValue(e.RowHandle, "status") is DBNull)
                { ll1 = false; }
                else { 
                ll1 = Convert.ToBoolean(advBandedGridView1.GetRowCellValue(e.RowHandle, "status"));}
                if (advBandedGridView1.GetRowCellValue(e.RowHandle, "stat_otveta") is DBNull)
                {f= 0; }
                else { 
                f = Convert.ToInt32(advBandedGridView1.GetRowCellValue(e.RowHandle, "stat_otveta"));}
                if (advBandedGridView1.GetRowCellValue(e.RowHandle, "otvet") is DBNull || advBandedGridView1.GetRowCellValue(e.RowHandle, "otvet")=="")
                { otvet = ""; }
                else
                {
                    otvet = Convert.ToString(advBandedGridView1.GetRowCellValue(e.RowHandle, "otvet"));
                }

                if(f==1 || otvet!="")
                {
                    e.Appearance.BackColor = Color.DarkTurquoise;
                    e.Appearance.ForeColor = Color.Black;
                }
               else{
                if (ll1 == true)
                {
                    e.Appearance.BackColor = Color.YellowGreen;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                
                {

                    e.Appearance.BackColor = Color.Pink;
                    e.Appearance.ForeColor = Color.Black;

                }}


            }
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                b1 = ((byte[])((DataRowView)(otvbindingSource.Current)).Row["prikr_file"]);
                exens4grid = (string)((DataRowView)(otvbindingSource.Current)).Row["name_file"];
                string exens4grid1 = Path.GetExtension(exens4grid);
                string filename = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid1);
                var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                bw.Write(b1);
                bw.Close();
                Process.Start(filename);
            }
            catch 
            { }
        }

        string str1 = "";
        string str2 = "";
        string str3 = "";

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    byte[] b1 = ((byte[])((DataRowView)(docprikrepfileBindingSource.Current)).Row["prikr_file"]);
            //    string exens4grid = (string)((DataRowView)(docprikrepfileBindingSource.Current)).Row["name_file"];
            //    exens4grid = Path.GetExtension(exens4grid);
            //    string filename = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid);
            //    var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
            //    bw.Write(b1);
            //    bw.Close();
            //    Process.Start(filename);
            //}
            //catch (Exception ex)
            //{ }
            try
            {
               
                byte[] b11 = ((byte[])((DataRowView)(docprikrepfileBindingSource.Current)).Row["prikr_file"]);
                string exens4grid1 = (string)((DataRowView)(docprikrepfileBindingSource.Current)).Row["name_file"];
                str2 = exens4grid1;
                exens4grid1 = Path.GetExtension(exens4grid1);
                str3 = exens4grid1;
                string filename1 = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid1);
                str1 = filename1;
                var bw = new BinaryWriter(File.Open(filename1, FileMode.OpenOrCreate));
                bw.Write(b11);
                bw.Close();
                Process.Start(filename1);
            }
            catch (Exception ex)
            { MessageBox.Show(str3 + "\n" + str2 + "\n" + str1 + " \n" + ex.ToString()); }
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            int id = (int)gridView1.GetRowCellValue(rowHandle, "id_otvet");
            this.otv_prikrep_fileTableAdapter.FillByID(this.deloDataSet.otv_prikrep_file, id);

        }

        private void Main1_Resize(object sender, EventArgs e)
        {
            
            if (FormWindowState.Minimized == WindowState)
            {
                timer1.Start();
                this.rassylkaTableAdapter.FillByAll(this.deloDataSet.rassylka, Globals.id_slujbi);
                Globals.kol_test = rassylkaBindingSource.Count;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true; 
                
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Stop();
            Show();
            WindowState = FormWindowState.Maximized;
            RepositoryItemCheckEdit checkEdit = gridControl1.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

            checkEdit.PictureChecked = Resources.Read;

            checkEdit.PictureUnchecked = Resources.Unread;

            checkEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;

            advBandedGridView1.Columns["status"].ColumnEdit = checkEdit;
            Animation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.rassylkaTableAdapter.FillByAll(this.deloDataSet.rassylka, Globals.id_slujbi);
            RepositoryItemCheckEdit checkEdit = gridControl1.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

            checkEdit.PictureChecked = Resources.Read;

            checkEdit.PictureUnchecked = Resources.Unread;

            checkEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;

            advBandedGridView1.Columns["status"].ColumnEdit = checkEdit;
            Animation();
            if (rassylkaBindingSource.Count > Globals.kol_test)
            {
                Show();
                WindowState = FormWindowState.Maximized;
            }
         
        }

        private void прочиталToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            bool stat;
            
            if(((DataRowView)(rassylkaBindingSource.Current)).Row["status"] is DBNull)
            {stat=false;}
            else { stat = (bool)((DataRowView)(rassylkaBindingSource.Current)).Row["status"]; }

            if (stat ==true)
            { MessageBox.Show("Этот документ уже прочитан!!!"); }
            else { 
            this.rassylkaTableAdapter.UpdateStatus(DateTime.Now, Globals.id_doc_protokol, Globals.id_slujbi);
           
         
           

            this.rassylkaTableAdapter.FillByRead(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count1 = rassylkaBindingSource.Count;
            navBarItem5.Caption = "Прочитанных всего " + "(" + count1 + ")"; ;

            this.rassylkaTableAdapter.FillByControl(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count2 = rassylkaBindingSource.Count;
            navBarItem1.Caption = "На контроле " + "(" + count2 + ")"; ;

            this.rassylkaTableAdapter.FillByForinfo(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count3 = rassylkaBindingSource.Count;
            navBarItem3.Caption = "К сведени " + "(" + count3 + ")"; ;
            this.rassylkaTableAdapter.FillByInbox(this.deloDataSet.rassylka, Globals.id_slujbi);
            int count = rassylkaBindingSource.Count;
            navBarItem2.Caption = "Входящие новых " + "(" + count + ")";
 this.rassylkaTableAdapter.FillByUnread(this.deloDataSet.rassylka, Globals.id_slujbi);
            RepositoryItemCheckEdit checkEdit = gridControl1.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;

            checkEdit.PictureChecked = Resources.Read;

            checkEdit.PictureUnchecked = Resources.Unread;

            checkEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;

            advBandedGridView1.Columns["status"].ColumnEdit = checkEdit;
          
            Animation();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DateTime s = Convert.ToDateTime(dateEdit6.Text);
            DateTime d = Convert.ToDateTime(dateEdit5.Text);
            this.rassylkaTableAdapter.FillByDate(this.deloDataSet.rassylka, Globals.id_slujbi,s,d);
            Animation();
            xtraTabPage1.Text = "Прочитанные";
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.rassylkaTableAdapter.FillByRead(this.deloDataSet.rassylka, Globals.id_slujbi);
            Animation();
            xtraTabPage1.Text = "Прочитанные";

        }

        private void рассылкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.but_click = 1;
            this.doc_prikrep_fileTableAdapter.FillByid_doc(this.deloDataSet.doc_prikrep_file, Globals.id_doc_protokol);
            if (docprikrepfileBindingSource.Count > 0)
            {
                Form kk = new Slujbi(Globals.id_slujbi);
                kk.ShowDialog();
                
            }
            else
            { MessageBox.Show("У этого документа нет файлов, невозможно переслать!!! Документ должен содержать хотя бы 1 файл!!!"); }


        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            var rowHandle = advBandedGridView2.FocusedRowHandle;

            for (int i = 0; i <= advBandedGridView2.RowCount; i++)
            {
                var check = advBandedGridView2.GetRowCellValue(i, "udal");
                if (Convert.ToString(check) != "")
                {
                    if (Convert.ToBoolean(check) == true)
                    {
                        int id = Convert.ToInt32(advBandedGridView2.GetRowCellValue(i, "id"));
                        rassylka_vizaTableAdapter.DeleteQuery(id);

                    }
                }
            }
            this.rassylka_vizaTableAdapter.FillByUser(this.deloDataSet.rassylka_viza, Globals.id_doc_protokol,Globals.id_user);
        }

        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }
        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.rassylkaTableAdapter.FillBy2016(this.deloDataSet.rassylka, Globals.id_slujbi);
            Animation();
            timer1.Stop();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            timer1.Stop();
            Globals.click_menu = 2;
            Form f = new Add_vnutr_doc(0);
            f.Show();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 32);
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            string ss = dateEdit10.Text;
            string dd = dateEdit9.Text;
            int? ddd = 32;
            this.view_all_vnutr_docTableAdapter.FillByVnutrDate(this.deloDataSet.View_all_vnutr_doc, ddd,ss,dd);
        }

        private void advBandedGridView4_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                if ((View.GetRowCellValue(e.RowHandle, View.Columns["viza"])) is DBNull)
                {
                    e.Appearance.BackColor = Color.FromArgb(0xCC, 0xCC, 0xFF);
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {


                    var ll = View.GetRowCellDisplayText(e.RowHandle, View.Columns["for_info"]);
                    if ((bool)(View.GetRowCellValue(e.RowHandle, View.Columns["for_info"])) != false)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else
                    {
                        var ll1 = View.GetRowCellDisplayText(e.RowHandle, View.Columns["otvet1"]);
                        if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["otvet1"])) != "" && (bool)(View.GetRowCellValue(e.RowHandle, View.Columns["control"])) == true)
                        {
                            e.Appearance.BackColor = Color.YellowGreen;
                            e.Appearance.ForeColor = Color.Black;
                        }
                        else
                        {
                            e.Appearance.BackColor = Color.Pink;
                            e.Appearance.ForeColor = Color.Black;
                        }
                    }
                }

            }
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdInput.ShowDialog();
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

                    this.queriesTableAdapter1.insert_file(Globals.id_doc, outlen, file_name, null, Globals.id_user);
                    MessageBox.Show("Файл успешно прикреплен ;) ");
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show("Данные не сохранились");
            }
        }

        private void viewallvnutrdocBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {

                Globals.id_doc = Convert.ToInt32(((DataRowView)viewallvnutrdocBindingSource.Current).Row["id"]);
             
            }
            catch (Exception ex) { }
        }

        private void отсканироватьДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kk = new MainFrame();
            kk.ShowDialog();
        }

        private void xtraTabControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                byte[] b11 = ((byte[])((DataRowView)(docprikrepfileBindingSource.Current)).Row["prikr_file"]);
                string exens4grid1 = (string)((DataRowView)(docprikrepfileBindingSource.Current)).Row["name_file"];
                str2 = exens4grid1;
                exens4grid1 = Path.GetExtension(exens4grid1);
                str3 = exens4grid1;
                string filename1 = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid1);
                str1 = filename1;
                var bw = new BinaryWriter(File.Open(filename1, FileMode.OpenOrCreate));
                bw.Write(b11);
                bw.Close();
                Process.Start(filename1);
            }
            catch (Exception ex)
            { MessageBox.Show(str3 + "\n" + str2 + "\n" + str1 + " \n" + ex.ToString()); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var rowHandle = advBandedGridView2.FocusedRowHandle;

            for (int i = 0; i <= advBandedGridView2.RowCount; i++)
            {
                var check = advBandedGridView2.GetRowCellValue(i, "udal");
                if (Convert.ToString(check) != "")
                {
                    if (Convert.ToBoolean(check) == true)
                    {
                        int id = Convert.ToInt32(advBandedGridView2.GetRowCellValue(i, "id"));
                        rassylka_vizaTableAdapter.DeleteQuery(id);

                    }
                }
            }
            this.rassylka_vizaTableAdapter.FillByUser(this.deloDataSet.rassylka_viza, Globals.id_doc, Globals.id_user);
        }

        private void рассылкаПротоколаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.but_click = 2;
            this.doc_prikrep_fileTableAdapter.FillByid_doc(this.deloDataSet.doc_prikrep_file, Globals.id_doc);
            if (docprikrepfileBindingSource.Count > 0)
            {
                Form kk = new Slujbi(23);
                kk.ShowDialog();

            }
            else
            { MessageBox.Show("У этого документа нет файлов, невозможно переслать!!! Документ должен содержать хотя бы 1 файл!!!"); }

        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                byte[] b11 = ((byte[])((DataRowView)(docprikrepfileBindingSource.Current)).Row["prikr_file"]);
                string exens4grid1 = (string)((DataRowView)(docprikrepfileBindingSource.Current)).Row["name_file"];
                str2 = exens4grid1;
                exens4grid1 = Path.GetExtension(exens4grid1);
                str3 = exens4grid1;
                string filename1 = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid1);
                str1 = filename1;
                var bw = new BinaryWriter(File.Open(filename1, FileMode.OpenOrCreate));
                bw.Write(b11);
                bw.Close();
                Process.Start(filename1);
            }
            catch (Exception ex)
            { MessageBox.Show(str3 + "\n" + str2 + "\n" + str1 + " \n" + ex.ToString()); }
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl6);
        }

        private void просмотрОтветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.date_otvet != null && Globals.otvet1 != "")
            {
                this.select_idTableAdapter.Fill(this.deloDataSet.select_id, Globals.otvet1, Globals.date_otvet);
                if (select_idBindingSource.Count > 0)
                {

                    try
                    {
                        int id_otvet = (int)((DataRowView)(select_idBindingSource.Current)).Row["id"];
                        this.doc_prikrep_fileTableAdapter.FillByid_doc(deloDataSet.doc_prikrep_file, id_otvet);
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
                else { MessageBox.Show("По этому документу нет  документа!!!"); }
            }
            else { MessageBox.Show("По этому документу нет  документа!!!"); }
        }

        private void advBandedGridView1_RowUpdated_1(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var rowHandle = advBandedGridView1.FocusedRowHandle;
            int id;
            string ispol;
            string visa_nach;
            if (advBandedGridView1.GetRowCellValue(rowHandle, "id") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "id") == "")
            { id = 0; }
            else
            {
                id = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "ispol") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "ispol") == "")
            { ispol = ""; }
            else
            {
                ispol = (string)advBandedGridView1.GetRowCellValue(rowHandle, "ispol");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "visa_nach") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "visa_nach") == "")
            { visa_nach = ""; }
            else
            {
                visa_nach = (string)advBandedGridView1.GetRowCellValue(rowHandle, "visa_nach");
            }
            rassylka_vizaTableAdapter.UpdateQuery(ispol, visa_nach, id);
        }

       

  
       
    }
}