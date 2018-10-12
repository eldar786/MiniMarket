using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace LogForm
{
   Public class UserBO // Declare Class Public to Access any where
    {
        //Declaring User Registration Variables
 
        private string _Username;
 
        private string _Password;
 
        // Get and set values
 
        public string username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
            }
        }
        public string address
        {
            get
            {
                return _Password;
            }
 
            set
            {
                _Password = value;
               }
        }
    }
}
 
        

            