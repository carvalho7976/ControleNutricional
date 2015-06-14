using System;
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
                return mde.Alimentos.Where (ae => ae.Id == nid).Select (ae => new Alimento
                {
                    Id = ae.Id,
                    Nome = ae.Nome,
                    Grupo = ae.Grupo,
                    Porcao = ae.Porcao,
                    Valor_calorico = ae.Valor_calorico.Value,
                    Cho = ae.Cho.Value,
                    Proteinas = ae.Proteinas.Value,
                    Gorduras_totais = ae.Gorduras_totais.Value,
                    Gorduras_saturadas = ae.Gorduras_saturadas.Value,
                    Colesterol = ae.Colesterol.Value,
                    Fosforo = ae.Fosforo.Value,
                    Poliinsaturados = ae.Poliinsaturados.Value,
                    Monoinsaturados = ae.Monoinsaturados.Value,
                    Vitamina_b1 = ae.Vitamina_b1.Value,
                    Vitamina_b2 = ae.Vitamina_b2.Value,
                    Vitamina_b3 = ae.Vitamina_b3.Value,
                    Vitamina_b6 = ae.Vitamina_b6.Value,
                    Gordura_trans = ae.Gordura_trans.Value,
                    Fibra_alimentar = ae.Fibra_alimentar.Value,
                    Acucar = ae.Acucar.Value,
                    Sodio = ae.Sodio.Value,
                    Selenio = ae.Selenio.Value,
                    Calcio = ae.Calcio.Value,
                    Ferro = ae.Ferro.Value,
                    Potassio = ae.Potassio.Value,
                    Zinco = ae.Zinco.Value,
                    Magnesio = ae.Magnesio.Value,
                    Vitamina_a = ae.Vitamina_a.Value,
                    Vitamina_b = ae.Vitamina_b.Value,
                    Vitamina_c = ae.Vitamina_c.Value,
                    Vitamina_d = ae.Vitamina_d.Value,
                    Vitamina_e = ae.Vitamina_e.Value,
                    Vitamina_b9 = ae.Vitamina_b9.Value,
                    Vitamina_b12 = ae.Vitamina_b12.Value
                }).First();
            };
        }

        public bool create(Alimento alimento)
        {
            using (NutricaoContext mde = new NutricaoContext())
            {
                try
                {
                    mde.Alimentos.Add(alimento);
                    mde.SaveChanges();
                    Debug.Write("Entrou no create");
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
