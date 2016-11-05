using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Randomer
{
    public class RandomHelper
    {
        private Random randomer;
        private List<char> allChars;

        bool hasLowerChar;
        bool hasUpperChar;
        bool hasNumber;
        bool hasSpecialChar;
        bool hasChineseChar;
        bool hasSameChar;
        int randomStringlength;

        private char[] specialChars = new char[] { '!', '@', '#', '$', '&' };
        private char[] chineseChars = new char[] { '赵', '钱', '孙', '李', '周', '刘', '王' };
        private int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public RandomHelper()
        {
            randomer = new Random();
            SetAllCharsValue();
        }

        private void SetAllCharsValue()
        {
            if (hasLowerChar)
                AddLowerCharsTo();
            if (hasUpperChar)
                AddUpperCharsTo();
        }

        public void AddLowerCharsTo()
        {
            for (int i = 97; i < 123; i++)
                this.allChars.Add((char)i);
        }

        public void AddUpperCharsTo()
        {
            for (int i = 65; i < 91; i++)
                this.allChars.Add((char)i);
        }

        public char GetRandomLowerChar()
        {
            return (char)randomer.Next(97, 123);
        }

        public char GetRandomUpperChar()
        {
            return (char)randomer.Next(65, 91);
        }

        public int GetRandomNumber()
        {
            return randomer.Next(10);
        }

        public string GetRandomNumbers(int length)
        {
            StringBuilder builder = new StringBuilder();
            int number = randomer.Next(10);
            while (builder.ToString().Length < length)
            {
                if (!builder.ToString().Contains(number.ToString()))
                {
                    builder.Append(number);
                }
                number = randomer.Next(10);
            }
            return builder.ToString();
        }

        public char GetRandomSpecialChar()
        {
            int index = randomer.Next(specialChars.Length);
            return this.specialChars[index];
        }

        public char GetRandomChineseChar()
        {
            int index = randomer.Next(chineseChars.Length);
            return this.chineseChars[index];
        }

        //public string GetRandomString()
        //{

        //}
    }
}
