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
            string path = HttpContext.Current.Request.MapPath("~/highscore.xml");

            DataSet ds = new DataSet();
            ds.ReadXml(path);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}