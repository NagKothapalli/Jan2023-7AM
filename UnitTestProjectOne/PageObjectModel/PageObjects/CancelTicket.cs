using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectOne.PageObjectModel.PageObjects
{
    public class CancelTicket
    {
        public void NavigateToCancelTicket()
        {
            Debug.WriteLine("RC : NavigateToCancelTicket ");
        }

        public void CancelBusTicket()
        {
            Debug.WriteLine("RC : CancelBusTicket ");
        }
    }
}
