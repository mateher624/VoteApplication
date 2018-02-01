using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerApplication
{
    class RegisterEntryRequestDto
    {
        public int PollId { get; set; }
        public string Pesel { get; set; }
    }
}