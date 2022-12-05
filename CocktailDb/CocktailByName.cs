using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocktailDb
{
    public partial class CocktailByName : Form
    {
        public CocktailByName()
        {
            InitializeComponent();
        }

        private void CkName_Click(object sender, EventArgs e)
        {

        }

        //Getters and Setters to Change the form labels and Images to display the appropriate Content

        public string CkNameLabel
        {
            get
            {
                return this.CkName.Text;
            }
            set
            {
                this.CkName.Text = value;
            }
        }

        public string CkCategory
        {
            get
            {
                return this.Category.Text;
            }
            set
            {
                this.Category.Text = value;
            }
        }

        public string CkAlcoholic
        {
            get
            {
                return this.Alcoholic.Text;
            }
            set
            {
                this.Alcoholic.Text = value;
            }
        }

        public string CkIng1
        {
            get
            {
                return this.Ingrediant1.Text;
            }
            set
            {
                this.Ingrediant1.Text = value;
            }
        }

        public string CkIng2
        {
            get
            {
                return this.Ingrediant2.Text;
            }
            set
            {
                this.Ingrediant2.Text = value;
            }
        }
        public string CkIng3
        {
            get
            {
                return this.Ingrediant3.Text;
            }
            set
            {
                this.Ingrediant3.Text = value;
            }
        }
        public string CkIng4
        {
            get
            {
                return this.Ingrediant4.Text;
            }
            set
            {
                this.Ingrediant4.Text = value;
            }
        }


        public String CkPicLoc
        {
            get
            {
                return this.CkPic.ImageLocation;
            }
            set
            {
                this.CkPic.ImageLocation = value;
            }
        }

        public string CkIdSet
        {
            get
            {
                return this.CkId.Text;
            }
            set
            {
                this.CkId.Text = value;
            }
        }


        private void Category_Click(object sender, EventArgs e)
        {

        }

        private void CocktailByName_Load(object sender, EventArgs e)
        {

        }

        private void CkId_Click(object sender, EventArgs e)
        {

        }

        private void Alcoholic_Click(object sender, EventArgs e)
        {

        }

        private void Ingrediant1_Click(object sender, EventArgs e)
        {

        }

        private void Ingrediant2_Click(object sender, EventArgs e)
        {

        }

        private void Ingrediant4_Click(object sender, EventArgs e)
        {

        }

        private void Ingrediant3_Click(object sender, EventArgs e)
        {

        }

        private void CkPic_Click(object sender, EventArgs e)
        {

        }
    }
}
