using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TesteUDS.DAO;
using TesteUDS.Models;

namespace TesteUDS.Controllers
{
    /// <summary>
    /// Api CRUD de Tamanho
    /// </summary>
    public class SizeController : ApiController
    {
        // GET: api/Size
        /// <summary>
        /// Busca todos os Tamanhos cadastrados
        /// </summary>
        /// <returns>Uma lista da class mSize</returns>
        public List<mSize> Get()
        {
            return DaoSize.Build().GetAll();
        }

        // GET: api/Size/5
        /// <summary>
        /// Busca Tamanhos por ID cadastrado
        /// </summary>
        /// <param name="id">ID do Tamanho</param>
        /// <returns>Class mSize</returns>
        public mSize Get(int id)
        {
            return DaoSize.Build().GetId(id);
        }

        // POST: api/Size
        /// <summary>
        /// Insere um novo Tamanho
        /// </summary>
        /// <param name="Model">Json com a Estrura da Class mSize</param>
        /// <returns>Class mSize</returns>
        public mSize Post(mSize Model)
        {
            return DaoSize.Build().Insert(Model);
        }

        // PUT: api/Size/5
        /// <summary>
        /// Atualiza Tamanho
        /// </summary>
        /// <param name="Model">Json com a Estrura da Class mSize</param>
        /// <returns>Class mSize</returns>
        public mSize Put(mSize Model)
        {
            return DaoSize.Build().Update(Model);
        }

        // DELETE: api/Size/5
        /// <summary>
        /// Deletar Tamanho
        /// </summary>
        /// <param name="id">ID do Tamanho</param>
        /// <returns>Class mSize da Tamanho deletada</returns>
        public mSize Delete(int id)
        {
            return DaoSize.Build().Delete(id);
        }
    }
}
