using System;

namespace GlobalX.ChatBots.WebexTeams.Models {
    internal class Message {
        public string Id { get; set; }
        public string RoomId { get; set; }
        public string RoomType { get; set; }
        public string ToPersonId { get; set; }
        public string ToPersonEmail { get; set; }
        public string ParentId { get; set; }
        public string Text { get; set; }
        public string Markdown { get; set; }
        public string Html { get; set; }
        public string[] Files { get; set; }
        public string PersonId { get; set; }
        public string PersonEmail { get; set; }
        public string[] MentionedPeople { get; set; }
        public string[] MentionedGroups { get; set; }
        public DateTime Created { get; set; }
    }
}
