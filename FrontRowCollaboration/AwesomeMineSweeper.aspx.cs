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
        List<ImageButton> ListOfButtons;

        protected void Page_Load(object sender, EventArgs e)
        {
            int gridSize = 49;
            SweeperGame game = new SweeperGame();
            ListOfButtons = new List<ImageButton>();

            createGameField(gridSize);

        }

        protected void bStartNewGame_Click(object sender, EventArgs e)
        {
            int gridSize = 49;
            StartNewGame(gridSize);
        }

        protected void StartNewGame(int gridSize)
        {

            Debug.WriteLine("Created gamefield");

            SweeperGame game = new SweeperGame();

            try
            {
                if (ListOfButtons != null)
                {
                    game.GenerateRandomMines(ListOfButtons);
                    Debug.WriteLine("Generated random");
                }
                else
                    Debug.WriteLine("BUTTON IS NULL");

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }

        }

        protected void createGameField(int gridSize)
        {
            ImageButton tb = new ImageButton();
            
            for (int i = 1; i <= gridSize; i++)
            {
                tb = new ImageButton();
                tb.ID = i.ToString();
                tb.Width = 40;
                tb.Height = 40;
                tb.BackColor = System.Drawing.Color.White;

                tb.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/c/c7/Minesweeper_unopened_square.svg";

                tb.Click += new ImageClickEventHandler(this.Button_Click);

                gameField.Controls.Add(tb);

                Debug.WriteLine("Adding list of buttons");
                ListOfButtons.Add(tb);
            }

            gameField.Width = (int)(Math.Sqrt(gridSize) * 40);
            gameField.Height = gameField.Width;
        }

        protected void Button_Click(object sender, EventArgs e)
        {

            ImageButton clickedButton = (ImageButton)sender;


            int thisID = Convert.ToInt32(clickedButton.ID);
            
            if(clickedButton.AlternateText == "X")
            {
                clickedButton.ImageUrl = @"http://media2.androidappsgame.com/1/214881/com-jipsaan-minesweeper-214881.jpg";
                clickedButton.ToolTip = "clicked";
            }

            else
            {
                clickedButton.ImageUrl = "";
            }

            UpdateGameField();

        }

        protected void UpdateGameField()
        {
            
            foreach(ImageButton ib in ListOfButtons)
            {
                
                if (ib.ToolTip == "clicked")
                {
                    if(ib.AlternateText == "X")
                    {
                            
                    }
                    else if (ib.AlternateText == "2")
                    {
                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/e/e1/Minesweeper_questionmark.svg";
                    }
                    else if (ib.AlternateText == "3")
                    {
                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Minesweeper_0.svg/76px-Minesweeper_0.svg.png";
                    }
                    else if (ib.AlternateText == "1")
                    {

                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/8/83/Minesweeper_flag.svg";
                    }
                    else
                    {

                    }
                }
            }
        }
        protected void EasyMode()
        {
            
        }
    }
}