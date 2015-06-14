﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControleNutricionalService.Models;
using System.Diagnostics;

namespace ControleNutricionalService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAlimento" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAlimento.svc or ServiceAlimento.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAlimento : IServiceAlimento {


        public List<Alimento> findall()
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                return mde.Alimentos.ToList();
            };
        }

        public Alimento find(string id)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                int nid = Convert.ToInt32(id);
                return mde.Alimentos.Where (ae => ae.Id == nid).First();
            };
        }

        public bool create(Alimento alimento) {
            Debug.Write("-----------create");
            using (NutricaoContext mde = new NutricaoContext())
            {
                try {
                    Debug.Write("Entrou no create");
                    mde.Alimentos.Add(alimento);
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

        public bool edit(Alimento alimento)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                try
                {                    
                    mde.Alimentos.Add(alimento);
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool delete(Alimento alimento)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                try
                {
                    mde.Alimentos.Remove(alimento);
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }
    }
}
