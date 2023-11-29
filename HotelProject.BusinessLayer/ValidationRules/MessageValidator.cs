﻿using FluentValidation;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<ContactMessage>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Mail adresinizi boş geçemezsiniz!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçemezsiniz!");
            RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage("Email adresiniz geçerli formatta değil. Lütfen geçerli formatta giriniz!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız!");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayınız!");
        }
    }
}