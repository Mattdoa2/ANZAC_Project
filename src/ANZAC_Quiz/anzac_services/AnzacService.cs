using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anzac_services
{
    public class AnzacService: IAnzacService
    {
        public string GetMessage(string name) 
        {
            return "www.google.com";
        }
    }
}
