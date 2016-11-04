using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 运行时T4模板 生成文本保存成HTML文件

            var runtimeTextTemplate = new RuntimeTextTemplate1();
            string webResponseText = runtimeTextTemplate.TransformText();
            Console.WriteLine(webResponseText);

            runtimeTextTemplate.WriteLine("text to append");

            System.IO.File.WriteAllText("outputPage.html", webResponseText);

            #endregion

            //ReadXML();
            Console.ReadKey();

        }

        static void ReadXML()
        {
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.PreserveWhitespace = true;

            try
            {
                doc.Load("booksData.xml");
            }
            catch (System.IO.FileNotFoundException)
            {
                doc.LoadXml(@"<?xml version='1.0' encoding='utf-8' ?>
<books xmlns='http://www.contoso.com/books'>
  <book genre='novel' ISBN='1-861001-57-8' publicationdate='1823-01-28'>
    <title>Pride And Prejudice</title>
    <price>24.95</price>
  </book>
  <book genre='novel' ISBN='1-861002-30-1' publicationdate='1985-01-01'>
    <title>The Handmaid's Tale</title>
    <price>29.95</price>
  </book>
  <book genre='novel' ISBN='1-861001-45-3' publicationdate='1811-01-01'>
    <title>Sense and Sensibility</title>
    <price>19.95</price>
  </book>
</books>");
            }
            catch (Exception e)
            {
                throw;
            }

            string val = doc.SelectSingleNode("book").Value;

        }

        static void ALoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i); 
            }
        }
    }
}
