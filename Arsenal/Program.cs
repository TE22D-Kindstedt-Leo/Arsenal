﻿using System.Text.Json;

string contents = File.ReadAllText("vapen.json");

vapen w = JsonSerializer.Deserialize<vapen>(contents);

Console.WriteLine("How many attacks to make?");

int numAttacks = 0;
string numAttacksStr = "";

while (!int.TryParse(numAttacksStr, out numAttacks))
{
  numAttacksStr = Console.ReadLine();
}

int damageSum = 0;

Console.ForegroundColor = ConsoleColor.Red;

for (int i = 0; i < numAttacks; i++)
{
  int damage = w.Attack();
  Console.WriteLine($"+{damage}");
  damageSum += damage;
}

Console.ResetColor();

Console.WriteLine($"You did a total of {damageSum} points of damage");

Console.ReadLine();