﻿using EAAutoFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EAAutoFramework.Base.Browser;

namespace EAAutoFramework.Config
{
    public class Settings
    {
        public static string TestType { get; set; }

        public static string AUT { get; set; }

        public static string Build { get; set; }

        public static BrowserType BrowserType { get; set; }

        public static string Islog { get; set; }

        public static string LogPath { get; set; }
    }
}