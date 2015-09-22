﻿namespace VisitorPattern
 {
     using System;
     using System.Collections.Generic;
     using VisitorPattern.Race;
     using VisitorPattern.Visitors;

     internal class RaceList
     {
         private readonly List<Races> races = new List<Races>();

         public void Attach(Races race)
         {
             this.races.Add(race);
         }

         public void Detach(Races race)
         {
             this.races.Remove(race);
         }

         public void Accept(IVisitor visitor)
         {
             foreach (var race in this.races)
             {
                 race.BecomeStronger(visitor);
             }

             Console.WriteLine();
         }
     }
 }
