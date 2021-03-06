using System;

namespace GlobalX.ChatBots.WebexTeams.Models
{
    internal class Person
    {
        public string Id { get;set; }
        public string[] Emails { get; set; }
        public PhoneNumber[] PhoneNumbers { get; set; }
        public string DisplayName { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public string OrgId { get; set; }
        public string[] Roles { get; set; }
        public string[] Licenses { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Timezone { get; set; }
        public DateTime LastActivity { get; set; }
        public string Status { get; set; }
        public string InvitePending { get; set; }
        public string LoginEnabled { get; set; }
        public string Type { get; set; }
    }
}
