using DevIo.Api.Dtos.Request;
using FluentValidation;

namespace DevIo.Api.Validators
{
    public class SupplierCreateDtoValidator : AbstractValidator<SupplierCreateDto>
    {
        public SupplierCreateDtoValidator() 
        {
            RuleFor(dto => dto.Name)
                .NotEmpty()
                .MaximumLength(200);
            RuleFor(dto => dto.Document)
                .NotEmpty()
                .Must(BeValidBrazilianDocument)
                .WithMessage("Invalid CPF or CNPJ");
            RuleFor(dto => dto.SupplierType)
                .IsInEnum();
            RuleFor(dto => dto.Address)
                .SetValidator(new AddressCreateDtoValidator());
        }

        private bool BeValidBrazilianDocument(string document)
        {
            return !string.IsNullOrWhiteSpace(document) && document.Length >= 11;
        }
    }
}
