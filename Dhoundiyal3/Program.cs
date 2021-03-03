/* Author: Anirudh Dhoundiyal
 * Class: CSC 346
 * Assignment: 3
 * Due Date: 02/22/2021
 * Instructor : Ken Gamradt
 * Program Discription: This program defines three different classes
 */
using System;

/*  Method: Main Program
 ***************************************************** 
 * Description: Runs the program
 * Input: Void
 * Output: Void
 */
namespace HeroNS
{
    class Program
    {
        static void Main()
        {
            Hero ani = new Hero();
            View.ViewV(ani);
            View.ViewH(ani);

            ani.Name = "Anirudh";
            View.ViewV(ani);
            View.ViewH(ani);
        }
    }
}
