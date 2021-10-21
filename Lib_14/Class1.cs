using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_14
{
    public class Class1
         
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="kol"></param>
        /// <param name="s2"></param>
        /// <param name="s1"></param>

        public static void Sum(int k,out int kol,out string s2, out string s1)
        {
            int x;// сгенерированное число
            int sum = 0;// приравнивание нулю переменной sum
            kol = 0;// количество сгенерированных чисел
            Random rnd = new Random(); 
            s1 = " ";// строка для вывода суммы
            s2 = "";// строка для вывода сгенерированных чисел
           
                while(sum<k)
                {
                    x = rnd.Next(55, 70);// генерирование чисел, распределенных в диапазоне от 55 до 70
                    s2 = x.ToString() + ";" + s2 ;//заполение строки числами
                    kol++;// счетчик кол-ва чисел
                    sum = sum + x;// находим сумму
                    s1 = sum.ToString();// заполнение строки суммой

                }
          
        }
    }
}
