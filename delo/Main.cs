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
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraGrid;

namespace delo
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {


        public Main()
        {
            InitializeComponent();
            gridView11.IndicatorWidth = 40;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iFRSforSeverelectroDataSet._Reference71' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'deloDataSet._Reference71' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'iFRSforSeverelectroDataSet._Reference71' table. You can move, or remove it, as needed.
          
            Globals.click_menu = 0;
            Globals.but_click_ishod = 0;
            Globals.but_click_file_insert = 0;
            // TODO: This line of code loads data into the 'dataSet2.SC488' table. You can move, or remove it, as needed.
            // this.sC488TableAdapter.Fill(this.dataSet2.SC488);
             //TODO: This line of code loads data into the 'deloDataSet.kom_udostov' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'deloDataSet.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.Fill(this.deloDataSet.users_programm);
            // TODO: This line of code loads data into the 'deloDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.deloDataSet.users);
            // TODO: This line of code loads data into the 'deloDataSet.otv_prikrep_file' table. You can move, or remove it, as needed.
            this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
            this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
            регистрацияКомандирудостовToolStripMenuItem.Visible = false;
            закрытьДокументToolStripMenuItem.Visible = true;
            // this.view_all_outbox_docTableAdapter.FillByUser(this.deloDataSet.View_all_outbox_doc,Globals.id_user);
            //this.doc_prikrep_fileTableAdapter.Fill(this.deloDataSet.doc_prikrep_file);

            Delegate.RemoveAll(Globals.en_delegate, Globals.en_delegate);
            Delegate.RemoveAll(Globals.en_delegate1, Globals.en_delegate1);
            Delegate.RemoveAll(Globals.en_delegate2, Globals.en_delegate2);
            Delegate.RemoveAll(Globals.en_delegate_raport, Globals.en_delegate_raport);
            Delegate.RemoveAll(Globals.en_delegate_prikazy, Globals.en_delegate_prikazy);
            Delegate.RemoveAll(Globals.en_delegate_ukazy, Globals.en_delegate_ukazy);
            Delegate.RemoveAll(Globals.en_delegate_akty, Globals.en_delegate_akty);
            Delegate.RemoveAll(Globals.en_delegate_kom, Globals.en_delegate_kom);
            Delegate.RemoveAll(Globals.en_delegate_dog_post, Globals.en_delegate_dog_post);
            Delegate.RemoveAll(Globals.en_delegate_dog_mat, Globals.en_delegate_dog_mat);
            Delegate.RemoveAll(Globals.en_delegate_dog_agent, Globals.en_delegate_dog_agent);
            Globals.en_delegate = visible_main;
            Globals.en_delegate1 = visible_main1;
            Globals.en_delegate2 = visible_main2;
            Globals.en_delegate_raport = visible_main_raport;
            Globals.en_delegate_prikazy = visible_main_prikazy;
            Globals.en_delegate_ukazy = visible_main_ukazy;
            Globals.en_delegate_akty = visible_main_akty;
            Globals.en_delegate_kom = visible_main_kom;
            Globals.en_delegate_dog_post = visible_main_post;
            Globals.en_delegate_dog_agent = visible_main_agent;
            Globals.en_delegate_dog_mat = visible_main_mat;
            Globals.en_delegate_kadr_prikazy = visible_main_kadr_prikazy;
            navBarGroup6.Visible = true;


            this.Text = "Вы вошли как: " + Globals.name_user + "        Подразделение: " + Globals.name_slujbi;
            if (Globals.id_slujbi != 130)
            {
                dropDownButton1.Visible = false;
            }

            navBarItem2.Caption = Globals.name_user.ToString();
            navBarItem19.Caption = Globals.name_user.ToString();
            xtraTabPage8.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage7.PageVisible = false;
            xtraTabPage2.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabPage13.PageVisible = false;
            xtraTabPage14.PageVisible = false;
            try
            {
                this.view_all_inbox_docTableAdapter.Fill_by_user(this.deloDataSet.View_all_inbox_doc, Globals.id_user);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public void visible_main()
        {
            Globals.click_menu = 0;
           
            try
            {

                //  this.viewallinboxdocBindingSource.MoveLast();
                this.Enabled = true;
                VhodTabControl1.SelectedTabPage = xtraTabPage1;
                закрытьДокументToolStripMenuItem.Visible = true;
                печатьToolStripMenuItem.Visible = true;
                посмотретьToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                this.view_all_inbox_docTableAdapter.Fill_by_user(this.deloDataSet.View_all_inbox_doc, Globals.id_user);
                this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
            }
            catch { }
        }
        public void visible_main_agent()
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = true;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                VhodTabControl1.SelectedTabPage = xtraTabPage14;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible =  false;
                посмотретьToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                this.view_all_agent_dogTableAdapter1.Fill(this.deloDataSet.View_all_agent_dog);
                this.viewallagentdogBindingSource.MoveLast();
                this.Enabled = true;

            }
            catch { }
        }
        public void visible_main1()
        {
            Globals.but_click_ishod = 0;
            try
            {
                this.view_all_outbox_docTableAdapter.FillByUser(this.deloDataSet.View_all_outbox_doc,15, Globals.id_user);
                viewalloutboxdocBindingSource.MoveLast();
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage3.Text = "Рассылка";
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                посмотретьToolStripMenuItem.Visible = false;
                xtraTabPage7.Text = "Исходящие документы";
                VhodTabControl1.SelectedTabPage = xtraTabPage7;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                this.Enabled = true;

            }
            catch { }
        }
        public void visible_main2()
        {
            Globals.but_click_ishod = 0;
            try
            {
                this.view_all_outbox_docTableAdapter.FillByUser(this.deloDataSet.View_all_outbox_doc, 34, Globals.id_user);
                viewalloutboxdocBindingSource.MoveLast();
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage3.Text = "Рассылка";
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                xtraTabPage7.Text = "Исходящие протокола";
                посмотретьToolStripMenuItem.Visible = false;
                VhodTabControl1.SelectedTabPage = xtraTabPage7;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                this.Enabled = true;

            }
            catch { }
        }
        public void visible_main_raport()
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Рапорта";
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 13);
                viewallvnutrdocBindingSource.MoveLast();
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = true;
                посмотретьToolStripMenuItem.Visible = true;
                печатьToolStripMenuItem.Visible = false;
                // viewallvnutrdocBindingSource.MoveLast();
                this.Enabled = true;
            }
            catch { }
        }
        public void visible_main_prikazy()
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Приказы";
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 25);
                viewallvnutrdocBindingSource.MoveLast();
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
            
                закрытьРапортToolStripMenuItem.Visible = true;
                посмотретьToolStripMenuItem.Visible = true;
                this.Enabled = true;
               
            }
            catch { }

        }
        public void visible_main_ukazy()
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Указания";
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 16);
                viewallvnutrdocBindingSource.MoveLast();
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = true;
                
                посмотретьToolStripMenuItem.Visible = true;
                this.Enabled = true;
            }
            catch { }
        }
        public void visible_main_akty()
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Акты ";
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 18);
                viewallvnutrdocBindingSource.MoveLast();
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = true;
                посмотретьToolStripMenuItem.Visible = true;
                печатьToolStripMenuItem.Visible = false;
                this.Enabled = true;
            }
            catch { }

        }
        public void visible_main_kom()
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Журнал регистрации командировочных удостоверений";
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 17);
                viewallvnutrdocBindingSource.MoveLast();
                регистрацияКомандирудостовToolStripMenuItem.Visible = true;
                закрытьРапортToolStripMenuItem.Visible = true;
                посмотретьToolStripMenuItem.Visible = true;
                печатьToolStripMenuItem.Visible = false;
                this.kom_udostovTableAdapter.Fill(this.deloDataSet.kom_udostov, Globals.id_doc);
                this.Enabled = true;
            }
            catch { }
        }
        public void visible_main_post()
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage8.PageVisible = true;
                xtraTabPage6.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage8.Text = "Договора о поставках";
                VhodTabControl1.SelectedTabPage = xtraTabPage8;
                добавитьДопсоглашенияToolStripMenuItem.Visible = true;
                this.view_all_dog_postavkeTableAdapter.Fill(this.deloDataSet.View_all_dog_postavke);
                viewalldogpostavkeBindingSource.MoveLast();
                //this.sC488TableAdapter.Fill(this.dataSet2.SC488);
                this._Reference71TableAdapter.Fill(this.iFRSforSeverelectroDataSet._Reference71);
                this.spr_orgTableAdapter.Fill_pos(this.deloDataSet.spr_org);
                this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
                this.users_programmTableAdapter.Fill_rukovod(this.deloDataSet.users_programm);
                печатьToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                
                посмотретьToolStripMenuItem.Visible = false;
                this.Enabled = true;
            }
            catch { }
        }
        public void visible_main_mat()
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage6.PageVisible = true;
                xtraTabPage8.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage6.Text = "Договора о материальной ответственности";
                VhodTabControl1.SelectedTabPage = xtraTabPage6;
                this.view_all_dog_mat_otvTableAdapter.Fill(this.deloDataSet.View_all_dog_mat_otv);
                viewalldogmatotvBindingSource.MoveLast();
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
                this.Enabled = true;
            }
            catch { }
        }
        public void visible_main_kadr_prikazy()
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Приказы ОУЧР";
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 26);
                viewallvnutrdocBindingSource.MoveLast();
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                this.Enabled = true;
            }
            catch { }
        }


        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 1;
            VhodTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabPage1.PageVisible = true;
            xtraTabPage3.PageVisible = true;
            xtraTabPage4.PageVisible = true;
            xtraTabPage5.PageVisible = true;
            xtraTabPage7.PageVisible = false;
            xtraTabPage2.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabPage13.PageVisible = false;
            xtraTabPage14.PageVisible = false;
            регистрацияКомандирудостовToolStripMenuItem.Visible = false;
            добавитьДопсоглашенияToolStripMenuItem.Visible = false;
            закрытьДокументToolStripMenuItem.Visible = true;
            печатьToolStripMenuItem.Visible = true;
            закрытьРапортToolStripMenuItem.Visible = false;
           
            посмотретьToolStripMenuItem.Visible = false;
            toolStripMenuItem2.Visible = true;
            toolStripMenuItem3.Visible = true;
            this.view_all_inbox_docTableAdapter.Fill(this.deloDataSet.View_all_inbox_doc);
            this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 1;
            try
            {
                this.rassylka_vizaTableAdapter.FillByStatus(this.deloDataSet.rassylka_viza, Globals.id_doc);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                VhodTabControl1.SelectedTabPage = xtraTabPage3;
                xtraTabPage1.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = true;
                посмотретьToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
            }
            catch { }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Enabled = false;
            Form kk = new Skaner();
            kk.ShowDialog();


        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Globals.form_ishod = 1;
            this.Enabled = false;
            Form kk = new Add_ishod_doc();
            kk.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Enabled = false;
            Form kk = new Add_vnutr_doc(0);
            kk.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }





        private void advBandedGridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                object ff = (View.GetRowCellValue(e.RowHandle, View.Columns["viza"]));
                if ((View.GetRowCellValue(e.RowHandle, View.Columns["viza"])) is DBNull || (View.GetRowCellValue(e.RowHandle, View.Columns["viza"])).ToString()=="")
                {
                    e.Appearance.BackColor = Color.FromArgb(0xCC, 0xCC, 0xFF);
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    if ((bool)(View.GetRowCellValue(e.RowHandle, View.Columns["for_info"])) != false)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else

                        if (((bool)View.GetRowCellValue(e.RowHandle, View.Columns["control"])) == true)
                        {
                            if (Convert.ToString(View.GetRowCellValue(e.RowHandle, View.Columns["otvet1"])).Trim().Length > 0)
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
                        else
                            if ((View.GetRowCellValue(e.RowHandle, View.Columns["v_rabote"])) != DBNull.Value)
                            {

                                if (Convert.ToString(View.GetRowCellValue(e.RowHandle, View.Columns["otvet1"])).Trim().Length > 0)
                                {
                                    e.Appearance.BackColor = Color.YellowGreen;
                                    e.Appearance.ForeColor = Color.Black;
                                }
                                else
                                {
                                    e.Appearance.BackColor = Color.LightSkyBlue;
                                    e.Appearance.ForeColor = Color.Black;
                                }


                            }
                }

            }
        }


        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // ToolStripItem l = e.ClickedItem;
            // if (l.Name == "toolStripMenuItem1")
            // {
            //this.Enabled = false;
            //Form kk = new Slujbi();
            //kk.ShowDialog();
            // }
        }



        private void viewallinboxdocBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            int ll = viewallinboxdocBindingSource.Position;
            try
            {
                Globals.id_doc = (int)((DataRowView)viewallinboxdocBindingSource.Current).Row["id"];
                Globals.id_vhod = Globals.id_doc;
                Globals.id_vhod_dubl= (string)((DataRowView)viewallinboxdocBindingSource.Current).Row["number"];
                //  var kk = ((DataRowView)viewallinboxdocBindingSource.Current).Row["otvet1"];
                if (((DataRowView)viewallinboxdocBindingSource.Current).Row["otvet1"] is DBNull)
                {
                    Globals.otvet1 = "";
                }
                else
                {
                    Globals.otvet1 = (string)((DataRowView)viewallinboxdocBindingSource.Current).Row["otvet1"];
                }
                if (((DataRowView)viewallinboxdocBindingSource.Current).Row["control"] is DBNull)
                { Globals.control = false; }
                else
                {
                    Globals.control = (bool)((DataRowView)viewallinboxdocBindingSource.Current).Row["control"];
                }
                if (((DataRowView)viewallinboxdocBindingSource.Current).Row["v_rabote"] is DBNull)
                { Globals.v_rab = false; }
                else
                {
                    Globals.v_rab = (bool)((DataRowView)viewallinboxdocBindingSource.Current).Row["v_rabote"];
                }
                if (((DataRowView)viewallinboxdocBindingSource.Current).Row["for_info"] is DBNull)
                { Globals.for_info = false; }
                else
                {
                    Globals.for_info = (bool)((DataRowView)viewallinboxdocBindingSource.Current).Row["for_info"];
                }
                if (((DataRowView)viewallinboxdocBindingSource.Current).Row["date_exec"] is DBNull)
                { Globals.date_otvet = null; }
                else
                {
                    Globals.date_otvet = (DateTime)((DataRowView)viewallinboxdocBindingSource.Current).Row["date_exec"];
                }

            }

            catch (Exception ex) { }

        }

        private void advBandedGridView2_RowClick(object sender, RowClickEventArgs e)
        {



        }

        private void advBandedGridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                if ((bool)(View.GetRowCellValue(e.RowHandle, View.Columns["svod"])) != false)
                {
                    e.Appearance.BackColor = Color.Pink;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {

                    //if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["status"])) != "")
                    //{
                    //    e.Appearance.BackColor = Color.YellowGreen;
                    //    e.Appearance.ForeColor = Color.Black;
                    //}

                }

            }

        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                byte[] b1 = ((byte[])((DataRowView)(otvetBindingSource.Current)).Row["prikr_file"]);
                string exens4grid = (string)((DataRowView)(otvetBindingSource.Current)).Row["name_file"];
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

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 1;
            try
            {
                this.view_all_inbox_docTableAdapter.FillByInfo(this.deloDataSet.View_all_inbox_doc, Globals.id_user);
                VhodTabControl1.SelectedTabPage = xtraTabPage1;
                xtraTabPage1.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = true;
                печатьToolStripMenuItem.Visible = true;
                закрытьРапортToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                посмотретьToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = true;
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
            }
            catch { }

        }

        private void navBarItem2_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 1;
            try
            {
                this.view_all_inbox_docTableAdapter.Fill_by_user(this.deloDataSet.View_all_inbox_doc, Globals.id_user);
                VhodTabControl1.SelectedTabPage = xtraTabPage1;
                xtraTabPage1.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = true;
                печатьToolStripMenuItem.Visible = true;
                toolStripMenuItem2.Visible = true;
                закрытьРапортToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = true;
                посмотретьToolStripMenuItem.Visible = false;
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
            }
            catch { }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 1;
            try
            {
                this.view_all_inbox_docTableAdapter.FillByControl(this.deloDataSet.View_all_inbox_doc, Globals.id_user);
                VhodTabControl1.SelectedTabPage = xtraTabPage1;
                xtraTabPage1.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = true;
                печатьToolStripMenuItem.Visible = true;
                закрытьРапортToolStripMenuItem.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
            }
            catch { }
        }

        private void navBarGroup2_ItemChanged(object sender, EventArgs e)
        {


        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_ishod = 15;
            Globals.but_click_file_insert = 2;
            try
            {
                this.view_all_outbox_docTableAdapter.Fill(this.deloDataSet.View_all_outbox_doc,15);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage3.Text = "Рассылка";
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                xtraTabPage7.Text = "Исходящие документы";
                VhodTabControl1.SelectedTabPage = xtraTabPage7;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
                посмотретьToolStripMenuItem.Visible = false;
            }
            catch { }
        }

        private void advBandedGridView3_RowClick(object sender, RowClickEventArgs e)
        {
            
        }

        private void viewalloutboxdocBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_ishod = 15;
            Globals.but_click_file_insert = 2;
            try
            {
                this.view_all_outbox_docTableAdapter.FillByUser(this.deloDataSet.View_all_outbox_doc, 15, Globals.id_user);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;

                xtraTabPage3.PageVisible = true;
                xtraTabPage3.Text = "Рассылка";
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                xtraTabPage7.Text = "Исходящие документы";
                VhodTabControl1.SelectedTabPage = xtraTabPage7;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
                посмотретьToolStripMenuItem.Visible = false;
            }
            catch { }
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 4;
            Globals.click_menu = 13;
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Рапорта";
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
                //  this.viewallvnutrdocBindingSource.CurrentItemChanged -= new System.EventHandler(this.viewallvnutrdocBindingSource_CurrentItemChanged);
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 13);
                //  this.viewallvnutrdocBindingSource.CurrentItemChanged += new System.EventHandler(this.viewallvnutrdocBindingSource_CurrentItemChanged);
                viewallvnutrdocBindingSource.MoveLast();
            }
            catch (Exception ex) { }
        }
        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 5;
            Globals.click_menu = 25;
            try
            {

                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;

                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Приказы";
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = true;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
                закрытьРапортToolStripMenuItem.Visible = false;
               
                // this.viewallvnutrdocBindingSource.CurrentItemChanged -= new System.EventHandler(this.viewallvnutrdocBindingSource_CurrentItemChanged);
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 25);
                // this.viewallvnutrdocBindingSource.CurrentItemChanged += new System.EventHandler(this.viewallvnutrdocBindingSource_CurrentItemChanged);
                viewallvnutrdocBindingSource.MoveLast();
            }
            catch (Exception ex) { }
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 6;
            Globals.click_menu = 16;
            try
            {

                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Указания";
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 16);
                viewallvnutrdocBindingSource.MoveLast();
            }
            catch { }
        }


        private void viewallvnutrdocBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Командировочные удостоверения";
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                печатьToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 17);
            }
            catch { }
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert =7;
            Globals.click_menu = 18;
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Акты";
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 18);
                viewallvnutrdocBindingSource.MoveLast();
            }
            catch { }
        }

        private void ах_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            Globals.but_click_file_insert = 10;
            try
            {
               
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                 xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage8.PageVisible = true;
                xtraTabPage6.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage8.Text = "Договора о поставках";
                VhodTabControl1.SelectedTabPage = xtraTabPage8;
                // repositoryItemGridLookUpEdit2.Buttons.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("kind1_code_mat"));
                // myLookup1.Properties.Columns["kind1_code_mat"].Caption = "Код";
                this.view_all_dog_postavkeTableAdapter.Fill(this.deloDataSet.View_all_dog_postavke);
               this._Reference71TableAdapter.Fill(this.iFRSforSeverelectroDataSet._Reference71);
              // this.sC488TableAdapter.Fill(this.dataSet2.SC488);
                this.spr_orgTableAdapter.Fill_pos(this.deloDataSet.spr_org);
                this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
                this.users_programmTableAdapter.Fill_rukovod(this.deloDataSet.users_programm);
                добавитьДопсоглашенияToolStripMenuItem.Visible = true;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
            }
            catch { }

        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 11;
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage6.PageVisible = true;
                xtraTabPage8.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage6.Text = "Договора о материальной ответственности";
                VhodTabControl1.SelectedTabPage = xtraTabPage6;
                this.view_all_dog_mat_otvTableAdapter.Fill(this.deloDataSet.View_all_dog_mat_otv);
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                посмотретьToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = true;
            }
            catch { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime s = Convert.ToDateTime(dateEdit1.Text);
            DateTime d = Convert.ToDateTime(dateEdit2.Text);
            this.view_all_dog_mat_otvTableAdapter.FillByDate(this.deloDataSet.View_all_dog_mat_otv, s, d);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dateEdit1.Text = "";
            dateEdit2.Text = "";
            this.view_all_dog_mat_otvTableAdapter.Fill(this.deloDataSet.View_all_dog_mat_otv);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DateTime s = Convert.ToDateTime(dateEdit4.Text);
            DateTime d = Convert.ToDateTime(dateEdit3.Text);
            this.view_all_dog_postavkeTableAdapter.FillByDate(this.deloDataSet.View_all_dog_postavke, s, d);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.view_all_dog_postavkeTableAdapter.Fill(this.deloDataSet.View_all_dog_postavke);
            dateEdit3.Text = "";
            dateEdit4.Text = "";
        }

        private void viewalldogmatotvBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_doc = (int)((DataRowView)viewalldogmatotvBindingSource.Current).Row["id"];

            }
            catch (Exception ex) { }

        }

        private void viewalldogpostavkeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_doc = (int)((DataRowView)viewalldogpostavkeBindingSource.Current).Row["id"];
                Globals.name_dog_post = (string)((DataRowView)viewalldogpostavkeBindingSource.Current).Row["number"];
                this.dop_soglTableAdapter.Fill(this.deloDataSet.dop_sogl, Globals.id_doc);

            }
            catch (Exception ex) { }
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage3.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage9.PageVisible = true;
                xtraTabPage10.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                this.spr_doljnosteiTableAdapter.Fill(this.deloDataSet.spr_doljnostei);
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
            }
            catch { }
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage3.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = true;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
            }
            catch { }

        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage3.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = true;
                xtraTabPage12.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                this.spr_org_rukTableAdapter.Fill(this.deloDataSet.spr_org_ruk);
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
            }
            catch { }

        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage3.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = true;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                печатьToolStripMenuItem.Visible = false;
                this.spr_slujbiTableAdapter.FillBySlujby(this.deloDataSet.spr_slujbi); регистрацияКомандирудостовToolStripMenuItem.Visible = false;
            }

            catch { }

        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            xtraTabPage1.PageVisible = false;
            xtraTabPage2.PageVisible = false;
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage7.PageVisible = false;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabPage13.PageVisible = true;
            xtraTabPage14.PageVisible = false;
            печатьToolStripMenuItem.Visible = false;
        }



        private void gridView5_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            simpleButton6_Click(sender, e);


        }



        private void gridControl9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string doljnost = gridView5.FindFilterText;
            this.spr_doljnosteiTableAdapter.InsertQuery(doljnost);
            this.spr_doljnosteiTableAdapter.Fill(this.deloDataSet.spr_doljnostei);

        }

        private void sprdoljnosteiBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_dolj = (int)((DataRowView)sprdoljnosteiBindingSource.Current).Row["id_doljnosti"];
                Globals.name_dolj = (string)((DataRowView)sprdoljnosteiBindingSource.Current).Row["nazvanie_dolj"];

            }
            catch (Exception ex) { }

        }



        public void simpleButton6_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView5.FocusedRowHandle;
            string dd = (string)gridView5.GetRowCellValue(rowHandle, "nazvanie_dolj");
            this.spr_doljnosteiTableAdapter.UpdateQuery(dd, Globals.id_dolj);
            this.spr_doljnosteiTableAdapter.Fill(this.deloDataSet.spr_doljnostei);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            this.spr_doljnosteiTableAdapter.UpdateDel(1, Globals.id_dolj);
            this.spr_doljnosteiTableAdapter.Fill(this.deloDataSet.spr_doljnostei);

        }

        private void gridView6_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            simpleButton10_Click(sender, e);
        }

        private void sprorgBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_org = (int)((DataRowView)sprorgBindingSource.Current).Row["id"];

            }
            catch (Exception ex) { }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView6.FocusedRowHandle;
            string name_org = (string)gridView6.GetRowCellValue(rowHandle, "name_org");
            int post = (int)gridView6.GetRowCellValue(rowHandle, "post");
            this.spr_orgTableAdapter.UpdateQuery(name_org, post, Globals.id_org);
            this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            this.spr_orgTableAdapter.UpdateDel(1, Globals.id_org);
            this.spr_orgTableAdapter.FillBy(this.deloDataSet.spr_org);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (gridView6.FindFilterText != "")
            {
                string name_org = gridView6.FindFilterText;
                this.spr_orgTableAdapter.InsertQuery(name_org, null);
                //textEdit2.Text = "";
                this.spr_orgTableAdapter.FillBy(this.deloDataSet.spr_org);
            }
            else { MessageBox.Show("Введите название организации"); }
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView7.FocusedRowHandle;
            string fio = (string)gridView7.GetRowCellValue(rowHandle, "fio");
            string dolj = (string)gridView7.GetRowCellValue(rowHandle, "doljn");
            this.spr_org_rukTableAdapter.UpdateQuery(fio, dolj, Globals.id_org_ruk);
            this.spr_org_rukTableAdapter.Fill(this.deloDataSet.spr_org_ruk);
        }

        private void sprorgrukBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_org_ruk = (int)((DataRowView)sprorgrukBindingSource.Current).Row["id"];

            }
            catch (Exception ex) { }
        }



        private void simpleButton11_Click(object sender, EventArgs e)
        {
            string fio = gridView7.FindFilterText;
            string dolj = textEdit1.Text;
            this.spr_org_rukTableAdapter.InsertQuery(fio, dolj);
            this.spr_org_rukTableAdapter.Fill(this.deloDataSet.spr_org_ruk);
            textEdit1.Text = "";
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            this.spr_org_rukTableAdapter.UpdateDel(1, Globals.id_org_ruk);
            this.spr_org_rukTableAdapter.Fill(this.deloDataSet.spr_org_ruk);

        }

        private void gridView7_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            simpleButton13_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ofdInput.ShowDialog();
            if(Globals.but_click_file_insert==1)
            { 
             Globals.en_delegate();
            }
            if (Globals.but_click_file_insert == 2)
            {
                Globals.en_delegate1();
            }
            if (Globals.but_click_file_insert == 3)
            {
                Globals.en_delegate2();
            }
            if (Globals.but_click_file_insert == 4)
            {
                Globals.en_delegate_raport();
            }
            if (Globals.but_click_file_insert == 5)
            {
                Globals.en_delegate_prikazy();
            }
            if (Globals.but_click_file_insert == 6)
            {
                Globals.en_delegate_ukazy();
            }
            if (Globals.but_click_file_insert == 7)
            {
                Globals.en_delegate_akty();
            }
            if (Globals.but_click_file_insert == 8)
            {
                Globals.en_delegate_kadr_prikazy();
            }
            if (Globals.but_click_file_insert == 9)
            {
                Globals.en_delegate_kom();
            }
            if (Globals.but_click_file_insert == 10)
            {
                Globals.en_delegate_dog_post();
            }
            if (Globals.but_click_file_insert == 11)
            {
                Globals.en_delegate_dog_mat();
            }
            if (Globals.but_click_file_insert == 12)
            {
                Globals.en_delegate_dog_agent();
            }



        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form kk = new MainFrame();
            kk.ShowDialog();

            if (Globals.but_click_file_insert == 1)
            {
                Globals.en_delegate();
            }
            if (Globals.but_click_file_insert == 2)
            {
                Globals.en_delegate1();
            }
            if (Globals.but_click_file_insert == 3)
            {
                Globals.en_delegate2();
            }
            if (Globals.but_click_file_insert == 4)
            {
                Globals.en_delegate_raport();
            }
            if (Globals.but_click_file_insert == 5)
            {
                Globals.en_delegate_prikazy();
            }
            if (Globals.but_click_file_insert == 6)
            {
                Globals.en_delegate_ukazy();
            }
            if (Globals.but_click_file_insert == 7)
            {
                Globals.en_delegate_akty();
            }
            if (Globals.but_click_file_insert == 8)
            {
                Globals.en_delegate_kadr_prikazy();
            }
            if (Globals.but_click_file_insert == 9)
            {
                Globals.en_delegate_kom();
            }
            if (Globals.but_click_file_insert == 10)
            {
                Globals.en_delegate_dog_post();
            }
            if (Globals.but_click_file_insert == 11)
            {
                Globals.en_delegate_dog_mat();
            }
            if (Globals.but_click_file_insert == 12)
            {
                Globals.en_delegate_dog_agent();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.doc_prikrep_fileTableAdapter.FillByid_doc(this.deloDataSet.doc_prikrep_file, Globals.id_doc);
            if (docprikrepfileBindingSource.Count > 0)
            {
                Form kk = new Slujbi(0);
                kk.ShowDialog();
                //if (Globals.but_click_file_insert == 1)
                //{
                //    Globals.en_delegate();
                //}
                //if (Globals.but_click_file_insert == 2)
                //{
                //    Globals.en_delegate1();
                //}
                //if (Globals.but_click_file_insert == 3)
                //{
                //    Globals.en_delegate2();
                //}
                //if (Globals.but_click_file_insert == 4)
                //{
                //    Globals.en_delegate_raport();
                //}
                //if (Globals.but_click_file_insert == 5)
                //{
                //    Globals.en_delegate_prikazy();
                //}
                //if (Globals.but_click_file_insert == 6)
                //{
                //    Globals.en_delegate_ukazy();
                //}
                //if (Globals.but_click_file_insert == 7)
                //{
                //    Globals.en_delegate_akty();
                //}
                //if (Globals.but_click_file_insert == 8)
                //{
                //    Globals.en_delegate_kadr_prikazy();
                //}
                //if (Globals.but_click_file_insert == 9)
                //{
                //    Globals.en_delegate_kom();
                //}
                //if (Globals.but_click_file_insert == 10)
                //{
                //    Globals.en_delegate_dog_post();
                //}
                //if (Globals.but_click_file_insert == 11)
                //{
                //    Globals.en_delegate_dog_mat();
                //}
                //if (Globals.but_click_file_insert == 12)
                //{
                //    Globals.en_delegate_dog_agent();
                //}
            }
            else
            { MessageBox.Show("У этого документа нет файлов, невозможно переслать!!! Документ должен содержать хотя бы 1 файл!!!"); }


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

        private void VhodTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            { if (VhodTabControl1.SelectedTabPage == xtraTabPage5)
                { this.doc_prikrep_fileTableAdapter.FillByid_doc(this.deloDataSet.doc_prikrep_file, Globals.id_doc); }
                if (VhodTabControl1.SelectedTabPage == xtraTabPage3)
                { this.rassylka_vizaTableAdapter.Fill(this.deloDataSet.rassylka_viza, Globals.id_doc); }
                if (VhodTabControl1.SelectedTabPage == xtraTabPage4)
                {
                    this.spr_slujbiTableAdapter.FillByAll(this.deloDataSet.spr_slujbi);
                    this.otvetTableAdapter.Fill(this.deloDataSet.otvet, Globals.id_doc);
                    this.otv_prikrep_fileTableAdapter.Fill(this.deloDataSet.otv_prikrep_file);
                }
               
            }
            catch { }

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

        private void gridView9_RowClick(object sender, RowClickEventArgs e)
        {

        }



        private void otvetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_otv = (int)((DataRowView)otvetBindingSource.Current).Row["id_otvet"];
                this.otv_prikrep_fileTableAdapter.FillByID(this.deloDataSet.otv_prikrep_file, Globals.id_otv);
            }
            catch (Exception ex) { }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form kk = new MainFrame();
            kk.ShowDialog();
            Globals.en_delegate();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ofdInput.ShowDialog();
           // Globals.en_delegate();
        }

        private void advBandedGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                byte[] b1 = ((byte[])((DataRowView)(rassylka_vizaBindingSource.Current)).Row["prikr_file"]);
                string exens4grid = (string)((DataRowView)(rassylka_vizaBindingSource.Current)).Row["name_file"];
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
            this.rassylka_vizaTableAdapter.Fill(this.deloDataSet.rassylka_viza, Globals.id_doc);
        }

        private void tileNavPane1_Click(object sender, EventArgs e)
        {

        }

        private void закрытьДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.form_ishod = 2;
            if (Globals.control != true)
            { MessageBox.Show("Этот документ закрыть невозможно!!! Он к сведению, а не на контроле"); return; }
            else
            {


                if (Globals.otvet1 != "")
                { MessageBox.Show("Этот документ уже закрыт!!!"); }
                else
                {
                    this.Enabled = false;
                    Form kk = new Add_ishod_doc();
                    kk.ShowDialog();
                }
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Enabled = false;
            Form kk = new Add_dogovor();
            kk.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Enabled = false;
            Form kk = new Add_post();
            kk.ShowDialog();
        }

        private void добавитьДопсоглашенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form kk = new dop_sogl();
            kk.ShowDialog();
        }

        private void регистрацияКомандирудостовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form kk = new add_kom_udost();
            kk.ShowDialog();
        }

        private void gridView11_DoubleClick(object sender, EventArgs e)
        {
            GridView gv = (GridView)advBandedGridView4.GetDetailView(advBandedGridView4.FocusedRowHandle, 0);
            Globals.id_kom = (int)gv.GetFocusedRowCellValue("id");

            //report.Parameters["Parameter2"].Value = Globals.date_prikaz;
            //report.Parameters["Parameter1"].Value = Globals.name_prikaz;
            //report.Parameters["parameter3"].Value = Globals.id_kom;
            XtraReport2 report = new XtraReport2();
            report.Parameters["parameter1"].Value = Globals.id_kom;
            report.Parameters["parameter3"].Value = Globals.date_prikaz;
            report.Parameters["parameter2"].Value = Globals.name_prikaz;
            report.RequestParameters = false;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.AutoShowParametersPanel = false;
            printTool.ShowPreviewDialog();
        }

        private void kom_udostovBindingSource_CurrentChanged(object sender, EventArgs e)
        {


        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

            try
            {
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

        private void gridView9_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                byte[] b1 = ((byte[])((DataRowView)(otvbindingSource.Current)).Row["prikr_file"]);
                string exens4grid = (string)((DataRowView)(otvbindingSource.Current)).Row["name_file"];
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

        private void advBandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var rowHandle = advBandedGridView1.FocusedRowHandle;
            int? id_org;
            int? id_org2;
            int? id_org3;
            int? id_org4;
            DateTime? srok;
            DateTime? date_exec;
            DateTime? date_reg;
            DateTime? date_prih;
            string num_p_doc;
            string ispolnitel2;
            string vozvrat;
            string srok_ispol;
            bool? control;
            string fax_electr;
            bool? jaloba; bool? v_rab;
            bool? for_info; string note; string about; string fio;
            string adres;
            string otvet;
            string dubl;
            if (advBandedGridView1.GetRowCellValue(rowHandle, "date_reg") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "date_reg") == "")
            { date_reg = null; }
            else
            {
                date_reg = (DateTime)advBandedGridView1.GetRowCellValue(rowHandle, "date_reg");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "date_exec") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "date_exec") == "" || advBandedGridView1.GetRowCellValue(rowHandle, "date_exec") == "01.01.0001 0:00:00")
            { date_exec = null; }
            else
            {
                date_exec = (DateTime)advBandedGridView1.GetRowCellValue(rowHandle, "date_exec");
                DateTime d = Convert.ToDateTime("01.01.0001 0:00:00");
                if (date_exec == d)
                { date_exec = null; }
                else { date_exec = (DateTime)advBandedGridView1.GetRowCellValue(rowHandle, "date_exec"); }
            }


            if (advBandedGridView1.GetRowCellValue(rowHandle, "num_pd") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "num_pd") == "")
            { num_p_doc = null; }
            else
            {
                num_p_doc = (string)advBandedGridView1.GetRowCellValue(rowHandle, "num_pd");
            }

            if (advBandedGridView1.GetRowCellValue(rowHandle, "date_pd") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "date_pd") == "" || advBandedGridView1.GetRowCellValue(rowHandle, "date_pd") == "01.01.0001 0:00:00")
            { date_prih = null; }
            else
            {
                date_prih = (DateTime)advBandedGridView1.GetRowCellValue(rowHandle, "date_pd");
                DateTime d=Convert.ToDateTime("01.01.0001 0:00:00");
                if (date_prih == d)
                { date_prih = null; }
                else { date_prih = (DateTime)advBandedGridView1.GetRowCellValue(rowHandle, "date_pd"); }
            }


            if (advBandedGridView1.GetRowCellValue(rowHandle, "control") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "control") == "")
            { control = null; }
            else
            {
                control = (bool)advBandedGridView1.GetRowCellValue(rowHandle, "control");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "jaloba") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "jaloba") == "")
            { jaloba = null; }
            else
            {
                jaloba = (bool)advBandedGridView1.GetRowCellValue(rowHandle, "jaloba");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "for_info") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "for_info") == "")
            { for_info = null; }
            else
            {
                for_info = (bool)advBandedGridView1.GetRowCellValue(rowHandle, "for_info");
            }

            if (advBandedGridView1.GetRowCellValue(rowHandle, "note") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "note") == "")
            { note = null; }
            else
            {
                note = (string)advBandedGridView1.GetRowCellValue(rowHandle, "note");
            }

            if (advBandedGridView1.GetRowCellValue(rowHandle, "about") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "about") == "")
            { about = null; }
            else
            {
                about = (string)advBandedGridView1.GetRowCellValue(rowHandle, "about");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "fio_org") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "fio_org") == "")
            { fio = null; }
            else
            {
                fio = (string)advBandedGridView1.GetRowCellValue(rowHandle, "fio_org");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "id_org") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "id_org") == "")
            { id_org = null; }
            else
            {

                id_org = Convert.ToInt32(advBandedGridView1.GetRowCellValue(rowHandle, "id_org"));
            }

            if (advBandedGridView1.GetRowCellValue(rowHandle, "id_org2") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "id_org2") == "")
            { id_org2 = null; }
            else
            {

                id_org2 = Convert.ToInt32(advBandedGridView1.GetRowCellValue(rowHandle, "id_org2"));
            }

            if (advBandedGridView1.GetRowCellValue(rowHandle, "id_org3") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "id_org3") == "")
            { id_org3 = null; }
            else
            {

                id_org3 = Convert.ToInt32(advBandedGridView1.GetRowCellValue(rowHandle, "id_org3"));
            }


            if (advBandedGridView1.GetRowCellValue(rowHandle, "id_org4") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "id_org4") == "")
            { id_org4 = null; }
            else
            {

                id_org4 = Convert.ToInt32(advBandedGridView1.GetRowCellValue(rowHandle, "id_org4"));
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "adres") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "adres") == "")
            { adres = null; }
            else
            {
                adres = (string)advBandedGridView1.GetRowCellValue(rowHandle, "adres");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "v_rabote") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "v_rabote") == "")
            { v_rab = null; }
            else
            {
                v_rab = (bool)advBandedGridView1.GetRowCellValue(rowHandle, "v_rabote");
            }
           // object dd = advBandedGridView1.GetRowCellValue(rowHandle, "srok");
            if (advBandedGridView1.GetRowCellValue(rowHandle, "srok") is DBNull)
            { srok = null; }  
            else
            {
                srok = (DateTime)advBandedGridView1.GetRowCellValue(rowHandle, "srok");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "otvet1") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "otvet1") == "")
            { otvet = null; }
            else
            {
                otvet = (string)advBandedGridView1.GetRowCellValue(rowHandle, "otvet1");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "ispolnitel2") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "ispolnitel2") == "")
            { ispolnitel2 = null; }
            else
            {
                ispolnitel2 = (string)advBandedGridView1.GetRowCellValue(rowHandle, "ispolnitel2");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "ispolnitel2") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "ispolnitel2") == "")
            { ispolnitel2 = null; }
            else
            {
                ispolnitel2 = (string)advBandedGridView1.GetRowCellValue(rowHandle, "ispolnitel2");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "fax_electr") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "fax_electr") == "")
            { fax_electr = null; }
            else
            {
                fax_electr = (string)advBandedGridView1.GetRowCellValue(rowHandle, "fax_electr");
            }

            if (advBandedGridView1.GetRowCellValue(rowHandle, "vozvrat") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "vozvrat") == "")
            { vozvrat = null; }
            else
            {
                vozvrat = (string)advBandedGridView1.GetRowCellValue(rowHandle, "vozvrat");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "srok_ispol") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "srok_ispol") == "")
            { srok_ispol = null; }
            else
            {
                srok_ispol = (string)advBandedGridView1.GetRowCellValue(rowHandle, "srok_ispol");
            }
            if (advBandedGridView1.GetRowCellValue(rowHandle, "dubl") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "dubl") == "")
            { dubl = null; }
            else
            {
                dubl = (string)advBandedGridView1.GetRowCellValue(rowHandle, "dubl");
            }
            view_all_inbox_docTableAdapter.UpdateQuery(date_reg, num_p_doc, date_prih, control, jaloba, for_info, note, about, fio, id_org, id_org2, id_org3, id_org4, adres, v_rab, srok,otvet,ispolnitel2,fax_electr,vozvrat,srok_ispol,dubl,date_exec,Globals.id_doc);
            //}

        }

        private void viewallvnutrdocBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {

                Globals.id_doc = Convert.ToInt32(((DataRowView)viewallvnutrdocBindingSource.Current).Row["id"]);
                this.kom_udostovTableAdapter.Fill(this.deloDataSet.kom_udostov, Globals.id_doc);
                Globals.name_prikaz = (string)((DataRowView)viewallvnutrdocBindingSource.Current).Row["number"];
                Globals.date_prikaz = (DateTime)((DataRowView)viewallvnutrdocBindingSource.Current).Row["date_reg"];
                if (((DataRowView)viewallvnutrdocBindingSource.Current).Row["otvet1"] is DBNull)
                {
                    Globals.otvet1 = "";
                }
                else
                {
                    Globals.otvet1 = (string)((DataRowView)viewallvnutrdocBindingSource.Current).Row["otvet1"];
                }
                if (((DataRowView)viewallvnutrdocBindingSource.Current).Row["date_exec"] is DBNull)
                { Globals.date_otvet = null; }
                else
                {
                    Globals.date_otvet = (DateTime)((DataRowView)viewallvnutrdocBindingSource.Current).Row["date_exec"];
                }
            }
            catch (Exception ex) { }
        }

        private void navBarItem9_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 4;
           Globals.click_menu = 13;
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Рапорта";
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                закрытьДокументToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = true;
                посмотретьToolStripMenuItem.Visible = true;
                //this.viewallvnutrdocBindingSource.CurrentItemChanged -= new System.EventHandler(this.viewallvnutrdocBindingSource_CurrentItemChanged);
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 13);
               // this.viewallvnutrdocBindingSource.CurrentItemChanged += new System.EventHandler(this.viewallvnutrdocBindingSource_CurrentItemChanged);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }



        private void simpleButton15_Click(object sender,EventArgs e)
        {
            GridView gv = (GridView)advBandedGridView4.GetDetailView(advBandedGridView4.FocusedRowHandle, 0);

            for (int i = 0; i <= gv.RowCount; i++)
            {
                var check = gv.GetRowCellValue(i, "del");
                if (Convert.ToString(check) != "") 
                {
                    if (Convert.ToBoolean(check) == true)
                    {
                        int id = Convert.ToInt32(gv.GetRowCellValue(i, "id"));
                        kom_udostovTableAdapter.DeleteQuery(id);

                    }
                }
            }
            this.kom_udostovTableAdapter.Fill(this.deloDataSet.kom_udostov, Globals.id_doc);
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            GridView gv = (GridView)gridView4.GetDetailView(gridView4.FocusedRowHandle, 0);

            for (int i = 0; i <= gv.RowCount; i++)
            {
                var check = gv.GetRowCellValue(i, "del");
                if (Convert.ToString(check) != "")
                {
                    if (Convert.ToBoolean(check) == true)
                    {
                        int id = Convert.ToInt32(gv.GetRowCellValue(i, "id"));
                        dop_soglTableAdapter.DeleteQuery(id);

                    }
                }
            }
            this.dop_soglTableAdapter.Fill(this.deloDataSet.dop_sogl, Globals.id_doc);
        }

        private void advBandedGridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var rowHandle = advBandedGridView4.FocusedRowHandle;


            DateTime? date_reg;
            DateTime? date_exec;
            string about;
            bool? control;
            string ispolnitel;
            string note;
            string otvet;
            string srok_ispol;
            string vozvrat;
            string num_pd;
            string ispolnitel2;
            string fax_electr;
            bool? for_info; int? otdel;
            if (advBandedGridView4.GetRowCellValue(rowHandle, "date_reg") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "date_reg") == "")
            { date_reg = null; }
            else
            {
                date_reg = (DateTime)advBandedGridView4.GetRowCellValue(rowHandle, "date_reg");
            }
            if (advBandedGridView4.GetRowCellValue(rowHandle, "about") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "about") == "")
            { about = null; }
            else
            {
                about = (string)advBandedGridView4.GetRowCellValue(rowHandle, "about");
            }
            if (advBandedGridView4.GetRowCellValue(rowHandle, "control") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "control") == "")
            { control = null; }
            else
            {
                control = (bool)advBandedGridView4.GetRowCellValue(rowHandle, "control");
            }

            if (advBandedGridView4.GetRowCellValue(rowHandle, "for_info") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "for_info") == "")
            { for_info = null; }
            else
            {
                for_info = (bool)advBandedGridView4.GetRowCellValue(rowHandle, "for_info");
            }

            if (advBandedGridView4.GetRowCellValue(rowHandle, "ispolnitel") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "ispolnitel") == "")
            { ispolnitel = null; }
            else
            {
                ispolnitel = (string)advBandedGridView4.GetRowCellValue(rowHandle, "ispolnitel");
            }
            if ((advBandedGridView4.GetRowCellValue(rowHandle, "otdel")).ToString() == null || advBandedGridView4.GetRowCellValue(rowHandle, "otdel") == " ")
            { otdel = null; }
            else
            {
                otdel = (int)advBandedGridView4.GetRowCellValue(rowHandle, "otdel");
            }

            if (advBandedGridView4.GetRowCellValue(rowHandle, "note") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "note") == "")
            { note = null; }
            else
            {
                note = (string)advBandedGridView4.GetRowCellValue(rowHandle, "note");
            }
            if (advBandedGridView4.GetRowCellValue(rowHandle, "num_pd") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "num_pd") == "")
            { num_pd = null; }
            else
            {
                num_pd = (string)advBandedGridView4.GetRowCellValue(rowHandle, "num_pd");
            }
            if (advBandedGridView4.GetRowCellValue(rowHandle, "ispolnitel2") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "ispolnitel2") == "")
            { ispolnitel2 = null; }
            else
            {
                ispolnitel2 = (string)advBandedGridView4.GetRowCellValue(rowHandle, "ispolnitel2");
            }
            if (advBandedGridView4.GetRowCellValue(rowHandle, "fax_electr") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "fax_electr") == "")
            { fax_electr = null; }
            else
            {
                fax_electr = (string)advBandedGridView4.GetRowCellValue(rowHandle, "fax_electr");
            }
            if (advBandedGridView4.GetRowCellValue(rowHandle, "vozvrat") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "vozvrat") == "")
            { vozvrat = null; }
            else
            {
                vozvrat = (string)advBandedGridView4.GetRowCellValue(rowHandle, "vozvrat");
            }
            if (advBandedGridView4.GetRowCellValue(rowHandle, "srok_ispol") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "srok_ispol") == "")
            { srok_ispol = null; }
            else
            {
                srok_ispol = (string)advBandedGridView4.GetRowCellValue(rowHandle, "srok_ispol");
            }
            if (advBandedGridView4.GetRowCellValue(rowHandle, "date_exec") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "date_exec") == "")
            { date_exec = null; }
            else
            {
                date_exec= (DateTime)advBandedGridView4.GetRowCellValue(rowHandle, "date_exec");
            }
            if (advBandedGridView4.GetRowCellValue(rowHandle, "otvet1") is DBNull || advBandedGridView4.GetRowCellValue(rowHandle, "otvet1") == "")
            { otvet = null; }
            else
            {
                otvet = (string)advBandedGridView4.GetRowCellValue(rowHandle, "otvet1");
            }
            view_all_vnutr_docTableAdapter.UpdateQuery(otdel, ispolnitel, about, for_info, control, date_reg, note,num_pd,ispolnitel2,fax_electr,vozvrat,srok_ispol, date_exec,otvet,Globals.id_doc);


        }

        private void рассылкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.doc_prikrep_fileTableAdapter.FillByid_doc(this.deloDataSet.doc_prikrep_file, Globals.id_doc);
            if (docprikrepfileBindingSource.Count > 0)
            {
                Form kk = new Slujbi(0);
                kk.ShowDialog();
                //Globals.en_delegate();
            }
            else
            { MessageBox.Show("У этого документа нет файлов, невозможно переслать!!! Документ должен содержать хотя бы 1 файл!!!"); }
        }

        private void закрытьПисьмоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.for_info == true || Globals.control == true)

            { MessageBox.Show("Этот документ закрыть невозможно!!! Он к сведению или на контроле!!! "); return; }
            else
            {


                if (Globals.otvet1 != "")
                { MessageBox.Show("Этот документ уже закрыт!!!"); }
                else
                {
                    this.Enabled = false;
                    Form kk = new zakryt_pismo();
                    kk.ShowDialog();
                }
            }
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {

            DateTime s = Convert.ToDateTime(dateEdit6.Text);
            DateTime d = Convert.ToDateTime(dateEdit5.Text);
            this.view_all_inbox_docTableAdapter.FillByDate(this.deloDataSet.View_all_inbox_doc, s, d);
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            this.view_all_inbox_docTableAdapter.Fill_by_user(this.deloDataSet.View_all_inbox_doc, Globals.id_user);
        }
        string obt;
        private void gridView4_RowStyle(object sender, RowStyleEventArgs e)
        {

         
            if (e.RowHandle >= 0)
            {
                if ((gridView4.GetRowCellValue(e.RowHandle, gridView4.Columns["adres_jal"])) is DBNull)
                { obt = ""; }


                else
                    if ((string)(gridView4.GetRowCellValue(e.RowHandle, gridView4.Columns["adres_jal"])) == "???")
                    {
                        obt = "1";
                    }
                    else
                    {
                        obt = "2";
                    }
            


            if ((gridView4.GetRowCellValue(e.RowHandle, gridView4.Columns["viza"])) is DBNull)
            {
                e.Appearance.BackColor = Color.FromArgb(0xCC, 0xCC, 0xFF);
                e.Appearance.ForeColor = Color.Black;
            }
            else
            {

                if (obt == "1")
                {
                    e.Appearance.BackColor = Color.FromArgb(0xFF, 0x99, 0xCC);
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }}






        private void gridControl5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            DateTime s = Convert.ToDateTime(dateEdit8.Text);
            DateTime d = Convert.ToDateTime(dateEdit7.Text);
            if(  Globals.but_click_ishod ==15)
            { 
            this.view_all_outbox_docTableAdapter.FillBydate(this.deloDataSet.View_all_outbox_doc,15, Globals.id_user, s, d);}
            if (Globals.but_click_ishod == 34)
            {
                this.view_all_outbox_docTableAdapter.FillBydate(this.deloDataSet.View_all_outbox_doc, 34, Globals.id_user, s, d);
            }
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            if (Globals.but_click_ishod == 15)
            { 
            this.view_all_outbox_docTableAdapter.FillByUser(this.deloDataSet.View_all_outbox_doc,15, Globals.id_user);}
            if (Globals.but_click_ishod == 34)
            {
                this.view_all_outbox_docTableAdapter.FillByUser(this.deloDataSet.View_all_outbox_doc, 15, Globals.id_user);
            }

        }

        private void navBarItem21_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraReport4 report = new XtraReport4();
           ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
           // XtraForm ss = new otchet_dlya_merii();
           // ss.Show();
        }

        private void navBarItem24_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 8;
            Globals.click_menu = 26;
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Приказы ОУЧР";
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 26);
                viewallvnutrdocBindingSource.MoveLast();
            }
            catch { }
        }

        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraReport3 report = new XtraReport3();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();

        }

        private void navBarItem23_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();

        }

        private void advBandedGridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            string fio;
            string note; string about;
            int? id_org;
            int? id_org2;
            int? otdel;
            
            string srok_ispol;
            string ispolnitel2;
            string fax_electr;
            int? ruk; string adres; string ispoln; string otvet;
            var rowHandle = advBandedGridView3.FocusedRowHandle;
            if (advBandedGridView3.GetRowCellValue(rowHandle, "note") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "note") == "")
            { note = ""; }
            else { note = (string)advBandedGridView3.GetRowCellValue(rowHandle, "note"); }

            if (advBandedGridView3.GetRowCellValue(rowHandle, "about") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "about") == "")
            { about = ""; }
            else { about = (string)advBandedGridView3.GetRowCellValue(rowHandle, "about"); }

            if (advBandedGridView3.GetRowCellValue(rowHandle, "fio_org") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "fio_org") == "")
            { fio = ""; }
            else { fio = (string)advBandedGridView3.GetRowCellValue(rowHandle, "fio_org"); }
            if (advBandedGridView3.GetRowCellValue(rowHandle, "id_org") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "id_org") == "")
            { id_org = null; }
            else
            {

                id_org = Convert.ToInt32(advBandedGridView3.GetRowCellValue(rowHandle, "id_org"));
            }

            if (advBandedGridView3.GetRowCellValue(rowHandle, "id_org2") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "id_org2") == "")
            { id_org2 = null; }
            else
            {

                id_org2 = Convert.ToInt32(advBandedGridView3.GetRowCellValue(rowHandle, "id_org2"));
            }
            if (advBandedGridView3.GetRowCellValue(rowHandle, "otdel") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "otdel") == "")
            { otdel = null; }
            else
            {

                otdel = Convert.ToInt32(advBandedGridView3.GetRowCellValue(rowHandle, "otdel"));
            }
            if (advBandedGridView3.GetRowCellValue(rowHandle, "rukovod") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "rukovod") == "")
            { ruk = null; }
            else
            {

                ruk = Convert.ToInt32(advBandedGridView3.GetRowCellValue(rowHandle, "rukovod"));
            }


            if (advBandedGridView3.GetRowCellValue(rowHandle, "adres_jal") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "adres_jal") == "")
            { adres = ""; }
            else { adres = (string)advBandedGridView3.GetRowCellValue(rowHandle, "adres_jal"); }


            if (advBandedGridView3.GetRowCellValue(rowHandle, "ispolnitel") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "ispolnitel") == "")
            { ispoln = ""; }
            else { ispoln = (string)advBandedGridView3.GetRowCellValue(rowHandle, "ispolnitel"); }

            if (advBandedGridView3.GetRowCellValue(rowHandle, "otvet") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "otvet") == "")
            { otvet = ""; }
            else { otvet = (string)advBandedGridView3.GetRowCellValue(rowHandle, "otvet"); }
            if (advBandedGridView3.GetRowCellValue(rowHandle, "ispolnitel2") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "ispolnitel2") == "")
            { ispolnitel2 = ""; }
            else { ispolnitel2 = (string)advBandedGridView3.GetRowCellValue(rowHandle, "ispolnitel2"); }
            if (advBandedGridView3.GetRowCellValue(rowHandle, "fax_electr") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "fax_electr") == "")
            { fax_electr = ""; }
            else { fax_electr = (string)advBandedGridView3.GetRowCellValue(rowHandle, "fax_electr"); }
            
            if (advBandedGridView3.GetRowCellValue(rowHandle, "srok_ispol") is DBNull || advBandedGridView3.GetRowCellValue(rowHandle, "srok_ispol") == "")
            { srok_ispol = ""; }
            else { srok_ispol = (string)advBandedGridView3.GetRowCellValue(rowHandle, "srok_ispol"); }
            view_all_outbox_docTableAdapter.UpdateQuery12(id_org, id_org2, otvet, fio, ruk, otdel, ispoln, about, adres, note, ispolnitel2, fax_electr, srok_ispol,Globals.id_doc);

        }

        private void advBandedGridView3_RowStyle(object sender, RowStyleEventArgs e)
        {
            string f;
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if ((View.GetRowCellValue(e.RowHandle, View.Columns["otvet"])) is DBNull || (View.GetRowCellValue(e.RowHandle, View.Columns["otvet"])) == "")
                { f = "1"; }
                else { f = "2"; }
                if (f == "2")
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    e.Appearance.BackColor = Color.SeaShell;
                    e.Appearance.ForeColor = Color.Black;
                }
            }


        }

        private void gridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DateTime? date_reg;
            string id_org;
            decimal? summa;
            string valuta;
            string about;
            int? rukovod;
            int? otdel;
            string ispolnitel;
            string doljnost_ispol;
            string chast_liso;
            DateTime? date_exec;
            DateTime? date_pd;

            var rowHandle = gridView4.FocusedRowHandle;
            if (gridView4.GetRowCellValue(rowHandle, "date_reg") is DBNull || gridView4.GetRowCellValue(rowHandle, "date_reg") == "")
            { date_reg = null; }
            else { date_reg = (DateTime)gridView4.GetRowCellValue(rowHandle, "date_reg"); }

            if (gridView4.GetRowCellValue(rowHandle, "num_pd") is DBNull || gridView4.GetRowCellValue(rowHandle, "num_pd") == "")
            { id_org = null; }
            else
            {

                id_org = (string)(gridView4.GetRowCellValue(rowHandle, "num_pd"));
            }

            if (gridView4.GetRowCellValue(rowHandle, "summa") is DBNull || gridView4.GetRowCellValue(rowHandle, "summa") == "")
            { summa = null; }
            else { summa = (decimal)gridView4.GetRowCellValue(rowHandle, "summa"); }


            if (gridView4.GetRowCellValue(rowHandle, "valuta") is DBNull || gridView4.GetRowCellValue(rowHandle, "valuta") == "")
            { valuta = ""; }
            else { valuta = (string)gridView4.GetRowCellValue(rowHandle, "valuta"); }



            if (gridView4.GetRowCellValue(rowHandle, "about") is DBNull || gridView4.GetRowCellValue(rowHandle, "about") == "")
            { about = ""; }
            else { about = (string)gridView4.GetRowCellValue(rowHandle, "about"); }



            if (gridView4.GetRowCellValue(rowHandle, "rukovod") is DBNull || gridView4.GetRowCellValue(rowHandle, "rukovod") == "")
            { rukovod = null; }
            else
            {

                rukovod = Convert.ToInt32(gridView4.GetRowCellValue(rowHandle, "rukovod"));
            }

            if (gridView4.GetRowCellValue(rowHandle, "otdel") is DBNull || gridView4.GetRowCellValue(rowHandle, "otdel") == "")
            { otdel = null; }
            else
            {

                otdel = Convert.ToInt32(gridView4.GetRowCellValue(rowHandle, "otdel"));
            }


            if (gridView4.GetRowCellValue(rowHandle, "ispolnitel") is DBNull || gridView4.GetRowCellValue(rowHandle, "ispolnitel") == "")
            { ispolnitel = ""; }
            else { ispolnitel = (string)gridView4.GetRowCellValue(rowHandle, "ispolnitel"); }

            if (gridView4.GetRowCellValue(rowHandle, "doljnost_ispol") is DBNull || gridView4.GetRowCellValue(rowHandle, "doljnost_ispol") == "")
            { doljnost_ispol = ""; }
            else { doljnost_ispol = (string)gridView4.GetRowCellValue(rowHandle, "doljnost_ispol"); }



            if (gridView4.GetRowCellValue(rowHandle, "adres_jal") is DBNull || gridView4.GetRowCellValue(rowHandle, "adres_jal") == "")
            { chast_liso = ""; }
            else { chast_liso = (string)gridView4.GetRowCellValue(rowHandle, "adres_jal"); }

            if (gridView4.GetRowCellValue(rowHandle, "date_exec") is DBNull || gridView4.GetRowCellValue(rowHandle, "date_exec") == "")
            { date_exec = null; }
            else { date_exec = (DateTime)gridView4.GetRowCellValue(rowHandle, "date_exec"); }

            if (gridView4.GetRowCellValue(rowHandle, "date_pd") is DBNull || gridView4.GetRowCellValue(rowHandle, "date_pd") == "")
            { date_pd = null; }
            else { date_pd = (DateTime)gridView4.GetRowCellValue(rowHandle, "date_pd"); }



            view_all_dog_postavkeTableAdapter.UpdateQuery(date_reg, id_org, summa, valuta, about, rukovod, otdel, ispolnitel, doljnost_ispol, chast_liso, date_exec, date_pd, Globals.id_doc);


        }

        private void отправитьПисьмоЧерезemailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            Form kk = new mail_send();
            kk.ShowDialog();

        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить документ? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var rowHandle = gridView2.FocusedRowHandle;

                for (int i = 0; i <= gridView2.RowCount; i++)
                {
                    var check = gridView2.GetRowCellValue(i, "vrem_check");
                    if (Convert.ToString(check) != "")
                    {
                        if (Convert.ToBoolean(check) == true)
                        {
                            int id = Convert.ToInt32(gridView2.GetRowCellValue(i, "id"));
                            doc_prikrep_fileTableAdapter.DeleteQuery(id);

                        }
                    }
                }
                this.doc_prikrep_fileTableAdapter.FillByid_doc(deloDataSet.doc_prikrep_file, Globals.id_doc);
            }
            else { return; }
        }

        private void gridControl4_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }



        private void barButtonItem21_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Enabled = false;
            Form kk = new add_agent_dog();
            kk.ShowDialog();
        }

        private void navBarItem25_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 12;
            try
            {

                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = true;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage4.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                VhodTabControl1.SelectedTabPage = xtraTabPage14;
                this.view_all_agent_dogTableAdapter1.Fill(this.deloDataSet.View_all_agent_dog);
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;


            }
            catch { }
        }

        private void viewallagentdogBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_doc = (int)((DataRowView)viewallagentdogBindingSource.Current).Row["id"];

            }
            catch (Exception ex) { }
        }

        private void gridControl13_Click(object sender, EventArgs e)
        {

        }

        private void рассылкаЧерезEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kk = new mail_send();
            kk.ShowDialog();
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

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl6);
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl7);
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl8);
        }

        private void pictureEdit5_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl5);
        }

        private void pictureEdit6_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl13);
        }

        private void gridView3_RowStyle(object sender, RowStyleEventArgs e)
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
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }

        private void advBandedGridView5_RowStyle(object sender, RowStyleEventArgs e)
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
                    e.Appearance.BackColor = Color.White;
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            if (Globals.click_menu == 26)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 26);
                viewallvnutrdocBindingSource.MoveLast();
            }
            if (Globals.click_menu == 18)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 18);
                viewallvnutrdocBindingSource.MoveLast();
            }
            if (Globals.click_menu == 16)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 16);
                viewallvnutrdocBindingSource.MoveLast();
            }
            if (Globals.click_menu == 25)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 25);
                viewallvnutrdocBindingSource.MoveLast();
            }
            if (Globals.click_menu == 13)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 13);
                viewallvnutrdocBindingSource.MoveLast();
            }
            if (Globals.click_menu == 17)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 17);
                viewallvnutrdocBindingSource.MoveLast();
            }
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            string s = dateEdit10.Text;
            string d = dateEdit9.Text;
            if (Globals.click_menu == 26)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutrDate(this.deloDataSet.View_all_vnutr_doc, 26, s, d);
            }
            if (Globals.click_menu == 18)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutrDate(this.deloDataSet.View_all_vnutr_doc, 18, s, d);
            }
            if (Globals.click_menu == 16)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutrDate(this.deloDataSet.View_all_vnutr_doc, 16, s, d);
            }
            if (Globals.click_menu == 25)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutrDate(this.deloDataSet.View_all_vnutr_doc,  25,s, d);
            }
            if (Globals.click_menu == 13)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutrDate(this.deloDataSet.View_all_vnutr_doc, 13, s, d);
            }
            if (Globals.click_menu == 17)
            {
                this.view_all_vnutr_docTableAdapter.FillByVnutrDate(this.deloDataSet.View_all_vnutr_doc,  17,s, d);
            }
            
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            Form kk = new Mail_send_holding();
            kk.ShowDialog();
        }

        private void gridView11_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView11_RowCountChanged(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = ((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            if (!gridView.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridView.GridControl.Handle);
            SizeF size = gr.MeasureString(gridView.RowCount.ToString(), gridView.PaintAppearance.Row.GetFont());
            gridView.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f)
                + DevExpress.XtraGrid.Views.Grid.Drawing.GridPainter.Indicator.ImageSize.Width + 10;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
         
        private void simpleButton26_Click(object sender, EventArgs e)
        {
            DateTime s = Convert.ToDateTime(dateEdit12.Text);
            DateTime d = Convert.ToDateTime(dateEdit11.Text);
            view_all_agent_dogTableAdapter1.FillBy(deloDataSet.View_all_agent_dog, s, d);
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            view_all_agent_dogTableAdapter1.Fill(deloDataSet.View_all_agent_dog);
        }

        private void navBarItem26_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                this.view_all_outbox_docTableAdapter.FillBy2016(this.deloDataSet.View_all_outbox_doc);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                //xtraTabPage3.Text = "Рассылка";
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                xtraTabPage7.Text = "Исходящий архив";
                VhodTabControl1.SelectedTabPage = xtraTabPage7;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = false;
                toolStripMenuItem2.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
            }
            catch { }
        }

        private void navBarItem27_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            VhodTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabPage1.PageVisible = true;
            xtraTabPage3.PageVisible = true;
            xtraTabPage4.PageVisible = true;
            xtraTabPage5.PageVisible = true;
            xtraTabPage7.PageVisible = false;
            xtraTabPage2.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabPage13.PageVisible = false;
            xtraTabPage14.PageVisible = false;
            регистрацияКомандирудостовToolStripMenuItem.Visible = false;
            добавитьДопсоглашенияToolStripMenuItem.Visible = false;
            закрытьДокументToolStripMenuItem.Visible = true;
            печатьToolStripMenuItem.Visible = true;
            toolStripMenuItem3.Visible = false;
            закрытьРапортToolStripMenuItem.Visible = false;
            посмотретьToolStripMenuItem.Visible = false;
            toolStripMenuItem2.Visible = false;
            this.view_all_inbox_docTableAdapter.FillBy(this.deloDataSet.View_all_inbox_doc);
            this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
        }

        private void navBarItem28_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_file_insert = 9;
            Globals.click_menu = 17;
            try
            {
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                xtraTabPage1.PageVisible = false;
                xtraTabPage7.PageVisible = false;
                xtraTabPage2.PageVisible = true;
                xtraTabPage3.PageVisible = true;
                xtraTabPage4.PageVisible = true;
                xtraTabPage5.PageVisible = true;
                xtraTabPage2.Text = "Приказы о командировке";
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                VhodTabControl1.SelectedTabPage = xtraTabPage2;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = true;
                закрытьРапортToolStripMenuItem.Visible = false;
                this.view_all_vnutr_docTableAdapter.FillByVnutr(this.deloDataSet.View_all_vnutr_doc, 17);
                viewallvnutrdocBindingSource.MoveLast();
            }
            catch { }
        }

        private void navBarItem29_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_ishod = 34;
            Globals.but_click_file_insert = 3;
            try
            {
                this.view_all_outbox_docTableAdapter.FillByUser(this.deloDataSet.View_all_outbox_doc, 34, Globals.id_user);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;

                xtraTabPage3.PageVisible = true;
                xtraTabPage3.Text = "Рассылка";
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                xtraTabPage7.Text = "Исходящие протокола";
                VhodTabControl1.SelectedTabPage = xtraTabPage7;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                toolStripMenuItem3.Visible = true;
            }
            catch { }
        }

        private void navBarItem30_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.but_click_ishod = 34;
            Globals.but_click_file_insert = 3;
            try
            {
                this.view_all_outbox_docTableAdapter.FillByAll(this.deloDataSet.View_all_outbox_doc, 34);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                xtraTabPage3.Text = "Рассылка";
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                xtraTabPage7.Text = "Исходящие протокола";
                VhodTabControl1.SelectedTabPage = xtraTabPage7;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                toolStripMenuItem2.Visible = true;
                посмотретьToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = true;
            }
            catch { }
        }

        private void viewalloutboxdocBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_doc = (int)((DataRowView)viewalloutboxdocBindingSource.Current).Row["id"];
            }
            catch (Exception ex) { }
        }

        private void advBandedGridView3_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //var rowHandle = advBandedGridView3.FocusedRowHandle;
            //Globals.id_doc = Convert.ToInt32(advBandedGridView3.GetRowCellValue(rowHandle, "id"));
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem32_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            VhodTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabPage1.PageVisible = true;
            xtraTabPage3.PageVisible = true;
            xtraTabPage4.PageVisible = true;
            xtraTabPage5.PageVisible = true;
            xtraTabPage7.PageVisible = false;
            xtraTabPage2.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabPage13.PageVisible = false;
            xtraTabPage14.PageVisible = false;
            регистрацияКомандирудостовToolStripMenuItem.Visible = false;
            добавитьДопсоглашенияToolStripMenuItem.Visible = false;
            закрытьДокументToolStripMenuItem.Visible = true;
            закрытьРапортToolStripMenuItem.Visible = false;
            печатьToolStripMenuItem.Visible = true;
            toolStripMenuItem2.Visible = true;
            toolStripMenuItem3.Visible = false;
            посмотретьToolStripMenuItem.Visible = false;
            this.view_all_inbox_docTableAdapter.FillBy2017(this.deloDataSet.View_all_inbox_doc);
            this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
        }

        private void navBarItem31_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                this.view_all_outbox_docTableAdapter.FillBy2017(this.deloDataSet.View_all_outbox_doc);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                //xtraTabPage3.Text = "Рассылка";
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                xtraTabPage7.Text = "Исходящий архив";
                VhodTabControl1.SelectedTabPage = xtraTabPage7;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
               закрытьДокументToolStripMenuItem.Visible = false;
               печатьToolStripMenuItem.Visible = false;
               закрытьРапортToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = false;
                toolStripMenuItem2.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
            }
            catch { }
        }

        private void advBandedGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.date_otvet != null && Globals.otvet1 != "")
            {
                this.view_all_outbox_docTableAdapter.FillById(this.deloDataSet.View_all_outbox_doc, Globals.otvet1, Globals.date_otvet);
                if (viewalloutboxdocBindingSource.Count > 0)
                {

                    try
                    {
                        int id_otvet = (int)((DataRowView)(viewalloutboxdocBindingSource.Current)).Row["id"];
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
                else { MessageBox.Show("По этому документу нет исходящего документа!!!"); }
            }
            else { MessageBox.Show("По этому документу нет исходящего документа!!!"); }
        }

        private void navBarItem33_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            VhodTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabPage1.PageVisible = true;
            xtraTabPage3.PageVisible = true;
            xtraTabPage4.PageVisible = true;
            xtraTabPage5.PageVisible = true;
            xtraTabPage7.PageVisible = false;
            xtraTabPage2.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabPage13.PageVisible = false;
            xtraTabPage14.PageVisible = false;
            регистрацияКомандирудостовToolStripMenuItem.Visible = false;
            добавитьДопсоглашенияToolStripMenuItem.Visible = false;
            закрытьДокументToolStripMenuItem.Visible = true;
            печатьToolStripMenuItem.Visible = true;
            закрытьРапортToolStripMenuItem.Visible = false;
            toolStripMenuItem2.Visible = true;
            toolStripMenuItem3.Visible = false;
            посмотретьToolStripMenuItem.Visible = false;
            this.view_all_inbox_docTableAdapter.FillBy2018(this.deloDataSet.View_all_inbox_doc);
            this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
        }

        private void navBarItem34_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                this.view_all_outbox_docTableAdapter.FillBy2018(this.deloDataSet.View_all_outbox_doc);
                this.spr_orgTableAdapter.Fill(this.deloDataSet.spr_org);
                xtraTabPage1.PageVisible = false;
                xtraTabPage2.PageVisible = false;
                xtraTabPage3.PageVisible = true;
                //xtraTabPage3.Text = "Рассылка";
                xtraTabPage4.PageVisible = false;
                xtraTabPage5.PageVisible = true;
                xtraTabPage7.PageVisible = true;
                xtraTabPage7.Text = "Исходящий архив";
                VhodTabControl1.SelectedTabPage = xtraTabPage7;
                xtraTabPage9.PageVisible = false;
                xtraTabPage10.PageVisible = false;
                xtraTabPage11.PageVisible = false;
                xtraTabPage12.PageVisible = false;
                xtraTabPage13.PageVisible = false;
                xtraTabPage6.PageVisible = false;
                xtraTabPage8.PageVisible = false;
                xtraTabPage14.PageVisible = false;
                регистрацияКомандирудостовToolStripMenuItem.Visible = false;
                добавитьДопсоглашенияToolStripMenuItem.Visible = false;
                закрытьДокументToolStripMenuItem.Visible = false;
                печатьToolStripMenuItem.Visible = false;
                закрытьРапортToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = false;
                toolStripMenuItem2.Visible = false;
                посмотретьToolStripMenuItem.Visible = false;
            }
            catch { }
        }

        private void закрытьРапортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form kk = new Add_vnutr_doc(Globals.id_doc);
            kk.ShowDialog();
        }

        private void посмотретьToolStripMenuItem_Click(object sender, EventArgs e)
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
                else { MessageBox.Show("По этому документу нет внутренного документа!!!"); }
            }
            else { MessageBox.Show("По этому документу нет внутренного документа!!!"); }
        }

       
       
    }
}

    
