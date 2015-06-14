using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControleNutricionalService.Models;

namespace ControleNutricionalService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAlimento" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAlimento.svc or ServiceAlimento.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAlimento : IServiceAlimento {
       
        public List<Models.Alimento> findall() {

            List<Alimento> listaAlimentos = new List<Alimento>();
            Alimento a = new Alimento();
            a.Nome = "Abacaxi";
            a.Id = 1;

            Alimento b = new Alimento();
            a.Nome = "Morango";
            a.Id = 2;

            Alimento c = new Alimento();
            a.Nome = "Kiwi";
            a.Id = 3;

            listaAlimentos.Add(a);
            listaAlimentos.Add(b);
            listaAlimentos.Add(c);

            return listaAlimentos;
        }

        public Alimento find(string id) {
            throw new NotImplementedException();
        }

        public bool create(Alimento alimento) {
            throw new NotImplementedException();
        }

        public bool edit(Alimento alimento) {
            throw new NotImplementedException();
        }

        public bool delete(Alimento alimento) {
            throw new NotImplementedException();
        }
    }
}
