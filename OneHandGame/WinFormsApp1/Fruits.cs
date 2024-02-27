namespace WinFormsApp1
{
    public class Fruits
    {
        PictureBox pictureBox = new();

        public int Points { get; private set; }

        public Image ChangeSymbol()
        {
            Random rand = new();
            int number = rand.Next(0, 9);

            switch (number)
            {
                case 0: Points = 10; return pictureBox.Image = Properties.Resources.cherry;
                case 1: Points = 20; return pictureBox.Image = Properties.Resources.strawberry;
                case 2: Points = 30; return pictureBox.Image = Properties.Resources.seven;
                case 3: Points = 40; return pictureBox.Image = Properties.Resources.lime;
                case 4: Points = 50; return pictureBox.Image = Properties.Resources.bell;
                case 5: Points = 60; return pictureBox.Image = Properties.Resources.sliva;
                case 6: Points = 70; return pictureBox.Image = Properties.Resources.peech;
                case 7: Points = 80; return pictureBox.Image = Properties.Resources.waterMelow;
                case 8: Points = 90; return pictureBox.Image = Properties.Resources.grape;
            }
            return pictureBox.Image;
        }

    }
}
