using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planet
{
    abstract class CreatureType
    {
        public CreatureType() { }
        public abstract void move();
        public abstract void absorb();
        public abstract int deadOrAlive();
        public abstract bool alive();
        public abstract int birth();
        ~CreatureType() {}
    }
    class Creature<T> : _object where T : CreatureType,new()
    {
        private T _p_implement;
        private int _amount = 0;

        public Creature(string type, string _sp, string name) : base(type, _sp, name)
        {
            _p_implement = new T();
        }
        //public coordinate creature_pos { get; set; }
        ~Creature()
        {
            if (_p_implement != null)
                _p_implement = null;
        }
        public override void update()
        {
            _p_implement.move();
            _p_implement.absorb();
            _amount -= _p_implement.deadOrAlive();
            if (_p_implement.alive())
                _amount += _p_implement.birth();
            _amount = _amount < 0 ? 0 : _amount;
        }
    }
}