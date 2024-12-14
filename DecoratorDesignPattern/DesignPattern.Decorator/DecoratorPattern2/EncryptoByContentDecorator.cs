using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoByContentDecorator : Decorator
    {
        Context context = new Context();
        private readonly ISendMessage _message;
        public EncryptoByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _message = sendMessage;
        }
        public void SendMessageByEncryptoContent(Message message)
        {
            string data = "";
            data = message.MessageSubjcet;
            char[] chars = data.ToCharArray();
            foreach (var c in chars)
            {

                message.MessageSubjcet += Convert.ToChar(c + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoContent(message);
        }
    }
}
