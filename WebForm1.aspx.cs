using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SepetUygulamasi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bir verinin bir yere veri tabanı veya bir koleksiyon veya dizide
            //kaç tane olduğunu bulmak için veri kayıt edilmeden önce vt de
            //veya koleksiyonda önce kontrol edilir kontrollü kayıttır adı bunu o şekilde kayıt edilir.
            //veriyi aldıktan sonra bakıp onu silme işlemi zordur.
            List<Urun> musteri_sepeti = new List<Urun>();
            if (Session["sepet"] != null)//seçili ürünleri sessionda tuturcaz her ürün seçiminde de yeni liste oluşturuloyr o yüzden session boş değilse müşteri listesine eklesin içerikleri
            {
                musteri_sepeti = (List<Urun>)Session["sepet"];
            }
            int no = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            bool kontrol = false;
            foreach (Urun gelen in musteri_sepeti)
            {
                if(gelen != null)
                {
                    if(gelen.Urun_no == no)
                    {
                        kontrol = true;
                        break;
                    }
                }
            }
            if (kontrol == false)
            {
                Urun yeni = new Urun(no, DropDownList1.SelectedItem.Text, 1);
                musteri_sepeti.Add(yeni);
            }
            else if(kontrol ==true)
            {
                foreach(Urun artir in musteri_sepeti)
                {
                    if(artir.Urun_no ==no)
                    {
                        artir.Adet++;
                    } 
                }
            }
            Session["sepet"] = musteri_sepeti;
            Response.Redirect("SepetinSayfasi.aspx");
        }
    }
}