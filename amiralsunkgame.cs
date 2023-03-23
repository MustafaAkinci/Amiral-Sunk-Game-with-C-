using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amiralsunkgame
{
    class Program
{
    protected void display(int x, int y, string s)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(s);
    }

    private static void Main(string[] args)
    {

        int coordAX, coordAY, coordBX, coordBY, coordCX, coordCY, Option;
        double BisectorA, r, R, area_inscribed, area_circumscribed, sA, sB, sC, areaS, Uc, Ub, Ua, areaSa, areaSb, areaSc, u, area, areaarea, centroidx, centroidy, CosAngle1, CosAngle2, CosAngle3, AngleA, AngleB, AngleC, medianBCX, medianACX, medianABX, medianBCY, medianACY, medianABY, a, aa, b, bb, c, cc, Ax, Ay, Bx, By, Cx, Cy;

        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;

        coordAX = 0;
        coordAY = 0;
        coordBX = 0;
        coordBY = 0;
        coordCX = 0;
        coordCY = 0;
        Ax = 0;
        Ay = 0;
        Bx = 0;
        By = 0;
        Cx = 0;
        Cy = 0;
        Option = 0;
        area = 0;
        areaarea = 0;
        a = 0;
        b = 0;
        c = 0;

        do
        {
            Console.WriteLine("      /\\                                  __/ ___                                     /\\   ");
            Console.WriteLine("     (  )                           _____/______|                                    (  )    ");
            Console.WriteLine("     (  )                   _______/_____\\_______\\_____                              (  ) ");
            Console.WriteLine("    /|/\\|\\                  \\              < < <       |                            /|/\\|\\");
            Console.WriteLine("  / _||||_ \\            ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~                   / _||||_ \\ ");

            Console.WriteLine("                                                        ");
            Console.WriteLine("                                  █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.WriteLine("                                  █░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Console.WriteLine("                                  █░░║║║╠─║─║─║║║║║╠─░░█");
            Console.WriteLine("                                  █░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Console.WriteLine("                                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            Console.WriteLine("                      ╔════════════════ ►  MENU ◄  ════════════════╗ ");
            Console.WriteLine("                      ║                                            ║ ");
            Console.WriteLine("                      ║ 1 - Entering Ship Location                 ║ ");
            Console.WriteLine("                      ║════════════════════════════════════════════║ ");
            Console.WriteLine("                      ║ 2 - Listing The Properties Of The Ship     ║");
            Console.WriteLine("                      ║════════════════════════════════════════════║ ");
            Console.WriteLine("                      ║ 3 - Shooting At The Ship                   ║");
            Console.WriteLine("                      ║════════════════════════════════════════════║ ");
            Console.WriteLine("                      ║ 4 - Showing High Score Table               ║");
            Console.WriteLine("                      ║════════════════════════════════════════════║ ");
            Console.WriteLine("                      ║ 5 - Exit                                   ║");
            Console.WriteLine("                      ╚════════════════════════════════════════════╝ ");

            int countleft;
            int count = 0;


            //We have created a loop that allows up to 7 attempts. And we have set a few details on feedbacks.(Like When the user enters a number correctly in first try, s/he sees PART1 message, after trying more than 1, s/he sees PART2 message...)

            do
            {
                Console.Write("    Enter the number (between 1 and 5) of option which one do you want to work on: ");
                Option = Convert.ToInt32(Console.ReadLine());
                countleft = 6 - count;
                if ((Option > 5 || Option < 1) && countleft >= 1)
                {
                    if (countleft == 1)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("    THE NUMBER DOES NOT CORRESPOND WITH ANY OPTION.");
                        Console.Write("    THIS IS YOUR LAST ATTEMPT TO ENTER A VALID NUMBER.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("    THE NUMBER DOES NOT CORRESPOND WITH ANY OPTION.");
                        Console.Write("    YOU HAVE "); Console.Write(countleft + " TRIES LEFT.");
                        Console.WriteLine(" ");
                    }
                }

                else if (Option >= 1 && Option <= 5 && count <= 0)
                {//PART1
                    Console.WriteLine("    You have entered a valid number");
                }

                else if (Option >= 1 && Option <= 5)
                {//PART2
                    Console.Write("    You have entered a valid number after "); Console.Write((count + 1) + " tries.");
                    Console.WriteLine(" ");
                }

                count = count + 1;

            }
            while ((Option > 5 || Option < 1) && count <= 6);
            if (count >= 7)
            {
                Console.WriteLine("    YOU HAVE REACHED THE MAXIMUM NUMBER OF ATTEMPTS!");
                Console.WriteLine(" ");
                Console.WriteLine(" ► PRESS ANY KEY TO EXIT. ◄ ");
                Console.ReadKey();
                Environment.Exit(0);
            }


            else
                Console.WriteLine(" ");
            Console.WriteLine("    CURRENT OPTION IS: " + Option);
            Console.WriteLine(" ");
            Console.WriteLine("     ► PRESS ANY KEY TO WORK ON THE CURRENT OPTION. ◄ ");
            Console.ReadKey();

            switch (Option)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("           ► ENTERING SHIP LOCATION ◄ ");
                        Console.WriteLine(" ");
                        Console.Write("Please enter a value (greater than 0, lower than 31) for the x coordinate of first point: ");

                        coordAX = Convert.ToInt32(Console.ReadLine());

                        if (coordAX >= 1 && coordAX <= 30)
                        {
                            Console.WriteLine(" ");
                            Console.Write("Please enter a value (greater than 0, lower than 13) for the y coordinate of first point: ");
                        }
                        else
                        {
                            Console.WriteLine("The value that you have entered is out of range. You must restart the game for entering the new value.");
                            Console.WriteLine(" ► Press any key to exit ◄ ");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        coordAY = Convert.ToInt32(Console.ReadLine());

                        if (coordAY >= 1 && coordAY <= 12)
                        {
                            Console.WriteLine(" ");
                            Console.Write("Please enter a value (greater than 0, lower than 31) for the x coordinate of second point: ");
                        }
                        else
                        {
                            Console.WriteLine("The value that you have entered is out of range. You must restart the game for entering the new value.");
                            Console.WriteLine(" ► Press any key to exit ◄ ");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        coordBX = Convert.ToInt32(Console.ReadLine());


                        if (coordBX >= 1 && coordBX <= 30)
                        {
                            Console.WriteLine(" ");
                            Console.Write("Please enter a value (greater than 0, lower than 13) for the y coordinate of second point: ");
                        }
                        else
                        {
                            Console.WriteLine("The value that you have entered is out of range. You must restart the game for entering the new value.");
                            Console.WriteLine(" ► Press any key to exit ◄ ");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        coordBY = Convert.ToInt32(Console.ReadLine());


                        if (coordBY >= 1 && coordBY <= 12)
                        {
                            Console.WriteLine(" ");
                            Console.Write("Please enter a value (greater than 0, lower than 31) for the x coordinate of third point: ");
                        }
                        else
                        {
                            Console.WriteLine("The value that you have entered is out of range. You must restart the game for entering the new value.");
                            Console.WriteLine(" ► Press any key to exit ◄ ");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        coordCX = Convert.ToInt32(Console.ReadLine());

                        if (coordCX >= 1 && coordCX <= 30)
                        {
                            Console.WriteLine(" ");
                            Console.Write("Please enter a value (greater than 0, lower than 13) for the y coordinate of third point: ");
                        }
                        else
                        {
                            Console.WriteLine("The value that you have entered is out of range. You must restart the game for entering the new value.");
                            Console.WriteLine(" ► Press any key to exit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }


                        coordCY = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");
                        if (coordCY >= 1 && coordCY <= 12)
                        {
                            Console.Clear();
                            Console.WriteLine("You have selected all the points. Now, the possibility of creating triangle with the given points is getting checked.");
                            Console.WriteLine(" ► Press any key to continue ◄ ");
                            Console.ReadKey();
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                        }
                        else
                        {
                            Console.WriteLine("The value that you have entered is out of range. You must restart the game for entering the new value.");
                            Console.WriteLine(" ► Press any key to exit ◄ ");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }

                        // We used this equations to save normal values of inputs. You are going to understand this part well after you see the following explanation parts

                        Ax = coordAX;
                        Ay = coordAY;
                        Bx = coordBX;
                        By = coordBY;
                        Cx = coordCX;
                        Cy = coordCY;
                        // We have found out the values of edges with those formulas. 
                        a = ((Bx - Cx) * (Bx - Cx) + (By - Cy) * (By - Cy));
                        a = Math.Pow(a, 0.5);

                        b = ((Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy));
                        b = Math.Pow(b, 0.5);

                        c = ((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By));
                        c = Math.Pow(c, 0.5);
                        u = (a + b + c) / 2;

                        // We have calculated the area with using values of the edges.
                        area = (u * (u - a) * (u - b) * (u - c));
                        area = Math.Pow(area, 0.5);


                        if (area > 0.00000005)
                        {
                            Console.WriteLine("Well Done!. The points that have been selected by you, are appropriate to create a valid triangle.");
                        }
                        else
                        {
                            Console.WriteLine("The points that have been selected by you, aren't appropriate to create a valid triangle.");
                            Console.WriteLine(" ► Press any key to exit ◄ ");
                            Console.ReadKey();
                            Environment.Exit(0);

                        }




                        Console.WriteLine(" ");

                        Console.WriteLine("finally, the corners of the ship have became as follows in sequence:");
                        Console.WriteLine("Coordinates of A : " + (coordAX, coordAY));
                        Console.WriteLine("Coordinates of B : " + (coordBX, coordBY));
                        Console.WriteLine("Coordinates of C : " + (coordCX, coordCY));

                        Console.WriteLine("Press any key to see these points on coordinate system!");
                        Console.ReadKey();



                        Ax = coordAX;
                        Ay = coordAY;
                        Bx = coordBX;
                        By = coordBY;
                        Cx = coordCX;
                        Cy = coordCY;

                        /*
                          There are two functions in following part. It is changing the values to display coordinates on plane correctly.
                         */

                        coordAX = (coordAX * 3 + 4);
                        coordAY = (14 - coordAY);
                        coordBX = (coordBX * 3 + 4);
                        coordBY = (14 - coordBY);
                        coordCX = (coordCX * 3 + 4);
                        coordCY = (14 - coordCY);

                        Console.Clear();

                        Program p = new Program();
                        // Here is a non-congested coordinate plane. We wanted to do it really different the other coders. But this request had became a problem to us. "Displaying it in new coordinate plane".
                        // We have solved it with creating functions, you can find the explanation in above explanation part.
                        Console.WriteLine("The properties of your ship will have been set after the location has became set according to entered points. ");
                        Console.WriteLine("Here is your coordinate system. ");

                        Console.WriteLine(" 12-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine(" 11-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine(" 10-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  9-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  8-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  7-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  6-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  5-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  4-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  3-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  2-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  1-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("    │──────────────────────────────────────────────────────────────────────────────────────────");
                        Console.WriteLine("   O   1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30");


                        // This part is displaying the coordinates correctly according to function part above
                        p.display(coordAX, coordAY, "A");
                        p.display(coordBX, coordBY, "B");
                        p.display(coordCX, coordCY, "C");
                        p.display(3, 17, "Well Done!");
                        p.display(3, 19, "as you can see, location has been marked on the system.");
                        Console.ReadKey();

                        Console.Clear();

                        break;


                    }


                case (2):
                    {
                        Console.Clear();
                        if (Ax == 0 && Ay == 0 && Bx == 0 && By == 0 && Cx == 0 && Cy == 0)
                        {
                            Console.WriteLine("You have not entered a value yet. You must restart the game for entering the value.");
                            Console.WriteLine(" ► Press any key to exit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        /* 
                          We have improved the sensivity of operations with using the following part. System uses the values that is without truncate function(a,b,c)
                                                                                                      but it also shows the other values to user with truncate function(aa,bb,cc) for better visualization
                         */

                        a = ((Bx - Cx) * (Bx - Cx) + (By - Cy) * (By - Cy));
                        a = Math.Pow(a, 0.5);
                        aa = Math.Truncate(1000 * a) / 1000;
                        b = ((Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy));
                        b = Math.Pow(b, 0.5);
                        bb = Math.Truncate(1000 * b) / 1000;
                        c = ((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By));
                        c = Math.Pow(c, 0.5);
                        cc = Math.Truncate(1000 * c) / 1000;

                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        Console.WriteLine("The size of the ship: " + "a:" + aa + ", " + "b:" + bb + ", " + "c:" + cc);

                        u = (a + b + c) / 2;
                        u = Math.Truncate(1000 * u) / 1000;
                        Console.WriteLine("The perimeter of the ship: " + (u * 2));
                        area = (u * (u - a) * (u - b) * (u - c));
                        area = Math.Pow(area, 0.5);
                        areaarea = Math.Truncate(1000 * area) / 1000;
                        Console.WriteLine("The area of the ship: " + areaarea);


                        medianBCX = (Bx + Cx) / 2;
                        medianBCY = (By + Cy) / 2;
                        medianACX = (Ax + Cx) / 2;
                        medianACY = (Ay + Cy) / 2;
                        medianABX = (Ax + Bx) / 2;
                        medianABY = (Ay + By) / 2;

                        // Following part is finding centroid

                        Console.WriteLine("The median points: " + "MEDIAN POINT OF │BC│ : " + "(" + medianBCX + " , " + medianBCY + ")" + " MEDIAN POINT OF │AC│ : " + "(" + medianACX + " , " + medianACY + ")" + " MEDIAN POINT OF │AB│ : " + "(" + medianABX + " , " + medianABY + ")");
                        centroidx = (Ax + Bx + Cx) / 3;
                        centroidx = Math.Truncate(100 * centroidx) / 100;
                        centroidy = (Ay + By + Cy) / 3;
                        centroidy = Math.Truncate(100 * centroidy) / 100;
                        Console.WriteLine("The centroid of the ship: " + "(" + centroidx + " , " + centroidy + ")");

                        // Following part is calculating the angles 



                        CosAngle1 = ((b * b) - (a * a) + (c * c)) / (2 * (b * c));
                        CosAngle2 = ((a * a) - (b * b) + (c * c)) / (2 * (a * c));
                        CosAngle3 = ((b * b) - (c * c) + (a * a)) / (2 * (b * a));

                        AngleA = Math.Acos(CosAngle1) / Math.PI * 180;
                        AngleA = Math.Truncate(100 * AngleA) / 100;

                        AngleB = Math.Acos(CosAngle2) / Math.PI * 180;
                        AngleB = Math.Truncate(100 * AngleB) / 100;

                        AngleC = Math.Acos(CosAngle3) / Math.PI * 180;
                        AngleC = Math.Truncate(100 * AngleC) / 100;

                        Console.WriteLine("Angle A = " + AngleA + "°");
                        Console.WriteLine("Angle B = " + AngleB + "°");
                        Console.WriteLine("Angle C = " + AngleC + "°");

                        BisectorA = (2 / (b + c)) * (Math.Sqrt(b * c * u * (u - a)));
                        BisectorA = Math.Truncate(1000 * BisectorA) / 1000;
                        r = area / u;
                        R = a * b * c / (area * 4);
                        area_inscribed = Math.PI * (r * r);
                        area_inscribed = Math.Truncate(1000 * area_inscribed) / 1000;
                        area_circumscribed = Math.PI * (R * R);
                        area_circumscribed = Math.Truncate(1000 * area_circumscribed) / 1000;
                        Console.WriteLine("The length of the bisector: " + BisectorA);
                        Console.WriteLine("The area of the inscribed circle: " + area_inscribed);
                        Console.WriteLine("The area of the circumscribed circle: " + area_circumscribed);

                        // Edge Type
                        if (a == b && b == c && a == c)
                            Console.Write("The type of the ship: Equilateral");
                        else if ((a == b) | (a == c) | (b == c))
                            Console.Write("The type of the ship: Isosceles");
                        else
                            Console.Write("The type of the ship: Scalene");

                        // Angle Type
                        if (AngleA < 90 && AngleB < 90 && AngleC < 90)
                            Console.WriteLine(" (Acute-angled)");
                        else if (AngleA == 90 | AngleB == 90 | AngleC == 90)
                            Console.WriteLine(" (Right-angled)");
                        else
                            Console.WriteLine(" (Obtuse-angled)");

                        Console.WriteLine(" ");
                        Console.WriteLine(" ► PRESS ANY KEY TO GO BACK TO MENU ◄ ");
                        Console.ReadKey();

                        Console.Clear();


                        break;

                    }

                case 3:
                    {
                        Console.Clear();
                        if (Ax == 0 && Ay == 0 && Bx == 0 && By == 0 && Cx == 0 && Cy == 0)
                        {
                            Console.WriteLine("You have not entered a value yet. You must restart the game for entering the value.");
                            Console.WriteLine(" ► Press any key to exit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        Random random = new Random();
                        int PX = random.Next(1, 31);
                        int PY = random.Next(1, 13);


                        Console.WriteLine("The random point has been selected like : " + (PX, PY));

                        sA = Math.Pow(((Ax - PX) * (Ax - PX)) + ((Ay - PY) * (Ay - PY)), 0.5);
                        sB = Math.Pow(((Bx - PX) * (Bx - PX)) + ((By - PY) * (By - PY)), 0.5);
                        sC = Math.Pow(((Cx - PX) * (Cx - PX)) + ((Cy - PY) * (Cy - PY)), 0.5);
                        Ua = (sB + sC + a);
                        Ua = Ua / 2;
                        Ub = (sA + sC + b);
                        Ub = Ub / 2;
                        Uc = (sA + sB + c);
                        Uc = Uc / 2;
                        areaSa = Math.Pow((Ua * (Ua - sB) * (Ua - sC) * (Ua - a)), 0.5);
                        areaSb = Math.Sqrt(Ub * (Ub - sA) * (Ub - sC) * (Ub - b));
                        areaSc = Math.Sqrt(Uc * (Uc - sA) * (Uc - sB) * (Uc - c));
                        areaS = areaSa + areaSb + areaSc;


                        Console.Clear();

                        Program p = new Program();

                        Console.WriteLine("Here is your coordinate system. You can see where is the shooting point. ");
                        Console.WriteLine(" ");

                        Console.WriteLine(" 12-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine(" 11-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine(" 10-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  9-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  8-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  7-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  6-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  5-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  4-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  3-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  2-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("  1-│  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·  ·");
                        Console.WriteLine("    │──────────────────────────────────────────────────────────────────────────────────────────");
                        Console.WriteLine("   O   1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30");


                        // This part is displaying the coordinates correctly according to function part above
                        PX = (PX * 3 + 4);
                        PY = (14 - PY);
                        p.display(coordAX, coordAY, "A");
                        p.display(coordBX, coordBY, "B");
                        p.display(coordCX, coordCY, "C");
                        p.display(PX, PY, "X");
                        p.display(3, 17, "");
                        Console.WriteLine("___                                                               ___");
                        Console.WriteLine("   \\  \\______                                                 ______/  /          ");
                        Console.WriteLine("###[== ______►                                               ◄______ ==]###");
                        Console.WriteLine("   /__/                                                             \\__\\              ");
                        Console.WriteLine(" ");
                        Console.WriteLine("as you can see, location of shooting point has been marked on the system.");
                        // we have set a new comparing value according to tolerance

                        if (area - 0.05 < areaS && areaS < area + 0.05)
                        {

                            Console.WriteLine("The ship sinks off!!!!!!!");
                            areaarea = 0;
                        }
                        else
                        {
                            areaarea = Convert.ToInt32(area);
                            Console.WriteLine("The shot has failed!, player got " + areaarea + " points");
                        }


                        Console.WriteLine(" ");
                        Console.WriteLine(" ► PRESS ANY KEY TO GO BACK TO MENU ◄ ");
                        Console.ReadKey();

                        Console.Clear();

                        break;
                    }

                case 4:
                    {
                        Console.Clear();

                        Console.WriteLine("Your score is " + areaarea);
                        Console.WriteLine();
                        Console.WriteLine("Please write your nickname");
                        string nickname = Console.ReadLine();
                        Console.Clear();


                        string first = "    Nazan Kaya: ";
                        string firstpoint = "60";
                        string second = "    Ali Kurt: ";
                        string secondpoint = "30";
                        string third = "    Sibel Arslan: ";
                        string thirdpoint = "10";
                        Console.WriteLine("                  ╔════════════════╗");
                        Console.WriteLine("                  ║SCOREBOARD TABLE║");
                        Console.WriteLine("                  ╚════════════════╝ ");
                        Console.WriteLine();
                        // we have set a new comparing value according to tolerance ( like 60.2, 30.2, 10.2 )
                        if
                         (areaarea > 60.2)
                        {


                            Console.WriteLine("    " + nickname + ": " + areaarea);
                            Console.WriteLine(" ");
                            Console.WriteLine(first + firstpoint);
                            Console.WriteLine(" ");
                            Console.WriteLine(second + secondpoint);

                        }


                        else if
                         (areaarea > 30.2)
                        {
                            Console.WriteLine(first + firstpoint);
                            Console.WriteLine(" ");
                            Console.WriteLine("    " + nickname + ": " + areaarea);
                            Console.WriteLine(" ");
                            Console.WriteLine(second + secondpoint);

                        }




                        else if
                         (areaarea > 10.2)
                        {
                            Console.WriteLine(first + firstpoint);
                            Console.WriteLine(" ");
                            Console.WriteLine(second + secondpoint);
                            Console.WriteLine(" ");
                            Console.WriteLine("    " + nickname + ": " + areaarea);

                        }

                        else
                        {

                            Console.WriteLine(first + firstpoint);
                            Console.WriteLine(" ");
                            Console.WriteLine(second + secondpoint);
                            Console.WriteLine(" ");
                            Console.WriteLine(third + thirdpoint);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Your points are not enough to shown on highscore table");

                        }



                        Program p = new Program();
                        p.display(1, 4, "1-");
                        p.display(1, 6, "2-");
                        p.display(1, 8, "3-");

                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("   ► PRESS ANY KEY TO GO BACK TO MENU ◄ ");
                        Console.ReadKey();

                        Console.Clear();

                        break;

                    }
            }
        }


        while (Option != 5);
        {
            Console.Clear();

            Console.WriteLine("You are leaving the game.                    ║      Story of naming ══╗");
            Console.WriteLine("                                             ║                     There is a reason to name our game as 'bestDEUce'");
            Console.WriteLine("                                             ║                          We wanted to similarize that you and your ship is a deuce. Because we belive on   ╗");
            Console.WriteLine("                                             ║                                                                                                            ↓");
            Console.WriteLine("                                             ║                                                                                                  Anything is possible when you have the right people there to support you.");
            Console.WriteLine("                                             ║                                                                                                                                                                 — Misty Copeland");
            Console.WriteLine("Thank you for playing 'bestDEUce'            ║                                                     ___     _____                       ");
            Console.WriteLine("                                             ║                                                    ║   \\   ║       ║     ║              ");
            Console.WriteLine("                    --Best wishes ^_^ --     ║                          ║     ____  ______  __║_  ║    \\  ║_____  ║     ║  ____ ____   ");
            Console.WriteLine("                                             ║                          ║___  ║___║ ║_____    ║   ║    /  ║       ║     ║ ║     ║___║  ");
            Console.WriteLine("                                                                        ║___║ ║____  ____║    ║   ║___/   ║_____  ║_____║ ║____ ║____  ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                                                                                                                           Programmed by ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                                                                                                                           ► MUSTAFA CAN AKINCI ◄ ");
            Console.WriteLine("                                              ");
            Console.WriteLine("   ► PRESS ANY KEY TO EXIT ◄                  ");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                            ▄▄▄▄  ");
            Console.WriteLine("                                                         ▄███████▄▄██▄▄▄▄▄▄▄▄▄-----------O");
            Console.WriteLine("                                                      ▄▄██████████████▄▄▄");
            Console.WriteLine("                                                     █████████████████████].");
            Console.WriteLine("                                                     00000000000000000000");

            Console.ReadKey();
            Environment.Exit(0);

        }





        Console.ReadLine();

    }

}
}





