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
    public partial class Add_otvet : DevExpress.XtraEditors.XtraForm
    {
        int? id_otv = 0;
        bool but_clik = false;
        bool but_clik1 = false;
        public Add_otvet()
        {
            InitializeComponent();
        }

        private void Add_otvet_Load(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (memoEdit1.Text!="")
            {
                //but_clik = false;
                if (!but_clik)
                {
                    
                    but_clik = true;

                    this.queriesTableAdapter1.insert_otvet1(Globals.id_doc,Globals.id_ras_viza, Globals.id_user,memoEdit1.Text, Globals.id_slujbi, ref id_otv);
                    MessageBox.Show("Документ успешно зарегистрирован, далее отсканируйте для  прикрепления файлов к этому документу!!!");
                    Globals.id_doc1 = Convert.ToInt32(id_otv);
                    simpleButton2.Enabled = false;
                    simpleButton3.Enabled = false;
                    MainFrame mf = new MainFrame();
                    mf.Show();

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (memoEdit1.Text != "")
            {
                if (!but_clik1)
                {

                   
                    but_clik1 = true;
                    this.queriesTableAdapter1.insert_otvet1(Globals.id_doc, Globals.id_ras_viza, Globals.id_user, memoEdit1.Text, Globals.id_slujbi, ref id_otv);
                    MessageBox.Show("Документ успешно зарегистрирован, далее прикрепите файл к этому документу!!!");
                    Globals.id_doc = Convert.ToInt32(id_otv);
                    simpleButton1.Enabled = false;
                    simpleButton3.Enabled = false;
                    ofdInput.ShowDialog();

                }
                else
                {
                    Globals.id_doc = Convert.ToInt32(id_otv);
                    simpleButton1.Enabled = false;
                    ofdInput.ShowDialog();
                }
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (memoEdit1.Text!="")
            {
                try
                {
                    this.queriesTableAdapter1.insert_otvet1(Globals.id_doc, Globals.id_ras_viza, Globals.id_user, memoEdit1.Text, Globals.id_slujbi, ref id_otv);
                    MessageBox.Show("Данные успешно сохранены!!!");
                }
                catch 
                { MessageBox.Show("Данные не сохранились!!!"); }
                Globals.en_delegate_otvety();
                Close();
            }
            else { MessageBox.Show("Ни все поля заполнены"); }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Globals.en_delegate_otvety();
            Close();
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

                    this.queriesTableAdapter1.insert_file_otv(Globals.id_doc, outlen, file_name, memoEdit1.Text, Globals.id_user);
                    MessageBox.Show("Файл успешно прикреплен ;) ");
                }
            }

            catch 
            {
                MessageBox.Show("Данные не сохранились");
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Globals.en_delegate_otvety();
        }
    }
}