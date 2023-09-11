using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheltene.Class
{
    /// <summary>
    /// Class <c>Superhero</c> models a superhero
    /// </summary>
    internal class Superhero
    {
        #region Properties
        /// <summary>
        /// _areaOfProtection represents what area - city, country or others - the hero is protecting
        /// </summary>
        private string _areaOfProtection;
        private string _costumeColour;
        private string _heroName;
        private string _powers;
        private string _secretIdentity;
        #endregion


        #region PublicMethods
        public string AreaOfProtection
        {
            get { return _areaOfProtection; }
            set { _areaOfProtection = value; }
        }
        public string CostumeColour
        {
            get { return _costumeColour; }
            set { _costumeColour = value; }
        }
        public string HeroName
        {
            get { return _heroName; }
            set { _heroName = value; }
        }
        public string Powers
        {
            get { return _powers; }
            set { _powers = value; }
        }
        public string SecretIdentity
        {
            get { return _secretIdentity; }
            private set { _secretIdentity = value; }
        }
        #endregion
    }
}
