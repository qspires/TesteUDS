using System.Collections.Generic;
using System.Web.Http;
using TesteUDS.DAO;
using TesteUDS.Manager;
using TesteUDS.Models;

namespace TesteUDS.Controllers
{
    /// <summary>
    /// Criar Pedido Pizza
    /// </summary>
    public class CreatePizzaController : ApiController
    {
        // GET: api/CreatePizza

        /// <summary>
        /// Busca todos os pedidos de pizzas cadastradas
        /// </summary>
        /// <returns>Uma lista da class mOrder</returns>
        public List<mOrder> Get()
        {
            return DaoOrder.Build().GetAll();
        }

        // GET: api/CreatePizza/5
        /// <summary>
        /// Busca pedido de pizza por ID cadastrado
        /// </summary>
        /// <param name="id">ID do pedido de pizza</param>
        /// <returns>Class mOrder</returns>
        public mOrder Get(int id)
        {
            return DaoOrder.Build().GetId(id);
        }

        // POST: api/CreatePizza
        /// <summary>
        /// Criar pizza
        /// </summary>
        /// <param name="IdSize">Id Do tamanho Consulte a API api/Size</param>
        /// <param name="IdPizza">Id da Pizza Consulte a API api/Pizza</param>
        /// <returns>Class mOrder</returns>
        public mOrder Post(int IdSize, int IdPizza)
        {
            return CreatePizzaManager.Build().AmountAndPrepared(IdSize, IdPizza);
        }

        // PUT: api/CreatePizza/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/CreatePizza/5
        //public void Delete(int id)
        //{
        //}
    }
}
