using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontRowCollaboration
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            ds.ReadXml(@"C:\Users\Administrator\Source\Repos\FrontRowCollaboration\FrontRowCollaboration\bin\highscore.xml");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}