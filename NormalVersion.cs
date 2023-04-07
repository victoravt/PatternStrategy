using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    public static class NormalVersion
    {
        public static void Run()
        {
            ///First version only using concrete classes
            var stg1 = new ConcreteStrategy1();
            var stg2 = new ConcreteStrategy2();

            var ctx = new Context(stg1);
            ctx.Execute();

            //Changing strategy
            ctx.SetStrategy(stg2);
            ctx.Execute();
        }

        class Context
        {
            // Concrete strategy field, publicly setable
            private IStrategy _strategy;

            public Context(IStrategy strategy)
            {
                _strategy = strategy;
            }

            public void SetStrategy(IStrategy strategy)
            {
                _strategy = strategy;
            }

            public void Execute()
            {
                _strategy.Execute();
            }
        }

        interface IStrategy
        {
            void Execute();
        }

        class ConcreteStrategy1 : IStrategy
        {
            public void Execute()
            {
                Console.WriteLine("Exec stg 1");
            }
        }

        class ConcreteStrategy2 : IStrategy
        {
            public void Execute()
            {
                Console.WriteLine("Exec stg 2");
            }
        }
    }
}
