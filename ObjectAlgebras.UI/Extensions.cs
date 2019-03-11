namespace ObjectAlgebras.UI
{
    public static class Extensions
    {
        public static A Add<A>(this IAlg<A> alg, int a, int b) =>
            alg.Add(alg.Lit(a), alg.Lit(b));

        public static A Sub<A>(this ISubAlg<A> alg, int a, int b) =>
            alg.Sub(alg.Lit(a), alg.Lit(b));
    }
}
