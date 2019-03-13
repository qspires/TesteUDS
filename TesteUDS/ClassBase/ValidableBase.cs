using FluentValidation;
using System;

namespace TesteUDS.ClassBase
{
    public class ValidableBase<Type, ValidatorType> : AbstractValidator<Type>
    {
        public static ValidatorType Build()
        {
            return (ValidatorType)Activator.CreateInstance(typeof(ValidatorType));
        }
    }
}