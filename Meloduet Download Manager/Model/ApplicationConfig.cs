using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meloduet_Download_Manager.Model
{
    /// <summary>
    /// 应用程序配置文件类
    /// </summary>
    public class ApplicationConfig
    {

            /// <summary>s
            /// 下载的文件的保存目录
            /// </summary>
            public string DownloadStoreDirectory { get; set; }       

            private static ApplicationConfig _config = new ApplicationConfig();
            private ApplicationConfig()
            {
                _config = Controller.ConfigController.GetAppConfig();
            }
            public static ApplicationConfig GetConfig()
            {
            
            
            return _config;
            }

    }
}
