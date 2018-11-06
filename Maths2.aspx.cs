using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Default2 : System.Web.UI.Page
{
    protected void Btn_fairedesmaths_Click(object sender, EventArgs e)
    {
        double a, b, c, d, f, i, j, k, l;
        a = double.Parse(Nb_1.Text);
        b = double.Parse(Nb_2.Text);
        c = double.Parse(Nb_3.Text);
        d = double.Parse(Nb_4.Text);
        f = a + b + c + d;
        TextBox1.Text = f.ToString();
        //g = if (a < b && a < c && a < d) ;
        //return a;
        //else if 
        //TextBox2.Text = g.ToString();
        //h
        //TextBox3.Text = h.ToString();

        i = Math.Sqrt(a);
        TextBox4.Text = i.ToString();
        j = Math.Sqrt(b);
        TextBox5.Text = j.ToString();
        k = Math.Sqrt(c);
        TextBox6.Text = k.ToString();
        l = Math.Sqrt(d);
        TextBox7.Text = l.ToString();

        //erreur : donne racine carre
        
    }

       
    protected void Nb_1_TextChanged(object sender, EventArgs e)
    {
        Nb_1.Text = Server.HtmlEncode(Nb_1.Text);
    }



    protected void Nb_2_TextChanged(object sender, EventArgs e)
    {
        Nb_2.Text = Server.HtmlEncode(Nb_2.Text);
    }



    protected void Nb_3_TextChanged(object sender, EventArgs e)
    {
        Nb_3.Text = Server.HtmlEncode(Nb_3.Text);
    }

    protected void Nb_4_TextChanged(object sender, EventArgs e)
    {
        Nb_4.Text = Server.HtmlEncode(Nb_4.Text);
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Server.HtmlEncode(TextBox1.Text);
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Server.HtmlEncode(TextBox2.Text);
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        TextBox3.Text = Server.HtmlEncode(TextBox3.Text);
    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        TextBox4.Text = Server.HtmlEncode(TextBox4.Text);
    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {
        TextBox5.Text = Server.HtmlEncode(TextBox5.Text);
    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {
        TextBox6.Text = Server.HtmlEncode(TextBox6.Text);
    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
        TextBox7.Text = Server.HtmlEncode(TextBox7.Text);
    }
}
