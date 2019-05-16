namespace delo
{
    partial class mail_send
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mail_send));
            this.deloDataSet = new delo.deloDataSet();
            this.mailusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mail_usersTableAdapter = new delo.deloDataSetTableAdapters.mail_usersTableAdapter();
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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.doc_prikrep_fileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doc_prikrep_fileTableAdapter = new delo.deloDataSetTableAdapters.doc_prikrep_fileTableAdapter();
            this.tableAdapterManager = new delo.deloDataSetTableAdapters.TableAdapterManager();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc_prikrep_fileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deloDataSet
            // 
            this.deloDataSet.DataSetName = "deloDataSet";
            this.deloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mailusersBindingSource
            // 
            this.mailusersBindingSource.DataMember = "mail_users";
            this.mailusersBindingSource.DataSource = this.deloDataSet;
            // 
            // mail_usersTableAdapter
            // 
            this.mail_usersTableAdapter.ClearBeforeFill = true;
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colnazv_slujbi,
            this.colchek,
            this.colvrem_check,
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.treeList1.DataSource = this.mailusersBindingSource;
            this.treeList1.KeyFieldName = "id_slujbi";
            this.treeList1.Location = new System.Drawing.Point(3, 18);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            this.treeList1.ParentFieldName = "id_zavis";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemDateEdit1});
            this.treeList1.Size = new System.Drawing.Size(789, 163);
            this.treeList1.TabIndex = 1;
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
            this.treeListColumn3.Caption = "email";
            this.treeListColumn3.FieldName = "email";
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
            this.treeListColumn4.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
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
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Куда в какую службу :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 186);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Обращение :";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(3, 205);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(613, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(636, 203);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Отправить";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 231);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 13);
            this.labelControl3.TabIndex = 7;
            // 
            // doc_prikrep_fileBindingSource
            // 
            this.doc_prikrep_fileBindingSource.DataMember = "doc_prikrep_file";
            this.doc_prikrep_fileBindingSource.DataSource = this.deloDataSet;
            // 
            // doc_prikrep_fileTableAdapter
            // 
            this.doc_prikrep_fileTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
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
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(717, 203);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Закрыть";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // mail_send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 236);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.treeList1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mail_send";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправка через интернет";
            this.Load += new System.EventHandler(this.mail_send_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc_prikrep_fileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private deloDataSet deloDataSet;
        private System.Windows.Forms.BindingSource mailusersBindingSource;
        private deloDataSetTableAdapters.mail_usersTableAdapter mail_usersTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnazv_slujbi;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colchek;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colvrem_check;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource doc_prikrep_fileBindingSource;
        private deloDataSetTableAdapters.doc_prikrep_fileTableAdapter doc_prikrep_fileTableAdapter;
        private deloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;



    }
}