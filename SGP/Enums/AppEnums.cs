﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Enums
{
    class AppEnums
    {
        public enum ClientType
        {
            [Description("Persona")]
            Person = 1,
            [Description("Empresa")]
            Company = 2
        }
    }

    public static class EnumExtensions
    {

        // This extension method is broken out so you can use a similar pattern with 
        // other MetaData elements in the future. This is your base method for each.
        public static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes[0];
        }

        // This method creates a specific call to the above method, requesting the
        // Description MetaData attribute.
        public static string ToName(this Enum value, string message = "")
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? message + " " + value.ToString() : message + " " + attribute.Description;
        }
    }
}
