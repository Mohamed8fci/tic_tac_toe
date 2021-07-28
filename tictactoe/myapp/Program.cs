using System;

namespace myapp
{
    class Program
    {   
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] board = new char[3,3];
            intialize(board);
            int moveplayed =0;
             
             // game play
             while (true)
             {
                 Console.Clear();
                 print(board);

             Console.WriteLine("please enter row: ");
             int row = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("please enter col: ");
             int col = Convert.ToInt32(Console.ReadLine());
             board[row,col] = player;

            //won the game
             if (player == board[0,0] && player == board[0,1] && player== board[0,2])
             {
                 Console.WriteLine(player +" won the game");
                 break;
             }

             if (player == board[1,0] && player == board[1,1] && player== board[1,2])
             {
                 Console.WriteLine(player +" won the game");
                 break;
             }
             if (player == board[2,0] && player == board[2,1] && player== board[2,2])
             {
                 Console.WriteLine(player +" won the game");
                 break;
             }
             if (player == board[0,0] && player == board[1,0] && player== board[2,0])
             {
                 Console.WriteLine(player +" won the game");
                 break;
             }
             if (player == board[0,1] && player == board[1,1] && player== board[2,1])
             {
                 Console.WriteLine(player +" won the game");
                 break;
             }
             if (player == board[0,2] && player == board[1,2] && player== board[2,2])
             {
                 Console.WriteLine(player +" won the game");
                 break;
             }
             if (player == board[0,0] && player == board[1,1] && player== board[2,2])
             {
                 Console.WriteLine(player +" won the game");
                 break;
             }
             if (player == board[0,2] && player == board[1,1] && player== board[2,0])
             {
                 Console.WriteLine(player +" won the game");
                 break;
             }


             // check draw 
             moveplayed++;
             if (moveplayed==9)
             {
                 Console.WriteLine("Draw");
                 break;
             }

             player = turnplayer(player);             
            }
        }
            static char turnplayer(char currentplayer){
                
             if (currentplayer == 'X')
             {
                 return 'O';
             }else
             {
                 return 'X';
             }
            }
            static void intialize(char[,]board){

                for(int row=0;row<3;row++){
                for (int col=0; col < 3; col++){
                   board[row,col] = ' ';
                }                
            }
            }
            static void print(char[,] board){

                 for (int row = 0;row < 3;row++){

                Console.Write(" |");

                for(int col=0;col<3;col++){
                     Console.Write(board[row,col]);
                     Console.Write(" | ");
                }
                    Console.WriteLine();
            }   

            }
        }
    }

