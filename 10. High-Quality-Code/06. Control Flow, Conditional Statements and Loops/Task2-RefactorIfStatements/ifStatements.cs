namespace Task2_RefactorIfStatements
{
    class IfStatements
    {
        static void Main(string[] args)
        {
            Potato potato;
            //... 
            if (potato != null)
                if (potato.isPeeled && !potato.isRotten)
                    Cook(potato);

            //...
            if (MIN_X <= x && x <= MAX_X &&
                MIN_Y <= y && y <= MAX_Y &&
                shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}
