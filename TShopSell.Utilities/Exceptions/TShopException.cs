using System;
using System.Collections.Generic;
using System.Text;

namespace TShopSell.Utilities.Exceptions
{
    public class TShopException:Exception
    {
        public TShopException()
        {

        }
        public TShopException(string message) 
            : base(message)
        {

        }
        public TShopException(string message,Exception inner) 
            : base(message,inner)
        {

        }
    }
}
