using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            LineCompare obj = new LineCompare();
            obj.Input();
            obj.calculation();
            obj.CompareLines();
        }
    }
}
