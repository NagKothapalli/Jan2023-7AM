using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectOne.SeleniumPractice
{
    public class RelativeXpath
    {
        //XPATH - Absolute xpath / Fixed xapth / Static xpath
        //  /html/body/div[1]/div[1]/div[2]/div/c-wiz/div/div[2]/div/div[1]/div/form/span/section/div/div/div[3]/button 
        //Relative XPATH - is like a SQL Select query - select EmpName from Employees where EmpID=22

        //tagName can be a html , head , body , span , input, div , a , img , table , tr , td , ul , li ......

        //tagName[@attribute='value']
        //Example    ->  //input[@type='email']

        //tagName[text()='value']
        //Example    ->  //span[text()='Next']

        //tagName[@attribute1='value1' and @attribute2='value2']
        //Example    ->  //input[@class='whsOnd zHQkBf' and @type='email']

        //tagName[text()='value' and @attribute='value' ]
        // Ex : //span[@class='VfPpkd-vQzf8d' and text()='Create account']

        //contains

        //tagName[contains(@attribute,'partial value')]

        //tagName[contains(text(),'partial text')]

        //tagName[contains(@attribute1,'value1') and @attribute2='value2']

        //tagName[ @attribute1='value1' and contains(@attribute2,'partial value')]

        //tagName[contains(@attribute1,'value1') or @attribute2='value2']

        //tagName[ @attribute1='value1' or contains(@attribute2,'partial value')]

        //regular expression

        //*[@attribute='value']
        //Example    ->  //*[@type='email']

        //*[text()='value']
        //Example    ->  //*[text()='Next']

        //*[@attribute1='value1' and @attribute2='value2']
        //Example    ->  //*[@class='whsOnd zHQkBf' and @type='email']

        //*[text()='value' and @attribute='value' ]
        // Ex : //*[@class='VfPpkd-vQzf8d' and text()='Create account']

        //Parent child 

        //Dynamic Xpath : Where we can pass some dynamic value in to the xpath string in run time 

        //a[text()='"+jDate+"']

    }
}
