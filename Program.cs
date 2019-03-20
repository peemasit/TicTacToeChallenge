using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeChallenge {
    class Program {
        static char[,] playfiled = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        static int count = 1;
        static void Main(string[] args) {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;
            do {

                if (player == 2) {
                    player = 1;
                    ChooseXorO('X', input);
                } else if (player == 1) {
                    player = 2;
                    ChooseXorO('O', input);
                }
                SetFiled();

                char[] checks = { 'O', 'X' };
                foreach (char check in checks) {
                    if (playfiled[0, 0] == check && playfiled[0, 1] == check && playfiled[0, 2] == check ||
                        playfiled[1, 0] == check && playfiled[1, 1] == check && playfiled[1, 2] == check ||
                        playfiled[2, 0] == check && playfiled[2, 1] == check && playfiled[2, 2] == check ||
                        playfiled[0, 0] == check && playfiled[1, 0] == check && playfiled[2, 0] == check ||
                        playfiled[0, 1] == check && playfiled[1, 1] == check && playfiled[2, 1] == check ||
                        playfiled[0, 2] == check && playfiled[1, 2] == check && playfiled[2, 2] == check ||
                        playfiled[0, 0] == check && playfiled[1, 1] == check && playfiled[2, 2] == check ||
                        playfiled[0, 2] == check && playfiled[1, 1] == check && playfiled[2, 0] == check) {
                        Console.WriteLine("we have the winner!");
                        if (player == 1) {
                            Console.WriteLine($"Player 2 has won!");
                        } else {
                            Console.WriteLine($"Player 1 has won!");
                        }
                        ResetFiled();

                    } else if (count == 10) {
                        Console.WriteLine("Drawww!");
                        ResetFiled();

                    }
                }
                do {
                    Console.Write($"player {player},choose field number! :");
                    try {
                        input = Convert.ToInt32(Console.ReadLine());
                    } catch (Exception) {
                        Console.WriteLine("please enter field number!");
                    }
                    if ((input == 1) && (playfiled[0, 0] == '1')) {
                        inputCorrect = true;
                    } else if ((input == 2) && (playfiled[0, 1] == '2')) {
                        inputCorrect = true;
                    } else if ((input == 3) && (playfiled[0, 2] == '3')) {
                        inputCorrect = true;
                    } else if ((input == 4) && (playfiled[1, 0] == '4')) {
                        inputCorrect = true;
                    } else if ((input == 5) && playfiled[1, 1] == '5') {
                        inputCorrect = true;
                    } else if ((input == 6) && playfiled[1, 2] == '6') {
                        inputCorrect = true;
                    } else if ((input == 7) && playfiled[2, 0] == '7') {
                        inputCorrect = true;
                    } else if ((input == 8) && playfiled[2, 1] == '8') {
                        inputCorrect = true;
                    } else if ((input == 9) && playfiled[2, 2] == '9') {
                        inputCorrect = true;
                    } else {
                        Console.WriteLine("please choose another filed!");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
                count++;

            } while (true);
        }

        static void SetFiled() {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {playfiled[0, 0]}  |  {playfiled[0, 1]}  |  {playfiled[0, 2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {playfiled[1, 0]}  |  {playfiled[1, 1]}  |  {playfiled[1, 2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {playfiled[2, 0]}  |  {playfiled[2, 1]}  |  {playfiled[2, 2]}  ");
            Console.WriteLine("     |     |     ");
            Console.WriteLine();
        }
        public static void ChooseXorO(char filed, int input) {
            switch (input) {
                case 1: playfiled[0, 0] = filed; break;
                case 2: playfiled[0, 1] = filed; break;
                case 3: playfiled[0, 2] = filed; break;
                case 4: playfiled[1, 0] = filed; break;
                case 5: playfiled[1, 1] = filed; break;
                case 6: playfiled[1, 2] = filed; break;
                case 7: playfiled[2, 0] = filed; break;
                case 8: playfiled[2, 1] = filed; break;
                case 9: playfiled[2, 2] = filed; break;
            }

        }
        public static void ResetFiled() {
            char[,] playfiled1 = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            Console.WriteLine("Please press any key to restart!");
            Console.ReadLine();
            playfiled = playfiled1;
            SetFiled();
            count = 0;

        }
    }
}
