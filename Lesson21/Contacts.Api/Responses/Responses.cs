namespace Contacts.Api.Responses
{
    public class Responses <T> where T : class
    {
        public int Code { get; set; } 
        public string Message { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public List<T> Data { get; set; }
    }
}
