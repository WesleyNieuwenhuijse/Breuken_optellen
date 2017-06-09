using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breuk
{
    class Bereken
    {
        #region attributen

        #endregion
        #region constructors
        public Bereken()
        {

        }
        #endregion
        #region methodes

        public Breuk Vereenvoudigen(Breuk resultaat)
        {
            for (int i = 2; i <= resultaat.Teller; i++)
            {
                if ((resultaat.Teller % i == 0) && (resultaat.Noemer % i == 0))
                {
                    resultaat.Teller /= i;
                    resultaat.Noemer /= i;
                    i = 2;
                }
            }
            return resultaat;
        }

        public Breuk OptellenBreuken(Breuk breuk1, Breuk breuk2)
        {
            Breuk brResultaat = new Breuk();
            int tussengetal;
            if (breuk1.Noemer == breuk2.Noemer)
            {
                brResultaat.Noemer = breuk1.Noemer;
            }
            else
            {
                tussengetal = breuk1.Noemer;
                breuk1.Teller = breuk1.Teller * breuk2.Noemer;
                breuk1.Noemer = breuk1.Noemer * breuk2.Noemer;
                breuk2.Teller = breuk2.Teller * tussengetal;
                breuk2.Noemer = breuk2.Noemer * tussengetal;
            }
            brResultaat.Teller = breuk1.Teller + breuk2.Teller;
            brResultaat.Noemer = breuk1.Noemer;
            return brResultaat;
        }
        #endregion
        #region getset

        #endregion

    }
}
