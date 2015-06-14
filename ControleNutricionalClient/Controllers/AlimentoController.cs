using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ControleNutricionalClient.ServiceAlimento;
namespace ControleNutricionalClient.Controllers
{
    public class AlimentoController : ApiController
    {
        // GET api/alimento
        public IEnumerable<Alimento> Get()
        {   
            ServiceAlimento.ServiceAlimentoClient servico = new ServiceAlimentoClient();

            return servico.findall(); 
        }

        // GET api/alimento/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/alimento
        public void Post([FromBody]string value)
        {
        }

        // PUT api/alimento/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/alimento/5
        public void Delete(int id)
        {
        }
    }
}
