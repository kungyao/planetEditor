using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planet
{
    class sv_species
    {
        private string _species;
        private string _type;

        public string get_type() { return _type; }
        public string get_species() { return _species; }

        public sv_species(string type,string name){ _species = name;_type = type; }
    }
}
