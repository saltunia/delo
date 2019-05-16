using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delo
{
    public  delegate void En_delegate();
    //public delegate void ttt(object, EventArgs);

    class Globals
    {
       
        public static int id_doc;
        public static En_delegate en_delegate;
        public static En_delegate en_delegate1;
        public static En_delegate en_delegate2;
        public static En_delegate en_delegate_raport;
        public static En_delegate en_delegate_prikazy;
        public static En_delegate en_delegate_ukazy;
        public static En_delegate en_delegate_akty;
        public static En_delegate en_delegate_kom;
        public static En_delegate en_delegate_dog_post;
        public static En_delegate en_delegate_dog_agent;
        public static En_delegate en_delegate_dog_mat;
        public static En_delegate en_delegate_otvety;
        public static En_delegate en_delegate_pol_ins;
        public static En_delegate en_delegate_kadr_prikazy;
        public static En_delegate en_delegate_metrol_prikazy; public static List<string> listImg;
        public static int id_user;
        public static string name_user; public static int id_slujbi;
        public static string name_slujbi;
        public static int prava_mod_spr;
        public static int id_dolj;
        public static int id_doljnost;
        public static string name_dolj;
        public static int iii;
        //переменные для входящих документов


        public static int id_org;
        public static int id_org_ruk;
        public static int id_ras_viza;
        public static int id_otv;
        public static string otvet;
        public static int id_vhod;
        public static string id_vhod_dubl;
        public static string otvet1;
        public static bool control;
        public static int form_ishod;
        public static string name_dog_post;
        public static string name_prikaz;
        public static DateTime date_prikaz;
        public static int id_kom;
        public static string name_slujba;
        public static string pol_instr;
        public static int id_sl_pol_ins;
        public static int kol_test;
        public static int id_doc1;
        public static int id_doc2;
        public static bool v_rab;
        public static bool for_info;
        public static int click_menu;
        public static int id_doc_protokol;
        public static int but_click;
        public static int but_click_ishod;
        public static int but_click_file_insert;
        public static DateTime? date_otvet;
    }

}
