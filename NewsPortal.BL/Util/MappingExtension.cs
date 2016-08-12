﻿
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace NewsPortal.BL.Util
{
    public static class MappingExtension
    {
        public static IMappingExpression<TSource, TDestination> IgnoreAllNonExisting<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        {
            var flags = BindingFlags.Public | BindingFlags.Instance;
            var sourceType = typeof(TSource);
            var destinationProperties = typeof(TDestination).GetProperties(flags);

            foreach (var property in destinationProperties.Where(property => sourceType.GetProperty(property.Name, flags) == null))
            {
                expression.ForMember(property.Name, opt => opt.Ignore());
            }
            return expression;
        }
    }
}
