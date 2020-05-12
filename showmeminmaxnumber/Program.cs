using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5]; //배열
            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                a[i] = int.Parse(Console.ReadLine()); //숫자 5개 입력
            }
            Console.WriteLine("-----------------------------------------");

            int min = a[0]; int max = a[0]; //초기 작은 수 큰 수 지정

            for (int i = 0; i < 5; i++)
            {
                if (max < a[i]) //a[i]가 max보다 크면 max에 집어 넣기
                    max = a[i];
                if (min > a[i]) //a[i]가 min보다 작으면 min에 집어 넣기
                    min = a[i];
            }

            Console.WriteLine("가장 큰 수 : " + max);
            Console.WriteLine("가장 작은 수 : " + min);
        }

    }
}
