using System;

namespace cty_net
{
    public class PrimitiveType : IType
    {
        public static PrimitiveType Bool = new();
        public static PrimitiveType Number = new();
        public static PrimitiveType String = new();

        public static Value True = new (Bool, true);
        public static Value False = new (Bool, false);
        
        public static Value Zero = new (Number, 0);
        
        public static Value PositiveInfinity = new (Number, float.PositiveInfinity);
        public static Value NegativeInfinity = new (Number, float.NegativeInfinity);
        
        private PrimitiveType(){}
        
        public string GetFriendlyName(FriendlyTypeNameMode mode)
        {
            if (this == Bool)
            {
                return "bool";
            }
            if (this == Number)
            {
                return "number";
            }
            if (this == String)
            {
                return "string";
            }

            throw new Exception("Invalid primitive type");
        }
    }
}