using Castle.DynamicProxy;
using System;

namespace ObjectAlgebras.UI.ProxyGeneration
{
    class MethodInterceptor : IInterceptor
    {
        private readonly Delegate _delegate;

        public MethodInterceptor(Delegate @delegate)
        {
            _delegate = @delegate;
        }

        public void Intercept(IInvocation invocation)
        {
            var result = _delegate.DynamicInvoke(invocation.Arguments);
            invocation.ReturnValue = result;
        }
    }
}