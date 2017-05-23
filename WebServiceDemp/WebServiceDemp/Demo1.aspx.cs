using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceDemp
{
    public partial class Demo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
              WebServiceDemp.cn.com.webxml.www.WeatherWebService ws = new WebServiceDemp.cn.com.webxml.www.WeatherWebService();
              string[] r = ws.getWeatherbyCityName(this.TextBox1.Text);
              this.TextBox2.Text = "";
              if (r == null)
              {
                  this.TextBox2.Text = "无" + this.TextBox1.Text + "城市的天气信息";
                  return;
             }
             foreach (string i in r)
             {
                 this.TextBox2.Text += i;
             }
        }
    }
}