using System;

namespace DemoMensageria.InputModels
{
    public class SendMessageInputModel
    {
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string Content { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
