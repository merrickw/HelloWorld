using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
			/* Add a + b = c and set label to display c */
			/* and more comments! */
			
			/* Master: And now we're adding a change to master, with no regard for feature */		
			/* Master: Moving master forward */
			/* Master: One more master change, should become HEAD */			
			/* Feature: And now we're adding a feature on feature branch */

            decimal a = decimal.Parse(txtFirst.Text);
            decimal b = decimal.Parse(txtSecond.Text);
            decimal c = a + b;
            lblAnswer.Text = c.ToString();
        }
    }
}