using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinGenerRandomString
{
    public class RandomHelper
    {
        static readonly char[] SPECIAL_CHARS = { '!', '@', '#', '$', '&' };
        static readonly char[] CHINESE_CHARS = { '赵', '钱', '孙', '李', '周', '刘', '王' };

        private Random randomer = new Random();
        private List<char> charLibrary = new List<char>();

        public bool HasLowerChar { get; private set; }
        public bool HasUpperChar { get; private set; }
        public bool HasNumber { get; private set; }
        public bool HasSpecialChar { get; private set; }
        public bool HasChineseChar { get; private set; }
        public bool HasSameChar { get; private set; }
        public int RandomStringlength { get; private set; }

        public RandomHelper()
            : this(true, true, true, false, false, false, 6) { }

        public RandomHelper(bool hasLowerChar, bool hasUpperChar, bool hasNumber) :
            this(hasLowerChar, hasUpperChar, hasNumber, false, false, false, 6) { }

        public RandomHelper(bool hasLowerChar, bool hasUpperChar, bool hasNumber, bool hasSpecialChar, bool hasChineseChar, bool hasSameChar, int randomStringlength)
        {
            this.HasLowerChar = hasLowerChar;
            this.HasUpperChar = hasUpperChar;
            this.HasNumber = hasNumber;
            this.HasSpecialChar = hasSpecialChar;
            this.HasChineseChar = hasChineseChar;
            this.HasSameChar = hasSameChar;
            this.RandomStringlength = randomStringlength;
            InitCharLibrary();
        }

        private void InitCharLibrary()
        {
            if (HasLowerChar) AddLowerChars();
            if (HasUpperChar) AddUpperChars();
            if (HasNumber) AddNumbers();
            if (HasSpecialChar) AddSpecialChars();
            if (HasChineseChar) AddChineseChars();
        }

        private void AddLowerChars()
        {
            for (int i = 97; i <= 122; i++)
                this.charLibrary.Add((char)i);
        }

        private void AddUpperChars()
        {
            for (int i = 65; i <= 90; i++)
                this.charLibrary.Add((char)i);
        }

        private void AddNumbers()
        {
            this.charLibrary.AddRange(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
        }

        private void AddSpecialChars()
        {
            this.charLibrary.AddRange(SPECIAL_CHARS);
        }

        private void AddChineseChars()
        {
            this.charLibrary.AddRange(CHINESE_CHARS);
        }

        public string GetRandomString()
        {
            List<char> randomString = new List<char>();
            while (LengthNotEnough(randomString))
                AddRandomCharTo(randomString);
            return new string(randomString.ToArray());
        }

        private void AddRandomCharTo(List<char> randomString)
        {
            char randomChar = GetRandomChar();
            if (HasSameChar)
                randomString.Add(randomChar);
            else
                AddIfNotHaveSameChar(randomString, randomChar);
        }

        private bool LengthNotEnough(List<char> randomString)
        {
            return randomString.Count < this.RandomStringlength;
        }

        private char GetRandomChar()
        {
            int index = randomer.Next(this.charLibrary.Count);
            return charLibrary[index];
        }

        private static void AddIfNotHaveSameChar(List<char> randomString, char randomChar)
        {
            if (!randomString.Contains(randomChar))
                randomString.Add(randomChar);
        }
    }
}
