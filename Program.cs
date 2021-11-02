using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace temple
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i=1;i<=13;i++)
            {
                for (int j=1;j<=16;j++)
                {
                    if(i==1)
                    {
                        if(j==8)
                        {
                            Console.Write("R");
                        }
                        else
                        {
                            Console.Write(" ");                       
                        }
                    }
                    if(i==2)
                    {
                        if(j>=7 && j<=9)
                        {
                            Console.Write("N ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Thread.Sleep(10);
                    if(i==3)
                    {
                        if(j>=5 && j<=11)
                        {
                            Console.Write("R ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Thread.Sleep(20);
                    if(i==4)
                    {
                        if(j==5 || j==8 || j==11)
                        {
                            Console.Write("N");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Thread.Sleep(20);
                    if(i==5 || i==6)
                    {
                        if(j>=3 && j<=13)
                        {
                            Console.Write("R ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Thread.Sleep(20);
                    if(i==7)
                    {
                        if(j==2 || j==6 || j==10)
                        {
                            Console.Write("N ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Thread.Sleep(20);
                    if(i==8||i==9)
                    {
                        if(j>=1 && j<=15)
                        {
                            Console.Write("R ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Thread.Sleep(20);
                    if(i==10)
                    {
                        if(j==1||j==8||j==15)
                        {
                            Console.Write("N ");
                        }
                        else
                        {
                            Console.Write(" ");
                            Thread.Sleep(20);
                        }
                    }
                    Thread.Sleep(20);
                    if(i>=11 && i<=13)
                    {
                        Console.Write("R ");
                        Thread.Sleep(20);
                    }
                }
                Console.WriteLine();
            }
          for (int i=1;i<=10;i++)
            {
                for(int j=1;j<=15; j++)
                {
                    if( j>=1 && j<=3 || j==6 ||j==8 || j==10 || j>=13 && j<=15)
                    {
                        Console.Write("R ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Thread.Sleep(20);
            }
            Thread.Sleep(20);
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=44;j++)
                {
                    if (i==1 && j<=19 || i==2 && j<=24 || i==3 && j<=29 || i==4 && j<=34 || i==5 && j<=44)
                    {
                        Console.Write("N ");
                    }
                    else
                    {
                        Console.Write(" ");
                        Thread.Sleep(20);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
