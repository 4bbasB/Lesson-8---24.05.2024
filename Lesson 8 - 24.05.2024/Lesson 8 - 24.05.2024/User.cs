using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8___24._05._2024
{
    internal class User
    {
		private string _password;

        public string Password
		{
			get { return _password; }
			set 
            {
                bool flag = true;
                if (value.Length < 7)
                    flag = false;


                bool flag2 = false;
                foreach (var item in value)
                {
                    if (char.IsUpper(item))
                    {
                        flag2 = true;
                        break;
                    }
                }
                if(flag2 == false)
                    flag = false;



                bool flag3 = false;
                foreach (var item in value)
                {
                    if (char.IsLower(item))
                    {
                        flag3 = true;
                        break;
                    }
                }
                if (flag3 == false)
                    flag = false;



                bool flag4 = false;
                foreach (var item in value)
                {
                    if (!char.IsLetterOrDigit(item))
                    {
                        flag4 = true;
                        break;
                    }
                }
                if (flag4 == false)
                    flag = false;



                bool flag5 = false;
                foreach (var item in value)
                {
                    if (char.IsDigit(item))
                    {
                        flag5 = true;
                        break;
                    }
                }
                if (flag5 == false)
                    flag = false;



                if(flag == true)
                {
                    _password = value;
                }
            }
        }
        public string Name { get; set; }

        
    }
}
