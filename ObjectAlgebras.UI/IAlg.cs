using System.Collections.Generic;
using System.Text;

namespace ObjectAlgebras.UI
{
    //Object algebra interface
    public interface IAlg<A>
    {
        A Lit(int x);
        A Add(A e1, A e2);
    }
}
