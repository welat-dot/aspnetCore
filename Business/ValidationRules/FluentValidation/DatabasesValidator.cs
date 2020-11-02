using entities.MasterTable;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class DatabasesValidator:AbstractValidator<Databases>
    {
        public DatabasesValidator()
        {
            RuleFor(d => d.DatabaseName).NotEmpty();
            RuleFor(d => d.DatabaseName).Length(5, 50);
            RuleFor(d => d.UsersRefId).NotEmpty();
        }
    }
}
