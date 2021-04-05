using System;

namespace STEP.Cat
{
    public enum Food
    {
        Fish=12,
        Whiskas=9,
        Beef=11,
        Mice=6,
        Milk=3
    }
    public class Cat
    {
        private int _Satiety;
        public int Satiety {
            get
            {
                return _Satiety;
            }
            set
            {
                if (_Satiety + value <= 100)
                {
                    _Satiety += value;
                }
                else
                {
                    Console.WriteLine("Кот сыт");
                }
            }
        }
    }
}
