using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileRecharge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
       //     Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t*");
         //   Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t* *");
          //  Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t* *");
            //Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t* *");
          //  Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t______________________________");
            //Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t..............................");
            Console.WriteLine("\t********************************************************");
            Console.WriteLine("\t*          WELCOME TO MOBILE RECHARGE SHOP             *");
          //  Console.WriteLine("\t*\t\t\t\t\t\t*PRESS ENTER*\t\t\t\t\t\t\t\t\t\t\t\t\t\t *");
            Console.WriteLine("\t********************************************************");
          // Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ! :\t\t\t\t\t\t\t: !");
      //      Console.WriteLine("\t\tt\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t! :..............: !");
        //    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ! : {#} [  ] {*} : !");
          //  Console.WriteLine("|t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ! : _____________: !");
            //Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ! :|1    2    3 |: !");
       //     Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ! :| 4   5     6|: !");
         //   Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ! :| 7   8     9|: !");
          //  Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ! :| *   0     #|: !");
            //Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ! :|____________|: !");
            Console.ResetColor();
            Console.ResetColor();
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter Mobile No:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            long c = long.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("SELECT YOUR MOBILE NETWORK");
            Console.WriteLine("1. BSNL");
            Console.WriteLine("2. RELIANCE");
            Console.WriteLine("3. IDEA");
            Console.WriteLine("4. AIRTEL ");
            Console.WriteLine("5. VODAFONE");
            Console.WriteLine("6. DOCOMO");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter any network between 1 to 6:");
            Console.ResetColor();
            int n = int.Parse(Console.ReadLine());
            while (n <= 0 || n > 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SELECT CORRECT NETWORK:");
                Console.ResetColor();
                n = int.Parse(Console.ReadLine());
            }
            switch (n)
            {
                case 7:
                    Console.WriteLine("SELECT YOUR PACKAGE");
                    Console.WriteLine("1. NORMAL RECHARGE");
                    Console.WriteLine("2. INTERNET RECHARGE");
                    Console.WriteLine("3. SMS RECHARGE");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("select between 1 to 3");
                    Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t WELCOME TO BSNL");
                    Console.WriteLine("\t\t\t__________________");
                    Console.ResetColor();
                    goto case 7;
                //break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t WELCOME TO RELIANCE");
                    Console.WriteLine("\t\t\t__________________");
                    Console.ResetColor();
                    goto case 7;
                //break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t WELCOME TO IDEA");
                    Console.WriteLine("\t\t\t__________________");
                    Console.ResetColor();
                    goto case 7;
                // break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t WELCOME TO AIRTEL");
                    Console.WriteLine("\t\t\t__________________");
                    Console.ResetColor();
                    goto case 7;
                //break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t WELCOME TO VODAFONE");
                    Console.WriteLine("\t\t\t__________________");
                    Console.ResetColor();
                    goto case 7;
                // break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t WELCOME TO DOCOMO");
                    Console.WriteLine("\t\t\t__________________");
                    Console.ResetColor();
                    goto case 7;
                    //break;
            }
            int j = int.Parse(Console.ReadLine());
            while (j <= 0 || j > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SELECT YOUR PACKAGE:");
                Console.ResetColor();
                j = int.Parse(Console.ReadLine());
            }
            if (n == 1)
            {
                if (j == 1)
                {
                    Console.WriteLine("1. RECHARGE RC 10/-");
                    Console.WriteLine("2. RECHARGE RC 30/-");
                    Console.WriteLine("3. RECHARGE RC 50/-");
                    Console.WriteLine("4. RECHARGE RC 70/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("select between 1 to 4");
                    Console.ResetColor();
                    int m = int.Parse(Console.ReadLine());
                    while (m <= 0 || m > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        m = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if (j == 2)
                {
                    Console.WriteLine("1. RECHARGE RC=9/-");
                    Console.WriteLine("2. RECHARGE RC=32/-");
                    Console.WriteLine("3. RECHARGE RC=58/-");
                    Console.WriteLine("4. RECHARGE RC=98/-");
                    Console.WriteLine("5. RECHARGE RC=153/-");
                    Console.WriteLine("6. RECHARGE RC=224/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int k = int.Parse(Console.ReadLine());
                    while (k <= 0 || k > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        k = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (k)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if (j == 3)
                {
                    Console.WriteLine("1. RECHARGE RC=9/-");
                    Console.WriteLine("2. RECHARGE RC=17/-");
                    Console.WriteLine("3. RECHARGE RC=34/-");
                    Console.WriteLine("4. RECHARGE RC=98/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 4:");
                    Console.ResetColor();
                    int s = int.Parse(Console.ReadLine());
                    while (s <= 0 || s > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        s = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (s)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
            }
            else if (n == 2)
            {
                if (j == 1)
                {
                    Console.WriteLine("1. RECHARGE RC=10/-");
                    Console.WriteLine("2. RECHARGE RC=20/-");
                    Console.WriteLine("3. RECHARGE RC=30/-");
                    Console.WriteLine("4. RECHARGE RC=50/-");
                    Console.WriteLine("5. RECHARGE RC=100/-");
                    Console.WriteLine("6. RECHARGE RC=200/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int m = int.Parse(Console.ReadLine());
                    while (m <= 0 || m > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        m = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if (j == 2)
                {
                    Console.WriteLine("1. RECHARGE RC=9/-");
                    Console.WriteLine("2. RECHARGE RC=34/-");
                    Console.WriteLine("3. RECHARGE RC=57/-");
                    Console.WriteLine("4. RECHARGE RC=72/-");
                    Console.WriteLine("5. RECHARGE RC=123/-");
                    Console.WriteLine("6. RECHARGE RC=254/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int k = int.Parse(Console.ReadLine());
                    while (k <= 0 || k > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        k = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (k)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if (j == 3)
                {
                    Console.WriteLine("1. RECHARGE RC=9/-");
                    Console.WriteLine("2. RECHARGE RC=32/-");
                    Console.WriteLine("3. RECHARGE RC=58/-");
                    Console.WriteLine("4. RECHARGE RC=98/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 4:");
                    Console.ResetColor();
                    int s = int.Parse(Console.ReadLine());
                    while (s <= 0 || s > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        s = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (s)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
            }
            else if (n == 3)
            {
                if (j == 1)
                {
                    Console.WriteLine("1. RECHARGE RC=10/-");
                    Console.WriteLine("2. RECHARGE RC=20/-");
                    Console.WriteLine("3. RECHARGE RC=30/-");
                    Console.WriteLine("4. RECHARGE RC=50/-");
                    Console.WriteLine("5. RECHARGE RC=100/-");
                    Console.WriteLine("6. RECHARGE RC=200/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int m = int.Parse(Console.ReadLine());
                    while (m <= 0 || m > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        m = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if (j == 2)
                {
                    Console.WriteLine("1. RECHARGE RC=17/-");
                    Console.WriteLine("2. RECHARGE RC=38/-");
                    Console.WriteLine("3. RECHARGE RC=56/-");
                    Console.WriteLine("4. RECHARGE RC=86/-");
                    Console.WriteLine("5. RECHARGE RC=128/-");
                    Console.WriteLine("6. RECHARGE RC=264/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int k = int.Parse(Console.ReadLine());
                    while (k <= 0 || k > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        k = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (k)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if (j == 3)
                {
                    Console.WriteLine("1. RECHARGE RC=9/-");
                    Console.WriteLine("2. RECHARGE RC=32/-");
                    Console.WriteLine("3. RECHARGE RC=58/-");
                    Console.WriteLine("4. RECHARGE RC=98/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 4:");
                    Console.ResetColor();
                    int s = int.Parse(Console.ReadLine());
                    while (s <= 0 || s > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        s = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (s)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
            }
            else if (n == 4)
            {
                if (j == 1)
                {
                    Console.WriteLine("1. RECHARGE RC=10/-");
                    Console.WriteLine("2. RECHARGE RC=20/-");
                    Console.WriteLine("3. RECHARGE RC=30/-");
                    Console.WriteLine("4. RECHARGE RC=40/-");
                    Console.WriteLine("5. RECHARGE RC=50/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 5:");
                    Console.ResetColor();
                    int m = int.Parse(Console.ReadLine());
                    while (m <= 0 || m > 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        m = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if (j == 2)
                {
                    Console.WriteLine("1. RECHARGE RC=16/-");
                    Console.WriteLine("2. RECHARGE RC=39/-");
                    Console.WriteLine("3. RECHARGE RC=55/-");
                    Console.WriteLine("4. RECHARGE RC=85/-");
                    Console.WriteLine("5. RECHARGE RC=130/-");
                    Console.WriteLine("6. RECHARGE RC=252/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int k = int.Parse(Console.ReadLine());
                    while (k <= 0 || k > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        k = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (k)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if (j == 3)
                {
                    Console.WriteLine("1. RECHARGE RC=9/-");
                    Console.WriteLine("2. RECHARGE RC=32/-");
                    Console.WriteLine("3. RECHARGE RC=58/-");
                    Console.WriteLine("4. RECHARGE RC=98/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 4:");
                    Console.ResetColor();
                    int s = int.Parse(Console.ReadLine());
                    while (s <= 0 || s > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        s = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (s)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
            }
            else if (n == 5)
            {
                if (j == 1)
                {
                    Console.WriteLine("1. RECHARGE RC=10/-");
                    Console.WriteLine("2. RECHARGE RC=20/-");
                    Console.WriteLine("3. RECHARGE RC=30/-");
                    Console.WriteLine("4. RECHARGE RC=50/-");
                    Console.WriteLine("5. RECHARGE RC=100/-");
                    Console.WriteLine("6. RECHARGE RC=200/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int m = int.Parse(Console.ReadLine());
                    while (m <= 0 || m > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        m = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if (j == 2)
                {
                    Console.WriteLine("1. RECHARGE RC=9/-");
                    Console.WriteLine("2. RECHARGE RC=38/-");
                    Console.WriteLine("3. RECHARGE RC=56/-");
                    Console.WriteLine("4. RECHARGE RC=89/-");
                    Console.WriteLine("5. RECHARGE RC=128/-");
                    Console.WriteLine("6. RECHARGE RC=264/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int k = int.Parse(Console.ReadLine());
                    while (k <= 0 || k > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        k = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (k)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if(j==3)
                {
                    Console.WriteLine("1. RECHARGE RC=14/-");
                    Console.WriteLine("2. RECHARGE RC=23/-");
                    Console.WriteLine("3. RECHARGE RC=36/-");
                    Console.WriteLine("4. RECHARGE RC=97/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 4:");
                    Console.ResetColor();
                    int s = int.Parse(Console.ReadLine());
                    while (s <= 0 || s > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        s = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (s)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
            }
            else if(n==6)
            {
                if(j==1)
                {
                    Console.WriteLine("1. RECHARGE RC=10/-");
                    Console.WriteLine("2. RECHARGE RC=20/-");
                    Console.WriteLine("3. RECHARGE RC=30/-");
                    Console.WriteLine("4. RECHARGE RC=50/-");
                    Console.WriteLine("5. RECHARGE RC=100/-");
                    Console.WriteLine("6. RECHARGE RC=200/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int m = int.Parse(Console.ReadLine());
                    while (m <= 0 || m > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        m = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if(j==2)
                {
                    Console.WriteLine("1. RECHARGE RC=9/-");
                    Console.WriteLine("2. RECHARGE RC=38/-");
                    Console.WriteLine("3. RECHARGE RC=56/-");
                    Console.WriteLine("4. RECHARGE RC=89/-");
                    Console.WriteLine("5. RECHARGE RC=128/-");
                    Console.WriteLine("6. RECHARGE RC=264/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 6:");
                    Console.ResetColor();
                    int k = int.Parse(Console.ReadLine());
                    while (k <= 0 || k > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        k = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (k)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 5:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 6:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
                else if(j==3)
                {
                    Console.WriteLine("1. RECHARGE RC=14/-");
                    Console.WriteLine("2. RECHARGE RC=21/-");
                    Console.WriteLine("3. RECHARGE RC=36/-");
                    Console.WriteLine("4. RECHARGE RC=103/-");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ENTER BETWEEN 1 TO 4:");
                    Console.ResetColor();
                    int s = int.Parse(Console.ReadLine());
                    while (s <= 0 || s > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SELECT CORRECT ONE!!");
                        Console.ResetColor();
                        s = int.Parse(Console.ReadLine());
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\a\a\a\a\a");
                    switch (s)
                    {
                        case 1:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 2:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 3:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                        case 4:
                            Console.WriteLine("YOUR RECHARGE SUCCESSFUL");
                            break;
                    }
                    Console.Beep();
                    Console.ResetColor();
                }
            }
            Console.ReadLine();
        }
    }
}



 
  
