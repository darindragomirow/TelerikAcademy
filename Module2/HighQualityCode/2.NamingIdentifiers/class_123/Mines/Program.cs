using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mines
{
    public class Mines
    {
        public class Score
        {
            string name;
            int points;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Points
            {
                get { return points; }
                set { points = value; }
            }

            public Score() { }

            public Score(string namе, int points)
            {
                this.Name = name;
                this.Points = points;
            }
        }

       public static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = CreateField();
            char[,] mine = PlantMine();
            int counter = 0;
            bool fire = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            const int MAX = 35;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh fieldteta bez mini4ki." +
                    " command 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    PrintField(field);
                    flag = false;
                }
                Console.Write("Daj row icol : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row<= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        RankList(champions);
                        break;
                    case "restart":
                        field = CreateField();
                        mine = PlantMine();
                        PrintField(field);
                        fire = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mine[row, col] != '*')
                        {
                            if (mine[row,col] == '-')
                            {
                                YourTurn(field, mine, row,col);
                                counter++;
                            }
                            if (MAX == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                PrintField(field);
                            }
                        }
                        else
                        {
                            fire = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna command\n");
                        break;
                }
                if (fire)
                {
                    PrintField(mine);
                    Console.Write("\nHfirstDimensionfirstDimension! Umria gerojski s {0} to4ki. " +
                        "Daj si nickName: ", counter);
                    string nickName = Console.ReadLine();
                    Score points = new Score(nickName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(points);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < points.Points)
                            {
                                champions.Insert(i, points);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    RankList(champions);

                    field = CreateField();
                    mine = PlantMine();
                    counter = 0;
                    fire = false;
                    flag = true;
                }
                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    PrintField(mine);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Score points = new Score(name, counter);
                    champions.Add(points);
                    RankList(champions);
                    field = CreateField();
                    mine = PlantMine();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void RankList(List<Score> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, points[i].Name, points[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void YourTurn(char[,] FIELD,
            char[,] MINES, int row, int col)
        {
            char NumberOfMines = CalculateNumberOfMines(MINES, row,col);
            MINES[row,col] = NumberOfMines;
            FIELD[row,col] = NumberOfMines;
        }

        private static void PrintField(char[,] board)
        {
            int firstDimension = board.GetLength(0);
            int secondDimension = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < firstDimension; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < secondDimension; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlantMine()
        {
            int rows = 5;
            int cols = 10;
            char[,] battleField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    battleField[i, j] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int number = random.Next(50);
                if (!randomNumbers.Contains(number))
                {
                    randomNumbers.Add(number);
                }
            }

            foreach (int num in randomNumbers)
            {
                int col = (num / cols);
                int row = (num % cols);
                if (row == 0 && num != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }
                battleField[col, row - 1] = '*';
            }

            return battleField;
        }

        private static void SetMinesInField(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char numberOfMines = CalculateNumberOfMines(field, i, j);
                        field[i, j] = numberOfMines;
                    }
                }
            }
        }

        private static char CalculateNumberOfMines(char[,] array, int secondDimension, int firstDimension)
        {
            int counter = 0;
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            if (secondDimension - 1 >= 0)
            {
                if (array[secondDimension - 1, firstDimension] == '*')
                {
                    counter++;
                }
            }
            if (secondDimension + 1 < rows)
            {
                if (array[secondDimension + 1, firstDimension] == '*')
                {
                    counter++;
                }
            }
            if (firstDimension - 1 >= 0)
            {
                if (array[secondDimension, firstDimension - 1] == '*')
                {
                    counter++;
                }
            }
            if (firstDimension + 1 < cols)
            {
                if (array[secondDimension, firstDimension + 1] == '*')
                {
                    counter++;
                }
            }
            if ((secondDimension - 1 >= 0) && (firstDimension - 1 >= 0))
            {
                if (array[secondDimension - 1, firstDimension - 1] == '*')
                {
                    counter++;
                }
            }
            if ((secondDimension - 1 >= 0) && (firstDimension + 1 < cols))
            {
                if (array[secondDimension - 1, firstDimension + 1] == '*')
                {
                    counter++;
                }
            }
            if ((secondDimension + 1 < rows) && (firstDimension - 1 >= 0))
            {
                if (array[secondDimension + 1, firstDimension - 1] == '*')
                {
                    counter++;
                }
            }
            if ((secondDimension + 1 < rows) && (firstDimension + 1 < cols))
            {
                if (array[secondDimension + 1, firstDimension + 1] == '*')
                {
                    counter++;
                }
            }
            return char.Parse(counter.ToString());
        }
    }
}
