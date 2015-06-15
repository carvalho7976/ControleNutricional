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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceRefeicao" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceRefeicao.svc or ServiceRefeicao.svc.cs at the Solution Explorer and start debugging.
    public class ServiceRefeicao : IServiceRefeicao
    {
        public List<Refeicao> findall()
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                return mde.Refeicao.ToList();
            };
        }

        public Refeicao find(string id)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                int nid = Convert.ToInt32(id);
                return mde.Refeicao.Where(ae => ae.Id == nid).First();
            };
        }

        public bool create(Refeicao refeicao)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                try
                {
                    Debug.Write("Entrou no create");
                    mde.Refeicao.Add(refeicao);
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

        public bool edit(Refeicao refeicao)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                var result = mde.Refeicao.SingleOrDefault(r => r.Id == refeicao.Id);

                if (result != null)
                {
                    //mde.Refeicao.Add(refeicao);                    
                    mde.Entry(refeicao).State = EntityState.Modified;
                    mde.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            };
        }

        public bool delete(Refeicao refeicao)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                var result = mde.Refeicao.Where(rf => rf.Id == refeicao.Id).SingleOrDefault();

                if (result != null)
                {
                    mde.Refeicao.Remove(result);
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
