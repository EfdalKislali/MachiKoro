using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Machi_Koro
{
    public partial class Form1 : Form
    {
        // Aangeven dat de Balance 0 is. 
        int Balance = 3;
        int koop_Bezienswaarigheid1 = 22;
        int kostenWheatField = 1;
        int wheatFieldCardPlayer = 1;
        int wheatFieldCards = 5;

        // Hier start het programma
        public Form1()
        {
            InitializeComponent();

            Dice dice1 = new Dice();
            Establishment WheatField = new Establishment(1, 1, "Wheat Field", "Blue", 1, 1);

            label1.Text = "Balance: " + Balance;
            label2.Text = "U dobbelde: " + dice1.Roll1();
            if (dice1.Roll1() == 1)
            {
                Balance += 1;
                UpdateBalance();
            }
            if (dice1.Roll1() == 2)
            {
                Balance += 1;
                UpdateBalance();
            }
            if (dice1.Roll1() == 3)
            {
                Balance += 1;
                UpdateBalance();
            }
            if (dice1.Roll1() == 0)
            {
                button4.Enabled = false;
            }
        }
        // Perongeluk op de label geklikt. 
        
        public void label1_Click(object sender, EventArgs e)
        {
        
        }

        // Als je op de knop klikt dan komt er dus één bij bij Balance. 
        public void button1_Click(object sender, EventArgs e)
        {
            Balance += 1;
            label1.Text = "Balance: " + Balance;

        }
        public void UpdateBalance()
        {
            label1.Text = "Balance: " + Balance;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (Balance >= koop_Bezienswaarigheid1)
            {
                button2.Text = "Gekocht";
                button2.Enabled = false;
                Balance = Balance - koop_Bezienswaarigheid1;
                UpdateBalance();

               /* Landmark Voorbeeld = new Landmark(koop_Bezienswaarigheid1, 2, "Voorbeeld", "Bezienswaardigheden"); */
                //landmarks.Add(Voorbeeld);


                //CardsInfo card = Kaarten.GetAndRemoveCard();
                //pictureBox2.ImageLocation = Path.GetFullPath(card.name);

            }
        }

        private List<Landmark> landmarks;

        public void button4_Click(object sender, EventArgs e)
        {
            Dice dice = new Dice();
            label2.Text = "U dobbelde: " + dice.Roll1();
            if (dice.Roll1() == 1)
            {
                Balance += 1 * wheatFieldCardPlayer;
                UpdateBalance();
                if (button2.Enabled == false)
                {

                }
            }
            if (dice.Roll1() == 2)
            {
                Balance += 1;
                UpdateBalance();
            }
            if (dice.Roll1() == 3)
            {
                Balance += 1;
                UpdateBalance();
            }

        }

        public void label2_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            player1.Roll();
        }




        public void button3_Click(object sender, EventArgs e)
        {
            button3.Text = " " + wheatFieldCards;
            Establishment WheatField = new Establishment(1, 1, "Wheat Field", "Blue", 1, 1);
            if (Balance >= kostenWheatField)
            {
                wheatFieldCards = wheatFieldCards - 1;
                Balance = Balance - 1;
                UpdateBalance();
                UpdateWheatField();
                label5.Text = " " + wheatFieldCardPlayer;
                wheatFieldCardPlayer = wheatFieldCardPlayer + 1;
                UpdateWheatFieldCardPlayer();
                if (wheatFieldCards == 0)
                {
                    button3.Enabled = false;
                }

            }

        }

        public void UpdateWheatFieldCardPlayer()
        {
            label5.Text = " " + wheatFieldCardPlayer;
        }
        
        public void UpdateWheatField()
        {
            button3.Text = " " + wheatFieldCards;
        }

        Establishment WheatField = new Establishment(1, 1, "Wheat Field", "Blue", 1, 1);

        


    }
}
