using DesignPattern.Decorator.DataAccess;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new();

        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage; 
        }

        public void SendMessageSubjectID(Message message)
        {
            if (message.Subject == "1")
            {
                message.Subject = "Toplantı";
            }
            else if(message.Subject == "2")
            {
                message.Subject = "Scrum Toplantısı";
            }

            else if(message.MessageId == 3)
            {
                message.Subject = "Haftalık Değerlendirme";
            }

            context.Messages.Add(message);
            context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageSubjectID(message);
        }
    }
}
