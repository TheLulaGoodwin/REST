using System;
using Catalog.Api.Controllers;
using Catalog.Api.Entities;
using Catalog.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Catalog.UnitTests;

public class ItemsControllerTests
{
    private readonly Mock<IItemsRepository> repositoryStub = new();

    private readonly Mock<ILogger<ItemsController>> loggerStub = new();

    [Fact]
    public async Task GetItemAsync_WithUnexistingItem_ReturnsNotfound()
    {
            // Arrange
            repositoryStub.Setup(repo => repo.GetItemAsync(It.IsAny<Guid>()))
                .ReturnsAsync((Item)null);

            var controller = new ItemsController(repositoryStub.Object, loggerStub.Object);

            // Act
            var result = await controller.GetItemAsync(Guid.NewGuid());

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
    }

    [Fact]
    public async Task GetItemAsync_WithExistingItem_ReturnsExpectedItem()
    {
        // Arrange

        // Act

        // Assert

    }
}