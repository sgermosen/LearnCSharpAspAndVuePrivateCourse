namespace Contacts.Api.Responses
{
    public class Response <T> where T : class
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
        public List<T> Data { get; set; }
    }
}
