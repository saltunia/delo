﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;

namespace delo
{
    public partial class Main2 : DevExpress.XtraEditors.XtraForm
    {
        int id_doc = 0;
        int id_doc1 = 0;
       
        public Main2()
        {
            InitializeComponent();


            // This line of code is generated by Data Source Configuration Wizard
            spr_slujbiTableAdapter1.FillByAll(deloDataSet1.spr_slujbi);
        }

        private void Main2_Load(object sender, EventArgs e)
        {
           // this.pol_instructionsTableAdapter.Fill_pol(deloDataSet1.pol_instructions, Globals.id_sl_pol_ins);
            // TODO: This line of code loads data into the 'deloDataSet1.doc_pol_ins_file' table. You can move, or remove it, as needed.
           // this.doc_pol_ins_fileTableAdapter.Fill(this.deloDataSet1.doc_pol_ins_file);
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel tt = sender as DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel;
            Delegate.RemoveAll(Globals.en_delegate_pol_ins, Globals.en_delegate_pol_ins);
            Globals.en_delegate_pol_ins = visible_main;
        }

        public void visible_main()
        {
            try
            {
               // this.doc_pol_ins_fileTableAdapter.Fill(this.deloDataSet1.doc_pol_ins_file);
                xtraTabControl1.SelectedTabPage = xtraTabPage1;
                //spr_slujbiTableAdapter1.Fill(deloDataSet1.spr_slujbi);
                this.Enabled = true;

            }
            catch { }
        }

        private void добавитьПоложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.pol_instr = "pol_ins";
            this.Enabled = false;
            Form kk = new Add_pol_instruc();
            kk.ShowDialog();

        }

        private string GetSelectedNode(TreeList trvTreeList)
        {
            string fff = trvTreeList.FocusedNode[trvTreeList.Columns["id_slujbi"]].ToString();

            try
            {
                Globals.id_sl_pol_ins = Convert.ToInt32(fff);
            }
            catch { }
            return fff;
        }
        private void treeList1_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            GetSelectedNode(treeList1);
            this.pol_instructionsTableAdapter.Fill_pol(deloDataSet1.pol_instructions, Globals.id_sl_pol_ins);
            //this.pol_instructionsTableAdapter.Fill_instr(deloDataSet1.pol_instructions, Globals.id_sl_pol_ins);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
              
               GridView gv = (GridView)gridView1.GetDetailView(gridView1.FocusedRowHandle, 0);
               byte[] b1 = (byte[])(gv.GetFocusedRowCellValue("prikr_file"));
              
                string exens4grid = (string)(gv.GetFocusedRowCellValue("name_file"));
                exens4grid = Path.GetExtension(exens4grid);
                string filename = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid);
                var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                bw.Write(b1);
                bw.Close();
                Process.Start(filename);
            }
            catch 
            { }
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                GridView gv = (GridView)gridView3.GetDetailView(gridView3.FocusedRowHandle, 0);
                byte[] b1 = (byte[])(gv.GetFocusedRowCellValue("prikr_file"));

                string exens4grid = (string)(gv.GetFocusedRowCellValue("name_file"));
                string filename = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid);
                var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                bw.Write(b1);
                bw.Close();
                Process.Start(filename);
            }
            catch 
            { }
        }

       

        private void windowsUIButtonPanel1_ButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel tt = sender as DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel;


            if (tt.Buttons[0].Properties.Checked == true)
            {
                tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;



                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage1);
                try
                {
                    xtraTabPage1.PageVisible = true;
                    xtraTabPage2.PageVisible = false;
                    xtraTabControl1.SelectedTabPage = xtraTabPage1;
                    this.pol_instructionsTableAdapter.Fill_pol(deloDataSet1.pol_instructions, Globals.id_sl_pol_ins);



                }
                finally
                {
                    transitionManager1.EndTransition();
                }
            }

            if (tt.Buttons[1].Properties.Checked == true)
            {
               tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;



                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage2);
                try
                {
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage2.PageVisible = true;
                   xtraTabControl1.SelectedTabPage = xtraTabPage2;
                    this.pol_instructionsTableAdapter.Fill_instr(deloDataSet1.pol_instructions, Globals.id_sl_pol_ins);



                }
                finally
                {
                    transitionManager1.EndTransition();
                }
            }



        }

        private void polinstructionsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try {
                id_doc = (int)((DataRowView)(polinstructionsBindingSource.Current)).Row["id"];
                this.doc_pol_ins_fileTableAdapter.FillById_doc(this.deloDataSet1.doc_pol_ins_file,id_doc);

            }
            catch { }
        }

        private void polinstructionsBindingSource1_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                id_doc1 = (int)((DataRowView)(polinstructionsBindingSource1.Current)).Row["id"];
                this.doc_pol_ins_fileTableAdapter.FillById_doc(this.deloDataSet1.doc_pol_ins_file, id_doc1);

            }
            catch { }
        }

        private void doc_pol_ins_fileBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {

               
            }
            catch { }
        }

        private void удалитьПоложениеИлиИнструкциюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.delete_pol_instruction(id_doc);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.delete_pol_instruction(id_doc1);
        }
    }
}
