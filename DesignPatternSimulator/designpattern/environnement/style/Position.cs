using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.environnement.style
{
    public class Position
    {
        public enum Orientation {
            AVANT, ARRIERE, GAUCHE, DROITE, NON_VALIDE
        }
    
        private int positionX;
        private int positionY;
        private Orientation orientation;
    
        public Position() {
            this.positionX = 0;
            this.positionY = 0;
            this.orientation = Orientation.NON_VALIDE;
        }
    
        public Position(int x, int y) {
            this.positionX = x;
            this.positionY = y;
            this.orientation = Orientation.NON_VALIDE;
        }
    
        public Position(int x, int y, Orientation orientation) {
            this.positionX = x;
            this.positionY = y;
            this.orientation = orientation;
        }
    
        public Position (Position p) {
            this.positionX = p.positionX;
            this.positionY = p.positionY;
            this.orientation = p.orientation;
        }

        public int getPositionX() {
            return positionX;
        }

        public void setPositionX(int positionX) {
            this.positionX = positionX;
        }

        public int getPositionY() {
            return positionY;
        }

        public void setPositionY(int positionY) {
            this.positionY = positionY;
        }

        public Orientation getOrientation() {
            return orientation;
        }

        public void setOrientation(Orientation orientation) {
            this.orientation = orientation;
        }
    }
}
