﻿namespace VisitorPattern.Visitors
 {
     using System;
     using VisitorPattern.Race;

     public class IncreaseAttackPointVisitor : IVisitor
     {
         public void Visit(Races race)
         {
             if (race != null)
             {
                 race.AttackPoints += 5;
                 Console.WriteLine("{0}'s new Attack points are: {1}. Now {0} attack will be more powerfull! ");
             }
         }
     }
 }
