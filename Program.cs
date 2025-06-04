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

        protected string[] khabgah_kh;
        public string[] khbg
        {
            get { return khabgah_kh; }
            set { khabgah_kh = value; }
        }
        protected int tos;
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
            khabgah_kh = new string[zarfiat_kh];
            tos = 0;

        }
        public string show_kh(string n, string add, int z, mas_khabgah mk)
        {
            return $"name:{n} address : {add} zarfiat : {z} and masool : {mk.showmasoolkh()}";
        }
        public void add_khabgah(string n, string add, int z, mas_khabgah mk)
        {
            if (tos < khabgah_kh.Length)
            {
                khabgah_kh[tos] = show_kh(n, add, z, mk);
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
                    if (khabgah_kh[i].Contains(kh))
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

                if (khabgah_kh[i].Contains(n1))
                {
                    khabgah_kh[i] = show_kh(n2, add2, z2, mk2); edited = true;
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
                    Console.WriteLine($"{i + 1} : {khabgah_kh[i]} ");
                    Console.WriteLine(new string('-', 100));
                }
            }
        }
        public void show_name_khabgahs()
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
                string kh = khabgah_kh[i];
                int end = kh.IndexOf("address");


                Console.WriteLine($"{i + 1} : {kh.Substring(5, end - 5).Trim()}");
                Console.WriteLine(new string('-', 45));
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
        protected mas_bolok mb_b;
        public mas_bolok mas_b
        {
            get { return mb_b; }
            set { mb_b = value; }
        }
        protected string[] boloks_b;
        protected int tos;
        public bolok(string name_b, int tabaqat_b, int otaq, mas_bolok mb_b)
        {
            this.name_b = name_b;
            this.tabaqat_b = tabaqat_b;
            this.otaq_b = otaq;
            this.mb_b = mb_b;
            boloks_b = new string[tabaqat_b * otaq];
            tos = 0;
        }

        public string show_bolok(string name_b, int tabaqat_b, int otaq, mas_bolok mb_b)
        {
            return $"name : {name_b} tabaqat : {tabaqat_b} tedad otaq : {otaq_b} masool blolok : {mb_b.show_mb()} ";
        }
        public void add_to_bolok(string name_b, int tabaqat_b, int otaq, mas_bolok mb_b)
        {
            if (tos < boloks_b.Length)
            {
                boloks_b[tos] = show_bolok(name_b, tabaqat_b, otaq, mb_b);
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
                    if (boloks_b[i].Contains(bl))
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

                if (boloks_b[i].Contains(n1))
                {
                    boloks_b[i] = show_bolok(n2, tab, ot, mb2); edited = true;
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
                    Console.WriteLine($"{i + 1} : {boloks_b[i]} ");
                    Console.WriteLine(new string('-', 200));
                }
            }
        }
        public void show_name_bolok()
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
                string bl = boloks_b[i];
                int end = bl.IndexOf("tabaqat");


                Console.WriteLine($"{i + 1} : {bl.Substring(6, end - 6).Trim()} ");
                Console.WriteLine(new string('-', 50));
            }
        }



    }
    class otaq
    {
        protected int shomare_ot;
        protected int tabaqe_ot;
        protected int zarfiat_ot;
        public otaq(int shomare_ot, int tabaqe_ot, int zarfiat_ot)
        {
            this.shomare_ot = shomare_ot;
            this.tabaqe_ot = tabaqe_ot;
            this.zarfiat_ot = zarfiat_ot;
        }

    }

    class tajhizat
    {
        protected tajhizt_item tajhizat_taj;
        protected string patnumber_taj;
        public tajhizat(tajhizt_item tajhizat_taj, string patnumber_taj)
        {
            this.tajhizat_taj = tajhizat_taj;
            this.patnumber_taj = patnumber_taj;
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
                Console.WriteLine("the bolok is full ");
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
        public static void show_all_masoolan()
        {
            Console.WriteLine("Masoolan Khabgah:");
            Console.WriteLine(new string('_', 200));
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
        public mas_bolok(string fullname_per, string code_melli_per, string phone_number_per, string address_per, string semat_mb, string sbolok_mb)
        : base(fullname_per, code_melli_per, phone_number_per, address_per)
        {
            this.semat_mb = semat_mb;
            this.sbolok_mb = sbolok_mb;
        }
        public string show_mb()
        {
            return base.showperson() + $"semat : {semat_mb} bolok tahte masooliat : {sbolok_mb}";
        }

    }

    class daneshjoo : person
    {
        protected string studentNumber;
        protected otaq otaghDaneshjoo;
        protected bolok bolokDaneshjoo;
        protected khabgah khabgahDaneshjoo;
        protected List<tajhizat> tajhizatList;

        public daneshjoo(
            string fullname_per,
            string code_melli_per,
            string phone_number_per,
            string address_per,
            string studentNumber,
            otaq otaghDaneshjoo,
            bolok bolokDaneshjoo,
            khabgah khabgahDaneshjoo,
            List<tajhizat> tajhizatList
        ) : base(fullname_per, code_melli_per, phone_number_per, address_per)
        {
            this.studentNumber = studentNumber;
            this.otaghDaneshjoo = otaghDaneshjoo;
            this.bolokDaneshjoo = bolokDaneshjoo;
            this.khabgahDaneshjoo = khabgahDaneshjoo;
            this.tajhizatList = tajhizatList;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
