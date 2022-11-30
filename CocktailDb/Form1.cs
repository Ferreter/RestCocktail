using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Serializers;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using static CocktailDb.CocktailDb;

namespace CocktailDb
{
    public partial class CocktailDb : Form
    {
        public CocktailDb()
        {
            InitializeComponent();
        }


        public String getSearchbyName(String s)
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/search.php?");
            var request = new RestRequest();

            //making parameter 
            request.AddParameter("s", s);

            //Service call
            var response = client.Execute(request);


            CocktailInfo mydrinks = JsonConvert.DeserializeObject<CocktailInfo>(response.Content);



            //MessageBox.Show(name);

            foreach(Drink d in mydrinks.drinks)
            {
                MessageBox.Show(d.strDrink);
            }
                 return "";
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            if(SearchBar.Text != "Enter any ingrediant or cocktail name")
            {
                SearchButton.Enabled = true;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String x = SearchBar.Text;
            String y = getSearchbyName((String)x);  
        }
    }
}
