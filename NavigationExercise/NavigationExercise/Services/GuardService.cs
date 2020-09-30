using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationExercise.Services
{
    public class GuardService
    {
        public bool gotCaught { get; set; }

        public bool GuardingCastle()
        {
            if (CheckPlayer())
            {
                gotCaught = GotCaught();
                return gotCaught;
            }
            return false;
        }
        public bool CheckPlayer()
        {
            if (NavigationExercise.App.inventory.hasLockPick || NavigationExercise.App.inventory.hasSword)
            {
                return true;
            }
            return false;
        }
        
        public bool GotCaught()
        {
            var gotCaught = new Random();
            return gotCaught.NextDouble() >= 0.5;
        }
    }
}
