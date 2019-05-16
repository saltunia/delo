namespace delo
{
    partial class authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authentification));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxPass = new DevExpress.XtraEditors.TextEdit();
            this.textBoxLogin = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.deloDataSet = new delo.deloDataSet();
            this.users_selectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_selectTableAdapter = new delo.deloDataSetTableAdapters.users_selectTableAdapter();
            this.tableAdapterManager = new delo.deloDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_selectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(248, 32);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Такого пользователя не существует \r\n           или пароль не верен!";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Stardust";
            this.defaultLookAndFeel1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(37, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Пароль";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(6, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Пользователь";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPass.Location = new System.Drawing.Point(82, 94);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Properties.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(201, 20);
            this.textBoxPass.TabIndex = 40;
            this.textBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPass_KeyDown);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.Location = new System.Drawing.Point(82, 64);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(201, 20);
            this.textBoxLogin.TabIndex = 39;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Location = new System.Drawing.Point(196, 120);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 21);
            this.simpleButton1.TabIndex = 41;
            this.simpleButton1.Text = "Отмена";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Location = new System.Drawing.Point(98, 120);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(92, 21);
            this.simpleButton2.TabIndex = 44;
            this.simpleButton2.Text = "OK";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            this.simpleButton2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.simpleButton2_KeyDown);
            // 
            // deloDataSet
            // 
            this.deloDataSet.DataSetName = "deloDataSet";
            this.deloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // users_selectBindingSource
            // 
            this.users_selectBindingSource.DataMember = "users_select";
            this.users_selectBindingSource.DataSource = this.deloDataSet;
            // 
            // users_selectTableAdapter
            // 
            this.users_selectTableAdapter.ClearBeforeFill = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 153);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в ПО \"Делопроизводство\"";
            this.Load += new System.EventHandler(this.authentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_selectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textBoxPass;
        private DevExpress.XtraEditors.TextEdit textBoxLogin;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private deloDataSet deloDataSet;
        private System.Windows.Forms.BindingSource users_selectBindingSource;
        private deloDataSetTableAdapters.users_selectTableAdapter users_selectTableAdapter;
        private deloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}