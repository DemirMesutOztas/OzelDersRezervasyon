using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OzelDersRezervasyon.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("Adı")]
        public string TeacherName { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("Soyadı")]
        public string TeacherSurname { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("E-mail")]
        public string TeacherEmail { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string TeacherPassword { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("Şifre Tekrar")]
        [DataType(DataType.Password)]
        [Compare("TeacherPassword")]
        public string TeacherPassword2 { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("Şehir")]
        public string TeacherCity { get; set; }
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DisplayName("Branş")]
        public string TeacherBranch { get; set; }
        [NotMapped]
        [DisplayName("Fotoğraf")]
        public HttpPostedFileBase TeacherPhoto { get; set; }
    }
}