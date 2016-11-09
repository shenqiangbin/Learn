using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SqlGenerator
{
    public class RandomGenerateEventArgs : EventArgs
    {
        public string RandomRecords { get; private set; }

        public RandomGenerateEventArgs(string randomRecords)
        {
            this.RandomRecords = randomRecords;
        }
    }

    public delegate void MyRandomEventHandler(object sender, RandomGenerateEventArgs e);

    /// <summary>
    /// 此类常见问题：Format中的参数个数不对
    /// </summary>
    public class RandomSql
    {
        private string format;
        private bool withQuotation = true;

        public bool WithQuotation
        {
            get { return withQuotation; }
            set
            {
                foreach (var v in Values)
                {
                    v.WithQuotation = value;
                }
            }
        }

        private IList<RandomValues> randomValues;

        public event MyRandomEventHandler Generating;
        public event EventHandler Generated;

        public IList<RandomValues> Values
        {
            get { return this.randomValues; }
            set { this.randomValues = value; }
        }

        public virtual void OnGenerating(RandomGenerateEventArgs e)
        {
            MyRandomEventHandler handler = Generating;
            if (handler != null)
                Generating(this, e);
        }

        public virtual void OnGenerated(EventArgs e)
        {
            EventHandler handler = Generated;
            if (handler != null)
                Generated(this, e);
        }

        public RandomSql(string format)
        {
            this.format = format;
            this.randomValues = new List<RandomValues>();
        }

        public void GenerateRecords(int number)
        {
            StringBuilder builder = new StringBuilder();
            RandomGenerateEventArgs args;

            for (int i = 0; i < number / 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    builder.AppendLine(string.Format(format, randomValues.Generate()));
                }
                args = new RandomGenerateEventArgs(builder.ToString());
                OnGenerating(args);
                builder.Remove(0, builder.ToString().Length);
            }

            for (int num = 0; num < number % 100; num++)
            {
                builder.AppendLine(string.Format(format, randomValues.Generate()));
            }
            args = new RandomGenerateEventArgs(builder.ToString());
            OnGenerating(args);
            OnGenerated(new EventArgs());
        }

        public void GenerateRecordsToFile(int number, string path)
        {
            StreamWriter writer = new StreamWriter(path);

            for (int i = 0; i < number / 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    writer.WriteLine(string.Format(format, randomValues.Generate()));
                }
            }

            for (int num = 0; num < number % 100; num++)
            {
                string record = string.Format(format, randomValues.Generate());
                writer.WriteLine(record);
            }
            writer.Dispose();
            OnGenerated(new EventArgs());
        }
    }

    public static class MyExtensions
    {
        public static object[] Generate(this IList<RandomValues> randomValues)
        {
            object[] values = new object[randomValues.Count];
            for (int i = 0; i < randomValues.Count; i++)
            {
                values[i] = randomValues[i].Generate();
            }
            return values;
        }
    }
}
