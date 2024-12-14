using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignPattern.Decorator.DAL
{
    public class Message
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int MessageID { get; set; }
        public string? MessageSender { get; set; }
        public string? MessageReciver { get; set; }
        public string? MessageSubjcet { get; set; }
        public string? MessageContent { get; set; }
    }
}
