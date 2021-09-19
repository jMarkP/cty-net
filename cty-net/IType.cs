namespace cty_net
{
    public interface IType
    {
        string GetFriendlyName(FriendlyTypeNameMode mode);

        /// <summary>
        /// FriendlyName returns a human-friendly *English* name for the given type.
        /// </summary>
        string FriendlyName => GetFriendlyName(FriendlyTypeNameMode.Name);
        /// <summary>
        /// FriendlyNameForConstraint is similar to FriendlyName except that the
        /// result is specialized for describing type _constraints_ rather than types
        /// themselves. This is more appropriate when reporting that a particular value
        /// does not conform to an expected type constraint.
        ///
        /// In particular, this function uses the term "any type" to refer to
        /// cty.DynamicPseudoType, rather than "dynamic" as returned by FriendlyName.
        /// </summary>
        string FriendlyNameForConstraint => GetFriendlyName(FriendlyTypeNameMode.ConstraintName);
    }
}