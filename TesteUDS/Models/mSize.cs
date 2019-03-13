using System;
using System.ComponentModel.DataAnnotations;
using TesteUDS.ClassBase;
using TesteUDS.Models.Size.Validators;

namespace TesteUDS.Models
{
    /// <summary>
    /// Class Tamanho
    /// </summary>
    [Serializable]
    public class mSize : EntityBase<mSize, mSizeValidator>
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
        [Required]
        public Decimal Amount { get; set; } //Valor

        /// <summary>
        /// Tempo de preparo em Segundos
        /// </summary>
        [Required]
        public int Time { get; set; } //Tempo em Segundos

        public override mSize Validate()
        {
            //ValidationResult = mSizeValidator.Build().Validate(this);
            return this;
        }

        public mSize SetSize(mSize model)
        {
            Description = model.Description;
            Amount = model.Amount;
            Time = model.Time;
            return this;
        }
    }
}