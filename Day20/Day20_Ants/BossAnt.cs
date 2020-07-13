using System;
using System.Collections.Generic;
using System.Text;

namespace Day20_Ants
{
    //BossAnt has public properties - LeadershipExperience, AntArmySize, and a 
    //public method void BossSound(), which prints “This is a secret boss ant sound: SQIIIIIIIQUUUU!”. 
    class BossAnt : Ant
    {
        public int LeadershipExperience { get; set; }
        public int AntArmySize { get; set; }
        public void BossSound()
        {
            Console.WriteLine("This is a secret boss ant sound: SQIIIIIIIQUUUU!");
        }
    }
}
