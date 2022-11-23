using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OzelDersRezervasyon.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage="Lütfen boş bırakmayınız")]
        [DisplayName("Adı")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("Soyadı")]
        public string StudentSurname { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("E-mail")]
        public string StudentEmail { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string StudentPassword { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("Şifre Tekrar")]
        [DataType(DataType.Password)]
        [Compare("StudentPassword")]
        public string StudentPassword2 { get; set; }
    }
}