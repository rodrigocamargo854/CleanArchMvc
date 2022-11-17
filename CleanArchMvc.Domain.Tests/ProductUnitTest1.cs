
using CleanArqMvc.Domain.Entities;
using FluentAssertions;


namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact]
        public void CreateProduct_With_a_valid_Parameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "product image");
            action.Should().NotThrow<CleanArqMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_Neagative_Value_DomainExcepetionInvalidId()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m, 99, "product image");
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>().WithMessage("Invalid id value.");
        }
      
        [Fact]
        public void CreateProduct_ShorNameValue_DomainExceptionShortName()
        {
            Action action = () => new Product(1, "Pr", "Product Description", 9.99m, 99, "product image");
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters");
        }

        [Fact]
        public void CreateProduct_WithNullImageName_NoDomainException()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99,null);
            action.Should().NotThrow<CleanArqMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_LongImageName_DomainExceptionLongImageName()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "product image toooooooooooooooooooooooooooooooooooo loooooooooooooooooooooooooooooooooooooooooooooooggggggggggggggggggggggggggggggggggggggggggggggggggccccccccccccccccccccccccggggggggggggggggggggggggg");
            action.Should().NotThrow<CleanArqMvc.Domain.Validation.DomainExceptionValidation >();
        }

        [Fact]
        public void CreateProduct_WithEmptyName_NoDomainException()
        {
            Action action = () => new Product(1, "Pr", "Product Description", 9.99m, 99, "");
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters");
        }

        [Theory]
        [InlineData(-5)]
        public void CreateProduct_InvalidStockValue_ExceptionNegativeValue(int value)
        {
            Action action = () => new Product(1, "Pr", "Product Description", 9.99m, value, "product image");
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters");
        }

        [Theory]
        [InlineData(-5)]
        public void CreateProduct_InvalidPrice_ExceptionNegativeValue(int value)
        {
            Action action = () => new Product(1, "Pr", "Product Description", value, 10, "product image");
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters");
        }

        [Theory]
        [InlineData(-2)]
        public void CreateProduct_MoreOneInvalidPrice_ExceptionNegativeValue(int value)
        {
            Action action = () => new Product(1, "Pr", "Product Description", value, 10, "product image");
            action.Should().Throw<CleanArqMvc.Domain.Validation.DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters");
        }

        [Fact]
        public void CreateProduct_WithNullImageName_NoNullReferenceException()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, null);
            action.Should().NotThrow<NullReferenceException>();
        }

    }
}
