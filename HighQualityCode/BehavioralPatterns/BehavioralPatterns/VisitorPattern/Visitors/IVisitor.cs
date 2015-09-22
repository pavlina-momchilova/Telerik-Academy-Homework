﻿namespace VisitorPattern.Visitors
 {
     using VisitorPattern.Race;

     public interface IVisitor
     {
         void Visit(Races race);
     }
 }
