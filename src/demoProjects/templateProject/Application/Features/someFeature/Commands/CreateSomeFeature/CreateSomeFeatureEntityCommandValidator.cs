using FluentValidation;

namespace Application.Features.someFeature.Commands.CreateSomeFeature
{
    public class CreateSomeFeatureEntityCommandValidator : AbstractValidator<CreateSomeFeatureEntityCommand>
    {
        public CreateSomeFeatureEntityCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
        }
    }
}
