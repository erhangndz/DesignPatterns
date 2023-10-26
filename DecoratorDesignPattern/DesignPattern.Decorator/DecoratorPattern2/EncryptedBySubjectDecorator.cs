using DesignPattern.Decorator.DataAccess;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptedBySubjectDecorator:Decorator
    {

        private readonly ISendMessage _sendMessage;
        Context context = new();

        public EncryptedBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessagebyEncryptedSubject(Message message)
        {
           
            string data = "";
            data = message.Subject;
            char[] chars = data.ToCharArray();
            foreach (char c in chars)
            {
                message.Subject += Convert.ToChar(c + 3).ToString();
            }

            context.Messages.Add(message);
            context.SaveChanges();
        }


        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessagebyEncryptedSubject(message);
        }
    }
}
