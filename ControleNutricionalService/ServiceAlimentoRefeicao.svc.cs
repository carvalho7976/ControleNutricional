using ControleNutricionalService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControleNutricionalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAlimentoRefeicao" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAlimentoRefeicao.svc or ServiceAlimentoRefeicao.svc.cs at the Solution Explorer and start debugging.
    //Crud para AlimentoRefeicao
    public class ServiceAlimentoRefeicao : IServiceAlimentoRefeicao
    {

        public List<AlimentoRefeicao> findall()
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                return mde.AlimentoRefeicao.ToList();
            };
        }

        public AlimentoRefeicao find(string id)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                int nid = Convert.ToInt32(id);
                return mde.AlimentoRefeicao.Where(ae => ae.Id == nid).First();
            };
        }

        public bool create(AlimentoRefeicao alimentoRefeicao)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                try
                {
                    mde.AlimentoRefeicao.Add(alimentoRefeicao);
                    mde.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    return false;
                }
            };
        }

        public bool edit(AlimentoRefeicao alimentoRefeicao)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                var result = mde.AlimentoRefeicao.SingleOrDefault(r => r.Id == alimentoRefeicao.Id);

                if (result != null)
                {
                    //mde.Refeicao.Add(refeicao);                    
                    mde.Entry(alimentoRefeicao).State = EntityState.Modified;
                    mde.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            };
        }

        public bool delete(AlimentoRefeicao alimentoRefeicao)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                var result = mde.AlimentoRefeicao.Where(rf => rf.Id == alimentoRefeicao.Id).SingleOrDefault();
                if (result != null)
                {
                    mde.AlimentoRefeicao.Remove(result);
                    mde.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            };
        }
    }
}
