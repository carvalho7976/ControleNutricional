using ControleNutricionalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ControleNutricionalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceRefeicao" in both code and config file together.
    [ServiceContract]
    public interface IServiceRefeicao
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findall", ResponseFormat = WebMessageFormat.Json)]
        List<Refeicao> findall();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "find/{id}", ResponseFormat = WebMessageFormat.Json)]
        Refeicao find(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool create(Refeicao refeicao);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool edit(Refeicao refeicao);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool delete(Refeicao refeicao);
      
    }
}
