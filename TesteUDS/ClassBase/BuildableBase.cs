using FluentValidation;
using System;

namespace TesteUDS.ClassBase
{
    public abstract class BuildableBase<Type>
    {
        public static Type Build()
        {
            return (Type)Activator.CreateInstance(typeof(Type));
        }
    }
}