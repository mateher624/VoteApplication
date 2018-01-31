using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OddawanieGlosow.Models.Dto.Scanner
{
    public class ScanAndVoteRequestDto
    {
        public int PollOptionNumber { get; set; }
        public int PollId { get; set; }
    }
}