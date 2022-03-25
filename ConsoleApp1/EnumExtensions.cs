﻿

//--------------- Part2 ---------------


using System.ComponentModel.DataAnnotations;
using System.Reflection;

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum enumValue, Type enumType)
    {
        string displayName = "";
        MemberInfo info = enumType.GetMember(enumValue.ToString()).First();

        if (info != null && info.CustomAttributes.Any())
        {
            DisplayAttribute nameAttr = info.GetCustomAttribute<DisplayAttribute>();
            displayName = nameAttr != null ? nameAttr.Name : enumValue.ToString();
        }
        else
        {
            displayName = enumValue.ToString();
        }
        return displayName;
    }
}