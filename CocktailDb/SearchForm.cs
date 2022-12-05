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
using System.IO;
using System.Net;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace CocktailDb
{
    public partial class CocktailDb : Form
    {
        public CocktailDb()
        {
            InitializeComponent();
        }


        public void getSearchbyName(String Param,String Value)
        {
            //Making the client
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/search.php?");
            var request = new RestRequest();

            //making parameter 
            request.AddParameter(Param, Value);

            //Service call
            var response = client.Execute(request);

            //Deserialise which is same in SearchByName and Random
            CocktailInfo mydrinks = JsonConvert.DeserializeObject<CocktailInfo>(response.Content);

            //Making the new form
            CocktailByName nameCocktails = new CocktailByName();

            foreach (DrinkbyName d in mydrinks.drinks)
            {
                //Changing all the form labels
                nameCocktails.CkNameLabel = d.strDrink;
                nameCocktails.CkIdSet = "Id : " + d.idDrink;
                nameCocktails.CkCategory = "Category : " + d.strCategory;
                nameCocktails.CkAlcoholic = "If Alcoholic : " + d.strAlcoholic;
                nameCocktails.CkIng1 = "Ingrediant 1 : " + d.strIngredient1;
                nameCocktails.CkIng2 = "Ingrediant 2 : " + d.strIngredient2;
                nameCocktails.CkIng3 = "Ingrediant 3 : " + d.strIngredient3;
                nameCocktails.CkIng4 = "Ingrediant 4 : " + d.strIngredient4;
                nameCocktails.CkPicLoc = d.strDrinkThumb + "/preview";

                //Displaying the form after changes are made
                nameCocktails.ShowDialog();
            }
        }

        public void getSearchbyIngrediant(String Param, String Value)
        {
            //Making the client
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/filter.php?");
            var request = new RestRequest();

            //making parameter 
            request.AddParameter(Param, Value);

            //Service call
            var response = client.Execute(request);

            //Deserialising the JSON produced by filter which is different than search by name and random
            CocktailInfobyIngrediant mydrinks = JsonConvert.DeserializeObject<CocktailInfobyIngrediant>(response.Content);

            //MessageBox.Show(name);

            foreach (DrinkbyIngrediant d in mydrinks.drinks)
            {
                getSearchbyName("s", d.strDrink); // as the JSON is different and ill have to make a different form
                // i am calling the searchByName to find the Similar JSON and using that to make the Second form which has 
                //more information in it
            }
        }



        public void getRandom()
        {
            //Making the client
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/random.php");
            var request = new RestRequest();

            //Service call
            var response = client.Execute(request);

            ////Deserialise which is same in SearchByName and Random
            CocktailInfo mydrinks = JsonConvert.DeserializeObject<CocktailInfo>(response.Content);

            //Making the new form
            CocktailByName nameCocktails = new CocktailByName();

            foreach (DrinkbyName d in mydrinks.drinks)
            {
                //Changing all the form labels
                nameCocktails.CkNameLabel = d.strDrink;
                nameCocktails.CkIdSet = "Id : " + d.idDrink;
                nameCocktails.CkCategory = "Category : " + d.strCategory;
                nameCocktails.CkAlcoholic = "If Alcoholic : " + d.strAlcoholic;
                nameCocktails.CkIng1 = "Ingrediant 1 : " + d.strIngredient1;
                nameCocktails.CkIng2 = "Ingrediant 2 : " + d.strIngredient2;
                nameCocktails.CkIng3 = "Ingrediant 3 : " + d.strIngredient3;
                nameCocktails.CkIng4 = "Ingrediant 4 : " + d.strIngredient4;
                nameCocktails.CkPicLoc = d.strDrinkThumb + "/preview";

                //Displaying the form after changes are made
                nameCocktails.ShowDialog();
            }
        }

 
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            if(SearchBar.Text != "Enter any ingrediant or cocktail name") //Check if any value was entered that is not filler
            {
                SearchButton.Enabled = true; //enabling the buttons
                SearchIngrediant.Enabled = true; //enabling the buttons
            }
        }

        private void SearchButton_Click(object sender, EventArgs e) //Search by Name button
        {
            String SearchBarText = SearchBar.Text; //Using Search Bar to Use as Search Value
            getSearchbyName("s", SearchBarText);   //Calling the function which produces the second form
        }

        private void CocktailDb_Load(object sender, EventArgs e)
        {

        }

        private void SearchIngrediant_Click(object sender, EventArgs e) //Search by Ingrediant
        {
            String SearchBarText = SearchBar.Text; //Using Search Bar to Use as Search Value
            getSearchbyIngrediant("i", SearchBarText); //Calling the function which produces the second form
        }

        private void Random_Click(object sender, EventArgs e)
        {
            getRandom(); //Calling the function which produces the second form

        }
    }
}
