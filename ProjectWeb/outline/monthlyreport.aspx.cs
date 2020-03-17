using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shamim_monthlyreport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dijel.Text = "ডিজেল";
        petrol.Text = "পেট্রোল";
        octen.Text = "অকটেন";
        mobil.Text = "মোবিল";
        supervtin.Text = "সুপার ভি (টিন)";
        supervbalti.Text = "সুপার ভি বালতি (১৫ লিঃ)";
        GTX.Text = "জি.টি.এক্স (১ লিঃ)";
        HD_40.Text = "এইচ ডি-৪০ (টিন)";
        GO5L.Text = "৫ লিঃ গিয়ার অয়েল";
        GO4L.Text = "৪ লিঃ গিয়ার অয়েল";
        GO1L.Text = "১ লিঃ গিয়ার অয়েল";
        breakOil.Text = "ব্রেক অয়েল (টিন)";
        mobil2T.Text = "২-টি মবিল (টিন)";
        visco3000.Text = "ভিসকো-৩০০০ টিঃ";
        gris1.Text = "১ নং গ্রীজ (পাউন্ড)";
        gris2.Text = "২ নং গ্রীজ (পাউন্ড)";
        gris3.Text = "৩ নং গ্রীজ (পাউন্ড)";
        gris4.Text = "৪ নং/কৌটা গ্রীজ (পাউন্ড)";
        lpg.Text = "এল পি জি (সিলিঃ)";
        ho.Text = "হাইড্রোলিক অয়েল";
        bp.Text = "ব্যাটারী পানি";
        cw.Text = "কুলেন্ট ওয়াটার";
        sto.Text = "পাওঃ ষ্ট্যারিং অয়েল";
        df.Text = "ডিঃ ফিল্টার";
        mf.Text = "মোবিল ফিল্টার";
        lf.Text = "লিলেন্ড ফিল্টার সেট";
        tf.Text = "টাটা ফিল্টার সেট";
        zp.Text = "কাপড়ের ঝুট";
        dsm.Text = "Delo Silver";
        fo.Text = "Flashing Oil";
        mbf.Text = "Eicher M/F";
        bbf.Text = "Eicher B/F";


        TextBox1.Text = Session["mdate1"].ToString();
        TextBox2.Text = Session["mdate2"].ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("monthly.aspx");
    }
}