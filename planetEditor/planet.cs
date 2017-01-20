using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planet
{
    class planet : _object
    {
        private List<_object> _object_ptrs = new List<_object>();
        private List<sv_species> _sv_ct_creature = new List<sv_species>();
        private double _radius;
        private coordinate _position_s;
        private bool radiusCheck(double r) { return r > Convert.ToDouble(0); }
        private bool _chsp(string name)
        {
            if (_sv_ct_creature.Exists(x => x.get_species() == name))
                return true;
            else
                return false;
        }

        public planet(string name, coordinate pos, double radius) : base(null,null,name) 
        {
           //_object s_object = new _object(name);
            _position_s = pos;
            _radius = radius;
            if (!radiusCheck(radius))
                throw new Exception("Radius should be greater than 0.0f.");
        }

        public void addnewcreature(sv_species p)
        {
            if (_chsp(p.get_species()))
                throw new Exception("name duplicate!");
            _sv_ct_creature.Add(p);
        }

        public void addObject(_object p)
        {
            if (!_sv_ct_creature.Exists(x => x.get_type() == p.getType() && x.get_species() == p.getSpecies())) 
                throw new Exception("shall be created first!");
            _object_ptrs.Add(p);
        }

        public void removeobject(int id)
        {
            if (_object_ptrs.Exists(x => x.getID() == id))
                for (int i = 0; i < _object_ptrs.Count; i++)
                {
                    if (id == _object_ptrs[i].getID())
                    {
                        _object_ptrs.Remove(_object_ptrs[i]);
                    }
                }
            else
                Console.WriteLine("we don't have it");
        }

        public void show()
        {
            Console.WriteLine("alive");
            for (int i = 0; i < _object_ptrs.Count; i++)
                Console.WriteLine(_object_ptrs[i].getID() + " " + _object_ptrs[i].getType() + " " + _object_ptrs[i].getSpecies() + " " + _object_ptrs[i].getName());
            Console.WriteLine("\ncan creat");
            for (int i = 0; i < _sv_ct_creature.Count; i++)
                Console.WriteLine(_sv_ct_creature[i].get_type() + " " + _sv_ct_creature[i].get_species());
        }

        public override void update()
        {
            for (int i = 0; i < _object_ptrs.Count; i++)
            {
                Console.WriteLine(_object_ptrs[i].getID() + "  " + _object_ptrs[i].getName());
                _object_ptrs[i].update();
            }
        }
    }
}