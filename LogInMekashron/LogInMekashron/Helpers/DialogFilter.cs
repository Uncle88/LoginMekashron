﻿using System.Xml.Linq;

namespace LogInMekashron.Helpers
{
    public static class DialogFilter
    {
        public static string LinqFilter(XDocument doc)
        {
            string Message = doc.Root.Value;
            return Message;
        }
    }
}

