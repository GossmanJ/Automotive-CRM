﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive_CRM
{
    static class Utilities
    {
        public static bool EmailCheck(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string PhoneNumberFormat(string str)
        {
            str = str.Replace(" ", "");
            foreach (char ch in str)
            {
                if(char.IsLetter(ch))
                {
                    return string.Empty;
                }
            }

            if (str.Length == 12 && str.Substring(3, 1) == "-" && str.Substring(7, 1) == "-")
            {
                return str;
            }

            try
            {
                if (str.Length == 10)
                {
                    return string.Format("{0:###-###-####}", long.Parse(str));
                }
            }
            catch
            {
                return string.Empty;
            }
            return string.Empty;
        }

        public static string Capitalize(string str)
        {
            char[] array = str.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsLetter(array[0]) && char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]) && char.IsLetter(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        public static string DecimalFormat(string str)
        {
            try
            {
                decimal result = decimal.Parse(str);
                str = result.ToString("#.##");
                return str;
            }
            catch
            {
                return "";
            }
        }

    }
}
