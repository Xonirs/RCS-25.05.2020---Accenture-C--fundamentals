using System;

namespace Day20_Ants
{
    class Program
    {
        static void Main(string[] args)
        {
            Ant ant = new Ant()
            {
                Name = "WorkerAnt",
                Size = 2
            };
            Console.WriteLine($"Hi, my name is {ant.Name} and my size is {ant.Size}");
            ant.WorkerSound();

            BossAnt bossAnt = new BossAnt()
            {
                Name = "BossAnt",
                Size = 5,
                AntArmySize = 400,
                LeadershipExperience = 8
            };
            Console.WriteLine($"Hi, my name is {bossAnt.Name} and my size is {bossAnt.Size}");
            Console.WriteLine($"My army size is {bossAnt.AntArmySize} and experience is lvl {bossAnt.LeadershipExperience}");
            bossAnt.WorkerSound();
            bossAnt.BossSound();
        }
    }
}

/*
 Create classes - Ant and BossAnt. BossAnt class is derived from base class Ant. Ant has public properties - Name, Size, 
 and a public method void WorkerSound(), which prints “WORK WORK WORK”. BossAnt has public properties - LeadershipExperience,
 AntArmySize, and a public method void BossSound(), which prints “This is a secret boss ant sound: SQIIIIIIIQUUUU!”. 
 In Program.Main create Ant and fill all the properties values, print them and use the method WorkerSound(). 
 Create BossAnt and fill all the properties (also the ones inherited from Ant), print them and use the method WorkerSound() 
 and BossSound().
     * * 
 */
