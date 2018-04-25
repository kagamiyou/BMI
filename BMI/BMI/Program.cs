using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // 顏色 + 標題
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("====         BMI          ====");

            // 輸入
            Console.WriteLine("請輸入體重:");
            string input = Console.ReadLine();

            Console.WriteLine("請輸入身高(公分):");
            string output = Console.ReadLine();

            // 計算
            double w = double.Parse(input);
            double h = double.Parse(output);
            double bmi = w / (h * h / 10000);

            // 輸出
            Console.WriteLine("您的BMI=" + bmi);

            // 結果
            if (bmi > 31.5)
            {
                Console.WriteLine("因為過重免兵役了~該認真減肥啦!");
            }
            else if (bmi > 31 && bmi < 31.5)
            {
                Console.WriteLine("你過重了!該減肥咯!不過你可以去替代役~");
            }

            else if (bmi > 24 && bmi < 31)
            {
                Console.WriteLine("有點過重咯!去軍中好好減肥吧!");
            }
            else if (bmi > 17 && bmi < 18.5)
            {
                Console.WriteLine("有點過輕咯!去軍中把體重增加吧!");
            }
            else if (bmi > 16.5 && bmi < 17)
            {
                Console.WriteLine("有點過輕咯!雖然免兵役，不過要去替代役啦!");
            }
            else if (bmi < 16.5)
            {
                Console.WriteLine("過輕咯!兵役替代役都不用了，多吃一點吧!");
            }
            else
            {
                Console.WriteLine("體重正常，兵役不可免");
            }
            Console.ReadLine();
        }
    }
}
