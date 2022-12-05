using System.Collections.Generic;
using static System.Windows.Forms.LinkLabel;

namespace CocktailDb
{
    public partial class CocktailDb
    {
        public class CocktailInfo // Main JSON Root file which is used to print data in CocktailByName form
        {
            public List<DrinkbyName> drinks { get; set; }
        }

        public class CocktailInfobyIngrediant // Root file for Searching by ingrediant 
        {
            public List<DrinkbyIngrediant> drinks { get; set; }
        }
    }
}
