﻿namespace VisitorPattern.Visitors
 {
     using System;
     using VisitorPattern.Race;

     public class IncreaseDefencePointVisitor : IVisitor
     {
         public void Visit(Races race)
         {
             if (race != null)
             {
                 race.DefencePoints += 5;
                 Console.WriteLine("{0}'s new Defence points are: {1}. Now {0} has bigger defence! ");
             }
         }
     }
 }
