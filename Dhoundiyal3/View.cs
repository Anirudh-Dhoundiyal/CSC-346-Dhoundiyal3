using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroNS
{
    public static class View
    {
        /*  Method: Override Cunstructor
        ***************************************************** 
        * Description: Displays the class instance for HERO Horizontally 
        * Input: HERO hero
        * Output: Void
        * IN/OUT AGGS:
        *   public string Name;
        *    public Global.RaceType RaceType;
        *    public short Health;
        *    public short Protection;
        *    public Global.WeaponType Weapon;
        * RETURN : void
        */
        public static void ViewH(Hero heroH)
        {
            Console.WriteLine("HERO  |  RACE  |  HEALTH  |  PROTECTION  |  WEAPON ");
            Console.Write(heroH.Name);
            Console.Write("  ");
            Console.Write(heroH.RaceType);
            Console.Write("     ");
            Console.Write(heroH.Health);
            Console.Write("         ");
            Console.Write(heroH.Protection);
            Console.Write("          ");
            Console.Write(heroH.Weapon);
        }
        /*  Method: Override Cunstructor
        ***************************************************** 
        * Description: Displays the class instance for HERO Vertically 
        * Input: HERO hero
        * Output: Void
        * IN/OUT AGGS:
        *   public string Name;
        *    public Global.RaceType RaceType;
        *    public short Health;
        *    public short Protection;
        *    public Global.WeaponType Weapon;
        * RETURN : void
        */
        public static void ViewV(Hero heroV)
        {
            Console.Write("Hero:       ");
            Console.WriteLine(heroV.Name);
            Console.Write("Race:       ");
            Console.WriteLine(heroV.RaceType);
            Console.Write("Health:     ");
            Console.WriteLine(heroV.Health);
            Console.Write("Protection: ");
            Console.WriteLine(heroV.Protection);
            Console.Write("Weapon:     ");
            Console.WriteLine(heroV.Weapon);
        }
    }
}
