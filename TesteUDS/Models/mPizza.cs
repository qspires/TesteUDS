using System;
using System.ComponentModel.DataAnnotations;
using TesteUDS.ClassBase;
using TesteUDS.Models.Pizza.Validators;

namespace TesteUDS.Models
{

    /// <summary>
    /// Class Pizza
    /// </summary>
    [Serializable]
    public class mPizza : EntityBase<mPizza, mPizzaValidator>
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; } //

        /// <summary>
        /// Descrição (nome da pizza)
        /// </summary>
        /// <value>
        /// Campos Obrigatorio
        /// </value>
        [Required]
        public string Description { get; set; } //Descrição

        /// <summary>
        /// Valor
        /// </summary>
        public Decimal Amount { get; set; } //Valor

        /// <summary>
        /// Tempo de preparo em Segundos
        /// </summary>
        public int Time { get; set; } //Tempo em Segundos

        public override mPizza Validate()
        {
            //ValidationResult = mPizzaValidator.Build().Validate(this);
            return this;
        }

        public mPizza SetPizza(mPizza model)
        {
            Description = model.Description;
            Amount = model.Amount;
            Time = model.Time;
            return this;
        }
    }
}