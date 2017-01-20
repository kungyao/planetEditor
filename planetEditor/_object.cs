using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planet
{
    class _object : Object
    {
        public static int s_next_id = 0;
        private int object_ID;
        private string object_name;
        private string _species;
        private string _type;

        public int getID(){ return object_ID; }
        public string getName(){ return object_name; }
        public string getType() { return _type; }
        public string getSpecies() { return _species; }

        public _object(string type,string species,string name)
        {
            object_ID = s_next_id++;
            _type = type;
            _species = species;
            object_name = name;
        }
        public override void update() {; }
        ~_object() { }
    }
    abstract class Object
    {
        public abstract void update();
    }
}