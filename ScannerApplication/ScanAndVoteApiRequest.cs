﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ScannerApplication.Dto;

namespace ScannerApplication
{
    class ScanAndVoteApiRequest
    {
        private readonly RestClient _client;

        public ScanAndVoteApiRequest()
        {
            _client = new RestClient("http://localhost:30718/api/scanner/scan-and-vote");
        }

        public void SendRequest(CreateVoteFromScanRequestDto reqDto)
        {
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(reqDto);
            _client.ExecuteAsync(request, response => { });
        }
    }
}
