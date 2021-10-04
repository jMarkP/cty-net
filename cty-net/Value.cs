using System;

namespace cty_net
{
    public class Value
    {
        private static readonly object Unknown = new object();
        public static Value UnknownVal(IType type) => new Value(type, Unknown);
        public static readonly Value DynamicVal = new Value(DynamicPseudoType.Instance, Unknown);
        
        public Value(IType type, object? v)
        {
            Type = type;
            V = v;
        }

        public IType Type { get; }
        public object? V { get; }
    }

    public class DynamicPseudoType : IType
    {
        public static readonly DynamicPseudoType Instance = new ();
        private DynamicPseudoType()
        {
        }
        public string GetFriendlyName(FriendlyTypeNameMode mode)
        {
            switch (mode)
            {
                case FriendlyTypeNameMode.ConstraintName:
                    return "any type";
                default:
                    return "dynamic";
            }
        }
    }
}