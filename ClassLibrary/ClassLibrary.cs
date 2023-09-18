using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringLibrary1
{
    public class StringLibery

    {
        /// <summary>
        /// Проверка Строка Name дожна содержать в себе только буквы, пробел и дефис. Строка Name не должна быть быть длиннее 50 символов 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>True | False </returns>
        public bool CheckName(string Name)
        {
            string regec = @"^(?=.{1,50}$)(([а-я])|(\s)|(\-))+$";
            string regecfu = @"^(\s)|(\-)+$";

            if (Regex.Match(Name, regecfu, RegexOptions.IgnoreCase).Success)
            {
                return false;
            }
            else
            {
                if (Regex.Match(Name,regec,RegexOptions.IgnoreCase).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
