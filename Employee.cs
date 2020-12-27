using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Employee : User
    {
       public void DisplayEmployee()
        {
            Console.WriteLine($"name: {name}\n money: {money}"); //можем использовать переменные класс User, потом что унаследовались от класса User
        }

    }
}
