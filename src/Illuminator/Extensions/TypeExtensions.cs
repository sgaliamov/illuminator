using System;

namespace Illuminator.Extensions
{
    public static class TypeExtensions
    {
        /// <summary>
        /// Not objects and structures.
        /// Extended version of IsPrimitive property.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns>true if the <paramref name="type">type</paramref> is one of the primitive types; otherwise, false.</returns>
        public static bool IsPrimitive(this Type type) =>
            type.IsPrimitive
            || type.IsEnum
            || ReferenceEquals(type, typeof(string))
            || ReferenceEquals(type, typeof(object))
            || ReferenceEquals(type, typeof(decimal));

        public static bool ImplementsGeneric(this Type type, Type generic) => type.FindGenericInterface(generic) != null;

        public static Type FindGenericInterface(this Type type, Type generic)
        {
            if (!generic.IsGenericType) {
                throw new ArgumentException($"{generic.DisplayName()} should be generic type.", nameof(generic));
            }

            if (type.IsInterface && type.IsGenericType && type.GetGenericTypeDefinition() == generic) {
                return type;
            }

            return Array.Find(
                type.GetInterfaces(),
                t => t.IsGenericType && generic == t.GetGenericTypeDefinition());
        }

        public static bool IsNullable(this Type type) =>
           type.IsValueType
           && type.IsGenericType
           && !type.IsGenericTypeDefinition
           && ReferenceEquals(type.GetGenericTypeDefinition(), typeof(Nullable<>));

        /// <summary>
        /// Returns the underlying type of the specified Enum or Nullable.
        /// </summary>
        /// <param name="type">The type whose underlying type will be retrieved.</param>
        /// <returns>The underlying type of <paramref name="type">type</paramref>.</returns>
        public static Type GetUnderlyingType(this Type type)
        {
            while (true) {
                if (type.IsEnum) {
                    return Enum.GetUnderlyingType(type);
                }

                if (type.IsNullable()) {
                    type = type.GetGenericArguments()[0];
                } else {
                    return type;
                }
            }
        }
    }
}
