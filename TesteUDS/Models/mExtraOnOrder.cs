using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TesteUDS.ClassBase;
using TesteUDS.Models.ExtraOnOrder.Validators;

namespace TesteUDS.Models
{
    /// <summary>
    /// Class Adicionais
    /// </summary>
    [Serializable]
    public class mExtraOnOrder : EntityBase<mExtraOnOrder, mExtraOnOrderValidator>
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; } //

        /// <summary>
        /// Id Do Pedido
        /// </summary>
        [Required]
        public int IdOrder { get; set; } //FK Pedido

        /// <summary>
        /// Id do Adicional
        /// </summary>
        [Required]
        public int IdExtra { get; set; } //FK Adicional


        ///// <summary>
        ///// Class Pedido
        ///// </summary>
        //[ForeignKey("IdOrder")]
        //public virtual mOrder mOrder { get; set; }

        /// <summary>
        /// Class Adicionais
        /// </summary>
        [ForeignKey("IdExtra")]
        public virtual mExtra mExtra { get; set; }


        public override mExtraOnOrder Validate()
        {
            return this;
        }

        public mExtraOnOrder SetExtraOnOrder(mExtraOnOrder model)
        {
            this.IdOrder = model.IdOrder;
            this.IdExtra = model.IdExtra;
            return this;
        }
    }
}