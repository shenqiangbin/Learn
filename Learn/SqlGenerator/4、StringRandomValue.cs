using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlGenerator
{
    public enum StringRandomValueFormat
    {
        Numberic,
        PersonName,
        Department,
        Duty,
        Machine,
        Printer,
        Book,
        SecurityLevel,
        Purpose,
        PagerType
    }

    public class StringRandomValue : RandomValues
    {
        private List<string> resource = new List<string>();
        private StringRandomValueFormat format;
        private Random randomer = new Random();

        public StringRandomValue(IEnumerable<string> resource)
        {
            this.resource.AddRange(resource);
        }

        public StringRandomValue(StringRandomValueFormat format)
            : this(format, false)
        { }

        public StringRandomValue(StringRandomValueFormat format, bool isNull)
        {
            this.isNull = isNull;
            if (isNull) resource.Add("null");

            this.format = format;
            if (format == StringRandomValueFormat.PersonName)
            {
                BuildPersonResource();
            }
            else if (format == StringRandomValueFormat.Numberic)
            {
                BuildStringResource();
            }
            else if (format == StringRandomValueFormat.Department)
            {
                resource.AddRange(new string[] { "总经理办公室", "人事部", "行政部", "账务部", "生产技术部", "保卫部", "后勤部", "计划营销部" });
            }
            else if (format == StringRandomValueFormat.Duty)
            {
                resource.AddRange(new string[] { "总监", "经理", "助理", "职员", "前台", "销售" });
            }
            else if (format == StringRandomValueFormat.Machine)
            {
                resource.AddRange(new string[] { "机器A-1", "机器A-2", "机器A-3", "机器B-1", "机器B-2", "机器B-3", "机器B-4", "机器C-1" });
            }
            else if (format == StringRandomValueFormat.Printer)
            {
                resource.AddRange(new string[] { "笠萌打印机", "惠普打印机", "巨无霸打印机", "真彩打印机", "酷哦3D打印机" });
            }
            else if (format == StringRandomValueFormat.Book)
            {
                resource.AddRange(new string[] { "西游", "红楼", "三国", "水浒" });
            }
            else if (format == StringRandomValueFormat.SecurityLevel)
            {
                resource.AddRange(new string[] { "非密", "内部", "秘密", "机密" });
            }
            else if (format == StringRandomValueFormat.Purpose)
            {
                resource.AddRange(new string[] { "保留", "流转", "外发" });
            }
            else if (format == StringRandomValueFormat.PagerType)
            {
                resource.AddRange(new string[] { "A4", "A3", "A5", "A2", "B4", "B5" });
            }
        }

        private void BuildStringResource()
        {
            for (long i = 201002010201; i < 201002010301; i++)
            {
                resource.Add(i.ToString());
            }
        }

        private void BuildPersonResource()
        {
            resource.AddRange(new string[] { 
                    "买红妹","井冈山","何炅","佟大为","倪萍","关凌","冯巩","冯远征","刘烨",
                    "周迅","宋柯","小龙","崔永元","巩俐","张丰毅","张怡宁","张涵予","张纪中",
                    "徐帆","文章","李修平","李冰冰","李小璐","杨澜","毕福剑","水均益","汪小菲",
                    "满文军","濮存昕","白岩松","秦海璐","窦唯","章子怡","管彤","萧萧","袁莉",
                    "赵忠祥","赵文卓","赵本山","邓婕","那姐","金龟子姐姐","陈好","陈红","陈鲁豫",
                    "陶红","鞠萍","马伊俐","高晓松","黄健翔","黄圣依"
                });
        }

        public override object Generate()
        {
            int index = randomer.Next(resource.Count);
            if (WithQuotation)
                return resource[index];
            else
                return string.Format("'{0}'", resource[index]);
        }
    }
}
