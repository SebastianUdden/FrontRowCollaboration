using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontRowCollaboration
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ImageButton tb = new ImageButton();
            List<ImageButton> lb = new List<ImageButton>();

            for(int i = 1; i <= 12; i++)
            {
                tb = new ImageButton();
                tb.ID = "Btn" + i.ToString();
                tb.Width = 40;
                tb.Height = 40;
                tb.BackColor = System.Drawing.Color.White;

                tb.ImageUrl = "http://reform.no/wp-content/uploads/2014/07/582616_468039903243747_963752385_n.jpg";

                gamePanel.Controls.Add(tb);
            }

            gamePanel.Width = 160;

            
        }

    }
}