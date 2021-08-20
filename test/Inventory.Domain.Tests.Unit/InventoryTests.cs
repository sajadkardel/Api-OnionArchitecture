using System;
using FluentAssertions;
using Inventory.Domain._Inventory.Exeptions;
using Inventory.Domain.Tests.Unit.Builders;
using Microsoft.VisualStudio.TestPlatform.TestExecutor;
using Xunit;
using Xunit.Categories;

namespace Inventory.Domain.Tests.Unit
{
    public class InventoryTests
    {
        private readonly InventoryTestBuilder _builder;

        public InventoryTests()
        {
            _builder = new InventoryTestBuilder();
        }

        [Fact]
        [UnitTest]
        public void Should_ConstructInventoryProperly()
        {
            const string product = "Mac";
            const double unitPrice = 1500;

            var inventory = _builder
                .WithProduct(product)
                .WithUnitPrice(unitPrice)
                .Build();

            inventory.Product.Should().Be(product);
            inventory.UnitPrice.Should().Be(unitPrice);
            inventory.InStock.Should().BeFalse();
        }

        [Theory]
        [UnitTest]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowProductNullException_WhenProductIs(string nullOrEmpty)
        {
            Action ctor = () => _builder
                .WithProduct(nullOrEmpty)
                .Build();

            ctor.Should().ThrowExactly<ProductNullException>();
        }

        [Theory]
        [UnitTest]
        [InlineData(0)]
        [InlineData(-1)]
        public void Should_ThrowInvalidUnitPriceException_WhenUnitPriceIs(double zeroOrLess)
        {
            Action ctor = () => _builder
                .WithUnitPrice(zeroOrLess)
                .Build();
         
            ctor.Should().ThrowExactly<InvalidUnitPriceException>();
        }
    }

}