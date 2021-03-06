﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Common.Json
{

    /// <summary>
    /// 将数据生成json信息
    /// </summary>
    public class JsonHandler
    {
        public static JsonMessage CreateMessage(int ptype, string pmessage, string pvalue,object obj)
        {
            JsonMessage json = new JsonMessage()
            {
                type = ptype,
                message = pmessage,
                value = pvalue,
                obj=obj
            };
            return json;
        }
        public static JsonMessage CreateMessage(int ptype, string pmessage)
        {
            JsonMessage json = new JsonMessage()
            {
                type = ptype,
                message = pmessage,
            };
            return json;
        }
    }

    public class JsonMessage
    {
        public int type { get; set; }
        public string message { get; set; }
        public string value { get; set; }

        public object obj { get; set; }
    }
}
