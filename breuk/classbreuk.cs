using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breuk
{
    class Breuk
    {
        #region attributen
        int teller;
        int noemer;
        #endregion
        #region constructors
        public Breuk()
        {

        }
        #endregion
        #region methodes
        public Breuk Vereenvoudig()
        {
            Breuk bam = new Breuk();
            return bam;
        }
        #endregion
        #region getset
        public int Teller
        {
            get { return this.teller; }
            set { this.teller = value; }
        }
        public int Noemer
        {
            get { return this.noemer; }
            set { this.noemer = value; }
        }
        #endregion

    }
}
