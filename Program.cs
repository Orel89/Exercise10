using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            //user.name - ошибка т.к переменная защищена от использования вне класса
            Manager manager = new Manager();
            // manager.money - ошибка т.к переменная защищена от использования вне класса

        }
    }
}
