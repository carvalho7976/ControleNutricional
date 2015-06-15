using ControleNutricionalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ControleNutricionalService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISeviceGrupo" in both code and config file together.
    [ServiceContract]
    public interface ISeviceGrupo {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findall", ResponseFormat = WebMessageFormat.Json)]
        List<Grupo> findall();
    }
}
