﻿using MeetingOrganizer.EntityLayer.Abstract;

namespace MeetingOrganizer.EntityLayer.Concrete
{
    public class User : BaseEntity<int>
    {
        public string Ad { get; set; }
        public string Email { get; set; }
        public int TcNo { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? ExprationToken { get; set; } // Tokenin gecerlilik suresi

    }
}