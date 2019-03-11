using ObjectAlgebras.UI.ProxyGeneration;
using System;

namespace ObjectAlgebras.UI
{
    public class EvalAlg : IAlg<IEval>
    {
        private readonly IProxyFactory _factory;

        public EvalAlg(IProxyFactory factory)
        {
            _factory = factory;
        }

        public IEval Add(IEval e1, IEval e2) =>
            _factory.For<IEval>((Func<int>)
                (() => e1.Eval() + e2.Eval()));

        public IEval Lit(int x) =>
             _factory.For<IEval>((Func<int>)
                 (() => x));
    }
}
