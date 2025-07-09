using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test_project
{
    enum tajhizt_item
    {
        yakhchal = 0, miz, sandali, takht, komod
    }
    enum status
    {
        salem = 0, maayob, darhaletaamir
    }
    class khabgah
    {
        protected string name_kh;
        public string namekh_kh
        {
            get { return name_kh; }
            set { name_kh = value; }
        }
        protected string address_kh;
        public string address
        {
            get { return address_kh; }
            set { address_kh = value; }
        }
        protected int zarfiat_kh;
        public int zarfiat
        {
            get { return zarfiat_kh; }
            set { zarfiat_kh = value; }
        }
        protected string m_kh;
        public string mskhabgaj
        {
            get { return m_kh; }
            set { m_kh = value; }
        }

        protected static khabgah[] khabgah_kh = new khabgah[1000];
        public static khabgah[] khbgh
        {
            get { return khabgah_kh; }
            set { khabgah_kh = value; }
        }
        public static int tos = 0;
        public khabgah(string nmae_kh, string address_kh, int zarfiat_kh, string kh=" ")
        {
            this.name_kh = nmae_kh;
            this.address_kh = address_kh;
            this.zarfiat_kh = zarfiat_kh;
            this.m_kh = kh;
        }
        public string show_kh()
        {
            return $"name:{this.name_kh} address : {this.address_kh}  zarfiat :  {this.zarfiat_kh}  and masool :  {mas_khabgah.find_mas_khabgah(this.m_kh).showmasoolkh()}";
        }
        public void add_khabgah()
        {
            if (tos < khabgah_kh.Length)
            {
                mas_khabgah.find_mas_khabgah(this.m_kh).skkh = mas_khabgah.find_mas_khabgah(this.m_kh).skkh + " " + this.namekh_kh;
                khabgah_kh[tos] = this;
                tos++;
            }
            else
            {
                Console.WriteLine("khabgah is full !!!");
            }
        }
        public static  void remove_khabgah(string kh)
        {
            if (tos != 0)
            {
                bool found = false;
                for (int i = 0; i < tos; i++)
                {
                    if (khabgah_kh[i].show_kh().Contains(kh))
                    {
                        mas_khabgah.find_mas_khabgah(khabgah_kh[i].m_kh).skkh = mas_khabgah.find_mas_khabgah(khabgah_kh[i].m_kh).skkh.Replace(khabgah_kh[i].namekh_kh,"");
                        for (int j = i + 1; j < tos; j++)
                        {
                            khabgah_kh[j - 1] = khabgah_kh[j];
                        }
                        khabgah_kh[tos - 1] = null;
                        tos--;
                        i--;
                        found = true;
                    }
                }
                if (!found) Console.WriteLine("not found this to remove !! ");

            }
            else
            {
                Console.WriteLine("no khabgah !!");
            }
        }
        public void edit_khabgah(int x)
        {
            if (x <= tos)
            {
                mas_khabgah.find_mas_khabgah(this.m_kh).skkh = this.namekh_kh;
                khabgah_kh[x - 1] = this;
            }
            else { Console.WriteLine("no this khabgah to edit (you should select corrct number beetwen list of khangahs) !!"); }
        }
        public static void show_all_khabgah()
        {
            if (tos == 0)
            {
                Console.WriteLine("No khabgah added yet.");
                return;
            }
            Console.WriteLine("all khabgahs :   ");
            Console.WriteLine(new string('-', 100));
            for (int i = 0; i < tos; i++)
            {
                if (khabgah_kh[i] != null)
                {
                    Console.WriteLine($"{i + 1} : {khabgah_kh[i].show_kh()} ");
                    Console.WriteLine(new string('-', 100));
                }
            }
        }
        public static void show_name_khabgahs()
        {
            if (tos == 0)
            {
                Console.WriteLine("No khabgah added yet.");
                return;
            }
            Console.WriteLine("all khabgahs :   ");
            Console.WriteLine(new string('-', 45));
            for (int i = 0; i < tos; i++)
            {

                Console.WriteLine($"{i + 1} : {khabgah_kh[i].name_kh}");
                Console.WriteLine(new string('-', 45));
            }
        }
        public static khabgah find_khabgah(string n)
        {

            if (khabgah_kh == null && tos == 0)
                Console.WriteLine("no khabgah yet! ");
            for (int i = 0; i < tos; i++)
            {
                if (khabgah_kh[i].show_kh().Contains(n))
                {
                    return khabgah_kh[i];
                }
            }
            Console.WriteLine("not found!! ");
            return null;
        }
        public static void zrf_kh()
        {
            Console.WriteLine("zarfiat ha: ");
            Console.WriteLine(new string('-', 200));
            for (int i = 0; i < tos; i++)
            {
                int c = 0;
                for (int j = 0; j < daneshjoo.tos; j++)
                {
                    if (khabgah_kh[i] != null && daneshjoo.danshjos[j] != null && daneshjoo.danshjos[j].kh_daneshjo == khabgah_kh[i].namekh_kh) c++;
                }
                Console.WriteLine($"{khabgah_kh[i].name_kh} :  {khabgah_kh[i].zarfiat_kh - c}");
                Console.WriteLine(new string('-', 200));
            }
        }
    }
    class bolok
    {
        protected string name_b;
        public string nam_b
        {
            get { return name_b; }
            set { name_b = value; }
        }
        protected int tabaqat_b;
        public int tabaqe_b
        {
            get { return tabaqat_b; }
            set { tabaqat_b = value; }
        }
        protected int otaq_b;
        public int otaqq_b
        {
            get { return otaq_b; }
            set { otaq_b = value; }
        }
        protected string mb_b;
        public string mas_b
        {
            get { return mb_b; }
            set { mb_b = value; }
        }
        protected static bolok[] boloks_b = new bolok[1000];
        public static bolok[] bolook
        {
            get { return boloks_b; }
            set { boloks_b = value; }
        }
        public static int tos = 0;
        public bolok(string name_b, int tabaqat_b, int otaq, string mb_b)
        {
            this.name_b = name_b;
            this.tabaqat_b = tabaqat_b;
            this.otaq_b = otaq;
            this.mb_b = mb_b;
        }

        public string show_bolok()
        {
            return $"name : {this.name_b} tabaqat : {this.tabaqat_b} tedad otaq : {this.otaq_b} masool blolok : {mas_bolok.find_mas_bolok((this.mb_b)).show_mb()} ";
        }
        public  void add_to_bolok()
        {
            if (tos < boloks_b.Length)
            {
                mas_bolok.find_mas_bolok(this.mb_b).sbl = this.name_b;
                boloks_b[tos] = this;
                tos++;
            }
            else
            {
                Console.WriteLine("the bolok is full ");
            }
        }
        public static void remove_bolok(string bl)
        {
            if (tos != 0)
            {
                bool found = false;
                for (int i = 0; i < tos; i++)
                {
                    if (boloks_b[i].show_bolok().Contains(bl))
                    {
                        mas_bolok.find_mas_bolok(boloks_b[i].mas_b).sbl ="??";
                        for (int j = i + 1; j < tos; j++)
                        {
                            boloks_b[j - 1] = boloks_b[j];
                        }
                        boloks_b[tos - 1] = null;
                        tos--;
                        i--;
                        found = true;
                    }
                }
                if (!found) Console.WriteLine("not found this to remove !! ");

            }
            else
            {
                Console.WriteLine("no bolok !!");
            }
        }
        public  void edit_bolok(int x)
        {

            if (x <= tos)
            {
                mas_bolok.find_mas_bolok(this.mb_b).sbl = this.name_b;
                boloks_b[x - 1] = this;
            }
            else Console.WriteLine("no this bolok to edit !! ");
        }

        public static void show_all_boloks()
        {
            if (tos == 0)
            {
                Console.WriteLine("No bolok added yet.");
                return;
            }
            Console.WriteLine("all boloks in this khabgah  :   ");
            Console.WriteLine(new string('-', 200));
            for (int i = 0; i < tos; i++)
            {
                if (boloks_b != null)
                {
                    Console.WriteLine($"{i + 1} : {boloks_b[i].show_bolok()} ");
                    Console.WriteLine(new string('-', 200));
                }
            }
        }
        public static void show_name_bolok()
        {
            if (tos == 0)
            {
                Console.WriteLine("No bolok added yet.");
                return;
            }
            Console.WriteLine("all boloks :   ");
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < tos; i++)
            {
                Console.WriteLine($"{i + 1} : {boloks_b[i].nam_b} ");
                Console.WriteLine(new string('-', 50));
            }
        }
        public static bolok find_bolok(string n)
        {

            if (boloks_b == null && boloks_b.Length == 0)
                Console.WriteLine("no bolok yet! ");
            for (int i = 0; i < tos; i++)
            {
                if (boloks_b[i].show_bolok().Contains(n))
                {
                    return boloks_b[i];
                }
            }
            Console.WriteLine("not found!! ");
            return null;
        }
        public static void zrf_bolok()
        {
            Console.WriteLine("zarfiat haye boloks: ");
            Console.WriteLine(new string('-', 200));
            for (int i = 0; i < tos; i++)
            {
                int c = 0;
                for (int j = 0; j < daneshjoo.tos; j++)
                {
                    if (boloks_b[i] != null && daneshjoo.danshjos[j] != null && daneshjoo.danshjos[j].bl_daneshjo == boloks_b[i].nam_b) c++;
                }
                Console.WriteLine($"{boloks_b[i].nam_b} :  {(boloks_b[i].otaqq_b * 6) - c}");
                Console.WriteLine(new string('-', 200));
            }
        }
    }
    class otaq
    {
        protected string shomare_ot;
        public string sh_ot
        {
            get { return shomare_ot; }
            set { shomare_ot = value; }
        }
        protected int tabaqe_ot;
        public int tab_ot
        {
            get { return tabaqe_ot; }
            set { tabaqe_ot = value; }
        }
        protected int zarfiat_ot = 6;
        public int zrf_ot
        {
            get { return zarfiat_ot; }
            set { zarfiat_ot = value; }
        }

        protected tajhizat tajhizat_ot;
        public tajhizat taj_ot
        {
            get { return tajhizat_ot; }
            set { tajhizat_ot = value; }
        }
        public static otaq[] otaqha = new otaq[1000];
        protected static int tos = 0;
        public static int tos_otaq
        {
            get { return tos;}
            set { tos = value; }
        }
        public otaq(string shomare_ot, int tabaqe_ot, tajhizat tj_ot = null)
        {
            this.shomare_ot = shomare_ot;
            this.tabaqe_ot = tabaqe_ot;
            this.tajhizat_ot = tj_ot;
        }

        public string show_otaq()
        {
            string tajhizInfo = tajhizat_ot != null ? tajhizat_ot.show_tajhiz() : "??";
            return $" shomare otaq: {shomare_ot} tabaqe : {tabaqe_ot} tajhizat : {tajhizInfo}";
        }
        public void add_otaq()
        {
            if (tos < otaqha.Length)
            {
                otaqha[tos] = this;
                tos++;
            }
            else { Console.WriteLine("otaqha is full!!"); }
        }
        public static void show_all_otaqs()
        {
            if (tos == 0)
            {
                Console.WriteLine("No otaq added yet.");
                return;
            }
            Console.WriteLine("all otaqs :   ");
            Console.WriteLine(new string('-', 200));
            for (int i = 0; i < tos; i++)
            {
                if (otaqha[i] != null)
                {
                    Console.WriteLine($"{i + 1} : {otaqha[i].show_otaq()} ");
                    Console.WriteLine(new string('-', 200));
                }
            }
        }
        public static void show_name_otaq()
        {
            if (tos == 0)
            {
                Console.WriteLine("No otaq added yet.");
                return;
            }
            Console.WriteLine("all otaqs  :   ");
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < tos; i++)
            {
                Console.WriteLine($"{i + 1} : {otaqha[i].shomare_ot} ");
                Console.WriteLine(new string('-', 50));
            }
        }
        public static otaq find_otaq(string n)
        {

            if (tos == 0)
            {
                Console.WriteLine("no otaq yet! ");
                return null;
            }

            for (int i = 0; i < tos; i++)
            {
                if (otaqha[i].show_otaq().Contains(n))
                {
                    return otaqha[i];
                }
            }
            Console.WriteLine("not found!! ");
            return null;
        }
        public static void full_or_empty()
        {
            int c = 0, indexp = 0, indexkh = 0;
            otaq[] por = new otaq[tos];
            otaq[] khali = new otaq[tos];
            for (int i = 0; i < tos; i++)
            {
                c = 0;
                for (int j = 0; j < tos; j++)
                {
                    if (otaqha[i].sh_ot == daneshjoo.danshjos[j].ot_daneshjo)
                    {
                        c++;
                    }
                }
                if (c < 6)
                {
                    khali[indexkh] = otaqha[i]; indexkh++;
                }
                else
                {
                    por[indexp] = otaqha[i]; indexp++;
                }
            }
            Console.WriteLine("otaq haye khali:");
            for (int i = 0; i < indexkh; i++) Console.WriteLine(khali[i].sh_ot);
            Console.WriteLine("otaq haye por: ");
            for (int i = 0; i < indexp; i++) Console.WriteLine(por[i].sh_ot);
        }
        public static void list_otaq_tajhizat()
        {
            Console.WriteLine("tamam tajhizat tamam otaqha :");
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < tos; i++)
            {
                int stu = 1;
                if (otaqha[i] != null)
                {
                    Console.WriteLine($"{i + 1} : {otaqha[i].shomare_ot} :  yakhchal : {otaqha[i].taj_ot.shmare_amv}  ");
                    for (int j = 0; j < daneshjoo.tos; j++)
                    {
                        if (daneshjoo.danshjos[j].ot_daneshjo == otaqha[i].shomare_ot)
                        {
                            Console.WriteLine($"{stu} : {daneshjoo.danshjos[j].tj_st.show_tajhiz()} ");
                            stu++;
                        }
                    }
                    Console.WriteLine(new string('-', 200));
                }
            }
        }
    }

    class tajhizat
    {
        protected tajhizt_item tajhizat_taj;
        public tajhizt_item tajh
        {
            get { return tajhizat_taj; }
            set { tajhizat_taj = value; }
        }
        protected string patnumber_taj;
        public string partnum
        {
            get { return patnumber_taj; }
            set { patnumber_taj = value; }
        }
        protected string shomare_amval_taj;
        public string shmare_amv
        {
            get { return shomare_amval_taj; }
            set { shomare_amval_taj = value; }
        }
        protected status status_tajhiz;
        public status st_t
        {
            get { return status_tajhiz; }
            set { status_tajhiz = value; }
        }
        protected static tajhizat[] all_info_tajh = new tajhizat[1000];
        public static tajhizat[] all_tj
        {
            get { return all_info_tajh; }
        }
        protected static int tos = 0;
        public static int ts
        {
            get { return tos; }
            set { tos = value; }
        }
        protected static string[,] sh_amvals = new string[100, 5];
        protected static string[] gozaresh_darkhast_ha = new string[1000];
        public static int count_gozaresh_amvl = 0;
        public tajhizat(tajhizt_item tajhizat_taj, string patnumber_taj, string shomare_amval, status status_tajhiz = 0)
        {
            this.tajhizat_taj = tajhizat_taj;
            this.patnumber_taj = patnumber_taj;
            this.status_tajhiz = status_tajhiz;
            this.shomare_amval_taj = shomare_amval;
        }
        public string show_tajhiz()
        {
            return $" name : {tajhizat_taj} part number  :  {patnumber_taj}  shmare amval : {shomare_amval_taj} and vaziat : {status_tajhiz} ";
        }
        public void add_to_tajhizat()
        {
            if (tos != all_info_tajh.Length)
            {
                all_info_tajh[tos] = this;
                tos++;
            }
            else Console.WriteLine("tajhizat are fulll !!");
        }
        public static void sabtTajhizjadid()
        {

            Console.WriteLine("Noe tajhiz (0:Yakhchal, 1:Miz, 2:Sandali, 3:Takht, 4:Komod):");
            if (!int.TryParse(Console.ReadLine(), out int tajIndex) || tajIndex < 0 || tajIndex > 4)//control input
            {
                Console.WriteLine("❌ vorodi na motabar ❌");
                return;
            }
            tajhizt_item noe = (tajhizt_item)tajIndex;
            Console.WriteLine("Part Number : (001 - 005):");
            string partnum = Console.ReadLine();
            int index = int.Parse(partnum) - 1;
            Console.WriteLine("shomare amval : ( 5 number) ");
            string shmare_amval = Console.ReadLine();
            int i = 0;
            for (; i < 1000 && sh_amvals[i, index] != null; i++)//find tekrari
            {
                if (sh_amvals[i, index] == (shmare_amval + partnum))
                {
                    Console.WriteLine("❌ shomare amval tekreri ❌");
                    return;
                }
            }
            if (i >= 1000)
            {
                Console.WriteLine("❌ zarfist takmil shode baraye in part number ❌");
                return;
            }
            sh_amvals[i, index] = shmare_amval + partnum;
            tajhizat jadid = new tajhizat(noe, partnum, shmare_amval + partnum);
            jadid.add_to_tajhizat();
        }
        public static void add_to_otaq()
        {
            otaq.show_name_otaq();
            Console.WriteLine("chose your otaq !!");
            string ot = Console.ReadLine();
            otaq ot1 = otaq.find_otaq(ot);
            if (ot1 == null)
            {
                Console.WriteLine("❌ otaq not found ❌");
                return;
            }
            sabtTajhizjadid();
            ot1.taj_ot = all_info_tajh[tos - 1];
        }
        public static void jabejaii_tj_otaq()
        {
            otaq.show_name_otaq();
            Console.WriteLine("chose otaq to jabejaii :");
            string ot_name1 = Console.ReadLine();
            otaq ot1 = otaq.find_otaq(ot_name1);
            if (ot1 == null)
            {
                Console.WriteLine("wrong otaq ");
                return;
            }
            string ot_name2 = Console.ReadLine();
            otaq ot2 = otaq.find_otaq(ot_name2);
            if (ot2 == null)
            {
                Console.WriteLine("wrong otaq ");
                return;
            }
            tajhizat t = ot2.taj_ot;
            ot2.taj_ot = ot1.taj_ot;
            ot1.taj_ot = t;
        }
        public static void add_to_student()
        {
            daneshjoo.show_name_students();
            Console.WriteLine("choosse student : ");
            string st_name = Console.ReadLine();
            daneshjoo st1 = daneshjoo.find_student(st_name);
            if (st1 == null)
            {
                Console.WriteLine("❌ student not found ❌");
                return;
            }
            sabtTajhizjadid();
            st1.tj_st = all_info_tajh[tos - 1];
        }
        public static void jabejaii_tj_student()
        {
            daneshjoo.show_name_students();
            Console.WriteLine("chose daneshjoo to jabejaii :");
            string st_name1 = Console.ReadLine();
            daneshjoo st1 = daneshjoo.find_student(st_name1);
            if (st1 == null)
            {
                Console.WriteLine("wrong student ");
                return;
            }
            string st_name2 = Console.ReadLine();
            daneshjoo st2 = daneshjoo.find_student(st_name2);
            if (st2 == null)
            {
                Console.WriteLine("wrong student ");
                return;
            }
            tajhizat t = st2.tj_st;
            st2.tj_st = st1.tj_st;
            st1.tj_st = t;
        }
        public static tajhizat find_tajhiz(string n)
        {

            if (tos == 0)
            {
                Console.WriteLine("no tajhiz  yet! ");
                return null;
            }
            for (int i = 0; i < tos; i++)
            {
                if (all_info_tajh[i].show_tajhiz().Contains(n))
                {
                    return all_info_tajh[i];
                }
            }
            Console.WriteLine("not found!! ");
            return null;
        }
        public static void shomare_amvals_show()
        {
            for(int i=0;i<sh_amvals.GetLength(0);i++)
            {
                for(int j=0;j<sh_amvals.GetLength(1);j++)
                {
                    Console.Write(sh_amvals[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public static void sabte_darkhast(string shomareamval1)
        {
            tajhizat t1 = tajhizat.find_tajhiz(shomareamval1);
            if (t1 == null)
            {
                Console.WriteLine("not found !!");
                return;
            }
            t1.status_tajhiz = status.darhaletaamir;
            Console.WriteLine("tajhiz dar hal taamir shod");
        }
        public static void peygiri(string n)
        {
            tajhizat t1 = tajhizat.find_tajhiz(n);
            if (t1 == null)
            {
                Console.WriteLine("not found ");
                return;
            }
            Console.WriteLine($"vaziat  of {t1.tajhizat_taj} : {t1.status_tajhiz}");
        }
        public static void sabt_maayobha(string s1)
        {

            tajhizat t1 = tajhizat.find_tajhiz(s1);
            if (t1 == null)
            {
                Console.WriteLine("not found !!");
                return;
            }
            t1.status_tajhiz = status.maayob;
            gozaresh_darkhast_ha[count_gozaresh_amvl] = $"{t1.tajhizat_taj} ba partNumber {t1.patnumber_taj} baraye {(daneshjoo.find_student(t1.shmare_amv)).fullname} dar hal taamir";
            count_gozaresh_amvl++;
        }
        public static void show_all_amval()
        {
            if (tos == 0)
            {
                Console.WriteLine("No amval added yet.");
                return;
            }
            Console.WriteLine("all amvals :   ");
            Console.WriteLine(new string('-', 200));
            for (int i = 0; i < tos; i++)
            {
                if (all_info_tajh[i] != null)
                {
                    Console.WriteLine($"{i + 1} : {all_info_tajh[i].show_tajhiz()} ");
                    Console.WriteLine(new string('-', 200));
                }
            }
        }
        public static void list_mayobs_drhaltamir()
        {
            int count = 1;
            Console.WriteLine("tamam maayob ha :");
            for (int i = 0; i < tos; i++)
            {
                if (all_info_tajh[i].status_tajhiz == status.maayob)
                {
                    Console.WriteLine($"{count} : {all_info_tajh[i].tajhizat_taj} ");
                    count++;
                }
            }
            Console.WriteLine("tamam dahale taamir ha :");
            count = 1;
            for (int j = 0; j < tos; j++)
            {
                if (all_info_tajh[j].status_tajhiz == status.darhaletaamir)
                {
                    Console.WriteLine($"{count} : {all_info_tajh[j].tajhizat_taj}");
                    count++;
                }
            }
        }
        public static void gozaresh_darkhast_tamirat()
        {
            Console.WriteLine("gozaresh darkhast taamir amval : ");
            Console.WriteLine(new string('_', 200));
            for (int i = 0; i < count_gozaresh_amvl; i++)
            {
                Console.WriteLine($"{i + 1} : {gozaresh_darkhast_ha[i]}");
            }
        }
    }
    class person
    {
        protected string fullname_per;
        public string fullname
        {
            get { return fullname_per; }
            set { fullname_per = value; }
        }
        protected string code_melli_per;
        public string cod_melli
        {
            get { return code_melli_per; }
            set { code_melli_per = value; }
        }
        protected string phone_number_per;
        public string phone
        {
            get { return phone_number_per; }
            set { phone_number_per = value; }
        }
        protected string address_per;
        public string address_person
        {
            get { return address_per; }
            set { address_per = value; }
        }
        public person(string fullname_per, string code_melli_per, string phone_number_per, string address_per)
        {
            this.fullname_per = fullname_per;
            this.code_melli_per = code_melli_per;
            this.phone_number_per = phone_number_per;
            this.address_per = address_per;
        }
        public virtual string showperson()
        {
            return $"fullname : {fullname_per} code melli : {code_melli_per}  phone number :  {phone_number_per} address  :  {address_per}  ";
        }

    }
    class mas_khabgah : person
    {
        protected string semat_mk;
        public string semt
        {
            get { return semat_mk; }
            set { semat_mk = value; }
        }
        protected string skhabgah_mk;
        public string skkh
        {
            get { return skhabgah_mk; }
            set { skhabgah_mk = value; }
        }
        protected static mas_khabgah[] masoolan_kh = new mas_khabgah[1000];
        protected static int tos = 0;
        public mas_khabgah(string fullname_per, string code_melli_per, string phone_number_per, string address_per, string semat="???", string skhabgah = "")
    : base(fullname_per, code_melli_per, phone_number_per, address_per)
        {
            this.semat_mk = semat;
            this.skhabgah_mk = skhabgah;

        }
        public string showmasoolkh()
        {
            return base.showperson() + $"semat : {this.semat_mk} khabgah tahte masooliat : {this.skhabgah_mk}";
        }
        public  void add_to_masool_kh()
        {
            if (tos < masoolan_kh.Length)
            {
                mas_khabgah new_masool = new mas_khabgah(this.fullname_per, this.code_melli_per, this.phone_number_per, this.address_per, this.semat_mk);
                masoolan_kh[tos] = new_masool;
                tos++;
            }
            else
            {
                Console.WriteLine("the khabgah  is full ");
            }
        }

        public static void remove_from_ma_kh(string bl)
        {
            if (tos != 0)
            {
                bool found = false;
                for (int i = 0; i < tos; i++)
                {
                    if (masoolan_kh[i].showmasoolkh().Contains(bl))
                    {
                        for (int j = i + 1; j < tos; j++)
                        {
                            masoolan_kh[j - 1] = masoolan_kh[j];
                        }
                        masoolan_kh[tos - 1] = null;
                        tos--;
                        i--;
                        found = true;
                    }
                }
                if (!found) Console.WriteLine("not found this to remove !! ");

            }
            else
            {
                Console.WriteLine("no masool !!");
            }
        }

        public static void edit_masool_kh(string n1, string fullname_per, string code_melli_per, string phone_number_per, string address_per, string semat)
        {
            bool edited = false;
            for (int i = 0; i < tos; i++)
            {
                if (masoolan_kh[i].showmasoolkh().Contains(n1))
                {
                    mas_khabgah new_masool = new mas_khabgah(fullname_per, code_melli_per, phone_number_per, address_per, semat);
                    masoolan_kh[i] = new_masool; edited = true;
                }

            }
            if (!edited) Console.WriteLine("no found to edit !!! ");
        }
        public static void show_all_masoolan_kh()
        {
            Console.WriteLine("Masoolan Khabgah:");
            Console.WriteLine(new string('~', 200));
            for (int i = 0; i < tos; i++)
            {
                Console.WriteLine(masoolan_kh[i].showmasoolkh());
                Console.WriteLine(new string('_', 200));
            }
        }
        public static mas_khabgah find_mas_khabgah(string n)
        {
            if (tos == 0)
            {
                Console.WriteLine("no maool KHABGAH yet! ");
                return null;
            }
            for (int i = 0; i < tos; i++)
            {
                if (masoolan_kh[i].fullname==n)
                {
                    return masoolan_kh[i];
                }
            }
            Console.WriteLine("not found!! ");
            return null;
        }
    }
    class mas_bolok : person
    {
        protected string semat_mb;
        public string smt
        {
            get { return semat_mb; }
            set { semat_mb = value; }
        }
        protected string sbolok_mb;
        public string sbl
        {
            get { return sbolok_mb; }
            set { sbolok_mb = value; }
        }
        protected static mas_bolok[] masoolan_bolok = new mas_bolok[1000];
        protected static int tos = 0;
        public mas_bolok(string fullname_per, string code_melli_per, string phone_number_per, string address_per, string semat_mb, string sbolok_mb = "??")
        : base(fullname_per, code_melli_per, phone_number_per, address_per)
        {
            this.semat_mb = semat_mb;
            this.sbolok_mb = sbolok_mb;
        }
        public string show_mb()
        {
            return base.showperson() + $"  semat : {semat_mb} bolok tahte masooliat : {sbolok_mb}";
        }
        public void add_to_masool_bl()
        {
            if (tos < masoolan_bolok.Length)
            {
                mas_bolok new_masool_b = new mas_bolok(this.fullname_per, this.code_melli_per, this.phone_number_per, this.address_per, this.semat_mb, this.sbolok_mb);
                masoolan_bolok[tos] = new_masool_b;
                tos++;
            }
            else
            {
                Console.WriteLine("the bolok is full ");
            }
        }

        public static void remove_from_ma_bl(string bl)
        {
            if (tos != 0)
            {
                bool found = false;
                for (int i = 0; i < tos; i++)
                {
                    if (masoolan_bolok[i].show_mb().Contains(bl))
                    {
                        for (int j = i + 1; j < tos; j++)
                        {
                            masoolan_bolok[j - 1] = masoolan_bolok[j];
                        }
                        masoolan_bolok[tos - 1] = null;
                        tos--;
                        i--;
                        found = true;
                    }
                }
                if (!found) Console.WriteLine("not found this to remove !! ");

            }
            else
            {
                Console.WriteLine("no masool !!");
            }
        }

        public static void edit_masool_bl(string n1, string fullname_per, string code_melli_per, string phone_number_per, string address_per, string semat, string skhabgah = "??")
        {
            bool edited = false;
            for (int i = 0; i < tos; i++)
            {

                if (masoolan_bolok[i].show_mb().Contains(n1))
                {
                    mas_bolok new_masool = new mas_bolok(fullname_per, code_melli_per, phone_number_per, address_per, semat, skhabgah);
                    masoolan_bolok[i] = new_masool; edited = true;
                }

            }
            if (!edited) Console.WriteLine("no found to edit !!! ");
        }

        public static void show_all_masoolan_b()
        {
            Console.WriteLine("Masoolan bolok:");
            Console.WriteLine(new string('~', 200));
            for (int i = 0; i < tos; i++)
            {
                Console.WriteLine(masoolan_bolok[i].show_mb());
                Console.WriteLine(new string('_', 200));
            }
        }
        public static mas_bolok find_mas_bolok(string n)
        {
            if (tos == 0)
            {
                Console.WriteLine("no maool bolok  yet! ");
                return null;
            }
            for (int i = 0; i < tos; i++)
            {
                if (masoolan_bolok[i].fullname == n)
                {
                    return masoolan_bolok[i];
                }
            }
            Console.WriteLine("not found masool bolok!! ");
            return null;
        }

    }
    class daneshjoo : person
    {
        protected string studentNumber;
        public string student_num
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }
        protected string otaghDaneshjoo;
        public string ot_daneshjo
        {
            get { return otaghDaneshjoo; }
            set { otaghDaneshjoo = value; }
        }
        protected string bolokDaneshjoo;
        public string bl_daneshjo
        {
            get { return bolokDaneshjoo; }
            set { bolokDaneshjoo = value; }
        }
        protected string khabgahDaneshjoo;
        public string kh_daneshjo
        {
            get { return khabgahDaneshjoo; }
            set { khabgahDaneshjoo = value; }
        }
        protected tajhizat tajhizat_List;
        public tajhizat tj_st
        {
            get { return tajhizat_List; }
            set { tajhizat_List = value; }
        }
        public static daneshjoo[] danshjos = new daneshjoo[1000];
        public static int tos;
        public int ts
        {
            get { return tos; }
            set { tos = value; }
        }
        protected static string[] gozarsh_eskan = new string[1000];
        public  string[] gozares
        {
            get { return gozarsh_eskan; }
            set { gozarsh_eskan = value; }
        }
        public static int countt_gozaresh_eskan = 0;
        public daneshjoo(string fullname_per, string studentNumber, string code_melli_per, string phone_number_per, string address_per, string ot_d = null, string bl_d = null,
            string kh_d = null, tajhizat tajhizat_List = null) :
            base(fullname_per, code_melli_per, phone_number_per, address_per)
        {
            this.studentNumber = studentNumber;
            this.ot_daneshjo = ot_d;
            this.bolokDaneshjoo = bl_d;
            this.khabgahDaneshjoo = kh_d;
            this.tajhizat_List = tajhizat_List;
            tos = 0;

        }
        public string show_student()
        {
            string tajhizInfo_std = tajhizat_List != null ? tajhizat_List.show_tajhiz() : "??";
            return base.showperson() + $"  shmare daneshjooii: {this.studentNumber} and khabgah {this.khabgahDaneshjoo} bolok {this.bolokDaneshjoo} otaq {this.ot_daneshjo} tajhizat : {tajhizInfo_std} ";
        }

        public  void add_to_danshjo()
        {
            if (tos < danshjos.Length)
            {
                if (daneshjoo.find_student(this.fullname) == null)
                {
                    danshjos[tos] = this;
                    tos++;
                }
                else Console.WriteLine("this student is exist !!");
            }
            else
            {
                Console.WriteLine("the danshjos is full ");
            }
        }

        public static void remove_from_danshjos(string bl)
        {
            if (tos != 0)
            {
                bool found = false;
                for (int i = 0; i < tos; i++)
                {
                    if (danshjos[i].show_student().Contains(bl))
                    {
                        for (int j = i + 1; j < tos; j++)
                        {
                            danshjos[j - 1] = danshjos[j];
                        }
                        danshjos[tos - 1] = null;
                        tos--;
                        i--;
                        found = true;
                    }
                }
                if (!found) Console.WriteLine("not found this to remove !! ");

            }
            else
            {
                Console.WriteLine("no  this daneshjo !!");
            }
        }


        public static daneshjoo find_student(string n)
        {

            if (tos == 0)
            {
                Console.WriteLine("no student yet! ");
                
            }
            for (int i = 0; i < tos; i++)
            {
                if (danshjos[i].fullname == n || danshjos[i].studentNumber == n || (danshjos[i].tajhizat_List!=null  && danshjos[i].tajhizat_List.shmare_amv==n))
                {
                    return danshjos[i];
                }
            }
            Console.WriteLine("not found!! ");
            return null;
        }
        public static void show_all_daneshjooyan()
        {
            Console.WriteLine("all danehjoyan : ");
            Console.WriteLine(new string('~', 200));
            for (int i = 0; i < tos; i++)
            {
                Console.WriteLine(danshjos[i].show_student());
                Console.WriteLine(new string('_', 200));
            }
        }
        public static void edit_student(string n1, string fullname_per, string studentNumber, string code_melli_per, string phone_number_per, string address_per, string ot_d = null, string bl_d = null,
            string kh_d = null, tajhizat tajhizat_List=null)
        {
            bool edited = false;
            for (int i = 0; i < tos; i++)
            {
                if (danshjos[i].fullname==n1)
                {
                    daneshjoo d = new daneshjoo(fullname_per,studentNumber ,code_melli_per, phone_number_per, address_per,ot_d,bl_d,kh_d,tajhizat_List);
                    danshjos[i] = d; edited = true;
                }

            }
            if (!edited) Console.WriteLine("no found to edit !!! ");
        }
        public static void show_name_students()
        {
            if (tos == 0)
            {
                Console.WriteLine("No student added yet.");
                return;
            }
            Console.WriteLine("all student :   ");
            Console.WriteLine(new string('-', 45));
            for (int i = 0; i < tos; i++)
            {

                Console.WriteLine($"{i + 1} : {danshjos[i].fullname}");
                Console.WriteLine(new string('-', 45));
            }
        }
        public static void sabt_nam(string fullname)
        {
            daneshjoo d = find_student(fullname);
            if (d == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            khabgah.show_name_khabgahs();
            Console.WriteLine("select khabgah by number:");
            int kh = int.Parse(Console.ReadLine());
            if (kh > khabgah.tos)
            {
                Console.WriteLine("Khabgah not found!");
                return;
            }
            var kh2 = khabgah.find_khabgah(khabgah.khbgh[kh - 1].namekh_kh);
            string k2 = kh2.namekh_kh;
            bolok.show_name_bolok();
            Console.WriteLine("select bolok by number: ");
            int bl = int.Parse(Console.ReadLine());
            if (bl > bolok.tos)
            {
                Console.WriteLine("Bolok not found!");
                return;
            };
            var b2 = bolok.bolook[bl - 1].nam_b;
            otaq.show_name_otaq();
            Console.WriteLine("select otaq by number: ");
            int ot = int.Parse(Console.ReadLine());
            if(ot>otaq.tos_otaq)
            {
                Console.WriteLine("otaq not found !!");
                return;
            }
            otaq ot1 = otaq.find_otaq(otaq.otaqha[ot-1].sh_ot);
            d.khabgahDaneshjoo = k2;
            d.bolokDaneshjoo = b2;
            d.otaghDaneshjoo = ot1.sh_ot;
            Console.WriteLine("sabtenam movafaqiat amiz :) ");
            gozarsh_eskan[countt_gozaresh_eskan] = $"{fullname} dar khabgah {k2} dar bolok {b2} va dar otaq {ot1} eskan karde .";
            countt_gozaresh_eskan++;
        }
        public static void jabejaii(string fullname)
        {
            daneshjoo d1 = find_student(fullname);
            if (d1 == null)
            {
                Console.WriteLine("student not found !!");
                return;
            }
            Console.WriteLine(d1.show_student());
            Console.WriteLine("be tartib khabgah bolok va otaq ra begooid");
            khabgah.show_name_khabgahs();
            int num_khabgah = int.Parse(Console.ReadLine());
            d1.kh_daneshjo = khabgah.khbgh[num_khabgah-1].namekh_kh;
            bolok.show_name_bolok();
            int num_bl = int.Parse(Console.ReadLine());
            d1.bolokDaneshjoo = bolok.bolook[num_khabgah-1].nam_b;
            otaq.show_name_otaq();
            int num_ot = int.Parse(Console.ReadLine());
            d1.otaghDaneshjoo = otaq.otaqha[num_ot-1].sh_ot;
        }

        public static void amar_kolli()
        {
            Console.WriteLine($"tedad daneshjo ha : {tos} ");
            Console.WriteLine(new string('-', 200));
            int count = 0;
            for (int i = 0; i < tos; i++)
            {
                if (danshjos[i].khabgahDaneshjoo != null) count++;
            }
            Console.WriteLine($"tedad daneshjohaye khabgahi : {count}");
        }
        public static void list_daneshjoo_tajhizat()
        {
            Console.WriteLine("tamam tajhizat tamam daneshjooyan :");
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < tos; i++)
            {
                if (danshjos[i] != null)
                {
                    string tajhizInfo = danshjos[i].tj_st != null ? danshjos[i].tj_st.show_tajhiz() : "no tajhiz!";
                    Console.WriteLine($"{(i + 1).ToString().PadRight(4)}. {danshjos[i].fullname} : {tajhizInfo}");
                }
            }
            Console.WriteLine(new string('-', 200));
        }
        public static void gozaresh_eskan()
        {
            Console.WriteLine("gozaresh tamame eskan ha :");
            Console.WriteLine(new string('-', 200));
            for(int i=0;i<countt_gozaresh_eskan;i++)
            {
                Console.WriteLine($"{i+1} : {gozarsh_eskan[i]}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "yes";
            while(exit!="no")
            {  Console.WriteLine("shamre gozine mored nazar ?\n"+
                "   1. modiriat khabgah ha : \n" +
                "   2. modiriat bolok ha   :\n" +
                "   3. modiriat ashkhas :\n" +
                "   4. modiriat amval   :\n" +
                "   5. gozaresh giri :\n");
               var menu=Console.ReadLine();
                switch(menu)
                {
                    case "1":
                        {
                            Console.WriteLine(" chekar mikoni? \n" +
                                "   1: afzoodan khabgah \n" +
                                "   2: hazf khabgah\n" +
                                "   3: virayesh khabgah\n" +
                                "   4:moshahede list khabgah ha \n");
                            var menu_khabgah=Console.ReadLine();
                            switch(menu_khabgah)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("be tartib nam adress zarfiat name masool khabgah ra benvis :");
                                        mas_khabgah.show_all_masoolan_kh();
                                        khabgah k = new khabgah(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()),Console.ReadLine());
                                        if (mas_khabgah.find_mas_khabgah(k.mskhabgaj)== null)
                                        {
                                            Console.WriteLine("ebteda  masool khabgah ra ezafe konid !!");
                                            break;
                                        }
                                        k.add_khabgah();
                                        break;
                                    }
                                case "2":
                                    {   khabgah.show_name_khabgahs();
                                        if (khabgah.tos == 0) break;
                                        Console.WriteLine("entekhab SHOMARE khabgah baraye hazf :");
                                        int kh = int.Parse(Console.ReadLine());
                                        khabgah.remove_khabgah(khabgah.khbgh[kh-1].namekh_kh);
                                        break;
                                    }
                                case "3":
                                    {   khabgah.show_all_khabgah();
                                        if (khabgah.tos == 0) break;
                                        Console.WriteLine("entekhabe khabgah baraye virayesh (be tartib SHOMARE qabli khabgah nam address zarfiat masool khabgah jadad ) :"); 
                                        int num_kh = int.Parse(Console.ReadLine());
                                        khabgah k = new khabgah(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
                                        if (mas_khabgah.find_mas_khabgah(k.mskhabgaj) == null)
                                        {
                                            Console.WriteLine("ebteda  masool khabgah ra ezafe konid !!");
                                            break;
                                        }    
                                        k.edit_khabgah(num_kh);
                                        break;
                                    }
                                case "4":
                                    {
                                        khabgah.show_all_khabgah();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("gozine namotabar !!!!!");
                                        break;
                                    }
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine(" chekar mikoni? \n" +
                              "   1: afzoodan bolok \n" +
                              "   2: hazf bolok\n" +
                              "   3: virayesh bolok\n" +
                              "   4:moshahede list bolok ha \n");
                            var menu_bolok = Console.ReadLine();
                            switch (menu_bolok)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("be tartib nam ,tedad tabaqat ,tedad otaqha, masool bolok  ra benvis :");
                                        mas_bolok.show_all_masoolan_b();
                                        bolok bl = new bolok(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), Console.ReadLine());
                                        if(mas_bolok.find_mas_bolok(bl.mas_b)==null)
                                        {
                                            break;
                                        }
                                        bl.add_to_bolok();
                                        break;
                                    }
                                case "2":
                                    {   bolok.show_name_bolok();
                                        if (bolok.tos == 0) break;
                                        Console.WriteLine("entekhab shomare bolok baraye hazf :");
                                        int b = int.Parse(Console.ReadLine());
                                        bolok.remove_bolok(bolok.bolook[b-1].nam_b);
                                        break;
                                    }
                                case "3":
                                    {
                                        bolok.show_all_boloks();
                                        if (bolok.tos == 0)  break;
                                        Console.WriteLine("entekhabe SHOMARE bolok baraye virayesh (be  nam tedad tabaqat , tedad otaqha  va masool bolok jadad ) :");
                                        int num_bolok = int.Parse(Console.ReadLine());
                                        bolok b1 = new bolok(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), Console.ReadLine());
                                        if (mas_bolok.find_mas_bolok(b1.mas_b) == null)
                                        {
                                            Console.WriteLine("ebteda masool bolok ra ezafe konid!!");
                                            break;
                                        }
                                        b1.edit_bolok(num_bolok);
                                        break;
                                    }
                                case "4":
                                    {
                                        bolok.show_all_boloks();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("gozine namotabar !!!!!");
                                        break;
                                    }
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("gozine ra entekhab konuid :\n" +
                                "   1: modiriat masoolan khabgah \n" +
                                "   2: modiriat masoolan bolok \n" +
                                "   3: modiriat daneshjoyan\n");
                            var menu_ashkhas = Console.ReadLine();
                            switch (menu_ashkhas)
                            {
                                case "1":
                                    {
                                        Console.WriteLine(" chekar mikoni? \n" +
                                "   1: afzoodan masool khabgah \n" +
                                "   2: hazf masool khabgah\n" +
                                "   3: virayesh masool khabgah\n" +
                                "   4:moshahede list masoolan khabgah ha \n");
                                        var menu_mas_khabgah = Console.ReadLine();
                                        switch (menu_mas_khabgah)
                                        {
                                            case "1":
                                                {
                                                    Console.WriteLine("be tartib name kamel ,code melli ,shomare hamrah ,address, semat(delkhah)   ra benvis :(5)");
                                                    mas_khabgah mk = new mas_khabgah(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),Console.ReadLine());
                                                    mk.add_to_masool_kh();
                                                    break;
                                                }
                                            case "2":
                                                {
                                                    Console.WriteLine("entekhab shomare masool khabgah baraye hazf :");
                                                    mas_khabgah.show_all_masoolan_kh();
                                                    string m_kh = Console.ReadLine();
                                                    mas_khabgah.remove_from_ma_kh(m_kh);
                                                    break;
                                                }
                                            case "3":
                                                {
                                                    Console.WriteLine("entekhabe masool  khabgah baraye virayesh " +
                                                        "(be tartib nam qabli masool khabgah name kamel ,code melli ,shomare hamrah ,address, semat(delkhah)  (6)) :");
                                                    mas_khabgah.show_all_masoolan_kh();
                                                    mas_khabgah.edit_masool_kh(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                                    break;
                                                }
                                            case "4":
                                                {
                                                    mas_khabgah.show_all_masoolan_kh();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("gozine namotabar !!!!!");
                                                    break;
                                                }
                                                
                                        }
                                        break;
                                    }
                                case "2":
                                    {
                                        Console.WriteLine(" chekar mikoni? \n" +
                                          "   1: afzoodan masool bolok \n" +
                                          "   2: hazf masool bolok\n" +
                                          "   3: virayesh masool bolok\n" +
                                          "   4:moshahede list masoolan bolok ha \n");
                                        var menu_mas_bolok = Console.ReadLine();
                                        switch (menu_mas_bolok)
                                        {
                                            case "1":
                                                {
                                                    Console.WriteLine("be tartib name kamel ,code melli ,shomare hamrah ,address, semat(delkhah) ,bolok taht masooliat(delkhah)  ra benvis :(6)");
                                                    mas_bolok mb = new mas_bolok(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                                    mb.add_to_masool_bl();
                                                    break;
                                                }
                                            case "2":
                                                {
                                                    Console.WriteLine("entekhab shomare masool bolok baraye hazf :");
                                                    mas_bolok.show_all_masoolan_b();
                                                    string m_kb = Console.ReadLine();
                                                    mas_bolok.remove_from_ma_bl(m_kb);
                                                    break;
                                                }
                                            case "3":
                                                {
                                                    Console.WriteLine("entekhabe masool  bolok baraye virayesh " +
                                                        "(be tartib nam qabli masool bolok name kamel ,code melli ,shomare hamrah ,address, semat(delkhah) ,khabgah taht masooliat(delkhah) (7)) :");
                                                    mas_bolok.show_all_masoolan_b();
                                                    mas_bolok.edit_masool_bl(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                                    break;
                                                }
                                            case "4":
                                                {
                                                    mas_bolok.show_all_masoolan_b();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("gozine namotabar !!!!!");
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case "3":
                                    {
                                        Console.WriteLine("chekar mikoni? \n" +
                                            "   1: afzoodan daneshjoo\n" +
                                            "   2: hazf daneshjoo\n" +
                                            "   3: virayesh daneshjoo\n" +
                                            "   4: jostejo daneshjoo\n" +
                                            "   5: moshahede etelaat kamel daneshjoo\n" +
                                            "   6: sabtenam daneshjoo\n" +
                                            "   7: jabejaii daneshjoo\n");
                                        var menu_daneshjoo = Console.ReadLine();
                                        switch(menu_daneshjoo)
                                        {
                                            case "1":
                                                {
                                                    Console.WriteLine("name kamel ,shomare daneshjooyi ,code melli ,shomare hamrah address otaq(delkhah) bolok(delkhah) khabgah(delkhah) ,tajhizat(delkhah) ra be tartib vared konid : (9)");
                                                    daneshjoo d1 = new daneshjoo(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                                        d1.add_to_danshjo();
                                                        break;
                                                }
                                            case "2":
                                                {
                                                    Console.WriteLine("entekhab shomare aneshjoo baraye hazf :");
                                                    daneshjoo.show_name_students();
                                                    int student_num = int.Parse(Console.ReadLine());
                                                    daneshjoo.remove_from_danshjos(daneshjoo.danshjos[student_num - 1].fullname);
                                                    break;
                                                }
                                            case "3":
                                                {
                                                    Console.WriteLine("name daneshjoo va baad name kamel ,shomare daneshjooyi ,code melli ,shomare hamrah address otaq(delkhah) bolok(delkhah) khabgah(delkhah) ,tajhizat(delkhah) " +
                                                        "ra be tartib vared konid : (10)");
                                                    string nam1 = Console.ReadLine();
                                                   Console.WriteLine(daneshjoo.find_student(nam1).show_student());
                                                    daneshjoo.edit_student(nam1, Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), otaq.find_otaq(Console.ReadLine()).sh_ot,
                                                        bolok.find_bolok(Console.ReadLine()).nam_b, khabgah.find_khabgah(Console.ReadLine()).namekh_kh, tajhizat.find_tajhiz(Console.ReadLine()));
                                                    break;
                                                }
                                            case "4":
                                                {
                                                    Console.WriteLine("nam ya shomare daneshjooyi ra baraye jostejo benivisid :");
                                                    Console.WriteLine(daneshjoo.find_student(Console.ReadLine()).show_student());
                                                    break;
                                                }
                                            case "5":
                                                {
                                                    daneshjoo.show_all_daneshjooyan();
                                                    break;
                                                }
                                            case "6":
                                                {
                                                    daneshjoo.show_name_students();
                                                    int num_stu = int.Parse(Console.ReadLine());
                                                    daneshjoo.sabt_nam(daneshjoo.danshjos[num_stu - 1].fullname);
                                                    break;
                                                }
                                            case "7":
                                                {
                                                    daneshjoo.show_name_students();
                                                    int num_stu = int.Parse(Console.ReadLine());
                                                    daneshjoo.jabejaii(daneshjoo.danshjos[num_stu - 1].fullname);
                                                    break;
                                                }
                                            default:
                                                { Console.WriteLine("gozine namotabar !!!");
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                     
                            }
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("gozine ra entekhab koonid : \n" +
                                "    1: sabt amval jadid\n" +
                                "    2: takhsis amval be otaq ha \n" +
                                "    3: takhsis amval be daneshjooyan \n" +
                                "    4: modiriat jabejaii  amval \n" +
                                "    5: modiriat taamirat\n");
                            var menu_amval = Console.ReadLine();
                            switch(menu_amval)
                            {
                                case "1":
                                    {
                                        tajhizat.sabtTajhizjadid();
                                        break;
                                    }
                                case "2":
                                    {
                                        tajhizat.add_to_otaq();
                                        break;
                                    }
                                case "3":
                                    {
                                        tajhizat.add_to_student();
                                        break;
                                    }
                                case "4":
                                    {
                                        Console.WriteLine("gozine ra entekab konid :\n" +
                                            "       1: jabejaii tajhizat bein otaqha\n" +
                                            "       2: jabejaii tajhizat bein daneshjooyan\n  ");
                                        var num_jabejaii = Console.ReadLine();
                                        switch(num_jabejaii)
                                        {
                                            case "1":
                                                {
                                                    tajhizat.jabejaii_tj_otaq();
                                                    break;
                                                }
                                            case "2":
                                                {
                                                    tajhizat.jabejaii_tj_student();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("gozine namotabar!!!1");
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case "5":
                                    {
                                        Console.WriteLine("gozine ra entekhab konid : \n" +
                                            "   1:  sabte darkhast taamirat\n" +
                                            "   2:  peygiri vaziiat taamir\n" +
                                            "   3:  sabt maayob \n");
                                        var num_taamirat = Console.ReadLine();
                                        switch(num_taamirat)
                                        {
                                            case "1":
                                                {
                                                    tajhizat.shomare_amvals_show();
                                                    string sh_amvl = Console.ReadLine();
                                                    tajhizat.sabte_darkhast(sh_amvl);
                                                    break;
                                                }
                                            case "2":
                                                {
                                                    tajhizat.show_all_amval();
                                                    string amval=Console.ReadLine();
                                                    tajhizat.peygiri(amval);
                                                    break;
                                                }
                                            case "3":
                                                {
                                                    tajhizat.show_all_amval();
                                                    string amval = Console.ReadLine();
                                                    tajhizat.sabt_maayobha(amval);
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("gozine namotabar  !!!");
                                                    break;
                                                }
                                        }
                                        break;
                                    }

                            }
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("gozine ra entekhab konid : \n" +
                                "   1:  gozaresh vaziiat eskan \n" +
                                "   2:  gozaresh amval\n" +
                                "   3:  gozaresh haye takhassosi\n");
                            var num_gozaresh_ha = Console.ReadLine();
                            switch(num_gozaresh_ha)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("gozine ra entekhab konid:\n" +
                                            "   1: amar kolli eskan daneshjoyan\n" +
                                            "   2: list otaq haye por va khali\n" +
                                            "   3: zarfiat baqimande har khabgah va bolok\n");
                                        var num_eskan = Console.ReadLine();
                                        switch(num_eskan)
                                        {
                                            case "1":
                                                {
                                                    daneshjoo.amar_kolli();
                                                    break;
                                                }
                                            case "2":
                                                {
                                                    otaq.full_or_empty();
                                                    break;
                                                }
                                            case "3":
                                                {
                                                    bolok.zrf_bolok();
                                                    khabgah.zrf_kh();
                                                    break;
                                                }
                                            default:
                                                { Console.WriteLine("gozine namotabar !!!");
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case "2":
                                    {
                                        Console.WriteLine("gozine ra entekhab konid :\n" +
                                            " 1:    list kamel amval\n" +
                                            " 2:    amval takhsis dade shode be har otaq\n" +
                                            " 3:    amval takhsis dade shode be har daneshjoo\n" +
                                            " 4:    amval mayob va darhale tamir\n");
                                        var num_g_amval =  Console.ReadLine();
                                        switch(num_g_amval)
                                        {
                                            case "1":
                                                {
                                                    tajhizat.show_all_amval();
                                                    break;
                                                }
                                            case "2":
                                                {
                                                    otaq.list_otaq_tajhizat();
                                                    break;
                                                }
                                            case "3":
                                                {
                                                    daneshjoo.list_daneshjoo_tajhizat();
                                                    break;
                                                }
                                            case "4":
                                                {
                                                    tajhizat.list_mayobs_drhaltamir();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("gozine namotabar !!!!");
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case "3":
                                    {
                                        Console.WriteLine("gozine ra entekhab konid :\n" +
                                            "1:     gozaresh darkhast haye taamir\n" +
                                            "2      gozaresh tarikhche eskan ");
                                        var menu_gozaresh_ha = Console.ReadLine();
                                        switch(menu_gozaresh_ha)
                                        {
                                            case "1":
                                                {
                                                    tajhizat.gozaresh_darkhast_tamirat();
                                                    break;
                                                }
                                            case "2":
                                                {
                                                    daneshjoo.gozaresh_eskan();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("gozine na motabar !!!");
                                                    break;
                                                }
                                        }
                                        break;
                                    }

                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("gozine na motabar !!!");
                            break;
                        }
                }
                Console.WriteLine("do yo wanna contiue?");
                exit = Console.ReadLine();
            }
        }
    }
}
