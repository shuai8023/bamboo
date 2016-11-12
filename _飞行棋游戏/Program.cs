using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _飞行棋游戏
{
    class Program
    {
        
        //Mr.刘
        //我们用静态字段来模拟全局变量
        static int[] Maps = new int[100];
        //声明一个静态数组用来存储玩家A跟玩家B的坐标
        static int[] PlayerPos = new int[2];
        static void Main(string[] args)
        {
            GameShow();
            InitailMap();
            DrawMap();
            Console.ReadKey();
        }

        /// <summary>
        /// 画游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("****0505.Net飞行棋*******");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("*************************");
        }



        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎
            for (int i = 0; i < luckyturn.Length; i++)
            {
                int index = luckyturn[i];
                Maps[index] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93, 2, 3, 4, 7, 8 };//暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }

        public static void DrawMap()
        {
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                //如果玩家A跟玩家B的坐标相同,并且都在这个地图上，画一个尖括号
                if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
                {
                    Console.Write("<>");
                }
                else if (PlayerPos[0] == i)
                {
                    Console.Write("A");
                }
                else if (PlayerPos[1] == i)
                {
                    Console.Write("B");
                }
                else
                {
                    switch (Maps[i])
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("□");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("◎");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("☆");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("▲");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("卐");
                            break;

                    }
                }
            }
            #endregion
            //画完第一横行之后  应该换行
            Console.WriteLine();

            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }

             
                Console.WriteLine();




            }
        }



        public static void DrawStringMap( int i)
        {
            #region 画图
            //如果玩家A跟玩家B的坐标相同,并且都在这个地图上，画一个尖括号
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                Console.Write("<>");
            }
            else if (PlayerPos[0] == i)
            {
                Console.Write("A");
            }
            else if (PlayerPos[1] == i)
            {
                Console.Write("B");
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("□");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("◎");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("☆");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("▲");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("卐");
                        break;
                        
                }
            }
            #endregion

        }
    }
}
