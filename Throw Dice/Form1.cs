using System.Security.Cryptography;

namespace Throw_Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        int dice1 = 0;
        int dice2 = 0;
        int timesthrown = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) > 12 || Int32.Parse(textBox1.Text) < 2)
            {
                MessageBox.Show("Your number has to be bigger than 1, and less than 13!");
            }
            else
            {
                while (dice1 + dice2 != Int32.Parse(textBox1.Text))
                {
                    timesthrown++;
                    dice1 = random.Next(1, 7);
                    dice2 = random.Next(1, 7);
                }
                MessageBox.Show("The dice had to be thrown " + timesthrown.ToString() + " Times!");
                timesthrown = 0;
                dice1 = 0;
                dice2 = 0;
            }
        }
    }
}
