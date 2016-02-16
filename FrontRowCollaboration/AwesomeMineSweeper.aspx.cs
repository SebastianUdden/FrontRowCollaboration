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
        List<ImageButton> ListOfButtons = new List<ImageButton>();

        protected void Page_Load(object sender, EventArgs e)
        {
            SweeperGame game = new SweeperGame();
            int gridSize = 49;

            if (!IsCallback)
            {
                createGameField(gridSize);

                try
                {
                    if(ListOfButtons != null)
                        game.GenerateRandomMines(ListOfButtons);
                    
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
                ListOfButtons.Add(tb);
                    
            }

            gameField.Width = (int)(Math.Sqrt(gridSize) * 40);
            gameField.Height = gameField.Width;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //some testing
            ListOfButtons.ElementAt(0).ImageUrl = "";
            ListOfButtons.ElementAt(2).ImageUrl = "";
            ListOfButtons.ElementAt(5).ImageUrl = "";
        }
    }
}