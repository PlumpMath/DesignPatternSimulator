using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.environnement.style
{
    public class ZonePion : AbstractZone
    {
        private bool occupe;
	    private string name;
        private int x;
        private int y;
        private Color color;

        public bool Occupe { get; set; }
        public int X { get; set; }
        public int Y {get;set;}

        public ZonePion()
        {
            this.X = 0;
            this.Y = 0;
            this.Occupe = false;
        }

        public ZonePion(int x, int y)
        {
            this.X = x;
            this.Y = y;
//            this.Occupe = false;
        }
	
	    public ZonePion(string nom, int x, int y) {
		    name = nom;
            this.X = x;
            this.Y = y;
            this.Occupe = false;
        }

        public ZonePion(Position p)
        {
            this.X = p.getPositionX();
            this.Y = p.getPositionY();
        }
	
	    public override AbstractZone CreerZone() {
		    return new ZonePion();
	    }

	    public override AbstractZone CreerZone(string s, int x, int y) {
		    return new ZonePion(s, x, y);
	    }

	    public string getName() {
		    return name;
	    }


        /// <summary>
        /// Recuperer la liste des zones entourants un pion
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ep"></param>
        /// <returns></returns>
        public List<ZonePion> GetList(Pion p, List<ZonePion> ep){

            List<ZonePion> zoneautour = new List<ZonePion>();
           

            var co1 = ep.Where(c => c.X == (p.Position.X - 1) && c.Y == (p.Position.Y - 1)).Single();
            var co2 = ep.Where(c => c.X == (p.Position.X - 1) && c.Y == (p.Position.Y)).Single();
            var co3 = ep.Where(c => c.X == (p.Position.X - 1) && c.Y == (p.Position.Y + 1)).Single();
            var co4 = ep.Where(c => c.X == (p.Position.X) && c.Y == (p.Position.Y - 1)).Single();
            var co5 = ep.Where(c => c.X == (p.Position.X) && c.Y == (p.Position.Y + 1)).Single();
            var co6 = ep.Where(c => c.X == (p.Position.X - 1) && c.Y == (p.Position.Y - 1)).Single();
            var co7 = ep.Where(c => c.X == (p.Position.X) && c.Y == (p.Position.Y - 1)).Single();
            var co8 = ep.Where(c => c.X == (p.Position.X + 1) && c.Y == (p.Position.Y - 1)).Single();
            zoneautour.Add(co1);
            zoneautour.Add(co2);
            zoneautour.Add(co3);
            zoneautour.Add(co4);
            zoneautour.Add(co5);
            zoneautour.Add(co6);
            zoneautour.Add(co7);
            zoneautour.Add(co8);
            return zoneautour;
        }

    }
}

