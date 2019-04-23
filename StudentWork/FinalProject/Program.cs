using System;
using System.Threading;

namespace FinalProject
{
    class Program
    {
        const ConsoleColor bluePaddle_COLOR = ConsoleColor.DarkBlue;
        const ConsoleColor BACKGROUND_COLOR = ConsoleColor.DarkGray;
        const ConsoleColor redPaddle_COLOR = ConsoleColor.Red;
        const ConsoleColor ball_COLOR = ConsoleColor.White;

        public static Coordinate ball {
            get;
            set;
        }
        public static Coordinate bluePaddle {
            get;
            set;
        }
        public static Coordinate redPaddle {
            get;
            set;
        }
        public static void movebluePaddle(int x,int y) {
            
            Coordinate newBluePaddle = new Coordinate()
            {
            X = bluePaddle.X + x,
            Y = bluePaddle.Y + y
            };
            
            if (canMove(newBluePaddle)) {
                removePaddle(bluePaddle);
                Console.BackgroundColor = bluePaddle_COLOR;
                Console.SetCursorPosition(newBluePaddle.X, newBluePaddle.Y);
                Console.Write(" ");

                bluePaddle = newBluePaddle;
            }


        }
        public static void moveRedPaddle(int x, int y) {
            Coordinate newRedPaddle = new Coordinate()
            {
                X = redPaddle.X + x,
                Y = redPaddle.Y + y
            };
            if (canMove(newRedPaddle)) {
                removePaddle(redPaddle);
                Console.BackgroundColor = redPaddle_COLOR;
                Console.SetCursorPosition(newRedPaddle.X, newRedPaddle.Y);
                Console.Write(" ");

                redPaddle = newRedPaddle;
            }
        }
        public static void moveBall(int dx, int dy) {
            Coordinate newBall = new Coordinate()
            {
                X = ball.X + dx,
                Y = ball.Y + dy
            };
            if (canMove(newBall)) {
                removePaddle(ball);
                Console.BackgroundColor = ball_COLOR;
                Console.SetCursorPosition(newBall.X, newBall.Y);
                Console.Write(" ");

                ball = newBall;
            }
        }
        public static bool canMove(Coordinate c){
            if (c.X < 0 || c.X > Console.WindowWidth) {
                
                return false;
            }
            if (c.Y < 0 || c.Y > Console.WindowHeight) {
                return false;
            }
            return true;
        }
        public static void removePaddle(Coordinate paddle) {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.SetCursorPosition(paddle.X, paddle.Y);
            Console.Write(" ");
        }
        static void SetBackgroundColor()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.Clear(); 
        }

        static void InitGame()
        {
            SetBackgroundColor();
 
           bluePaddle = new Coordinate()
            {
                X = 7,
                Y = 0
            };
            redPaddle = new Coordinate()
            {
                X = 135,
                Y = 0
            };
            ball = new Coordinate() {
                X = (Console.WindowWidth/2),
                Y = (Console.WindowHeight/2)
            };
            movebluePaddle(0, 0);
            moveRedPaddle(0,0);
            moveBall(0,0);

        }
        public static void moveBallThread() {
            int dx = 1;
            int dy = 1;
            int redScore = 0;
            int blueScore = 0;
            while(true) {
                if (ball.Y == Console.WindowHeight - 1 || ball.Y == 0) {
                    dy = -dy;
                }
                if (ball.X == Console.WindowWidth - 1 || ball.X == 0) {
                    dx = -dx;
                }
                if ((ball.X == redPaddle.X && Math.Abs(ball.Y - redPaddle.Y) < 2) || (ball.X==bluePaddle.X && Math.Abs(ball.Y - bluePaddle.Y) < 2)) {
                    dx = -dx;
                }
                if(ball.X == 1) {
                    redScore++;
                }
                if(ball.X == Console.WindowWidth - 1) {
                    blueScore++;
                }
                if (blueScore == 3) {
                    Console.WriteLine("Blue Wins!");
                    dy = 0;
                    dx = 0;
                }
                else if (redScore == 3) {
                    Console.WriteLine("Red Wins!");
                    dy = 0;
                    dx = 0;
                }
                moveBall(dx,dy);
                
                System.Threading.Thread.Sleep(200);
       
            
            }
        } 
        static void Main(string[] args)
        {
            InitGame();
            ThreadStart ballThreadRef = new ThreadStart(moveBallThread);
            Thread BallThread = new Thread(ballThreadRef);
            BallThread.Start();
            ConsoleKeyInfo keyInfo;
            //while (().Key != ConsoleKey.Escape) {
            
                while (true) {

                keyInfo = Console.ReadKey(true);
                
                if (keyInfo.Key == ConsoleKey.W) {
                    movebluePaddle(0,-1);
                }
                else if (keyInfo.Key == ConsoleKey.S) {
                    movebluePaddle(0, 1);
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow) {
                    moveRedPaddle(0, -1);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow) {
                    moveRedPaddle(0, 1);
                }
                }
                /*switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        
                        break;
                    case ConsoleKey.S:
                        
                        break;
                    case ConsoleKey.UpArrow:
                        
                        break;
                    case ConsoleKey.DownArrow:
                        
                        break;
                    
                }*/
               
                
            //}
        }
    }
    class Coordinate
{
        public int X { get; set; } //Left
        public int Y { get; set; } //Right
}

}
