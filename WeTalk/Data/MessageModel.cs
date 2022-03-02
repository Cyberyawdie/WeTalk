namespace WeTalk.Data
{
    public class MessageModel
    {
        public string? UserId { get; set; }
        public string? Message { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;

        public MessageModel(string user, string message)
        {
            UserId = user;
            Message = message;

        }
    }
}
