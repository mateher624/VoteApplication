using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ScannerApplication
{
    class ScanAndVoteApiRequest
    {
        RestClient client;

        public ScanAndVoteApiRequest()
        {
            client = new RestClient("http://localhost:30718/api/scanner/scan-and-vote");
        }

        public void SendRequest(CreateVoteFromScanRequestDto reqDto)
        {
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(reqDto);
            client.ExecuteAsync(request, response => { });
        }
    }
}
