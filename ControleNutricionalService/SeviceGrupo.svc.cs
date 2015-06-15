using ControleNutricionalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControleNutricionalService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SeviceGrupo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SeviceGrupo.svc or SeviceGrupo.svc.cs at the Solution Explorer and start debugging.
    public class SeviceGrupo : ISeviceGrupo {
        
        public List<Models.Grupo> findall() {
            using (NutricaoContext mde = new NutricaoContext()) {
                return mde.Grupos.ToList();
            };
        }
    }
}
