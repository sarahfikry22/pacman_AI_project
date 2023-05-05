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

        private void pictureBox66_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pac_man_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            //start the game

            InitializeComponent();
            beginGame();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        //BFS Algorithm

        private void mainGameTimer(object sender, EventArgs e)
        { 
            //Pac Man movement
            //move to right and down
            foreach (Tuple<int, int> p in directions)
            {
                int diffOne = pac_man.Left - p.Item1;//right
                int diffTwo = pac_man.Top - p.Item2;//down

                // solution path
                //Console.WriteLine(p.Item1 + " " + p.Item2);

                if(diffOne != 0 )
                {
                    pac_man.Left += playerSpeed;
                }
                else
                {
                    pac_man.Top += playerSpeed;
                }

                //for loop to slow the pac man movement
                for (int i = 0; i < 10000000; i++){ }

            }
            // if you want to start from any point
           /* pac_man.Left = pacManX;
            pac_man.Top = pacManY;*/

            beginGame();
        }
        // when we load the game or the game is over
        private void beginGame()
        {
            /*score = 0;
            redGhostSpeed = 3;
            yellowGhostSpeed = 3;
            pinkGhostX = 3;
            pinkGhostY = 3;*/

            // pac man speed
            playerSpeed = 1;
    
            isGameOver = false;
            
            // initial_location of the pac man
            // inital state
            pac_man.Left = 55;
            pac_man.Top = 105;

            pacManX = pac_man.Left;
            pacManY = pac_man.Top;


            /*redGhost.Left = 140;
            redGhost.Top = 60;*/
            /*yellowGhost.Left = 280;
            yellowGhost.Top = 300;*/

            /*pinkGhost.Left = 400;
            pinkGhost.Top = 150;
                                */

            gameTimer.Start();

            Bfs(pac_man.Left, pac_man.Top);
            pac_man.Left = pacManX;
            pac_man.Top = pacManY;
           
            // the path from pac man to the coin
            directions.Reverse();

        }
        // if the algo does not find a solution
        private void gameOver(string message )
        {
            isGameOver = true;
            gameTimer.Stop();
        }
        private void Bfs(int x, int y)
        {
            set.Clear();
            directions.Clear();
           
            Dictionary<Tuple<int, int>, Tuple<int, int>> hashMap = new Dictionary<Tuple<int, int>, Tuple<int, int>>();
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            q.Enqueue(new Tuple<int, int>(x, y));
            Tuple<int, int> last = null;

            while(q.Count() > 0)
            {
                Tuple<int, int> p = q.Dequeue();
                x = p.Item1;
                y = p.Item2;
                

                // Checking Boundaries of the form
                if (x < 0 || y < 0) continue;
                if (x > 926 || y > 1000) continue;

                // Checking If I've visited this node before or not.
                if (set.Contains(new Tuple<int, int>(x, y)))
                {
                    continue;
                }
                set.Add(new Tuple<int, int>(x, y));
                
                //object to change values and find solution path first before the pac man move;
                pac_man_beta.Left = x;
                pac_man_beta.Top = y;

                int state = 1;
                foreach (Control z in this.Controls)
                {
                    if (z is PictureBox)
                    {
                        //check if the pac man hit a wall or ghost
                        if ((string)z.Tag == "wall" || (string)z.Tag == "ghost")
                        {
                            if (pac_man_beta.Bounds.IntersectsWith(z.Bounds))
                            {
                                state = 0;
                                break;
                            }
                        }
                        //find the goal
                        if ((string)z.Tag == "coin")
                        {
                            if (pac_man_beta.Top == z.Top && pac_man_beta.Left == z.Left)
                            {
                                state = 2;
                                last = p;//bool to check there is no obstecle in his way to the goal;
                                break;
                            }
                        }
                    }
                }

                if(state == 2)
                {
                    //win
                    break;
                }
                if (state == 0)
                {
                    //lost 
                    continue;
                }
                // add nodes to queue
                q.Enqueue(new Tuple<int, int>(x + playerSpeed, y));
                q.Enqueue(new Tuple<int, int>(x, y + playerSpeed));

                //find shortest path
                if (!hashMap.ContainsKey(new Tuple<int, int>(x + playerSpeed, y))) {
                    hashMap[new Tuple<int, int>(x + playerSpeed, y)] = p;
                }
                if (!hashMap.ContainsKey(new Tuple<int, int>(x, y + playerSpeed))) {
                    hashMap[new Tuple<int, int>(x, y + playerSpeed)] = p;
                }
            }

            /*Console.WriteLine(set.Count());*/

            // if the pac man does not find a solution;
            if (last == null)
            {
                Console.WriteLine("Not Possible"); 
                return;
            }

            //loop to insert the solution path from the coin to the pac man;
            while(hashMap.ContainsKey(last))
            {
                directions.Add(last);
                last = hashMap[last];
            }
            directions.Add(last);
        }
    }   
}
