﻿using System;
using DtoLayer.AppUserDtos;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
	public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
	{


		public AppUserRegisterValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");

			RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen En fazla 30 karakter girişi yapın");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen En az 2 karakter veri girişi yapın");

			RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("parolalarınız eşleşmedi");
          
        }


	}
}

