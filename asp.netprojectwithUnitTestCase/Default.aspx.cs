using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.netprojectwithUnitTestCase
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Add(object sender, EventArgs e)
        {
            MathOperator math = new MathOperator();
            int num1 = int.Parse(txtfirstNumber.Text);
            int num2 = int.Parse(txtsecondNumber.Text);
            lblvalue.Text= math.Add(num1, num2).ToString();
        }
    }
}