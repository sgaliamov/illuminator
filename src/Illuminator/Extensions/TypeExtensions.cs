﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Illuminator.Extensions
{
    internal static class TypeExtensions
    {
        public static TResult Create<TResult>(this Type type) {
            // todo: benchmark creation
            var ctor = type.GetConstructor(Type.EmptyTypes)
                       ?? throw new ArgumentException(
                           $"Type {type.DisplayName()} should has default constructor.",
                           nameof(type));

            var lambda = Expression.Lambda(typeof(Func<TResult>), Expression.New(ctor));
            var compiled = (Func<TResult>)lambda.Compile();

            return compiled();
        }

        /// <summary>Returns the underlying type of the specified enumeration or Nullable.</summary>
        /// <param name="type">The type whose underlying type will be retrieved.</param>
        /// <returns>The underlying type of <paramref name="type">type</paramref>.</returns>
        public static Type GetUnderlyingType(this Type type) {
            while (true) {
                if (type.IsEnum) {
                    return Enum.GetUnderlyingType(type);
                }

                if (type.IsNullable()) {
                    type = type.GetGenericArguments()[0];
                }
                else {
                    return type;
                }
            }
        }

        public static bool IsNullable(this Type type) =>
            type.IsValueType
            && type.IsGenericType
            && !type.IsGenericTypeDefinition
            && ReferenceEquals(type.GetGenericTypeDefinition(), typeof(Nullable<>));

        /// <summary>
        ///     Not objects and structures.
        ///     Extended version of IsPrimitive property.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns>true if the <paramref name="type">type</paramref> is one of the primitive types; otherwise, false.</returns>
        public static bool IsPrimitive(this Type type) =>
            type.IsPrimitive
            || type.IsEnum
            || ReferenceEquals(type, typeof(string))
            || ReferenceEquals(type, typeof(decimal));

        public static Type GetGenericInterface(this Type type, Type generic) {
            if (!generic.IsGenericType) {
                throw new ArgumentException($"{generic.DisplayName()} should be generic type.", nameof(generic));
            }

            if (type.IsInterface && type.IsGenericType && type.GetGenericTypeDefinition() == generic) {
                return type;
            }

            return type.GetInterfaces().FirstOrDefault(t => t.IsGenericType && generic == t.GetGenericTypeDefinition());
        }
    }
}
