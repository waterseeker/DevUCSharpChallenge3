using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpChallenge3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultImage.ImageUrl = "Images/pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                resultImage.ImageUrl = "Images/pen.png";
            }
            else if (phoneRadioButton.Checked)
            {
                resultImage.ImageUrl = "Images/phone.png";
            }
            else  
            {
                resultImage.ImageUrl = "Images/tablet.png";
            }
        }
    }
}