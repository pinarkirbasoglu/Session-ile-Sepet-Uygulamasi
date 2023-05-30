using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SepetUygulamasi
{
    public class Urun
    {
        private int urun_no;
        private string urun_ad;
        private int adet;

        public Urun()
        {
        }

        public int Urun_no { get => urun_no; set => urun_no = value; }
        public string Urun_ad { get => urun_ad; set => urun_ad = value; }
        public int Adet { get => adet; set => adet = value; }

        public Urun(int urun_no, string urun_ad, int adet)
        {
            this.Urun_no = urun_no;
            this.Urun_ad = urun_ad;
            this.Adet = adet;
        }

        public string urad()
        {
            return Urun_ad;
        }
        public int urno()
        {
            return Urun_no;
        }
    }
}