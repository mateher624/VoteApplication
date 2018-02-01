using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ScannerApplication.Dto;

namespace ScannerApplication
{
    class RegisterEntryApiRequest
    {
        private readonly RestClient _client;

        public RegisterEntryApiRequest()
        {
            _client = new RestClient("http://localhost:30718/api/staff/register-entry");
        }

        public void SendRequest(RegisterEntryRequestDto reqDto)
        {
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(reqDto);
            _client.ExecuteAsync<VoteResponseDto>(request, response =>
            {
                if (response.Data.StatusCode == 200)
                {
                    Console.WriteLine("Głos nie był wczesneij oddawany.");
                }
                else
                {
                    Console.WriteLine("Pesel znajduje się już w  bazie obecności dla tego głosowania.");
                }
                
            });
        }
    }
}
