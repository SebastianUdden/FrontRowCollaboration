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

        public void GenerateRandomMines(List<ImageButton> buttons)
        {
            Random random = new Random();
            Thread.Sleep(100);
            
            int amountOf3 = 0;
            int amountOf2 = 0;
            int amountOf1 = 0; 

            while((amountOf3 > 0) || (amountOf2 > 0) || (amountOf1 > 0)) 
            { 
                int thisRandom = random.Next(1, (buttons.Count() + 1));

                if(buttons.ElementAt(thisRandom).AlternateText == "")
                {
                    if(amountOf3 > 0)
                    { 
                        buttons.ElementAt(thisRandom).AlternateText = "3";
                        amountOf3 = amountOf3 - 1;
                    }
                    else if(amountOf2 > 0)
                    {
                        buttons.ElementAt(thisRandom).AlternateText = "3";
                        amountOf2 = amountOf2 - 1;
                    }
                    else if (amountOf1 > 0)
                    {
                        buttons.ElementAt(thisRandom).AlternateText = "3";
                        amountOf1 = amountOf1 - 1;
                    }
                }               
            }
        }
    }
}