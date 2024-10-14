using System.IO;

namespace _03.HeroesEx
{
    class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<Hero> heroesList = new List<Hero>();
                int heroCount = int.Parse(Console.ReadLine());
                for (int i = 0;  i < heroCount; i++)
                {
                    Hero hero = new Hero();
                    string[] heroes = Console.ReadLine().Split();
                    hero.Name = heroes[0];
                    hero.HP = int.Parse(heroes[1]);
                    hero.MP = int.Parse(heroes[2]);
                    heroesList.Add(hero);
                }
                string command = "";
                while ((command = Console.ReadLine()) != "End")
                {
                    string[] splitCommand = command.Split(" - ");
                    string action = splitCommand[0];
                    string heroName = splitCommand[1];
                    if (action == "CastSpell")
                    {
                        int mpNeeded = int.Parse(splitCommand[2]);
                        string spellName = splitCommand[3];
                        Hero herofounded = heroesList.FirstOrDefault(h => h.Name == heroName);
                        if (herofounded != null && herofounded.MP >= mpNeeded)
                        {
                            herofounded.MP -= mpNeeded;
                            Console.WriteLine($"{herofounded.Name} has successfully cast {spellName} and now has {herofounded.MP} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{herofounded.Name} does not have enough MP to cast {spellName}!");
                        }

                    }
                    else if (action == "TakeDamage")
                    {
                        int damage = int.Parse(splitCommand[2]);
                        string attacker = splitCommand[3];
                        Hero herofounded = heroesList.FirstOrDefault(h => h.Name == heroName);
                        if (herofounded != null)
                        {
                            herofounded.HP -= damage;
                        }

                        if (herofounded.HP > 0)
                        {
                            Console.WriteLine($"{herofounded.Name} was hit for {damage} HP by {attacker} and now has {herofounded.HP} HP left!");
                        }
                        else
                        {
                            heroesList.Remove(herofounded);
                            Console.WriteLine($"{herofounded.Name} has been killed by {attacker}!");
                        }
                    }
                    else if (action == "Recharge")
                    {
                        int amount = int.Parse(splitCommand[2]);
                        Hero herofounded = heroesList.FirstOrDefault(h => h.Name == heroName);
                        int recoveredMP = Math.Min(amount, 200 - herofounded.MP);
                        herofounded.MP += recoveredMP;
                        Console.WriteLine($"{herofounded.Name} recharged for {recoveredMP} MP!");
                    }
                    else if (action == "Heal")
                    {
                        int amount = int.Parse(splitCommand[2]);
                        Hero herofounded = heroesList.FirstOrDefault(h => h.Name == heroName);
                        int recoveredHP = Math.Min(amount, 100 - herofounded.HP);
                        herofounded.HP += recoveredHP;
                        Console.WriteLine($"{herofounded.Name} healed for {recoveredHP} HP!");
                    }
                }
                foreach (Hero hero in heroesList)
                {
                    Console.WriteLine($"{hero.Name}");
                    Console.WriteLine($"  HP: {hero.HP}");
                    Console.WriteLine($"  MP: {hero.MP}");
                }
            }
        }
    }
}