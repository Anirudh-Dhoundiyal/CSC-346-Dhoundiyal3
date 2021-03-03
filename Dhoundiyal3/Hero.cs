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
        public string Name;
        public Global.RaceType RaceType;
        public short Health;
        public short Protection;
        public Global.WeaponType Weapon;
        public Hero()
        {
            Name = "Geralt";
            RaceType = Global.RaceType.WITCHER;
            Health = 200;
            Protection = 50;
            Weapon = Global.WeaponType.AXE;
        }
/*  Method: Override Cunstructor
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
        public Hero(string name, Global.RaceType raceType, short health, short protection, Global.WeaponType weapon)
        {
            Name = name;
            RaceType = raceType;
            Health = health;
            Protection = protection;
            Weapon = weapon;
        }
        /*  Method: Copy Cunstructor
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
            RaceType = copyhero.RaceType;
            Health = copyhero.Health;
            Protection = copyhero.Protection;
            Weapon = copyhero.Weapon;
        }

    }
}
