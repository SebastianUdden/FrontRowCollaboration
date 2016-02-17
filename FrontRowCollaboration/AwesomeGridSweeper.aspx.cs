using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace FrontRowCollaboration
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        List<ImageButton> ListOfButtons;

        protected void Page_Load(object sender, EventArgs e)
        {
            int gridSize = 49;
            Debug.WriteLine("PAGE LOADED ******* \n\n");
            try { 
                gridSize = Convert.ToInt32(txGridSize.Text) * Convert.ToInt32(txGridSize.Text);
            } catch(Exception ex) { }

            SweeperGame game = new SweeperGame();
            ListOfButtons = new List<ImageButton>();
            createGameField(gridSize);

        }

        protected void bStartGame_Click(object sender, EventArgs e)
        {

            gameField.Controls.Clear();
            createGameField(Convert.ToInt32(txGridSize.Text) * Convert.ToInt32(txGridSize.Text));
            StartNewGame(Convert.ToInt32(txGridSize.Text) * Convert.ToInt32(txGridSize.Text));
            
        }

        protected void StartNewGame(int gridSize)
        {
            Debug.WriteLine("Created gamefield");

            SweeperGame game = new SweeperGame();

            int minesCount = ListOfButtons.Count() / 2;

            Debug.WriteLine("Mines count is: " + minesCount);

            try
            {
                if (ListOfButtons != null)
                {
                    game.GenerateRandomMines(ListOfButtons, (minesCount));
                    Debug.WriteLine("Generated random");
                }
                else
                    Debug.WriteLine("BUTTON IS NULL");

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }

        }

        protected void Button_Click(object sender, EventArgs e)
        {

            foreach (ImageButton ib in ListOfButtons)
            {
                if (ib.AlternateText != "")
                    break;

                return;
            }

            ImageButton clickedButton = (ImageButton)sender;
            clickedButton.ToolTip = "clicked";
            int thisID = Convert.ToInt32(clickedButton.ID);

            if (clickedButton.AlternateText == "X")
            {
                
                clickedButton.ImageUrl = @"http://a5.mzstatic.com/us/r30/Purple4/v4/a4/81/d5/a481d5b9-c5ad-2148-57c0-3ccb1966fd75/icon175x175.jpeg";
                clickedButton.AlternateText = "BOM";
            }

            else
            {
                clickedButton.ImageUrl = "";
            }

            UpdateGameField();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

        }

        protected void UpdateGameField()
        {

            foreach (ImageButton ib in ListOfButtons)
            {
                
                if (ib.ToolTip == "clicked")
                {
                    if (ib.AlternateText.Count() > 0)
                        Debug.WriteLine("Substring is: " + ib.AlternateText.Substring(0, 1));

                    if (ib.AlternateText.Count() > 0)
                    {

                        if (ib.AlternateText == "BOM")
                        {
                            ib.ImageUrl = @"http://a5.mzstatic.com/us/r30/Purple4/v4/a4/81/d5/a481d5b9-c5ad-2148-57c0-3ccb1966fd75/icon175x175.jpeg";
                        }

                        else if ((ib.AlternateText.Substring(0, 1) == "X") && (ib.AlternateText.Count() < 2))
                        {
                            ib.ImageUrl = @"http://media2.androidappsgame.com/1/214881/com-jipsaan-minesweeper-214881.jpg";
                            ib.AlternateText = "X";
                        }

                        else if ((ib.AlternateText.Substring(0, 1) == "2") && (ib.AlternateText.Count() < 2))
                        {
                            ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/4/44/Minesweeper_2.svg";
                        }

                        else if ((ib.AlternateText.Substring(0, 1) == "3") && (ib.AlternateText.Count() < 2))
                        {
                            ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/0/08/Minesweeper_3.svg";
                        }

                        else if ((ib.AlternateText.Substring(0, 1) == "4") && (ib.AlternateText.Count() < 2))
                        {
                            ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/4/4f/Minesweeper_4.svg";
                        }

                        else if ((ib.AlternateText.Substring(0, 1) == "5") && (ib.AlternateText.Count() < 2))
                        {
                            ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/4/46/Minesweeper_5.svg";
                        }

                        else if ((ib.AlternateText.Substring(0, 1) == "1") && (ib.AlternateText.Count() < 2))
                        {
                            ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/c/ca/Minesweeper_1.svg";
                        }
                        else if (ib.AlternateText.Count() > 3)
                        {
                            if (ib.AlternateText.Substring(1, 4) == "FLAG")
                            {
                                ib.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/83/Minesweeper_flag.svg";
                            }
                        }
                        else
                        {
                            ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/8/80/Minesweeper_0.svg";
                        }
                    }
                    else
                    {
                        ib.ImageUrl = @"https://upload.wikimedia.org/wikipedia/commons/8/80/Minesweeper_0.svg";
                    }
                }
            }
        }

        protected void createGameField(int gridSize)
        {
            ImageButton tb = new ImageButton();

            if (ListOfButtons != null)
                ListOfButtons.Clear();

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

                ListOfButtons.Add(tb);
            }

            gameField.Width = (int)(Math.Sqrt(gridSize) * 40);
            gameField.Height = gameField.Width;


        }
    }
}