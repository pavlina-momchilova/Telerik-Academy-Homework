namespace RefactorTheFollowingIfStatements
{
    using System;

    public class Chief
    {
        private static bool shouldVisitCell;

        public static void Main(string[] args)
        {
            Potato potato = new Potato();
            if (potato != null)
            {
                if (!potato.IsRotten && potato.HasBeenPeeled)
                {
                    Cook(potato);
                }
            }

            double x = 0, y = 0, minX = 0, maxY = 0, minY = 0, maxX = 0;

            bool isInRangeY = maxY >= y && minY <= y;
            bool isInRangeAndCellIsVisit = isInRangeY && shouldVisitCell;
            bool biggerThanMaxXAndIsVisit = x <= maxX && isInRangeAndCellIsVisit;
            bool isInRange = x >= minX && biggerThanMaxXAndIsVisit;

            if (isInRangeY)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }
    }
}
