using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelIO
{
    class testASYNC
    {
        public static void ThreadTest()
        {
            Task t = Task.Run(() => { AsyncWork(); });

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("メインスレッド：処理A実行");
            }
        }
        static void AsyncWork()
        {
            for(int i = 0; i< 100; i++)
            {
                Console.WriteLine("子スレッド：処理B実行");
            }
        }
    }
}
