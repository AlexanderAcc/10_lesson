using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwich_class
{
    class Sandwich // бутерброд
    {
        public int Weight { get; set; } // масса

    }
    class Bread // хлеб
    {

        public int Weight { get; set; } // масса

        public static Sandwich operator +(Butter butter, Bread bread) // суммирование массы хлеба и масла
        {
            return new Sandwich { Weight = butter.Weight + bread.Weight }; // возвращение значения в форму
        }
    }
    class Butter // масло
    {

        public int Weight { get; set; } // масса

        public static Sandwich operator +(Bread bread, Butter butter) // суммирование массы хлеба и масла
        {
            return new Sandwich { Weight = butter.Weight + bread.Weight }; // возвращение значения в форму
        }
    }

}
