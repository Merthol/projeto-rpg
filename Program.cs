using projeto_rpg.src.Entities;

var hero1 = new Knight("Arus", "Knight");
var hero2 = new Wizard("Jennica", "White Wizard");
var hero3 = new Ninja("Wedge", "Ninja");
Console.WriteLine(hero2);
Console.WriteLine();
Console.ReadLine();
Console.WriteLine(hero2.displayPrimaryAttributes());
Console.WriteLine();
Console.WriteLine(hero2.displaySecondaryAttributes());
Console.WriteLine("=======================================\n");
Console.ReadLine();
hero2.LevelUp();
hero2.LevelUp();
hero2.LevelUp();
Console.WriteLine(hero2);
Console.WriteLine();
Console.WriteLine(hero2.displayPrimaryAttributes());
Console.WriteLine();
Console.WriteLine(hero2.displaySecondaryAttributes());
Console.WriteLine("=======================================\n");
Console.ReadLine();
// Console.WriteLine(hero2);
// Console.WriteLine(hero2.displayPrimaryAttributes());
// Console.WriteLine();
// Console.WriteLine(hero2.displaySecondaryAttributes());
// Console.WriteLine("=======================================\n");
// Console.WriteLine(hero3);
// Console.WriteLine(hero3.displayPrimaryAttributes());
// Console.WriteLine();
// Console.WriteLine(hero3.displaySecondaryAttributes());
// Console.WriteLine("=======================================\n");
// Console.WriteLine(hero1.Attack());
// Console.WriteLine(hero2);
// Console.WriteLine(hero2.Attack());
// Console.WriteLine(hero2.Attack(3));
// Console.WriteLine(hero2.Attack(9));