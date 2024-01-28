using System;
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
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        }


	}
}

