using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem.Menu
{
    public class MenuItem //denne klasse indeholder en konstruktør som sætter titlen på et menuitem/menuPoint,
                          //denne konstruktør bruges i Show() metoden, som bruges i Program.cs, hvor 
                          //menuPoint->menuObject sættes til at blive initialiseret med streng
    {

        public string Title; 

        public MenuItem(string itemTitle) 
        {
            Title = itemTitle;
        }
    }
}
