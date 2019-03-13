using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TesteUDS.ClassBase;
using TesteUDS.Models.Order.Validators;

namespace TesteUDS.Models
{

    /// <summary>
    /// Class Order (pedido)
    /// </summary>
    [Serializable]
    public class mOrder : EntityBase<mOrder, mOrderValidator>
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; } //

        /// <summary>
        /// Id do Tamanho
        /// </summary>
        [Required]
        public int IdSize { get; set; } //FK Tamanho

        /// <summary>
        /// Id da Pizza
        /// </summary>
        [Required]
        public int IdPizza { get; set; } //Fk Pizza

        /// <summary>
        /// Quantidade (padrão sempre será 1)
        /// </summary>
        public int Quantity { get; set; } //Quantidade 


        /// <summary>
        /// Valor total
        /// </summary>
        public Decimal Amount { get; set; } //Valor

        /// <summary>
        /// Tempo de preparo em Segundos
        /// </summary>
        [Required]
        public int Time { get; set; } //Tempo em Segundos

        /// <summary>
        /// Data de criação do pedido
        /// </summary>
        public DateTime? DateCreate { get; set; } //Data de criação so pedido



        /// <summary>
        /// Class Size (Tamanho)
        /// </summary>
        [ForeignKey("IdSize")]
        public virtual mSize mSize { get; set; }

        /// <summary>
        /// Class Pizza
        /// </summary>
        [ForeignKey("IdPizza")]
        public virtual mPizza mPizza { get; set; }

        /// <summary>
        /// Class Adicionais
        /// </summary>
        [ForeignKey("IdOrder")]
        public virtual List<mExtraOnOrder> mExtraOnOrder { get; set; }

        public override mOrder Validate()
        {
            return this;
        }

        public mOrder SetOrder(mOrder model)
        {
            IdSize = model.IdSize;
            IdPizza = model.IdPizza;
            Quantity = model.Quantity;
            Amount = model.Amount;
            Time = model.Time;
            DateCreate = model.DateCreate;
            return this;
        }
    }
}