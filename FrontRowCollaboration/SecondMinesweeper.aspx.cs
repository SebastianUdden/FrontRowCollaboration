using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FrontRowCollaboration
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //XDocument doc = XDocument.Load("\\FrontRowCollaboration\\highscore.xml");

            //var rows = doc.Descendants("root").Select(el => new()
            //{
            //    Answer1 = el.Element("Answer1").Value,
            //    Answer2 = el.Element("Answer2").Value,
            //    Answer3 = el.Element("Answer3").Value,
            //    Answer4 = el.Element("Answer4").Value,
            //});

            DataSet ds = new DataSet();
            ds.ReadXml("\\FrontRowCollaboration\\highscore.xml");
            GridView3.datasource = ds;
            GridView3.databind();

        }
    }
}