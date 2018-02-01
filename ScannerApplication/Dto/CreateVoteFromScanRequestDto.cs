using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerApplication
{
    class CreateVoteFromScanRequestDto
    {
        public int PollOptionNumber { get; set; }
        public int PollId { get; set; }
    }
}
