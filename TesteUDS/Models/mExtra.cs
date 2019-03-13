using System;
using System.ComponentModel.DataAnnotations;
using TesteUDS.ClassBase;
using TesteUDS.Models.Extra.Validators;

namespace TesteUDS.Models
{
    /// <summary>
    /// Class Adicionais
    /// </summary>
    [Serializable]
    public class mExtra : EntityBase<mExtra, mExtraValidator>
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; } //

        /// <summary>
        /// Descrição (nome do Opcional)
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
        public int Time { get; set; } //Tempo em Segundos

        public override mExtra Validate()
        {
            return this;
        }

        public mExtra SetExtra(mExtra model)
        {
            Description = model.Description;
            Amount = model.Amount;
            Time = model.Time;
            return this;
        }
    }
}