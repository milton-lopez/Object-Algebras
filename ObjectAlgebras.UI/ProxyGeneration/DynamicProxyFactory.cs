using Castle.DynamicProxy;
using System;

namespace ObjectAlgebras.UI.ProxyGeneration
{
    public class DynamicProxyFactory : IProxyFactory
    {
        public T For<T>(Delegate @delegate) where T : class
        {
            var interceptor = new MethodInterceptor(@delegate);
            return new ProxyGenerator().CreateInterfaceProxyWithoutTarget<T>(interceptor);
        }
    }
}