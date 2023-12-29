using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
            Console.ForegroundColor = ConsoleColor.Green;
            //In the code below, we define the variables.
            String firstAx, firstAy;
            int Ax = 0, Ay = 0, Bx, By, Cx, Cy;
            int Aset = 0, Bset = 0, Cset = 0;
            int Ascore = 0, Bscore = 0, Cscore = 0;
            int Ahealth = 0, Bhealth = 0, Chealth = 0;
            Console.WriteLine("Enter the location of A:");
            Console.Write("Ax: ");
            firstAx = Console.ReadLine();
            Console.Write("Ay: ");
            firstAy = Console.ReadLine();


            //In the code below, we are checking if A coordinates are empty or greater than 10 and smaller than 10.
            if (firstAx == "" | firstAy == "")
            {
                Console.WriteLine("Please,You have to give integer");
                Console.ReadLine();
                Environment.Exit(0);

            }
            else if (Convert.ToInt16(firstAx) <= 10 & Convert.ToInt16(firstAx) >= -10 & Convert.ToInt16(firstAy) <= 10 & Convert.ToInt16(firstAy) >= -10)
            {
                Ax = Convert.ToInt16(firstAx);
                Ay = Convert.ToInt16(firstAy);
            }
            else
            {
                Console.WriteLine("Please, You have to give an integer that is between 10 and -10.");
                Console.ReadLine();
                Environment.Exit(0);
            }

 

            //In the code below, we determined B and C coordinates and sets and healths of A, B, C randomly.
            Random rand = new Random();

            Bx = rand.Next(-10, 11);
            By = rand.Next(-10, 11);
            Cx = rand.Next(-10, 11);
            Cy = rand.Next(-10, 11);
            int whichSet = rand.Next(1, 7);
            int whichHealth = rand.Next(1, 7);

            

            if (whichSet == 1)
            {
                Aset = 1;
                Bset = 2;
                Cset = 3;
            }else if(whichSet == 2)
            {
                Aset = 1;
                Bset = 3;
                Cset = 2;
            }else if(whichSet == 3)
            {
                Aset = 2;
                Bset = 1;
                Cset = 3;
            }else if(whichSet == 4)
            {
                Aset = 2;
                Bset = 3;
                Cset = 1;
            }else if(whichSet == 5)
            {
                Aset = 3;
                Bset = 1;
                Cset = 2;
            }else if(whichSet == 6)
            {
                Aset = 3;
                Bset = 2;
                Cset = 1;
            }

            if (whichHealth == 1)
            {
                Ahealth = 100;
                Bhealth = 80;
                Chealth = 60;
            }
            else if (whichHealth == 2)
            {
                Ahealth = 100;
                Bhealth = 60;
                Chealth = 80;
            }
            else if (whichHealth == 3)
            {
                Ahealth = 80;
                Bhealth = 100;
                Chealth = 60;
            }
            else if (whichHealth == 4)
            {
                Ahealth = 80;
                Bhealth = 60;
                Chealth = 100;
            }
            else if (whichHealth == 5)
            {
                Ahealth = 60;
                Bhealth = 100;
                Chealth = 80;
            }
            else if (whichHealth == 6)
            {
                Ahealth = 60;
                Bhealth = 80;
                Chealth = 100;
            }


            //Here, we are checking if the coordinates are the same.
            if (Ax == Bx & Ay == By | Ax == Cx & Ay == Cy | Bx == Cx & By == Cy)
            {
                Console.WriteLine("The game is over because some coordinates variables are equal.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            //Here, we are writing coordinates,sets and healths of A,B,C.
            Console.WriteLine($"\nA: ({Ax},{Ay})  Set: {Aset}  Health: {Ahealth}");
            Console.WriteLine($"B: ({Bx},{By})  Set: {Bset}  Health: {Bhealth}");
            Console.WriteLine($"C: ({Cx},{Cy})  Set: {Cset}  Health: {Chealth}\n\n");

            Console.ForegroundColor = ConsoleColor.Red;

            //Here, we are writing the coordinate system.
            Console.WriteLine("    + - - - - - - - - - - ^ - - - - - - - - - - +");
            Console.WriteLine("10  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("9   | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("8   | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("7   | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("6   | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("5   | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("4   | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("3   | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("2   | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("1   | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("0   | - - - - - - - - - - + - - - - - - - - - - >");
            Console.WriteLine("-1  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-2  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-3  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-4  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-5  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-6  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-7  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-8  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-9  | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("-10 | . . . . . . . . . . | . . . . . . . . . . |");
            Console.WriteLine("    + - - - - - - - - - - - - - - - - - - - - - +");
            Console.WriteLine("      0 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 0  ");

            //Here, we are adding A,B,C to the coordinate system.
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(26 + (Ax * 2),20 - Ay);
            Console.Write('A');

            Console.SetCursorPosition(26 + (Bx * 2), 20 - By);
            Console.Write('B');

            Console.SetCursorPosition(26 + (Cx * 2), 20 - Cy);
            Console.Write('C');

            Console.SetCursorPosition(0, 34);


            //Here, we are finding distances between archers.
            Double A_B = Math.Pow(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2), 0.5);
            Double B_C = Math.Pow(Math.Pow((Bx - Cx), 2) + Math.Pow((By - Cy), 2), 0.5);
            Double A_C = Math.Pow(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2), 0.5);


            Console.ForegroundColor = ConsoleColor.Blue;
            //Here, we are finding the smallest distance between archers. 
            if (A_B < B_C & A_B < A_C & A_B <= 15)
            {
                //Here, the two archers which have the smallest distance are fighting(A-B).
                Console.WriteLine("Round 1: A-B\n");

                if(Aset == 3 & Bset == 2 | Aset == 2 & Bset == 1 | Aset == 1 & Bset == 3)
                {
                    //Awin
                    Bhealth = 0;
                    Bscore = 0;
                    Cscore = 0;
                    Ahealth = Ahealth - 25;
                    Ascore = 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Ahealth);

                    Console.WriteLine($"A: Survivor      Health: {Ahealth}    Score:{Ascore}");
                    Console.WriteLine($"B: Defeated      Health: {Bhealth}    Score:{Bscore}");
                    Console.WriteLine($"C: Non-fighter   Health: {Chealth}    Score:{Cscore}\n\n");

                    if(A_C <= 15)
                    {
                        Console.WriteLine("Round 2: A-C\n");

                        if (Aset == 3 & Cset == 2)
                        {
                            //A WIN
                            Chealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy)) + (100 - Ahealth);
                        }
                        else if (Aset == 2 & Cset == 1)
                        {
                            //A WIN
                            Chealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy)) + (100 - Ahealth);
                        }
                        else if (Aset == 1 & Cset == 3)
                        {
                            //A WIN
                            Chealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy)) + (100 - Ahealth);
                        }
                        else
                        {
                            //C WIN
                            Ahealth = 0;
                            Chealth = Chealth - 25;
                            Cscore = Cscore + 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy)) + (100 - Chealth);
                        }
                        
                        if(Ahealth == 0)
                        {
                            Console.WriteLine($"A: Defeated      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Defeated      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Survivor      Health: {Chealth}    Score:{Cscore}\n\n");
                        }
                        else
                        {
                            Console.WriteLine($"A: Survivor      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Defeated      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Defeated      Health: {Chealth}    Score:{Cscore}\n\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Round 2: A-C\n");

                        Console.WriteLine("Too distant, no attack");
                    }

                }
                else
                {
                    //B WIN
                    Ahealth = 0;
                    Ascore = 0;
                    Cscore = 0;
                    Bhealth = Bhealth - 25;
                    Bscore = 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Bhealth);
                    
                    Console.WriteLine($"A: Defeated      Health: {Ahealth}    Score:{Ascore}");
                    Console.WriteLine($"B: Survivor      Health: {Bhealth}    Score:{Bscore}");
                    Console.WriteLine($"C: Non-fighter   Health: {Chealth}    Score:{Cscore}\n\n");

                    if (B_C <= 15)
                    {
                        Console.WriteLine("Round 2: B-C\n");

                        if (Bset == 3 & Cset == 2)
                        {
                            //B WIN
                            Chealth = 0;
                            Bhealth = Bhealth - 25;
                            Bscore = Bscore + 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Bhealth);
                        }
                        else if (Bset == 2 & Cset == 1)
                        {
                            //B WIN
                            Chealth = 0;
                            Bhealth = Bhealth - 25;
                            Bscore = Bscore + 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Bhealth);
                        }
                        else if (Bset == 1 & Cset == 3)
                        {
                            //B WIN
                            Chealth = 0;
                            Bhealth = Bhealth - 25;
                            Bscore = Bscore + 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Bhealth);

                        }
                        else
                        {
                            //C WIN
                            Bhealth = 0;
                            Chealth = Chealth - 25;
                            Cscore = Cscore + 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Chealth);
                        }


                        if (Bhealth == 0)
                        {
                            Console.WriteLine($"A: Defeated      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Defeated      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Survivor      Health: {Chealth}    Score:{Cscore}\n\n");
                        }
                        else
                        {
                            Console.WriteLine($"A: Defeated      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Survivor      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Defeated      Health: {Chealth}    Score:{Cscore}\n\n");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Round 2: B-C\n");

                        Console.WriteLine("Too distant, no attack");
                    }
                }
            }
            else if (B_C < A_B & B_C < A_C & B_C <= 15)
            {
                //Here, the two archers which have the smallest distance are fighting(B-C).
                Console.WriteLine("Round 1: B-C\n");

                if(Bset == 3 & Cset == 2 | Bset == 2 & Cset == 1 | Bset == 1 & Cset == 3)
                {
                    //B WIN

                    Chealth = 0;
                    Cscore = 0;
                    Bhealth = Bhealth - 25;
                    Bscore = 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Bhealth);

                    Console.WriteLine($"A: Non-fighter      Health: {Ahealth}    Score:{Ascore}");
                    Console.WriteLine($"B: Survivor         Health: {Bhealth}    Score:{Bscore}");
                    Console.WriteLine($"C: Defeated         Health: {Chealth}    Score:{Cscore}\n\n");

                    if (A_B <= 15)
                    {
                        Console.WriteLine("Round 2: A-B\n");

                        if (Aset == 1 & Bset == 3)
                        {
                            //A WIN
                            Bhealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Ahealth);

                        }
                        else if (Aset == 3 & Bset == 2)
                        {
                            //A WIN
                            Bhealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Ahealth);
                        }
                        else if (Aset == 2 & Bset == 1)
                        {
                            //A WIN
                            Bhealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Ahealth);
                        }
                        else
                        {
                            //B WIN
                            Ahealth = 0;
                            Bhealth = Bhealth - 25;
                            Bscore = Bscore + 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Bhealth);
                        }

                        if (Ahealth == 0)
                        {
                            Console.WriteLine($"A: Defeated      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Survivor      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Defeated      Health: {Chealth}    Score:{Cscore}\n\n");
                        }
                        else
                        {
                            Console.WriteLine($"A: Survivor      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Defeated      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Defeated      Health: {Chealth}    Score:{Cscore}\n\n");
                        }




                    }
                    else
                    {
                        Console.WriteLine("Round 2: A-B\n");

                        Console.WriteLine("Too distant, no attack");
                    }


                }
                else
                {
                    //C WIN
                    Bhealth = 0;
                    Bscore = 0;
                    Chealth = Chealth - 25;
                    Cscore = 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Chealth);

                    Console.WriteLine($"A: Non-fighter      Health: {Ahealth}    Score:{Ascore}");
                    Console.WriteLine($"B: Defeated         Health: {Bhealth}    Score:{Bscore}");
                    Console.WriteLine($"C: Survivor         Health: {Chealth}    Score:{Cscore}\n\n");

                    if (A_C <= 15)
                    {
                        Console.WriteLine("Round 2: A-C\n");

                        if (Aset == 1 & Cset == 3)
                        {
                            //A WIN
                            Chealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy)) + (100 - Ahealth);

                        }
                        else if (Aset == 2 & Cset == 1)
                        {
                            //A WIN
                            Chealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy)) + (100 - Ahealth);
                        }
                        else if (Aset == 3 & Cset == 2)
                        {
                            //A WIN

                            Chealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy)) + (100 - Ahealth);
                        }
                        else
                        {
                            //C WIN
                            Ahealth = 0;
                            Chealth = Chealth - 25;
                            Cscore = Cscore + 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy) + (100 - Chealth));
                        }

                        if (Ahealth == 0)
                        {
                            Console.WriteLine($"A: Defeated      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Defeated      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Survivor      Health: {Chealth}    Score:{Cscore}\n\n");
                        }
                        else
                        {
                            Console.WriteLine($"A: Survivor      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Defeated      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Defeated      Health: {Chealth}    Score:{Cscore}\n\n");
                        }



                    }
                    else
                    {
                        Console.WriteLine("Round 2: A-C\n");

                        Console.WriteLine("Too distant, no attack");
                    }

                }

            }
            else if (A_C < A_B & A_C < B_C & A_C <= 15)
            {
                //Here, the two archers which have the smallest distance are fighting(A-C).
                Console.WriteLine("Round 1: A-C\n");

                if(Aset == 3 & Cset == 2 | Aset == 2 & Cset == 1 | Aset == 1 & Cset == 3)
                {
                    //A WIN
                    Chealth = 0;
                    Cscore = 0;
                    Ahealth = Ahealth - 25;
                    Ascore = 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy)) + (100 - Ahealth);

                    Console.WriteLine($"A: Survivor         Health: {Ahealth}    Score:{Ascore}");
                    Console.WriteLine($"B: Non-fighter      Health: {Bhealth}    Score:{Bscore}");
                    Console.WriteLine($"C: Defeated         Health: {Chealth}    Score:{Cscore}\n\n");

                    if (A_B <= 15)
                    {
                        Console.WriteLine("Round 2: A-B\n");

                        if (Aset == 3 & Bset == 2)
                        {
                            //A WIN
                            Bhealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Ahealth);

                        }
                        else if (Aset == 1 & Bset == 3)
                        {
                            //A WIN
                            Bhealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Ahealth);
                        }
                        else if (Aset == 2 & Bset == 1)
                        {
                            //A WIN
                            Bhealth = 0;
                            Ahealth = Ahealth - 25;
                            Ascore = Ascore + 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Ahealth);
                        }
                        else
                        {
                            //B WIN
                            Ahealth = 0;
                            Bhealth = Bhealth - 25;
                            Bscore = Bscore + 10 * (Math.Abs(Ax - Bx) + Math.Abs(Ay - By)) + (100 - Bhealth);
                        }


                        if (Ahealth == 0)
                        {
                            Console.WriteLine($"A: Defeated      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Survivor      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Defeated      Health: {Chealth}    Score:{Cscore}\n\n");
                        }
                        else
                        {
                            Console.WriteLine($"A: Survivor      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Defeated      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Defeated      Health: {Chealth}    Score:{Cscore}\n\n");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Round 2: A-B\n");

                        Console.WriteLine("Too distant, no attack");
                    }

                }
                else
                {
                    //C WIN
                    Ahealth = 0;
                    Ascore = 0;
                    Chealth = Chealth - 25;
                    Cscore = 10 * (Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy)) + (100 - Chealth);

                    Console.WriteLine($"A: Defeated         Health: {Ahealth}    Score:{Ascore}");
                    Console.WriteLine($"B: Non-fighter      Health: {Bhealth}    Score:{Bscore}");
                    Console.WriteLine($"C: Survivor         Health: {Chealth}    Score:{Cscore}\n\n");

                    if (B_C <= 15)
                    {
                        Console.WriteLine("Round 2: B-C\n");

                        if (Cset == 3 & Bset == 2)
                        {
                            //C WIN
                            Bhealth = 0;
                            Chealth = Chealth - 25;
                            Cscore = Cscore + 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Chealth);

                        }
                        else if (Cset == 1 & Bset == 3)
                        {
                            //C WIN
                            Bhealth = 0;
                            Chealth = Chealth - 25;
                            Cscore = Cscore + 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Chealth);
                        }
                        else if (Cset == 2 & Bset == 1)
                        {
                            //C WIN
                            Bhealth = 0;
                            Chealth = Chealth - 25;
                            Cscore = Cscore + 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Chealth);
                        }
                        else
                        {
                            //B WIN
                            Chealth = 0;
                            Bhealth = Bhealth - 25;
                            Bscore = Bscore + 10 * (Math.Abs(Cx - Bx) + Math.Abs(Cy - By)) + (100 - Bhealth);
                        }

                        if (Bhealth == 0)
                        {
                            Console.WriteLine($"A: Defeated      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Defeated      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Survivor      Health: {Chealth}    Score:{Cscore}\n\n");
                        }
                        else
                        {
                            Console.WriteLine($"A: Defeated      Health: {Ahealth}    Score:{Ascore}");
                            Console.WriteLine($"B: Survivor      Health: {Bhealth}    Score:{Bscore}");
                            Console.WriteLine($"C: Defeated      Health: {Chealth}    Score:{Cscore}\n\n");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Round 2: B-C\n");

                        Console.WriteLine("Too distant, no attack");
                    }


                }

            }
            else
            {
                //Here we check the distances if they are equal or greater than 15.
                Console.WriteLine("All distances between archers are equal(Equilateral triangle) or all distances is bigger than 15.");
                Console.ReadLine();
                Environment.Exit(0);

            }

            Console.ForegroundColor = ConsoleColor.White;

            if (Cscore > Bscore & Cscore > Ascore)
            {
                Console.WriteLine($"C has the maximum score ({Cscore})");
            }
            else if(Bscore > Cscore & Bscore > Ascore)
            {
                Console.WriteLine($"B has the maximum score ({Bscore})");
            }
            else
            {
                Console.WriteLine($"A has the maximum score ({Ascore})");
            }

            Console.ReadLine();


           

        }

    }
}

