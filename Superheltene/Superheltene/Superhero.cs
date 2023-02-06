using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheltene
{
    public class Superhero
    {
        private string _identity;
        private string _ability;
        private string _equipment;
        private string _costume;
        private string _moralCode;
        private string _enemy;
        private string _anxiety;

        public string Identity
        { 
            get { return _identity; }

            private set { _identity = value; }
        }

        public string Ability 
        { 
            get { return _ability; } 
            
            private set { _ability = value;  } 
        }

        public string Equipment
        {
            get { return _equipment; }

            private set { _equipment = value; }
        }

        public string Costume
        {
            get { return _costume; }

            private set { _costume = value; }
        }

        public string MoralCode
        {
            get { return _moralCode; }

            private set { _moralCode = value; }
        }

        public string Enemy
        {
            get { return _enemy; }

            private set { _enemy = value; }
        }

        public string Anxiety
        {
            get { return _anxiety; }

            private set { _anxiety = value; }
        }
    }
}
