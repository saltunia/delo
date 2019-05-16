namespace delo
{
    partial class Slujbi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colnazv_slujbi = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colchek = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colvrem_check = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.deloDataSet1 = new delo.deloDataSet();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.spr_slujbiTableAdapter1 = new delo.deloDataSetTableAdapters.spr_slujbiTableAdapter();
            this.sprBS = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.queriesTableAdapter1 = new delo.deloDataSetTableAdapters.QueriesTableAdapter();
            this.rassylka_vizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rassylka_vizaTableAdapter = new delo.deloDataSetTableAdapters.rassylka_vizaTableAdapter();
            this.tableAdapterManager = new delo.deloDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deloDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rassylka_vizaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colnazv_slujbi,
            this.colchek,
            this.colvrem_check,
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.treeList1.DataMember = "spr_slujbi";
            this.treeList1.DataSource = this.deloDataSet1;
            this.treeList1.KeyFieldName = "id_slujbi";
            this.treeList1.Location = new System.Drawing.Point(2, 2);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.ParentFieldName = "id_zavis";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemDateEdit1});
            this.treeList1.Size = new System.Drawing.Size(583, 569);
            this.treeList1.TabIndex = 0;
            this.treeList1.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeList1_BeforeCheckNode);
            this.treeList1.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterCheckNode);
            // 
            // colnazv_slujbi
            // 
            this.colnazv_slujbi.Caption = "Название службы";
            this.colnazv_slujbi.FieldName = "nazv_slujbi";
            this.colnazv_slujbi.MinWidth = 32;
            this.colnazv_slujbi.Name = "colnazv_slujbi";
            this.colnazv_slujbi.Visible = true;
            this.colnazv_slujbi.VisibleIndex = 0;
            this.colnazv_slujbi.Width = 280;
            // 
            // colchek
            // 
            this.colchek.FieldName = "chek";
            this.colchek.Name = "colchek";
            this.colchek.Width = 182;
            // 
            // colvrem_check
            // 
            this.colvrem_check.FieldName = "vrem_check";
            this.colvrem_check.Name = "colvrem_check";
            this.colvrem_check.Width = 182;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "id_slujbi";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Свод за";
            this.treeListColumn2.ColumnEdit = this.repositoryItemCheckEdit2;
            this.treeListColumn2.FieldName = "vrem_check";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 56;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Примечание";
            this.treeListColumn3.FieldName = "vrem_note";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 3;
            this.treeListColumn3.Width = 125;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Срок до";
            this.treeListColumn4.ColumnEdit = this.repositoryItemDateEdit1;
            this.treeListColumn4.FieldName = "date_ispol";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 2;
            this.treeListColumn4.Width = 85;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.repositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // deloDataSet1
            // 
            this.deloDataSet1.DataSetName = "deloDataSet";
            this.deloDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // spr_slujbiTableAdapter1
            // 
            this.spr_slujbiTableAdapter1.ClearBeforeFill = true;
            // 
            // sprBS
            // 
            this.sprBS.DataMember = "spr_slujbi";
            this.sprBS.DataSource = this.deloDataSet1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(408, 586);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Сохранить";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(499, 586);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Отмена";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // rassylka_vizaBindingSource
            // 
            this.rassylka_vizaBindingSource.DataMember = "rassylka_viza";
            this.rassylka_vizaBindingSource.DataSource = this.deloDataSet1;
            this.rassylka_vizaBindingSource.CurrentItemChanged += new System.EventHandler(this.rassylka_vizaBindingSource_CurrentItemChanged);
            // 
            // rassylka_vizaTableAdapter
            // 
            this.rassylka_vizaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._Reference71TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.doc_pol_ins_fileTableAdapter = null;
            this.tableAdapterManager.documentTableAdapter = null;
            this.tableAdapterManager.dop_soglTableAdapter = null;
            this.tableAdapterManager.kom_udostovTableAdapter = null;
            this.tableAdapterManager.otv_prikrep_fileTableAdapter = null;
            this.tableAdapterManager.pol_instructionsTableAdapter = null;
            this.tableAdapterManager.spr_docTableAdapter = null;
            this.tableAdapterManager.spr_doljnosteiTableAdapter = null;
            this.tableAdapterManager.spr_org_rukTableAdapter = null;
            this.tableAdapterManager.spr_orgTableAdapter = null;
            this.tableAdapterManager.spr_vidov_slujbiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = delo.deloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.users_programmTableAdapter = null;
            // 
            // Slujbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 621);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.treeList1);
            this.Name = "Slujbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите куда надо отправить документ";
            this.Load += new System.EventHandler(this.Slujbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deloDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rassylka_vizaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private deloDataSet deloDataSet1;
        private deloDataSetTableAdapters.spr_slujbiTableAdapter spr_slujbiTableAdapter1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.BindingSource sprBS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnazv_slujbi;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colchek;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colvrem_check;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private deloDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private System.Windows.Forms.BindingSource rassylka_vizaBindingSource;
        private deloDataSetTableAdapters.rassylka_vizaTableAdapter rassylka_vizaTableAdapter;
        private deloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}