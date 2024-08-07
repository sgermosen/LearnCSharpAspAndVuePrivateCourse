﻿using Contacts.Domain;

namespace Contacts.Api.Responses
{
    public class ContactResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public int Code { get; set; }
        public Contact Data { get; set; }
    }
}
