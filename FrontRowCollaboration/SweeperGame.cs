using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontRowCollaboration
{
    public class SweeperGame
    {
        public void GenerateRandomMines(List<ImageButton> buttons, int numberOfMines)
        {
            Random random = new Random();
            Thread.Sleep(10);
            int minesCount = numberOfMines;

            while(minesCount > 0)
            { 
                int thisRandom = random.Next(1, (buttons.Count + 1));

                if(buttons.ElementAt(thisRandom - 1).AlternateText == "")
                {
                    buttons.ElementAt(thisRandom - 1).AlternateText = "X";
                    minesCount--;
                }               
            }

            GenerateMap(buttons);
        }

        public void GenerateMap(List<ImageButton> buttons)
        {
            //7 x 7

            #region bizzare if-logic 
            for (int i = 0; i < buttons.Count(); i++)
            {
                int thisCount = 0;

                if(buttons.ElementAt(i).AlternateText == "")
                {
                    if((i <=6))
                    {
                        if(i == 0)
                        {
                            if(buttons.ElementAt(i+1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1; 
                            }
                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                        }
                        else if (i == 6)
                        {
                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                        }
                        else
                        {
                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                       
                    }
                    else if((i>6) && (i<14))
                    {

                        if (i == 7)
                        {
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else if (i == 13)
                        {

                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else
                        {
                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }

                    }

                    else if ((i > 13) && (i < 21))
                    {

                        if (i == 14)
                        {
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else if (i == 20)
                        {

                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else
                        {
                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }

                    }

                    else if ((i > 20) && (i < 28))
                    {

                        if (i == 21)
                        {
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else if (i == 27)
                        {

                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else
                        {
                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }

                    }

                    else if ((i > 27) && (i < 35))
                    {

                        if (i == 28)
                        {
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else if (i == 34)
                        {

                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else
                        {
                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }

                    }

                    else if ((i > 34) && (i < 42))
                    {

                        if (i == 35)
                        {
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else if (i == 41)
                        {

                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else
                        {
                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }

                    }

                    else if ((i > 41) && (i < 49))
                    {

                        if (i == 42)
                        {
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else if (i == 48)
                        {

                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }


                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }
                        else
                        {
                            if (buttons.ElementAt(i - 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i + 1).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 6).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }
                            if (buttons.ElementAt(i - 7).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                            if (buttons.ElementAt(i - 8).AlternateText == "X")
                            {
                                thisCount = thisCount + 1;
                            }

                        }

                    }


                    buttons.ElementAt(i).AlternateText = thisCount.ToString();

                }

            }

            #endregion

        }
    }
}