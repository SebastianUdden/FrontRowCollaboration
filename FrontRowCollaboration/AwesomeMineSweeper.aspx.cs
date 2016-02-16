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
                    game.GenerateRandomMines(ListOfButtons, (ListOfButtons.Count() / 3));
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
            
            clickedButton.ToolTip = "clicked";

            int thisID = Convert.ToInt32(clickedButton.ID);
            
            if(clickedButton.AlternateText == "X")
            {
                
                ShowLoserField();

                clickedButton.ImageUrl = "";
                clickedButton.AlternateText = "BOM";
                
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
                        ib.ImageUrl = "";
                        ib.AlternateText = "X";

                    }
                    else if (ib.AlternateText == "2")
                    {
                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/4/44/Minesweeper_2.svg";
                    }

                    else if (ib.AlternateText == "3")
                    {
                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/0/08/Minesweeper_3.svg";
                    }

                    else if (ib.AlternateText == "4")
                    {
                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/4/4f/Minesweeper_4.svg";
                    }

                    else if (ib.AlternateText == "5")
                    {
                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/4/46/Minesweeper_5.svg";
                    }
                    

                    else if (ib.AlternateText == "1")
                    {

                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/c/ca/Minesweeper_1.svg";
                    }
                    else
                    {
                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/8/80/Minesweeper_0.svg";
                    }
                }
            }
        }


        protected void ShowLoserField()
        {
            foreach (ImageButton ib in ListOfButtons)
            {
                if (ib.AlternateText == "X")
                {

                    ib.ImageUrl = @"http://media2.androidappsgame.com/1/214881/com-jipsaan-minesweeper-214881.jpg";
                }

                else if (ib.AlternateText == "2")
                {
                    ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/4/44/Minesweeper_2.svg";
                }
                else if (ib.AlternateText == "3")
                {
                    ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/0/08/Minesweeper_3.svg";
                }

                else if (ib.AlternateText == "4")
                {
                    ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/4/4f/Minesweeper_4.svg";
                }

                else if (ib.AlternateText == "5")
                {
                    ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/4/46/Minesweeper_5.svg";
                }
                else if (ib.AlternateText == "6")
                {
                    ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/c/cc/Minesweeper_6.svg";
                }

                else if (ib.AlternateText == "1")
                {
                    ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/c/ca/Minesweeper_1.svg";
                }
                else
                {
                    ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/8/80/Minesweeper_0.svg";
                }
                

            }
        }

        protected void EasyMode()
        {
            
        }
    }
}