using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsMakeADeal
{
    

    public partial class Form1 : Form
    {
        public Random r = new Random();
        public int[] vals = new int[3];
        public Random r2 = new Random();
        public Random r3 = new Random(); 
        public static int i = 0;
        public static int num = 0; 
        String[] Prizes = {"Desk" , "Car" , "Boat" }; 
       

        public Form1() 
        {

            InitializeComponent();
            fillArray(vals);

          







        }

    

        public void fillArray(int [] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(10); 
               
                

            }

            for(int b = 0; b < nums.Length-1; b++)
            {
                while(nums[b] == nums[b+1])
                {
                    nums[b] = r2.Next(100); 
                }
            }
            

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            i = r.Next(2);
            MessageBox.Show("One of the prizes are: " + Prizes[i]);
            compareScore(0,1,2 , button1);
            button1.Text = ""; 




        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            i = r.Next(2);
            MessageBox.Show("One of the prizes are: " + Prizes[i]);
            compareScore(1,0,2 , button2);
            button2.Text = ""; 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            i = r.Next(2);
            MessageBox.Show("One of the prizes are: " + Prizes[i]);
            compareScore(2,0,1 , button3);
            button3.Text = ""; 

        }

     

        public void compareScore(int x, int y, int z , Button b1)
        {
            DialogResult dialogResult = MessageBox.Show("Is this your final decision?", "Decision", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.Yes)
            {
                if (vals[x] > vals[y] && vals[x] > vals[z])
                {
                    MessageBox.Show("You won: " + Prizes[2]);
                    b1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Boat3));
                }
                else if (vals[x] < vals[y] && vals[x] < vals[z])
                {
                    MessageBox.Show("You won: " + Prizes[0]);
                    b1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.desk3));
                }
                else
                {
                    MessageBox.Show("You won: " + Prizes[1]);
                    b1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Car));
                }

            }

            



        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.door5));
            button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.door5)); 
            button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.door5));

            button1.Text = "Door 1";
            button2.Text = "Door 2";
            button3.Text = "Door 3"; 

            fillArray(vals); 
        }
    }

   
}
