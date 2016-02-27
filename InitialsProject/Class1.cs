using System;
using System.Collections.Generic;
using System.Text;

namespace InitialsProject
{
    public class InitialsRunner
    {

        public string GetInitials(char[] name)
        {
            string result = string.Empty;
            bool isStartInitial = true;

            foreach (var letter in name)
            {


                if (isStartInitial && letter != ' ')
                {
                    result += letter;
                    isStartInitial = false;
                }

                if (letter == ' ')
                {
                    isStartInitial = true;
                }

                if (letter == '-')
                {
                    result = "NA";
                    break;
                }



            }




            return result.ToUpper();
        }

    }
}
