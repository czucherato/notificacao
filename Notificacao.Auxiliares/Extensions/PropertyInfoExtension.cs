using System;
using System.Reflection;
using System.Linq.Expressions;

namespace Notificacao.Auxiliares.Extensions
{
    public static class PropertyInfoExtension
    {
        public static PropertyInfo GetPropertyInfo<TSource, TProperty>(
            TSource _, 
            Expression<Func<TSource, TProperty>> expression)
        {
            Type type = typeof(TSource);

            if (!(expression.Body is MemberExpression member))
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    expression.ToString()));

            PropertyInfo propertyInfo = member.Member as PropertyInfo;
            if (propertyInfo == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a field, not a property.",
                    expression.ToString()));

            if (type != propertyInfo.ReflectedType &&
                !type.IsSubclassOf(propertyInfo.ReflectedType))
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a property that is not from type {1}.",
                    expression.ToString(),
                    type));

            return propertyInfo;
        }
    }
}