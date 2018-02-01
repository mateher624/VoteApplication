using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ScannerApplication
{
    class RegisterEntryApiRequest
    {
        RestClient client;

        public RegisterEntryApiRequest()
        {
            client = new RestClient("http://localhost:30718/api/staff/register-entry");
        }

        public void SendRequest(RegisterEntryRequestDto reqDto)
        {
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(reqDto);
            client.ExecuteAsync(request, response => { });
        }
    }
}
