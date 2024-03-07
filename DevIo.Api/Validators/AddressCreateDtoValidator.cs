using DevIo.Api.Dtos.Request;
using FluentValidation;

namespace DevIo.Api.Validators
{
    public class AddressCreateDtoValidator : AbstractValidator<AddressCreateDto>
    {
        public AddressCreateDtoValidator()
        {
            RuleFor(dto => dto.Street).NotEmpty();
            RuleFor(dto => dto.Number).NotEmpty();
            RuleFor(dto => dto.PostalCode).NotEmpty();
            RuleFor(dto => dto.Neighbourhood).NotEmpty();
            RuleFor(dto => dto.Municipality).NotEmpty();
            RuleFor(dto => dto.AdministrativeArea).NotEmpty();
        }
    }
}
