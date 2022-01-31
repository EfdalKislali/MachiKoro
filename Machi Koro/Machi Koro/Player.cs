using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class Player : Form1
    {
        public Player()
        {
            hand = new List<Cards>();
            int Balance = 3;
            string name = " ";
        }

    public List<Cards> hand;
        public List<Landmark> Goal;

        public void Roll()
        {
            Dice dice = new Dice();
            //label2.Text = "U dobbelde: " + dice.Roll();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Name = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }


}
