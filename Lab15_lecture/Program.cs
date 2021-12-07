using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_lecture
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IMovable
    {
        void Move();
        void Brake();
    }
    class Mercedes : IMovable
    {
        public void Brake()
        {
            throw new NotImplementedException(); //это автоматические заглушки, созданные студией
        }
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
