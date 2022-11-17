using CleanArqMvc.Domain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action=() => new Category(1,"Category Name" );
            action.Should()
                .NotThrow<CleanArqMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateCategory_With_a_Negative_Value_DomainExceptionValue()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid id value.");
        }

        [Fact]
        public void CreateCategory_With_a_Negative_Value_DomainExceptiShortName()
        {
            Action action = () => new Category(1, "Ca");
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Name too short, minimum 3 characters.");
        }

        [Fact]
        public void CreateCategory_Missing_Name_Value_DomainNameIsRequired()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name can not be null");
        }

        [Fact]
        public void CreateCategory_Null_Name_Value_NullName()
        {
            Action action = () => new Category(1, null);
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name can not be null");
        }
    }
}

