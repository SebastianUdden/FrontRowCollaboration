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

                tb.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/c/c7/Minesweeper_unopened_square.svg";

                tb.Click += new ImageClickEventHandler(this.Button_Click);

                gameField.Controls.Add(tb);
                ListOfButtons.Add(tb);
                    
            }

            gameField.Width = (int)(Math.Sqrt(gridSize) * 40);
            gameField.Height = gameField.Width;

        }

        protected void Button_Click(object sender, EventArgs e)
        {

            foreach(ImageButton ib in ListOfButtons)
            {
                   ib.ToolTip = ib.AlternateText;
            }

            ImageButton clickedButton = (ImageButton) sender;

            Debug.WriteLine("Sender is: " + clickedButton.ID);
            Debug.WriteLine("Status is: " + clickedButton.AlternateText);

        }
    }
}