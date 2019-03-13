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
    /// Api CRUD de Adicional
    /// </summary>
    public class ExtraController : ApiController
    {
        // GET: api/Extra
        /// <summary>
        /// Busca todos os Adicionais cadastrados
        /// </summary>
        /// <returns>Uma lista da class mExtra</returns>
        public List<mExtra> Get()
        {
            return DaoExtra.Build().GetAll();
        }

        // GET: api/Extra/5
        /// <summary>
        /// Busca Adicionais por ID cadastrado
        /// </summary>
        /// <param name="id">ID do Adicional</param>
        /// <returns>Class mExtra</returns>
        public mExtra Get(int id)
        {
            return DaoExtra.Build().GetId(id);
        }

        // POST: api/Extra
        /// <summary>
        /// Insere um novo Adicional
        /// </summary>
        /// <param name="Model">Json com a Estrura da Class mExtra</param>
        /// <returns>Class mExtra</returns>
        public mExtra Post(mExtra Model)
        {
            return DaoExtra.Build().Insert(Model);
        }

        // PUT: api/Extra/5
        /// <summary>
        /// Atualiza Adicional
        /// </summary>
        /// <param name="Model">Json com a Estrura da Class mExtra</param>
        /// <returns>Class mExtra</returns>
        public mExtra Put(mExtra Model)
        {
            return DaoExtra.Build().Update(Model);
        }

        // DELETE: api/Extra/5
        /// <summary>
        /// Deletar Adicional
        /// </summary>
        /// <param name="id">ID do Adicional</param>
        /// <returns>Class mExtra da Adicional deletada</returns>
        public mExtra Delete(int id)
        {
            return DaoExtra.Build().Delete(id);
        }
    }
}
