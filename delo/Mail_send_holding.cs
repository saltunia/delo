﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.Net.Mail;
using DevExpress.XtraTreeList.Nodes;
using System.IO;


namespace delo
{
    public partial class Mail_send_holding : DevExpress.XtraEditors.XtraForm
    {
        int check2 = 0;
        int check1 = 0;
        DateTime? date;
        string date1;
        bool svod;
        public Mail_send_holding()
        {

            InitializeComponent();
        }

        private void Mail_send_holding_Load(object sender, EventArgs e)
        {
            this.mail_usersTableAdapter.FillByHolding(this.deloDataSet.mail_users);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("oaoseverelectro@mail.ru", "0555008214ema");
            SmtpServer.Host = "smtp.mail.ru";
            SmtpServer.Port = 25;
            SmtpServer.EnableSsl = true;
            MailMessage mail;
            mail = new MailMessage();

            if (check1 == 1 || check2 == 1)
            {
                List<TreeListNode> nodes = treeList1.GetAllCheckedNodes();
                foreach (TreeListNode no in nodes)
                {

                    string email;
                    string ll1;
                    string ll2;
                    string ll3;

                    string ll = no.GetValue(treeListColumn1).ToString();
                    if (no.GetValue(treeListColumn2) is DBNull || Convert.ToBoolean(no.GetValue(treeListColumn2)) == false)
                    { ll1 = null; }
                    else
                    {
                        ll1 = no.GetValue(treeListColumn2).ToString();
                    }
                    if (no.GetValue(treeListColumn3) is DBNull)
                    { ll2 = null; }
                    else
                    {
                        ll2 = no.GetValue(treeListColumn3).ToString();
                    }

                    if (no.GetValue(treeListColumn4) == null || no.GetValue(treeListColumn4).ToString() == "")
                    { ll3 = null; }
                    else
                    {
                        ll3 = no.GetValue(treeListColumn4).ToString();
                    }

                    int id_res = Convert.ToInt32(ll);
                    if (ll1 != "")
                    { svod = Convert.ToBoolean(ll1); }
                    else { svod = false; }
                    if (ll3 != "")
                    { email = Convert.ToString(ll2); }
                    else { email = ""; }
                    if (ll2 != "")
                    { date = Convert.ToDateTime(ll3); }
                    else { date = null; }


                    mail.To.Add(ll2);
                }

            }
            else { MessageBox.Show("Выберите куда отправить документ"); }



            mail.From = new MailAddress("oaoseverelectro@mail.ru");
            //mail.Bcc.Add("saltunia@mail.ru");
            mail.Subject = textEdit1.Text;
            if (date.ToString() == "01.01.0001 0:00:00")
            { date1 = "нет срока"; }
            else { date1 = date.ToString(); }
            mail.Body = "Добрый день, \nВам документ от ОАО Северэлектро " + "\nСрок до: " + date1 + "\nСвод за: " + svod.ToString();
            this.doc_prikrep_fileTableAdapter.FillByid_doc(this.deloDataSet.doc_prikrep_file, Globals.id_doc);
            int rowcount = doc_prikrep_fileBindingSource.Count;
            for (int i = 0; i < rowcount; i++)
            {
                byte[] b1 = ((byte[])((DataRowView)(doc_prikrep_fileBindingSource.Current)).Row["prikr_file"]);
                string exens4grid = (string)((DataRowView)(doc_prikrep_fileBindingSource.Current)).Row["name_file"];
                exens4grid = Path.GetExtension(exens4grid);
                string filename = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid);
                var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                bw.Write(b1);
                bw.Close();

                mail.Attachments.Add(new Attachment(filename));
                doc_prikrep_fileBindingSource.MoveNext();
            }
            mail.IsBodyHtml = false;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            SmtpServer.Timeout = 5000 * 60 * 1000;
            SmtpServer.Send(mail);
            MessageBox.Show("Письмо успешно отправлено");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeList1_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }
        private void SetCheckedChildNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            check2 = 1;
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }
        private void SetCheckedParentNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            check1 = 1;
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = true;
                        break;
                    }
                }
                node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }
        private void treeList1_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked); 
        }
    }
}