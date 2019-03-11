using System;

namespace ObjectAlgebras.UI.ProxyGeneration
{
    public interface IProxyFactory
    {
        T For<T>(Delegate @delegate) where T : class;
    }
}