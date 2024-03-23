using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem.Menu
{
    public class Menu

    {
        public string Title;

        private MenuItem[] _menuItems = new MenuItem[30];

        private int _itemCount = 0;

        public Menu(string title)
        {
            Title = title;
        }
        public void Show()
        {
         
            Console.WriteLine(Title);
            Console.WriteLine(_menuItems[0].Title);
            Console.WriteLine(_menuItems[1].Title);
            Console.WriteLine(_menuItems[2].Title);
            Console.WriteLine(_menuItems[3].Title);
            Console.WriteLine(_menuItems[4].Title);
            Console.WriteLine(_menuItems[5].Title);
            Console.WriteLine(_menuItems[6].Title);
            Console.WriteLine(_menuItems[7].Title);

            

            Console.WriteLine("\n\n(Tryk på menupunkt eller 0 for at afslutte)\n\n");
      
            //  SelectMenuItem();


            //  Console.ReadLine() ;

        }



        public void AddMenuItem(MenuItem menuTitle) 
            //denne metode tillader at tilføje menuitems til menuen,
            //disse menuitems hænger sammen med itemcount og udgør menutitle
        {
            _menuItems[_itemCount] = menuTitle;
            _itemCount++;
        }

        public int SelectMenuItem()
        {
            //  return Convert.ToInt32(Console.ReadLine());
            int menuPoint = int.Parse(Console.ReadLine()); //menupunkt vælges i konsollen ved indtast af heltal som konverteres til string

            if (menuPoint <= _itemCount)


            {
                //Console.WriteLine(_menuItems[menuPoint-1].Title);
                return menuPoint;
            }

            Console.WriteLine("\n\nFejl. Indtast gyldigt heltal fra menu. Indtast 0 for at lukke programmet.\n\n"); 
            //Man kan lukke programmet ved at trykke på 0, fordi vores array i konstruktøren øverst indeholdende
            //"_menuItems" starter med indeks 0 at der ikke er en 'case 0' i program.cs. som kalder metoden.
            //samtidig er metoden sat til at være menupoint <= _itemCount. og returnere menupoint valgt i konsollen. 
            
            return SelectMenuItem();

        }

    }


}
