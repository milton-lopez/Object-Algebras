namespace ObjectAlgebras.UI
{
    public interface ISubAlg<A> : IAlg<A>
    {
        A Sub(A e1, A e2);
    }
}
