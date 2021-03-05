using System;
/* Author: Anirudh Dhoundiyal
 * Class: CSC 346
 * Assignment: 3
 * Due Date: 02/22/2021
 * Instructor : Ken Gamradt
 * Program Discription: This program defines three different classes
 */

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HeroNS
{

    public class Hero
    {
        public string Name
        {
            get;
            set;
        }
        public Global.RaceType Race
        {
            get;
            set;

        }


        public short Health
        {
            get;
            set;
        }
        public short Protection
        {
            get;
            set;
        }

        public Global.WeaponType Weapon
        {
            get;
            set;
        }

        /*  Method: constructor
        ***************************************************** 
        * Description: Overwrites the class instance for HERO
        * Input: Void
        * Output: Void
        * IN/OUT AGGS:
        *   public string Name;
        *    public Global.RaceType RaceType;
        *    public short Health;
        *    public short Protection;
        *    public Global.WeaponType Weapon;
        * RETURN : void
        */
        public Hero(string name = "Geralt", Global.RaceType raceType = Global.RaceType.WITCHER, short health = 200, short protection = 50, Global.WeaponType weapon = Global.WeaponType.AXE)
        {
            Name = name;
            Race = raceType;
            Health = health;
            Protection = protection;
            Weapon = weapon;
        }
        /*  Method: Copy constructor
        ***************************************************** 
        * Description: copys the class instance for HERO
        * Input: Void
        * Output: Void
        * IN/OUT AGGS:
        *   Hero :hero
        * RETURN : void
        */
        public Hero(Hero copyhero)
        {
            Name = copyhero.Name;
            Race = copyhero.Race;
            Health = copyhero.Health;
            Protection = copyhero.Protection;
            Weapon = copyhero.Weapon;
        }

    }
}
