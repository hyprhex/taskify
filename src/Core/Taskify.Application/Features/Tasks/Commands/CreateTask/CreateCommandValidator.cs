using FluentValidation;

namespace Taskify.Application.Features.Tasks.Commands.CreateTask
{
  public class CreateCommandValidator : AbstractValidator<CreateTaskCommand>
  {
    public CreateCommandValidator()
    {
      RuleFor(p => p.Title)
          .NotEmpty()
          .MaximumLength(100);

      RuleFor(p => p.Description)
              .MaximumLength(500);

    }

  }
}
