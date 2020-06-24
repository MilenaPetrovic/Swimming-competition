using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Sistemske_operacije
{
    public class UcitajListuPrijava : OpstaSO
    {
        public List<IDomenskiObjekat> lista;

        protected override void IzvrsiOperaciju(IDomenskiObjekat objekat)
        {
            List<IDomenskiObjekat> prijave = broker.Pronadji(objekat);

            for (int i = 0; i < prijave.Count;)
            {
                IDomenskiObjekat ido = prijave[i];
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
            lista = prijave;
        }

        protected override void Validacija(IDomenskiObjekat objekat)
        {
            throw new NotImplementedException();
        }
    }
}
