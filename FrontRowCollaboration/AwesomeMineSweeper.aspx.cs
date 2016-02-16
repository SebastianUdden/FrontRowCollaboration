using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace FrontRowCollaboration
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        List<ImageButton> lb = new List<ImageButton>();

        protected void Page_Load(object sender, EventArgs e)
        {

            SweeperGame game = new SweeperGame();
            int gridSize = 54;

            if (!IsCallback)
            {
                createGameField(gridSize);

                try {
                    game.GenerateRandomMines(gridSize);
                } catch (Exception ex) { Debug.WriteLine(ex.Message); }
            }

        }

        protected void createGameField(int gridSize)
        {
            ImageButton tb = new ImageButton();
            

            for (int i = 1; i <= gridSize; i++)
            {
                tb = new ImageButton();
                tb.ID = "Btn" + i.ToString();
                tb.Width = 40;
                tb.Height = 40;
                tb.BackColor = System.Drawing.Color.White;

                tb.ImageUrl = "http://reform.no/wp-content/uploads/2014/07/582616_468039903243747_963752385_n.jpg";

                gameField.Controls.Add(tb);
                lb.Add(tb);
                    
            }

            gameField.Width = (int) (gridSize * 6.67);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //some testing
            lb.ElementAt(0).ImageUrl = "";
            lb.ElementAt(2).ImageUrl = "";
            lb.ElementAt(5).ImageUrl = "";

        }
    }
}