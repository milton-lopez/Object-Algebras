using ObjectAlgebras.UI.ProxyGeneration;
using System;

namespace ObjectAlgebras.UI
{
    public class PrintAlg : ISubAlg<IPrint>
    {
        private readonly IProxyFactory _factory;

        public PrintAlg(IProxyFactory factory)
        {
            _factory = factory;
        }

        public IPrint Add(IPrint e1, IPrint e2) =>
            _factory.For<IPrint>((Func<string>)
                (() => e1.Print() + " + " + e2.Print()));

        public IPrint Lit(int x) =>
            _factory.For<IPrint>((Func<string>)
                (() => x.ToString()));

        public IPrint Sub(IPrint e1, IPrint e2) =>
            _factory.For<IPrint>((Func<string>)
                (() => e1.Print() + " - " + e2.Print()));
    }
}
