using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meloduet_Download_Manager.Types
{
    public static class Extension
    {

        public static string[] Program = new []{ "exe","com","out","jar" };
        public static string[] Document = new[] { "doc", "docx", "dot", "dps", "dpt", "et", "ett", "htm", "html", "pdf", "pot", "pps", "ppt", "pptx", "rtf", "txt", "wps", "wpt", "xls", "xlsx", "xlt", "xml" };
        public static string[] Picture = new[] { "ai", "bmp", "cdr", "dxf", "eps", "exif", "fpx", "gif", "hdri", "jpeg", "pcd", "pcx", "png", "psd", "raw", "svg", "tga", "tiff", "ufo" };
        public static string[] Video = new[] { "avi", "rmvb", "rm", "asf", "divx", "mpg", "mpeg", "mpe", "wmv", "mp4", "mkv", "vob" };
        public static string[] Music = new[] { "aac", "mid", "wav", "mp3", "ogg","aif","flac","ape" };
        public static string[] Archive = new[] { "7z", "ace", "arj", "bz", "bz2", "bzip2", "cab", "deb", "gz", "gzip", "img", "iso", "isz", "lzh", "lzma", "rar", "rpm", "tar", "tgz", "xar", "xz", "zip", "zipx" };
    }
}
