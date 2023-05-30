using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SepetUygulamasi
{
    public partial class SepetinSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Urun> musteri_sepeti = (List<Urun>)Session["sepet"];
            Response.Write("<table border=1><tr><td>no</td><td>ad</td><td>adet</td></tr>");
            foreach(Urun ekran in musteri_sepeti)
            {
                 Response.Write("<tr><td>" + ekran.Urun_no + "</td><td>" + ekran.Urun_ad + "</td><td>" + ekran.Adet + "</td></tr>");
            }
            Response.Write("</table>");
        }
    }
}