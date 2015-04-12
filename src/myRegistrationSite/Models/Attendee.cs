using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace myRegistrationSite.Models
{
    public class Attendee
    {
        [Display(Name = "あなたのお名前"), Required]
        public string Name { get; set; }

        [Display(Name = "あなたの e-mail アドレス"), Required, EmailAddress]
        public string Email { get; set; }

        [Display(Name = "ライトニングトークする")]
        public bool beLT { get; set; }

        [Display(Name = "懇親会に参加する")]
        public bool beParty { get; set; }

        [Display(Name = "登録日時(UTC)")]
        public DateTime CreateAt { get; set; }
    }
}