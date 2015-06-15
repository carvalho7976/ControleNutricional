using ControleNutricionalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControleNutricionalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceRefeicao" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceRefeicao.svc or ServiceRefeicao.svc.cs at the Solution Explorer and start debugging.
    public class ServiceRefeicao : IServiceRefeicao
    {
        public List<Refeicao> findall()
        {
            throw new NotImplementedException();
        }

        public Refeicao find(string id)
        {
            throw new NotImplementedException();
        }

        public bool create(Refeicao refeicao)
        {
            throw new NotImplementedException();
        }

        public bool edit(Refeicao refeicao)
        {
            throw new NotImplementedException();
        }

        public bool delete(Refeicao refeicao)
        {
            throw new NotImplementedException();
        }
    }
}
