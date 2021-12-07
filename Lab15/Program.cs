using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arithStep1 = 10;
            const int arithStart1 = -50;
            const int arithStep2 = 15;
            const int arithStart2 = 0;
            const int geomStep1 = 10;
            const int geomStart1 = 1;
            const int geomStep2 = 7;
            const int geomStart2 = -5;

            ArithProgression Arith1 = new ArithProgression();
            GeomProgression Geom1 = new GeomProgression();

            Console.WriteLine("Начало арифметической прогрессии с: {0}, значений: {1}", arithStart1, arithStep1);
            Arith1.GetStart(arithStart1);
            for (int i = 0; i < arithStep1; i++)
                Console.WriteLine("Следующее значение: {0}", Arith1.GetNext());

            Console.WriteLine("Начало арифметической прогрессии с: {0}, значений: {1}", arithStart2, arithStep2);
            Arith1.GetStart(arithStart2);
            for (int i = 0; i < arithStep2; i++)
                Console.WriteLine("Следующее значение: {0}", Arith1.GetNext());

            Console.WriteLine("Начало геометрической прогрессии с: {0}, значений: {1}", geomStart1, geomStep1);
            Geom1.GetStart(geomStart1);
            for (int i = 0; i < geomStep1; i++)
                Console.WriteLine("Следующее значение: {0}", Geom1.GetNext());

            Console.WriteLine("Начало геометрической прогрессии с: {0}, значений: {1}", geomStart2, geomStep2);
            Geom1.GetStart(geomStart2);
            for (int i = 0; i < geomStep2; i++)
                Console.WriteLine("Следующее значение: {0}", Geom1.GetNext());

            Console.ReadKey();

        }
    }
    interface ISeries
    {
        void GetStart(int x); //устанавливает начальное значение
        int GetNext(); //возвращает следующее число ряда
        void Reset(); //выполняет сброс к начальному значению
    }
    class ArithProgression : ISeries
    {
        int begin = 0;
        int sum = 0;
        int arithConst = 5;

        public void GetStart(int x)
        {
            begin = x;
            sum = begin;
        }

        public int GetNext()
        {
            sum += arithConst;
            return sum;
        }

        public void Reset()
        {
            sum = begin;
        }
    }

    class GeomProgression : ISeries
    {
        int begin = 0;
        int sum = 0;
        int geomConst = 2;

        public void GetStart(int x)
        {
            begin = x;
            sum = begin;
        }

        public int GetNext()
        {
            sum *= geomConst;
            return sum;
        }

        public void Reset()
        {
            sum = begin;
        }
    }

}
