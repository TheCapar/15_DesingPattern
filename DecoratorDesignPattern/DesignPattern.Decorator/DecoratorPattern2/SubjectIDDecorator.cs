using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        Context context = new Context();
        private readonly ISendMessage _message;
        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _message = sendMessage;
        }
        public void SendMessageIDSubject(Message message)
        {
            if(message.MessageSubjcet == "1")
            {
                message.MessageSubjcet = "Toplantı";
            }
            if (message.MessageSubjcet == "2")
            {
                message.MessageSubjcet = "Scrum Toplantısı";
            }
            if (message.MessageSubjcet == "3")
            {
                message.MessageSubjcet = "Haftalık Değerlendirme";
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIDSubject(message);
        }
    }
}
