using ObjectAlgebras.UI.ProxyGeneration;
using System;

namespace ObjectAlgebras.UI
{
    public class EvalSubAlg : EvalAlg, ISubAlg<IEval>
    {
        private readonly IProxyFactory _factory;

        public EvalSubAlg(IProxyFactory factory) : base(factory)
        {
            _factory = factory;
        }

        public IEval Sub(IEval e1, IEval e2) =>
            _factory.For<IEval>((Func<int>)
                (() => e1.Eval() - e2.Eval()));
    }
}
