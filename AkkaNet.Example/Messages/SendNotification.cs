namespace AkkaNet.Example.Messages
{
    public class SendNotification
    {
        public string Message { get; set; }
        public NotificationType Type { get; set; }
    }
}
