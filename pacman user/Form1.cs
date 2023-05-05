namespace pacman_gui
{
    public partial class Form1 : Form
    {

        bool goup, godown, goleft, goright, isGameOver;

        int score, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY;

        public Form1()
        {
            InitializeComponent();
            resetGame();

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
        }

        private void yellowghost_Click(object sender, EventArgs e)
        {
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }


            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }


            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true) {
                resetGame();
            
            }

        }

        private void maingametimer(object sender, EventArgs e)
        {
            txtscore.Text = "score : " + score;

            if (goleft == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;
            }
            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }

            if (pacman.Left < -10)
            {
                pacman.Left = 680;
            }
            if (pacman.Left > 680)
            {
                pacman.Left = -10;
            }
            if (pacman.Top < -10)
            {
                pacman.Top = 550;
            }
            if (pacman.Top > 550)
            {
                pacman.Top = -10;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }
                    if ((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("you lose !");
                        }
                        if (pinkghost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                        }
                        

                    }

                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("you lose !");
                        }

                    }
                }

            }


            redghost.Left += redGhostSpeed;

            if (redghost.Bounds.IntersectsWith(pictureBox3.Bounds) || redghost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                redGhostSpeed = -redGhostSpeed;

            }

            yellowghost.Left += yellowGhostSpeed;

            if (yellowghost.Bounds.IntersectsWith(pictureBox1.Bounds) || yellowghost.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                yellowGhostSpeed = -yellowGhostSpeed;

            }

            pinkghost.Left -= pinkGhostX;
            pinkghost.Top -= pinkGhostY;


            if (pinkghost.Top < 0 || pinkghost.Top > 520)
            {
                pinkGhostY = -pinkGhostY;
            }
            if (pinkghost.Left < 0 || pinkghost.Left > 620)
            {
                pinkGhostX = -pinkGhostX;
            }


            if (score == 67)
            {
                gameOver("you win !");
            }




        }

        private void gameOver()
        {
            throw new NotImplementedException();
        }

        private void resetGame()
        {
            txtscore.Text = "score:0";
            score = 0;
            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            pinkGhostX = 5;
            pinkGhostY = 5;
            playerSpeed = 8;

            isGameOver = false;

            pacman.Left = 40;
            pacman.Top = 80;

            redghost.Left = 307;
            redghost.Top = 66;

            yellowghost.Left = 403;
            yellowghost.Top = 450;

            pinkghost.Left = 499;
            pinkghost.Top = 223;

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    x.Visible = true;
                }


            }

            gametimer.Start();

        }
        private void gameOver(string message)
        {
            isGameOver=true;

            gametimer.Stop();

            txtscore.Text += Environment.NewLine + message ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}