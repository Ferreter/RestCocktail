using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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


           Root mydrinks = JsonConvert.DeserializeObject<Root>(response.Content);



            //MessageBox.Show(name);

            foreach(Drink d in mydrinks.drinks)
            {
                MessageBox.Show(d.strDrink);
            }
                 return "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Heading.Text = response
        }

        public class Drink
        {
            public string idDrink { get; set; }
            public string strDrink { get; set; }
            public object strDrinkAlternate { get; set; }
            public string strTags { get; set; }
            public object strVideo { get; set; }
            public string strCategory { get; set; }
            public string strIBA { get; set; }
            public string strAlcoholic { get; set; }
            public string strGlass { get; set; }
            public string strInstructions { get; set; }
            public object strInstructionsES { get; set; }
            public string strInstructionsDE { get; set; }
            public object strInstructionsFR { get; set; }
            public string strInstructionsIT { get; set; }

            [JsonProperty("strInstructionsZH-HANS")]
            public object strInstructionsZHHANS { get; set; }

            [JsonProperty("strInstructionsZH-HANT")]
            public object strInstructionsZHHANT { get; set; }
            public string strDrinkThumb { get; set; }
            public string strIngredient1 { get; set; }
            public string strIngredient2 { get; set; }
            public string strIngredient3 { get; set; }
            public string strIngredient4 { get; set; }
            public string strIngredient5 { get; set; }
            public string strIngredient6 { get; set; }
            public string strIngredient7 { get; set; }
            public object strIngredient8 { get; set; }
            public object strIngredient9 { get; set; }
            public object strIngredient10 { get; set; }
            public object strIngredient11 { get; set; }
            public object strIngredient12 { get; set; }
            public object strIngredient13 { get; set; }
            public object strIngredient14 { get; set; }
            public object strIngredient15 { get; set; }
            public string strMeasure1 { get; set; }
            public string strMeasure2 { get; set; }
            public string strMeasure3 { get; set; }
            public string strMeasure4 { get; set; }
            public string strMeasure5 { get; set; }
            public string strMeasure6 { get; set; }
            public string strMeasure7 { get; set; }
            public object strMeasure8 { get; set; }
            public object strMeasure9 { get; set; }
            public object strMeasure10 { get; set; }
            public object strMeasure11 { get; set; }
            public object strMeasure12 { get; set; }
            public object strMeasure13 { get; set; }
            public object strMeasure14 { get; set; }
            public object strMeasure15 { get; set; }
            public string strImageSource { get; set; }
            public string strImageAttribution { get; set; }
            public string strCreativeCommonsConfirmed { get; set; }
            public string dateModified { get; set; }

            public Drink(string idDrink, string strDrink, object strDrinkAlternate, string strTags, object strVideo, string strCategory, string strIBA, string strAlcoholic, string strGlass, string strInstructions, object strInstructionsES, string strInstructionsDE, object strInstructionsFR, string strInstructionsIT, object strInstructionsZHHANS, object strInstructionsZHHANT, string strDrinkThumb, string strIngredient1, string strIngredient2, string strIngredient3, string strIngredient4, string strIngredient5, string strIngredient6, string strIngredient7, object strIngredient8, object strIngredient9, object strIngredient10, object strIngredient11, object strIngredient12, object strIngredient13, object strIngredient14, object strIngredient15, string strMeasure1, string strMeasure2, string strMeasure3, string strMeasure4, string strMeasure5, string strMeasure6, string strMeasure7, object strMeasure8, object strMeasure9, object strMeasure10, object strMeasure11, object strMeasure12, object strMeasure13, object strMeasure14, object strMeasure15, string strImageSource, string strImageAttribution, string strCreativeCommonsConfirmed, string dateModified)
            {
                this.idDrink = idDrink;
                this.strDrink = strDrink;
                this.strDrinkAlternate = strDrinkAlternate;
                this.strTags = strTags;
                this.strVideo = strVideo;
                this.strCategory = strCategory;
                this.strIBA = strIBA;
                this.strAlcoholic = strAlcoholic;
                this.strGlass = strGlass;
                this.strInstructions = strInstructions;
                this.strInstructionsES = strInstructionsES;
                this.strInstructionsDE = strInstructionsDE;
                this.strInstructionsFR = strInstructionsFR;
                this.strInstructionsIT = strInstructionsIT;
                this.strInstructionsZHHANS = strInstructionsZHHANS;
                this.strInstructionsZHHANT = strInstructionsZHHANT;
                this.strDrinkThumb = strDrinkThumb;
                this.strIngredient1 = strIngredient1;
                this.strIngredient2 = strIngredient2;
                this.strIngredient3 = strIngredient3;
                this.strIngredient4 = strIngredient4;
                this.strIngredient5 = strIngredient5;
                this.strIngredient6 = strIngredient6;
                this.strIngredient7 = strIngredient7;
                this.strIngredient8 = strIngredient8;
                this.strIngredient9 = strIngredient9;
                this.strIngredient10 = strIngredient10;
                this.strIngredient11 = strIngredient11;
                this.strIngredient12 = strIngredient12;
                this.strIngredient13 = strIngredient13;
                this.strIngredient14 = strIngredient14;
                this.strIngredient15 = strIngredient15;
                this.strMeasure1 = strMeasure1;
                this.strMeasure2 = strMeasure2;
                this.strMeasure3 = strMeasure3;
                this.strMeasure4 = strMeasure4;
                this.strMeasure5 = strMeasure5;
                this.strMeasure6 = strMeasure6;
                this.strMeasure7 = strMeasure7;
                this.strMeasure8 = strMeasure8;
                this.strMeasure9 = strMeasure9;
                this.strMeasure10 = strMeasure10;
                this.strMeasure11 = strMeasure11;
                this.strMeasure12 = strMeasure12;
                this.strMeasure13 = strMeasure13;
                this.strMeasure14 = strMeasure14;
                this.strMeasure15 = strMeasure15;
                this.strImageSource = strImageSource;
                this.strImageAttribution = strImageAttribution;
                this.strCreativeCommonsConfirmed = strCreativeCommonsConfirmed;
                this.dateModified = dateModified;
            }


        }

        public class Root
        {
            public List<Drink> drinks { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x = getSearchbyName("Tommy's");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CocktailDb_Load(object sender, EventArgs e)
        {

        }
    }
}
