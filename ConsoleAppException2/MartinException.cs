using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppException2
{

    /// <summary>
    /// Min egen definerede exception
    /// </summary>
    class MartinException: Exception
    {

        public MartinException()
            :base()
        {

        }

        public MartinException(string tekst)
            :base(tekst)
        {

        }



    }
}
