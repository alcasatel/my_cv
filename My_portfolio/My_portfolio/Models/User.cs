using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Metanit.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Дата рождения")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.Month < DateOfBirth.Month ||
                   (DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day))
                    age--;
                return age;
            }
        }
        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Display(Name = "Должность")]
        public string Vocation { get; set; }

        public string Email { get; set; }

        [Display(Name = "Адресс")]
        public string Adress { get; set; }

        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Display(Name = "Обо мне")]
        [DataType(DataType.MultilineText)]
        public string About { get; set; }

        public IEnumerable<UserLanguage> Languages { get; set; }
        public IEnumerable<UserEducation> Educations { get; set; }
        public IEnumerable<UserExperience> Experiences { get; set; }
        public IEnumerable<UserSkill> Skills { get; set; }
        public IEnumerable<UserOther> Others { get; set; }

    }

    public class UserLanguage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Language { get; set; }
        public string Level { get; set; }
    }

    public class UserEducation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Speciality { get; set; }
        public string Level { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        public string About { get; set; }
    }

    public class UserExperience
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Vocation { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }
        public string About { get; set; }
    }

    public class UserSkill
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class UserOther
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AvatarPhoto { get; set; }
        public string BackgroundPhoto { get; set; }
        public string CVFile { get; set; }
        
    }
}