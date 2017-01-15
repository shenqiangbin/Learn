using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace ConfigLib
{
    /// <summary>
    /// 配置中心
    /// 默认不是测试模式，且读取的是d盘下的website.json配置文件
    /// 可以自定义，需将configLib.config.json拷贝到引用configLib.dll的目录下（注意：是引用项目的目录）
    /// 当是测试模式时，将会寻找fake文件夹下的同名配置文件
    /// 
    /// 注意：MVC程序，ConfigLib.config.json文件是放在bin所有文件夹，而不是bin目录下。
    /// </summary>
    public class ConfigCenter
    {
        private string _baseDir = "d:/";
        private WebSite _webSite;
        private Config _config;

        public ConfigCenter()
        {
            _config = CreateConfig();
            if (_config.IsFake)
                _config.BaseDir = Path.Combine(new[] { _config.BaseDir, "fake/" });
        }

        private Config CreateConfig()
        {            
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"ConfigLib.config.json";            
            if (File.Exists(path))
                return JsonHelper.DeserializeJsonFromFile<Config>(path);
            else
                return new Config { IsFake = false, BaseDir = _baseDir };
        }

        public WebSite WebSite
        {
            get
            {
                if (_webSite == null)
                    _webSite = JsonHelper.DeserializeJsonFromFile<WebSite>(_config.BaseDir + @"website.json");
                return _webSite;
            }
        }
    }

    public class Config
    {
        public bool IsFake { get; set; }
        public string BaseDir { get; set; }
    }

    public class WebSite
    {
        public string Door { get; set; }
        public string Clinic { get; set; }
        public string Supplier { get; set; }
    }
}
