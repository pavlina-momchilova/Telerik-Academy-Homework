﻿namespace VisitorPattern.Race
 {
     using VisitorPattern.Visitors;

     public abstract class Races
     {
         protected Races()
         {

         }

         protected Races(string name, int defencePoints, int attackPoints)
         {
             this.Name = name;
             this.DefencePoints = defencePoints;
             this.AttackPoints = attackPoints;
         }

         public string Name { get; set; }

         public int DefencePoints { get; set; }

         public int AttackPoints { get; set; }

         public void BecomeStronger(IVisitor visitor)
         {
             visitor.Visit(this);
         }
     }
 }
