using DesignPattern.Decorator.DataAccess;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptedbyBodyDecorator : Decorator
    {

        private readonly ISendMessage _sendMessage;
        Context context = new();
        public EncryptedbyBodyDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessagebyEncryptedBody(Message message)
        {
            message.Sender = "Takım Lideri";
            message.Receiver = "Yazılım Ekibi";
            message.Body = "Saat 17'de Publish yapılacak";
            message.Subject = "Publish";
            string data = "";
            data = message.Body;
            char[] chars = data.ToCharArray();
            foreach (char c in chars)
            {
                data += (c + 3).ToString();
            }

            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessagebyEncryptedBody(message);
        }
    }
}
