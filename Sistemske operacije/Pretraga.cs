using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Sistemske_operacije
{
    public class Pretraga : OpstaSO
    {
        public List<IDomenskiObjekat> lista = new List<IDomenskiObjekat>();
        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {
            List<IDomenskiObjekat> pomocnaLista = broker.Pretraga(objekat);
            
            for (int i = 0; i < pomocnaLista.Count;)
            {
                IDomenskiObjekat ido = pomocnaLista[i];
                IDomenskiObjekat podDomen = ido.VratiPodDomen();

                while (podDomen != null)
                {
                    podDomen.PostaviVrednost(broker.Pronadji(podDomen)[0]);

                    while (podDomen.VratiPodDomen() != null)
                    {
                        IDomenskiObjekat podPod = podDomen.VratiPodDomen();

                        podPod.PostaviVrednost(broker.Pronadji(podPod)[0]);
                        podDomen.PostaviVrednostPodDomena(podPod);
                    }

                    ido.PostaviVrednostPodDomena(podDomen);
                    podDomen = ido.VratiPodDomen();
                }

                i++;
            }
            lista = pomocnaLista;
        }
    }
}
