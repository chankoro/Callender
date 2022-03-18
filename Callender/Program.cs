using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob8_14
{
    class Program
    {
        static void Main(string[] args)
        { 
            // 年月入力テキストボックス
            //Console.Write("年を入力してください");
            //Console.WriteLine();
            //Console.Write("年:");
            // 年を入力
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}年",year);
            // 閏年かの確認
            int urucheck = 0;
            // 月を入力
            //Console.Write("月:");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0}月:",month);

            // 曜日を定義
            int week;
            string[] weekarray = {"日","月","火","水","木","金","土"};
             
            // 閏年かの判定
            if(year % 4 == 0 && year % 100 != 0 )
            {
                //Console.WriteLine("閏年です");
                urucheck++;
            }
            else if (year % 400 == 0)
            {
                //Console.WriteLine("閏年です");
                urucheck++;
            }
            
            // グレゴリオ暦1年1月1日から何日閏年が発生したか
            double afgc = (year/4)+(year/400)-(year/100);
            Console.WriteLine("{0}日",afgc);

            // １年の月ごとの日数を配列にする
            // 1年は12ヵ月なので長さ12の配列を作成する
            int []aday = new int[12];
            
            // ループが正常終了するよう、月をmonthとする。
            //int month;
            for(int i = 1; i <= 12; i++)
            {
              int year2 = year;
              int month = 0;
              Console.WriteLine("{0}月",i);
              // 1月の曜日計算が違うので分ける
              if(i == 1)
                {
                    // ツェラーの公式で1月2月は前年の13月14月で計算
                      year --;
                    　month = 13;
                      for(int j = 1; j < 32; j++)
                      {
                        // ツェラーの公式
                        week = (year + (year/4) - (year/100) + (year/400) + (13*month+8)/5 + j) % 7;
                        if(j == 1)
                        {
                            // 1日の曜日を合わせる
                            for(int k = 0; k < week; k++)
                            {
                                Console.Write("  ");
                            }
                        }
                        if(week == 0)
                        {
                            //日曜日は赤で表示する
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0,2:d}",j);
                        }
                        else if(week == 6)
                        {
                            //土曜日は青で表示する
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("{0,2:d}",j);
                            Console.WriteLine();
                        }
                        else 
                        { 
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("{0,2:d}",j);
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        year2 = year;
                      }
                     
                }
               // 2月は閏年は29日
              else if(i == 2 && urucheck == 1)
                {
                        year --;
                        month = 14;
                        for(int j = 1; j <= 29; j++)
                        {
                             // ツェラーの公式
                             week = (year + (year/4) - (year/100) + (year/400) + (13*month+8)/5 + j) % 7;
                          if(j == 1)
                          {
                              // 1日の曜日を合わせる
                              for(int k = 0; k < week; k++)
                              {
                                  Console.Write("  ");
                              }
                          }
                          if(week == 0)
                          {
                              //日曜日は赤で表示する
                              Console.ForegroundColor = ConsoleColor.Red;
                              Console.Write("{0,2:d}",j);
                          }
                          else if(week == 6)
                          {
                              //土曜日は青で表示する
                              Console.ForegroundColor = ConsoleColor.Blue;
                              Console.Write("{0,2:d}",j);
                              Console.WriteLine();
                          }
                          else 
                          { 
                              Console.ForegroundColor = ConsoleColor.Gray;
                              Console.Write("{0,2:d}",j);
                          }
                          Console.ForegroundColor = ConsoleColor.Gray;
                        }
                }
              // 2月は閏年でなければ28日
              else if(i== 2 && urucheck == 0)
                {
                        year --;
                        month = 14;
                        for(int j = 1; j <= 28; j++)
                        {
                            // ツェラーの公式
                            week = (year + (year/4) - (year/100) + (year/400) + (((13*month)+8)/5) + j) % 7;
                            // 1日の曜日を合わせる    
                        if(j == 1) 
                            { 
                               for(int k = 0; k < week; k++)
                               {
                                   Console.Write("  ");
                               }
                            }
                            if(week == 0)
                               {
                                  //日曜日は赤で表示する
                                  Console.ForegroundColor = ConsoleColor.Red;
                                  Console.Write("{0,2:d}",j);
                                }
                            else if(week == 6)
                                {
                                   //土曜日は青で表示する
                                   Console.ForegroundColor = ConsoleColor.Blue;
                                   Console.Write("{0,2:d}",j);
                                   Console.WriteLine();
                                 }
                            else
                                 {  
                                   Console.ForegroundColor = ConsoleColor.Gray;
                                   Console.Write("{0,2:d}",j);
                                  }
                            Console.ForegroundColor = ConsoleColor.Gray;
                            year2 = year;
                        }
                }
              // 4月,6月,9月,11月は30日
              else if(i == 4 || i == 6 || i == 9 || i == 11)
                {
                        for (int j = 1; j < 31; j++)
                        {
                            month = i;
                            // ツェラーの公式
                            week = (year + (year/4) - (year/100) + (year/400) + (13*month+8)/5 + j) % 7;
                            // 1日の曜日を合わせる
                             if(j == 1) 
                             { 
                               for(int k = 0; k < week; k++)
                               {
                                    Console.Write("  ");
                               }
                             }
                        if(week == 0)
                            {
                               //日曜日は赤で表示する
                               Console.ForegroundColor = ConsoleColor.Red;
                               Console.Write("{0,2:d}",j);
                            }
                        else if(week == 6)
                            {
                               //土曜日は青で表示する
                               Console.ForegroundColor = ConsoleColor.Blue;
                               Console.Write("{0,2:d}",j);
                               Console.WriteLine();
                             }
                        else
                             {  
                               Console.ForegroundColor = ConsoleColor.Gray;
                               Console.Write("{0,2:d}",j);
                             }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        }
                }
              // それ以外は31日
              else 
                { 
                        for(int j = 1; j < 32; j++)
                        {
                            month = i;
                            // ツェラーの公式
                            week = (year + (year/4) - (year/100) + (year/400) + (13*month+8)/5 + j) % 7;
                              // 1日の曜日を合わせる
                             if(j == 1) 
                             { 
                               for(int k = 0; k < week; k++)
                               {
                                    Console.Write("  ");
                               }
                             }
                        if(week == 0)
                            {
                               //日曜日は赤で表示する
                               Console.ForegroundColor = ConsoleColor.Red;
                               Console.Write("{0,2:d}",j);
                            }
                        else if(week == 6)
                            {
                               //土曜日は青で表示する
                               Console.ForegroundColor = ConsoleColor.Blue;
                               Console.Write("{0,2:d}",j);
                               Console.WriteLine();
                             }
                        else
                             {  
                               Console.ForegroundColor = ConsoleColor.Gray;
                               Console.Write("{0,2:d}",j);
                             }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            urucheck = 0;
        }
    }
}
