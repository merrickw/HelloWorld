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
<<<<<<< HEAD
			
			/* Master: And now we're adding a change to master, with no regard for feature */		
			/* Master: Moving master forward */
			/* Master: One more master change, should become HEAD */			
			/* Feature: And now we're adding a feature on feature branch */
			/* Feature: And now we're adding a feature on feature branch */			
			/* Feature: Moving feature ahead as well */
			/* Feature: Moving feature ahead as well */
			/* Feature: And more feature changes */
			/* Feature: Moving feature ahead as well */
			/* Feature: And more feature changes */
			/* Feature: pushing feature ahead */
			
			/* Change for git extensions*/
=======
			/* And now we're adding a feature on feature branch */
			
			/* Moving feature ahead as well */
			/* And more feature changes */
			/* pushing feature ahead */
>>>>>>> c533af7a350a18c65781abfca2ef5c5d061d0fb9
			
            decimal a = decimal.Parse(txtFirst.Text);
            decimal b = decimal.Parse(txtSecond.Text);
            decimal c = a + b;
            lblAnswer.Text = c.ToString();
        }
    }
}