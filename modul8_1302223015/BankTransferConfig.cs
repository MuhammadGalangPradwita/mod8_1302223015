using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302223015
{
    internal class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> method { get; set; }
        public Confirmation confirmation { get; set; }

        public BankTransferConfig(string lang, int threshold, int low_fee, int high_fee, List<string> method, string en, string id)
        {
            this.lang = lang;
            this.transfer = new Transfer(threshold, low_fee, high_fee);
            this.method = method;
        }
    }

    public class Confirmation
    {
        public string en;
        public string id;

        public Confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
