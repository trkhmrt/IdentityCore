using System;
using System.ComponentModel.DataAnnotations;

namespace DtoLayer.AppUserDtos
{
	public class AppUserRegisterDto
	{
        /*
        [Required(ErrorMessage="Ad alanı zorunludur")]
        [Display(Name="İsim")]
        [MaxLength(30,ErrorMessage ="En Fazla 30 karakter girebilirsiniz.")]*/

		public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Username { get; set; }
    }
}

