using System;
using System.Collections.Generic;
using System.Linq;
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
        sakem = 0, maayob, darhaletaamir
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
        protected mas_khabgah m_kh;
        public mas_khabgah mskhabgaj
        {
            get { return m_kh; }
            set { m_kh = value; }
        }

        protected static khabgah[] khabgah_kh = new khabgah[1000];
        public khabgah[] khbg
        {
            get { return khabgah_kh; }
            set { khabgah_kh = value; }
        }
        protected static int tos = 0;
        public int ts
        {
            get { return tos; }
        }
        public khabgah(string nmae_kh, string address_kh, int zarfiat_kh, mas_khabgah kh)
        {
            this.name_kh = nmae_kh;
            this.address_kh = address_kh;
            this.zarfiat_kh = zarfiat_kh;
            m_kh = kh;


        }
        public string show_kh()
        {
            return $"name:{this.name_kh} address : {this.address_kh}  zarfiat :  {this.zarfiat_kh}  and masool :  {this.m_kh.showmasoolkh()}";
        }
        public void add_khabgah()
        {
            if (tos < khabgah_kh.Length)
            {
                khabgah k = new khabgah(this.name_kh, this.address_kh, this.zarfiat_kh, this.m_kh);
                khabgah_kh[tos] = k;
                tos++;
            }
            else
            {
                Console.WriteLine("khabgah is full !!!");
            }
        }
        public void remove_khabgah(string kh)
        {
            if (tos != 0)
            {
                bool found = false;
                for (int i = 0; i < tos; i++)
                {
                    if (khabgah_kh[i].show_kh().Contains(kh))
                    {
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
        public void edit_khabgah(string n1, string n2, string add2, int z2, mas_khabgah mk2)
        {
            bool edited = false;
            for (int i = 0; i < tos; i++)
            {

                if (khabgah_kh[i].show_kh().Contains(n1))
                {
                    khabgah k2 = new khabgah(n2, add2, z2, mk2);
                    khabgah_kh[i] = k2; edited = true;
                }

            }
            if (!edited) Console.WriteLine("no found to edit !!! ");
        }
        public void show_all_khabgah()
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

            if (khabgah_kh == null || khabgah_kh.Length == 0)
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
        protected mas_bolok mb_b;
        public mas_bolok mas_b
        {
            get { return mb_b; }
            set { mb_b = value; }
        }
        protected static bolok[] boloks_b = new bolok[1000];
        protected static int tos = 0;
        public bolok(string name_b, int tabaqat_b, int otaq, mas_bolok mb_b)
        {
            this.name_b = name_b;
            this.tabaqat_b = tabaqat_b;
            this.otaq_b = otaq;
            this.mb_b = mb_b;
        }

        public string show_bolok()
        {
            return $"name : {this.name_b} tabaqat : {this.tabaqat_b} tedad otaq : {this.otaq_b} masool blolok : {this.mb_b.show_mb()} ";
        }
        public void add_to_bolok(string name_b, int tabaqat_b, int otaq, mas_bolok mb_b)
        {
            if (tos < boloks_b.Length)
            {
                bolok b1 = new bolok(name_b, tabaqat_b, otaq, mb_b);
                boloks_b[tos] = b1;
                tos++;
            }
            else
            {
                Console.WriteLine("the bolok is full ");
            }
        }
        public void remove_bolok(string bl)
        {
            if (tos != 0)
            {
                bool found = false;
                for (int i = 0; i < tos; i++)
                {
                    if (boloks_b[i].show_bolok().Contains(bl))
                    {
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
        public void edit_bolok(string n1, string n2, int tab, int ot, mas_bolok mb2)
        {
            bool edited = false;
            for (int i = 0; i < tos; i++)
            {

                if (boloks_b[i].show_bolok().Contains(n1))
                {
                    bolok b2 = new bolok(n2, tab, ot, mb2);
                    boloks_b[i] = b2; edited = true;
                }

            }
            if (!edited) Console.WriteLine("no found to edit !!! ");
        }
        public void show_all_boloks()
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

            if (boloks_b == null || boloks_b.Length == 0)
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



    }
    class otaq
    {
        protected int shomare_ot;
        public int sh_ot
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
        protected int zarfiat_ot;
        public int zrf_ot
        {
            get { return zarfiat_ot; }
            set { zarfiat_ot = value; }
        }
        public static otaq[] otaqha = new otaq[1000];
        public static int tos = 0;
        public otaq(int shomare_ot, int tabaqe_ot, int zarfiat_ot = 6)
        {
            this.shomare_ot = shomare_ot;
            this.tabaqe_ot = tabaqe_ot;
            this.zarfiat_ot = zarfiat_ot;
        }
        public string otaq_tostr()
        {
            return $" shomare otaq: {shomare_ot} tabaqe : {tabaqe_ot} zarfiat : {zarfiat_ot}  ";
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
        protected static int tos = 0;
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
            tajhizt_item noe = (tajhizt_item)int.Parse(Console.ReadLine());

            Console.WriteLine("Part Number : (001 - 005):");
            string partnum = Console.ReadLine();
            Console.WriteLine("shomare amval : (8number) ");
            string shmare_amval = Console.ReadLine();
            tajhizat jadid = new tajhizat(noe, partnum, shmare_amval);
            jadid.add_to_tajhizat();

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
            return $"fullname : {fullname_per} code melli : {code_melli_per} phone number : {phone_number_per} address : {address_per}";
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
        public mas_khabgah(string fullname_per, string code_melli_per, string phone_number_per, string address_per, string semat, string skhabgah = "??")
    : base(fullname_per, code_melli_per, phone_number_per, address_per)
        {
            this.semat_mk = semat;
            this.skhabgah_mk = skhabgah;

        }
        public string showmasoolkh()
        {
            return base.showperson() + $"semat : {this.semat_mk} khabgah tahte masooliat : {this.skhabgah_mk}";
        }
        public void add_to_masool_kh()
        {
            if (tos < masoolan_kh.Length)
            {
                mas_khabgah new_masool = new mas_khabgah(this.fullname_per, this.code_melli_per, this.phone_number_per, this.address_per, this.semat_mk, this.skhabgah_mk);
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

        public static void edit_masool_kh(string n1, string fullname_per, string code_melli_per, string phone_number_per, string address_per, string semat, string skhabgah = "??")
        {
            bool edited = false;
            for (int i = 0; i < tos; i++)
            {

                if (masoolan_kh[i].showmasoolkh().Contains(n1))
                {
                    mas_khabgah new_masool = new mas_khabgah(fullname_per, code_melli_per, phone_number_per, address_per, semat, skhabgah);
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
        //protected List<tajhizat> tajhizatList;
        protected static daneshjoo[] danshjos = new daneshjoo[1000];
        protected static int tos = 0;
        public daneshjoo(string fullname_per, string studentNumber, string code_melli_per, string phone_number_per, string address_per, string ot_d = null, string bl_d = null, string kh_d = null) :
            base(fullname_per, code_melli_per, phone_number_per, address_per)
        {
            this.studentNumber = studentNumber;
            this.ot_daneshjo = ot_d;
            this.bolokDaneshjoo = bl_d;
            this.khabgahDaneshjoo = kh_d;
        }
        public string show_student()
        {
            return base.showperson() + $"  shmare daneshjooii: {this.studentNumber} and khabgah {this.khabgahDaneshjoo} bolok {this.bolokDaneshjoo} otaq {this.ot_daneshjo} ";
        }

        public void add_to_danshjo()
        {
            if (tos < danshjos.Length)
            {
                if (daneshjoo.find_student(this.studentNumber) == null)
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
                return null;
            }

            for (int i = 0; i < tos; i++)
            {
                if (danshjos[i].fullname == n || danshjos[i].studentNumber == n)
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
        public void sabt_nam(string fullname)
        {
            daneshjoo d = find_student(fullname);
            if (d == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            khabgah.show_name_khabgahs();
            Console.WriteLine("select khabgah :");
            string kh = Console.ReadLine();
            var kh2 = khabgah.find_khabgah(kh);
            if (kh2 == null)
            {
                Console.WriteLine("Khabgah not found!");
                return;
            }
            string k2 = kh2.namekh_kh;
            bolok.show_name_bolok();
            Console.WriteLine("select bolok : ");
            string bl = Console.ReadLine();
            var b2 = bolok.find_bolok(bl);
            if (b2 == null)
            {
                Console.WriteLine("Bolok not found!");
                return;
            }
            string bolok2 = b2.nam_b;
            Console.WriteLine("select otaq : ");
            string ot = Console.ReadLine();

            d.khabgahDaneshjoo = k2;
            d.bolokDaneshjoo = bolok2;
            d.otaghDaneshjoo = ot;

            Console.WriteLine("sabtenam movafaqiat amiz :) ");
        }
        public void jabejaii(string fullname)
        {
            daneshjoo d1 = find_student(fullname);
            if (d1 == null)
            {
                Console.WriteLine("student not found !!");
                return;
            }
            Console.WriteLine(d1.show_student());
            Console.WriteLine("be tartib khabgah bolok va otaq ra begooid");
            d1.kh_daneshjo = Console.ReadLine();
            d1.bolokDaneshjoo = Console.ReadLine();
            d1.otaghDaneshjoo = Console.ReadLine();

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
