using System;

namespace OOP_lab_6_4_1
{
    class Results
    {
        private string _month;
        private int _plannedProductivity;
        private int _productivity;
        
        public string Month
        {
            get { return _month; }
            set { _month = value; }
        }
        public int PlannedProductivity
        {
            get { return _plannedProductivity; }
            set { _plannedProductivity = value; }
        }
        public int Productivity
        {
            get { return _productivity; }
            set { _productivity = value; }
        }

        public Results()
        {
            Month = "Не вказано";
            PlannedProductivity = 0;
            Productivity = 0;
        }

        public Results(string str)
        {
            string[] elements = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            Month = elements[0];
            PlannedProductivity = int.Parse(elements[1]);
            Productivity = int.Parse(elements[2]);
        }

        public static int Compare(int planproductivity, int realproductivity)
        {
            return planproductivity - realproductivity;
        }
    }
}
