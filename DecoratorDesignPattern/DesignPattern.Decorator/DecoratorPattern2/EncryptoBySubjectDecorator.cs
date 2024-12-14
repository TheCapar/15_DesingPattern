using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageByEncryptoSubject(Message message)
        {
            string encryptedSubject = "";
            char[] chars = message.MessageSubjcet.ToCharArray();
            foreach (var c in chars)
            {
                encryptedSubject += Convert.ToChar(c + 3).ToString();
            }
            message.MessageSubjcet = encryptedSubject; // Yeni değeri doğrudan atıyoruz.

            context.Messages.Add(message); // Identity sütununa müdahale etmiyoruz.
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoSubject(message);
        }
    }
}
