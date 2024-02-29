using System.Media;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Fruits fruits = new();
        private int count = 0;
        private SoundPlayer player;
        private SoundPlayer backgroundMusicPlayer;
        int firstFruit = 0;
        int secondFruit = 0;
        int thirdFruit = 0;
        int coins = 100;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 50; //  milliseconds
            timer.Tick += Timer_Tick;
            backgroundMusicPlayer = new SoundPlayer("../../../audio/background_music.wav");
            backgroundMusicPlayer.PlayLooping(); // Loop the background music
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            count++;

            if (count <= 12)
            {
                pictureBox2.Image = fruits.ChangeSymbol();
                pictureBox3.Image = fruits.ChangeSymbol();
                pictureBox1.Image = fruits.ChangeSymbol();
                firstFruit = fruits.Points;
            }
            else if (count <= 24)
            {
                pictureBox2.Image = fruits.ChangeSymbol();
                secondFruit = fruits.Points;
                pictureBox3.Image = fruits.ChangeSymbol();
            }
            else if (count <= 36)
            {
                pictureBox3.Image = fruits.ChangeSymbol();
                thirdFruit = fruits.Points;
            }
            else
            {
                player.Stop();
                timer.Stop();

                if (firstFruit == secondFruit && secondFruit == thirdFruit)
                {
                    coins += 250;
                    player = new("../../../audio/winjackpot.wav");
                    player.Play();
                    pictureBoxJackpot.Show();
                }
                else if (firstFruit == secondFruit || firstFruit == thirdFruit || secondFruit == thirdFruit)
                {
                    richTextBoxResult.ForeColor = Color.Green;
                    coins += 20;
                    player = new("../../../audio/cashbell.wav");
                    player.Play();
                }
                richTextBoxResult.Text = coins.ToString() + " $";
                spinButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spinButton.Enabled = false;

            richTextBoxResult.ForeColor = Color.Black;
            if (coins <= 10)
            {
                richTextBoxResult.ForeColor = Color.Red;
            }
            coins--;
            if (coins < 0)
            {
                DialogResult result = MessageBox.Show("Game Over! Play again?", "Game Over", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    coins = 100;
                    richTextBoxResult.Text = coins.ToString() + " $";
                    richTextBoxResult.ForeColor = Color.Green;
                }
                else
                {
                    Application.Exit();
                }
            }
            richTextBoxResult.Text = coins.ToString() + " $";
            player = new("../../../audio/wheel.wav");
            player.Play();
            count = 0;
            timer.Start();
            pictureBoxJackpot.Hide();
        }
    }
}
