using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class Home
    {
        public void BookTicket()
        {
            Debug.WriteLine("RC : Book Bus Ticket ");
        }
        public void PrintTicket()
        {
            Debug.WriteLine("RC : Print Bus Ticket ");
        }
    }
}
