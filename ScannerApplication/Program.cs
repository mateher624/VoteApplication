using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ScannerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var th = new Thread(SendScanRequests);
            th.Start();
            RegisterEntryApiRequest apiRq = new RegisterEntryApiRequest();
            RegisterEntryRequestDto dto = new RegisterEntryRequestDto();
            dto.PollId = 1;
            while (true)
            {
                Console.WriteLine("Podaj pesel lub zostaw puste aby wyjść: ");
                var tmp = Console.ReadLine();
                if(tmp == "")
                {
                    break;
                }
                else
                {
                    dto.Pesel = tmp;
                    apiRq.SendRequest(dto);
                }
            }
            th.Abort();
        }

        static void SendScanRequests()
        {
            ScanAndVoteApiRequest scanAndVoteApiReqest = new ScanAndVoteApiRequest();
            CreateVoteFromScanRequestDto dto = new CreateVoteFromScanRequestDto();
            var sw = Stopwatch.StartNew();
            while (true)
            {
                if (sw.ElapsedMilliseconds > 5000)
                {
                    sw.Restart();
                    dto.PollId = 1;
                    dto.PollOptionNumber = 1;

                    scanAndVoteApiReqest.SendRequest(dto);
                }
            }
        }
    }
}
