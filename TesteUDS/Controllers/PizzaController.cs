
using System.Collections.Generic;
using System.Web.Http;
using TesteUDS.DAO;
using TesteUDS.Models;

namespace TesteUDS.Controllers
{

    /// <summary>
    /// Api CRUD de Pizza
    /// </summary>
    public class PizzaController : ApiController
    {
        // GET: api/Pizza
        /// <summary>
        /// Busca todos os sabores de Pizzas cadastradas
        /// </summary>
        /// <returns>Uma lista da class mPizza</returns>
        public List<mPizza> Get()
        {
            return DaoPizza.Build().GetAll();
        }

        // GET: api/Pizza/5
        /// <summary>
        /// Busca Pizzas por ID cadastradas
        /// </summary>
        /// <param name="id">ID da Pizza</param>
        /// <returns>Class mPizza</returns>
        public mPizza Get(int id)
        {
            return DaoPizza.Build().GetId(id);
        }

        // POST: api/Pizza
        /// <summary>
        /// Insere uma nova Pizza
        /// </summary>
        /// <param name="Model">Json com a Estrura da Class mPizza</param>
        /// <returns>Class mPizza</returns>
        public mPizza Post(mPizza Model)
        {
            return DaoPizza.Build().Insert(Model);
        }

        // PUT: api/Pizza/5
        /// <summary>
        /// Atualiza Pizza
        /// </summary>
        /// <param name="Model">Json com a Estrura da Class mPizza</param>
        /// <returns>Class mPizza</returns>
        public mPizza Put(mPizza Model)
        {
            return DaoPizza.Build().Update(Model);
        }


        // DELETE: api/Pizza/5
        /// <summary>
        /// Deletar Pizza
        /// </summary>
        /// <param name="id">ID da Pizza</param>
        /// <returns>Class mPizza da pizza deletada</returns>
        public mPizza Delete(int id)
        {
            return DaoPizza.Build().Delete(id);
        }
    }
}
