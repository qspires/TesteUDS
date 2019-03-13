using System.Web.Http;
using TesteUDS.Manager;
using TesteUDS.Models;

namespace TesteUDS.Controllers
{
    /// <summary>
    /// Personalizar Pizza
    /// </summary>
    public class CustomPizzaController : ApiController
    {
        //// GET: api/CreatePizza
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/CreatePizza/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/CreatePizza
        /// <summary>
        /// Adicionar Adicionais
        /// </summary>
        /// <param name="IdOrder">Id Do Pedido Consulte a API api/Order</param>
        /// <param name="IdExtra">Id da Adicional Consulte a API api/Extra</param>
        /// <returns>Class mOrder</returns>
        public mOrder Post(int IdOrder, int IdExtra)
        {
            return ExtraOnOrderManager.Build().CreateExtra(IdOrder, IdExtra);
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
