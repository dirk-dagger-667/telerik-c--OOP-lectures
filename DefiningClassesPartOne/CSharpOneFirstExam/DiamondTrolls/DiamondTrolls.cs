using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondTrolls
{
    class DiamondTrolls
    {
        static void Main(string[] args)
        {
            int widthNOfDiamond = int.Parse(Console.ReadLine());
            int height = 6 + ((widthNOfDiamond - 3) / 2) * 3;
            
            Console.WriteLine(new String('.', (widthNOfDiamond + 1) / 2) + new String('*', widthNOfDiamond) + new String('.', (widthNOfDiamond + 1) / 2));

            for (int i = 0; i < (height-3) / 3; i++)
            {
                Console.WriteLine(new String('.', widthNOfDiamond / 2 - i) + '*' + new String('.', widthNOfDiamond / 2 + i) + '*' + new String('.', widthNOfDiamond / 2 + i) + '*' + new String('.', widthNOfDiamond / 2 - i));
            }

            Console.WriteLine(new String('*', 2*widthNOfDiamond + 1));

            for (int i = 0; i < 2*(height-3)/3; i++)
            {
                Console.WriteLine(new String('.', i + 1) + '*' + new String('.', widthNOfDiamond - 2 - i) + '*' + new String('.', widthNOfDiamond - 2 - i) + '*' + new String('.', i + 1));
            }

            Console.WriteLine(new String('.', widthNOfDiamond) + '*' + new String('.', widthNOfDiamond));
        }
    }
}
