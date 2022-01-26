using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyNamesForYou
{
    public partial class funnyNamesForYou : Form
    {
        bool maleBtnPressed = false;
        bool femaleBtnPressed = false;
        public funnyNamesForYou()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label3.Text = "Select MALE or FEMALE and Press CLICK FOR THE NAME";
        }

        private void male_button_Click(object sender, EventArgs e)
        {
            maleBtnPressed = true;
            femaleBtnPressed = false;
        }

        private void female_button_Click(object sender, EventArgs e)
        {
            maleBtnPressed = false;
            femaleBtnPressed = true;
        }

        private void name_button_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            if(maleBtnPressed == true || femaleBtnPressed == true)
            label3.Text = String.Empty;
            label1.Text = NameFinding();
        }
        private string NameFinding()
        {
            string[] name1 = { "Agreeable ", "Ambitious ", "Brave ", "Calm ", "Delightful ", "Eager ", "Faithful ", "Gentle ", "Happy ", "Jolly ", "Kind ", "Lively ", "Nice ", "Obedient ", "Polite ", "Proud ", "Silly ","Thankful ","Victorious ","Witty ","Wonderful ","Zealous " };
            string[] nameFemales = { "Aurora","Connie","Deja","Ellie","Eva","Fawn","Inu","Kimchi","Lark","London","Paisley","Paprika","Reba","Ruby","Saffron","Sushi","Ursula","Waverly","Willow" };
            string[] nameMales = { "Asher", "Baloo", "Channing", "Cozby", "Dexter", "Flynn", "Gidget", "Henrick", "Lego", "Lenny", "Levi", "Oatmeal", "Odin", "Pepper", "Rudolf", "Seven", "Sid", "Sprite", "Tesla", "Winston" };
            string[] resultantName = new string[450];
            int k = 0;
            int l = 0;
            int limit = 0;
            if (femaleBtnPressed==true)
            {
                for (int i = 0; i < 22; i++)
                {
                    for (int j = 0; j < 19; j++)
                    {
                        resultantName[k] = name1[i] + nameFemales[j];
                        k++;
                    }
                }
                limit = 418;
            }
            else if (maleBtnPressed==true)
            {
                for (int i = 0; i < 22; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        resultantName[l] = name1[i] + nameMales[j];
                        l++;
                    }
                }
                limit = 440;
            }
            Random random=new Random();
            int num=random.Next(0,limit);
            return resultantName[num];
        }
    }
}
