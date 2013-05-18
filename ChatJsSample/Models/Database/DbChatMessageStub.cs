using System;
using ChatJsSample.Code;

namespace ChatJsSample.Models.Database
{
    public class DbChatMessageStub : ChatMessage
    {
        /// <summary>
        /// Message text
        /// </summary>
        public string Message { get; set; }

        public DateTime Date { get; set; }

        public int UserFromId { get; set; }

        public int UserToId { get; set; }

        public string TenancyId { get; set; }
    }
}