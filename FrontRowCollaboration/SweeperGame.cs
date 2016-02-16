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
            int minesCount = buttons.Count() / 5;

            while(minesCount > 0)
            { 
                int thisRandom = random.Next(1, (buttons.Count + 1));

                if(buttons.ElementAt(thisRandom - 1).AlternateText == "")
                {
                    buttons.ElementAt(thisRandom - 1).AlternateText = "X";
                    minesCount--;
                }               
            }
        }
    }
}