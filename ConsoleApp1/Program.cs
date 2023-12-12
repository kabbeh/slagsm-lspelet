﻿using System;

int heroHp = 100;
int villainHp = 100;

string heroName = "SOLAR";
string villainName = "IRELKING";

Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
  Console.WriteLine("\n----- ===== NEW ROUND ===== -----");
  Console.WriteLine($"{heroName}: {heroHp}  {villainName}: {villainHp}\n");

  int heroDamage = generator.Next(20);
  villainHp -= heroDamage;
  villainHp = Math.Max(0, villainHp);
  Console.WriteLine($"{heroName} did {heroDamage} damage to {villainName}");

  int villainDamage = generator.Next(20);
  heroHp -= villainDamage;
  heroHp = Math.Max(0, heroHp);
  Console.WriteLine($"{villainName} did {villainDamage} damage to {heroName}");

  Console.WriteLine("Press any button to continue");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== THE FIGHT IS OVER ===== -----");

if (heroHp == 0 && villainHp == 0)
{
  Console.WriteLine("TIED");
}
else if (heroHp == 0)
{
  Console.WriteLine($"{villainName} WON!");
}
else
{
  Console.WriteLine($"{heroName} WON!");
}

Console.WriteLine("Press whatever button to continue or something.");
Console.ReadKey();