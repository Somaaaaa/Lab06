using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class BankClient
    {
        string clientName;
        string clientAccountNumber;
        string clientAddress;

        public BankClient(string clientName, String clientAccountNumber, string clientAddress)
        {
            this.clientName = clientName;
            this.clientName = clientAccountNumber;
            this.clientAddress = clientAddress;
        }
        public string GetAllClientData()
        {
            string allClientData = "";
            allClientData = clientName + clientAccountNumber + clientAddress;
            return allClientData;
        }
    }
}
