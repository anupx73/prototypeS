using System;

namespace PrototypeS
{
    class PrototypeEvents
    {
        
    }

    public class SmartSearchEventArgs : EventArgs
    {
        public bool IsNewCustomer { get; protected set; }

        public SmartSearchEventArgs(bool isNewCustomer)
        {
            this.IsNewCustomer = isNewCustomer;
        }
    }
}
