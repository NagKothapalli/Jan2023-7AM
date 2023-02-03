using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class TicketStatus
    {
        public void NavigateToTicketStatus()
        {
            Debug.WriteLine("RC : NavigateToTicketStatus ");
        }

        public void CheckStatusOfBusTicket()
        {
            Debug.WriteLine("RC : CheckStatusOfBusTicket ");
        }
    }
}
