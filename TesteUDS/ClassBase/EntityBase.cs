using FluentValidation.Results;
using System.ComponentModel.DataAnnotations.Schema;
using TesteUDS.Models;

namespace TesteUDS.ClassBase
{
    public abstract class EntityBase<Type, Validator> : BuildableBase<Type>
    {
        public EntityBase()
        {
            State = new State();
        }

        /// <summary>
        /// Class Estado (FeedBack da operação)
        /// </summary>
        [NotMapped]
        public virtual State State { get; set; }
        //public ValidationResult ValidationResult;
        //public Guid Id { get; protected set; }
        //public bool IsValid { get { return ValidationResult == null ? false : ValidationResult.IsValid; } }
        public abstract Type Validate();
    }
}