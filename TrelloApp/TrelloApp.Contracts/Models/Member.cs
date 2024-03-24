using System.Text.Json.Serialization;
using TrelloApp.Contracts.Response;

namespace TrelloApp.Contracts.Models;

public class Member
    {
        public string Id { get; set; }

        public string AvatarUrl { get; set; }

        public string Bio { get; set; }
        
        
        public string FullName { get; set; }
        
    }