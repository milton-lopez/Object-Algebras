using ObjectAlgebras.UI.ProxyGeneration;
using System;

namespace ObjectAlgebras.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new DynamicProxyFactory();

            var evalAlgebra = new EvalAlg(factory);
            var evalSubAlgebra = new EvalSubAlg(factory);
            var printAlgebra = new PrintAlg(factory);


            Console.WriteLine("The expression '{0}' returns: {1}", printAlgebra.Add(3, 4).Print(), evalAlgebra.Add(3, 4).Eval());
            Console.ReadLine();
        }
    }
}
