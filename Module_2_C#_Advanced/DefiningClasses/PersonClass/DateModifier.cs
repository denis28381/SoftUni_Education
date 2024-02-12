namespace DefiningClasses
{
    internal class DateModifier
    {
        private int diffrenceInDays;
        private DateTime firstDate;
        private DateTime secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            this.firstDate = DateTime.Parse(firstDate);
            this.secondDate = DateTime.Parse(secondDate);
        }

        public int DifferanceInDays
        {
            get
            {
                return diffrenceInDays = Math.Abs((int)(firstDate - secondDate).TotalDays);
            } 
           // set;
        }

    }
}
