// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!!");

Attack attack1 = new Attack("fireball", 20);
Attack attack2 = new Attack("punch", 15);
Attack attack3 = new Attack("throw", 25);

Enemy enemy1 = new Enemy("bandit");

enemy1.AddAttack(attack1);
enemy1.AddAttack(attack2);
enemy1.AddAttack(attack3);

System.Console.WriteLine(enemy1.RandomAttack().Name);