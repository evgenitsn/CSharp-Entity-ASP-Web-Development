﻿using System;

namespace TheSlum.Characters
{
    public static class CharacterFactory
    {
         public static Character Create(string type, string id, Team team, int x,int y)
        {
             switch (type.ToLower())
             {
                case "mage":
                    return new Mage(id, x, y, team);
                case "warrior":
                    return new Warrior(id, x, y, team);
                case "healer":
                    return new Healer(id, x, y, team);
                default:
                     throw new ArgumentException("Invalid character type supplied.");
            }
        }
    }
}