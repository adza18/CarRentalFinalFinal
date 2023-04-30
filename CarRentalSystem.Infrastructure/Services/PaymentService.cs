using CarRentalSystem.Application.Common.Services;
using CarRentalSystem.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Infrastructure.Services
{
    public class PaymentService: IPayment
    {
        static readonly HttpClient client = new HttpClient();
        public async Task<PaymentResponseDTO> Payment(string payAmount, string payToken)
        {
            string url = "https://khalti.com/api/v2/payment/verify/";

            // Create the request message
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = new StringContent(JsonConvert.SerializeObject(new
            { amount = payAmount, token = payToken }), Encoding.UTF8, "application/json");

            // Add the authorization header
            request.Headers.Add("Authorization", "Key test_secret_key_c5a20838a91d42efb878ab884a505453");

            // Send the request
            HttpResponseMessage response = await client.SendAsync(request);

            // Print the response
            response.EnsureSuccessStatusCode();

            // Deserialize the response JSON into PaymentResponse object
            PaymentResponseDTO paymentResponse = JsonConvert.DeserializeObject<PaymentResponseDTO>(await response.Content.ReadAsStringAsync());

            return paymentResponse;
        }
    }
}
