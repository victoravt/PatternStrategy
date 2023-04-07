using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    public static class FunctionalTypeVersion
    {
        public static void Run()
        {
            var context1 = new Context (() => Console.WriteLine("Exec stg 1 hello functional proging"));
            var context2 = new Context (() => Console.WriteLine("Exec stg 2 hello functional proging"));

            context1.Execute();
            context2.Execute();
        }

        class Context
        {
            private Action _strategyAction;

            public Context(Action strategyFunction)
            {
                _strategyAction = strategyFunction;
            }

            public void Execute()
            {
                _strategyAction();
            }
        }
    }

    
}



