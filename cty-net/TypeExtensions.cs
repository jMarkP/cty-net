using System;

namespace cty_net
{
    public static class TypeExtensions
    {
        public static bool HasDynamicTypes(this IType type)
        {
            switch (type)
            {
                case PrimitiveType:
                    return false;
                default:
                    throw new Exception($"HasDynamicTypes does not support type {type.FriendlyName}");
            }
        }
    }
}
