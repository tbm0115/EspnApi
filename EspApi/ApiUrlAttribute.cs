using System;
using System.Collections.Generic;
using System.Text;

namespace EspnApi
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ApiUrlAttribute : Attribute
    {
        public string Url { get; }

        public ApiUrlAttribute(string url)
        {
            Url = url;
        }
    }
}
