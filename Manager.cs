using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Manager : User
    {
        public void DisplayManager()
        {
            Console.WriteLine($"name: {name}\n money: {money}");//можем использовать переменные класс User, потом что унаследовались от класса User 
        }

    }
}
