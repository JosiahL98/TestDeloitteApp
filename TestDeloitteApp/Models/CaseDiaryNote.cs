﻿using Microsoft.AspNetCore.Mvc;

namespace TestDeloitteApp.Models
{
    public class CaseDiaryNote
    {
        public int Id { get; set; }
        public int CaseDiaryId { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        public string? Line4 { get; set; }
        public string? Line5 { get; set; }
        public string? Line6 { get; set; }
        public string? Line7 { get; set; }
        public string? Line8 { get; set; }
        public string? Line9 { get; set; }
        public string? Line10 { get; set; }
    }
}
