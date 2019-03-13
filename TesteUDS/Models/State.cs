using System.ComponentModel.DataAnnotations.Schema;

namespace TesteUDS.Models
{
    /// <summary>
    /// Class Estado (FeedBack da operação)
    /// </summary>
    public class State
    {
        /// <summary>
        /// Se der Erro Retorna True, Se OK Retorna False
        /// </summary>
        [NotMapped]
        public virtual bool IsError { get; set; }

        /// <summary>
        /// Mensagem de erro
        /// </summary>
        /// 
        [NotMapped]
        public virtual string MessageError { get; set; }

        /// <summary>
        /// Mensagem de Sucesso
        /// </summary>
        /// 
        [NotMapped]
        public virtual string MessageSucess { get; set; }
    }
}