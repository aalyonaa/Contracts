﻿namespace Marvelous.Contracts.ExchangeModels
{
    public class LeadAuthExchangeModel
    {
        public int Id { get; set; }
        public byte Role { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
    }
}
