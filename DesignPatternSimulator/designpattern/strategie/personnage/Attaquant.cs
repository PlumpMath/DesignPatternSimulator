using DesignPatternSimulator.designpattern.observateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class Attaquant : Personnage
    {
        public Attaquant(Organisation org,string nom) : base( org, nom)
        {
        }
        public Random rnd = new Random();
        ////*[0] Rating in his position
        //private int rate;
        ////*[1] Speed
        //private int speed;
        ////*[2] Power
        //private int power;
        ////*[3] Jump Strength
        //private int jumpStrength;
        ////*[4] Shot Strength
        //private int shotStrength;
        ////*[5] Passing Accuracy
        //private int passAccuracy;
        ////*[6] Long Pass Accuracy
        //private int longPassAccuracy;
        ////*[7] Shot Accuracy
        //private int shotAccuracy;
        ////*[8] Stamina
        //private int stamina;
        ////*[9] Risk of injury/Sturdiness
        //private int riskInjury;
        ////*[10] Goalkeeping
        //private int goalKeeping;
        ////*[11] Defending
        //private int defending;
        ////*[12] Left/Right Foot (0 is right, 1 is left, 2 is both
        //private int foot;


        private int getRate() { return this.rate; }
        private int getSpeed() { return this.speed; }
        private int getPower() { return this.power; }

        private int getJumpStrength() { return this.jumpStrength; }
        //*[4] Shot Strength
        private int getShotStrength() { return this.shotStrength; }
        //*[5] Passing Accuracy
        private int getPassAccuracy() { return this.passAccuracy; }
        //*[6] Long Pass Accuracy
        private int getLongPassAccuracy() { return this.longPassAccuracy; }
        //*[7] Shot Accuracy
        private int getShotAccuracy() { return this.shotAccuracy; }
        //*[8] Stamina
        private int getStamina() { return this.stamina; }
        //*[9] Risk of injury/Sturdiness
        private int getRiskInjury() { return this.riskInjury; }
        //*[10] Goalkeeping
        private int getGoalKeeping() { return this.goalKeeping; }
        //*[11] Defending
        private int getDefending() { return this.defending; }
        //*[12] Left/Right Foot (0 is right, 1 is left, 2 is both
        private int getFoot() { return this.foot; }

        private void setRate(int value) { rnd.Next(value); }
        private void setSpeed(int value) { rnd.Next(value); }
        private void setPower(int value) { rnd.Next(value); }

        private void setJumpStrength(int value) { rnd.Next(value); }
        //*[4] Shot Strength
        private void setShotStrength(int value) { rnd.Next(value); }
        //*[5] Passing Accuracy
        private void setPassAccuracy(int value) { rnd.Next(value); }
        //*[6] Long Pass Accuracy
        private void setLongPassAccuracy(int value) { rnd.Next(value); }
        //*[7] Shot Accuracy
        private void setShotAccuracy(int value) { rnd.Next(value); }
        //*[8] Stamina
        private void setStamina(int value) { rnd.Next(value); }
        //*[9] Risk of injury/Sturdiness
        private void setRiskInjury(int value) { rnd.Next(value); }
        //*[10] Goalkeeping
        private void soalKeeping(int value) { rnd.Next(value); }
        //*[11] Defending
        private void setDefending(int value) { rnd.Next(value); }
        //*[12] Left/Right Foot (0 is right, 1 is left, 2 is both
        private void setFoot(int value) { rnd.Next(value); }

    }
}
