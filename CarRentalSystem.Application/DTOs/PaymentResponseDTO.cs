using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Application.DTOs
{
    public class PaymentResponseDTO
    {

        public string idx { get; set; }
        public Type type { get; set; }
        public State state { get; set; }
        public int amount { get; set; }
        public int fee_amount { get; set; }
        public object reference { get; set; }
        public bool refunded { get; set; }
        public DateTime created_on { get; set; }
        public User user { get; set; }
        public Merchant merchant { get; set; }
        public object remarks { get; set; }
        public string token { get; set; }
        public int cashback { get; set; }
        public string product_identity { get; set; }
    }
    public class Type
    {
        public string idx { get; set; }
        public string name { get; set; }
    }

    public class State
    {
        public string idx { get; set; }
        public string name { get; set; }
        public string template { get; set; }
    }

    public class User
    {
        public string idx { get; set; }
        public string name { get; set; }
    }

    public class Merchant
    {
        public string idx { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
    }
}
