using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_Man_GUI
{
    public partial class Form1 : Form
    {
        bool goup, godown, goleft, goright, isGameOver;
        List<Tuple<int, int>> directions = new List<Tuple<int, int>>();
        HashSet<Tuple<int, int>> set = new HashSet<Tuple<int, int>>();

        int score, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY,pinkGhostSpeed, pacManX, pacManY;
        int cnt = 0;

        private void pac_man_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            beginGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
       


        private void mainGameTimer(object sender, EventArgs e)
        {
            
            foreach(Tuple<int, int> p in directions)
            {
                int diffOne = pac_man.Left - p.Item1;
                int diffTwo = pac_man.Top - p.Item2;

                if(diffOne != 0 )
                {
                    pac_man.Left += playerSpeed;
/*                    pac_man.Image = Properties.Resources.right;
*/                }
                else
                {
                    pac_man.Top += playerSpeed;
/*                    pac_man.Image = Properties.Resources.down;
*/                }

                for (int i = 0; i < 1000000; i ++)
                {

                }
            }
            beginGame();
        }
        // when we load the game or the game is over
        private void beginGame()
        {
            score = 0;
            redGhostSpeed = 3;
            yellowGhostSpeed = 3;
            pinkGhostX = 3;
            pinkGhostY = 3;
            playerSpeed = 1;

            isGameOver = false;

            pac_man.Left = 50;
            pac_man.Top = 109;
            pacManX = 50;
            pacManY = 109;
            redGhost.Left = 140;
            redGhost.Top = 60;

            yellowGhost.Left = 280;
            yellowGhost.Top = 300;

            pinkGhost.Left = 400;
            pinkGhost.Top = 150;

            gameTimer.Start();

            
            Bfs(pac_man.Left, pac_man.Top);
            pac_man.Left = pacManX;
            pac_man.Top = pacManY;
            directions.Reverse();
        }
        private void gameOver(string message )
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text ="Score: "+ score+Environment.NewLine + message;
        }


        private void Bfs(int x, int y)
        {
            
            Dictionary<Tuple<int, int>, Tuple<int, int>> hashMap = new Dictionary<Tuple<int, int>, Tuple<int, int>>();
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            q.Enqueue(new Tuple<int, int>(x, y));
            Tuple<int, int> last = new Tuple<int, int>(x, y);

            while(q.Count() > 0)
            {
                Tuple<int, int> p = q.Dequeue();
                x = p.Item1;
                y = p.Item2;
                if (x < 0 || y < 0) continue;

                if (x > 926 || y > 1000) continue;

                if (set.Contains(new Tuple<int, int>(x, y)))
                {
                    continue;
                }

                set.Add(new Tuple<int, int>(x, y));
                pac_man.Location = new Point(x, y);
                foreach (Control z in this.Controls)
                {
                    if (z is PictureBox)
                    {
                        if ((string)z.Tag == "coin")
                        {
                            if (pac_man.Top == z.Top && pac_man.Left == z.Left)
                            {
                                last = p;
                                break;
                            }
                        }
                        if ((string)z.Tag == "wall")
                        {
                            if (pac_man.Bounds.IntersectsWith(z.Bounds))
                            {
                                continue;
                            }
                        }
                        if ((string)z.Tag == "ghost")
                        {
                            if (pac_man.Bounds.IntersectsWith(z.Bounds))
                            {
                                continue;
                            }
                        }
                    } else
                    {
                        if(pac_man.Bounds.IntersectsWith(z.Bounds))
                        {
                            continue;
                        }
                    }
                }
                q.Enqueue(new Tuple<int, int>(x + playerSpeed, y));
                q.Enqueue(new Tuple<int, int>(x, y + playerSpeed));
                hashMap[new Tuple<int, int>(x + playerSpeed, y)] = p;
                hashMap[new Tuple<int, int>(x, y + playerSpeed)] = p;
            }


            while(hashMap.ContainsKey(last))
            {
                directions.Add(last);
                last = hashMap[last];
            }

            directions.Add(last);
        }
    }


    
}
