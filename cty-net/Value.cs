namespace cty_net
{
    public class Value
    {
        public Value(IType type, object? v)
        {
            Type = type;
            V = v;
        }

        public IType Type { get; }
        public object? V { get; }
    }
}