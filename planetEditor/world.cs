using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace planet
{
    class animal : CreatureType
    {
        public animal() { }
        public override void move() { Console.WriteLine("Run Run Run"); }
        public override void absorb() { Console.WriteLine("Eat Eat Eat"); }
        public override int deadOrAlive() { Console.WriteLine("Alive"); return 0; }
        public override bool alive() { return true; }
        public override int birth() { return 0; }
        ~animal() { }
    }
    class plant : CreatureType
    {
        public plant() { }
        public override void move() { Console.WriteLine("Plant cannot move :("); }
        public override void absorb() { Console.WriteLine("Growth"); }
        public override int deadOrAlive() { Console.WriteLine("Alive"); return 0; }
        public override bool alive() { return true; }
        public override int birth() { Console.WriteLine("Spread seeds"); return 0; }
        ~plant() { }
    }
    class world
    {
        static void Main()
        {
            //List<planet> sv_planet = new List<planet>();
            bool run = true;
            planet p_planet = null;
            while (run)
            {
                Console.WriteLine("(1)cp name x y z radious \n(2)ac type(animal or plant) creature name\n(3)ro id\n(4)up\n(5)cc type(animal or plant) creature\n(6)list\n(7)exit");
                string input = Console.ReadLine();
                string[] args = input.Split(' ');
                string command = args[0];
                if (command == "exit")
                    Console.WriteLine("bye~!");
                else if (command == "cp") //creat planet
                {
                    double r = Convert.ToDouble(args[5]);
                    string name = args[1];
                    coordinate pos = new coordinate(Convert.ToSingle(args[2]), Convert.ToSingle(args[3]), Convert.ToSingle(args[4]));
                    try
                    {
                        p_planet = new planet(name, pos, r);
                        Console.WriteLine(p_planet.getName() + " created!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("you shall creat planet!!");
                        if (p_planet != null) p_planet = null;
                    }
                }
                else
                {
                    if (p_planet == null) 
                        Console.WriteLine("You shall creat a planet first!!!");
                    else
                    {
                        if (command == "ac") //add creature
                        {
                            string c_type = args[1];
                            string _creature = args[2]; //species
                            string name = args[3];
                            _object op = null;
                            if (c_type == "animal")
                                op = new Creature<animal>(c_type, _creature,name);
                            else if (c_type == "plant")
                                op = new Creature<plant>(c_type, _creature, name);
                            else
                                Console.WriteLine("i don't konw");
                            if (op != null)
                            {
                                try
                                {
                                    p_planet.addObject(op);
                                    Console.WriteLine(op.getSpecies() + " " + op.getName() + " added!");
                                }
                                catch (Exception a)
                                {
                                    Console.WriteLine(a.Message);
                                }
                            }
                        }
                        else if (command == "ro") //remove
                        {
                            int id = Convert.ToInt32(args[1]);
                            p_planet.removeobject(id);
                            Console.WriteLine(id + " removed!");
                        }
                        else if (command == "up")
                            p_planet.update();
                        else if (command == "cc")
                        {
                            string c_type = args[1];
                            string ct_name = args[2];
                            sv_species tmp = new sv_species(c_type,ct_name);
                            try
                            {
                                p_planet.addnewcreature(tmp);
                                Console.WriteLine(tmp.get_species() + " created !");
                            }
                            catch (Exception a)
                            {
                                Console.WriteLine(a.Message);
                                if (tmp != null) tmp = null;
                            }
                        }
                        else if (command == "list")
                            p_planet.show();
                        else
                            Console.WriteLine("error");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}