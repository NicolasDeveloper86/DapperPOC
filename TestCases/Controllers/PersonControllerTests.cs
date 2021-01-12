using Common.Filters;
using DapperPOC.Controllers;
using DapperPOC.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestCases.Controller
{
    public class PersonControllerTests
    {
        private PersonController personController;
        private Mock<IPersonService> mockPersonService;

        private void Init()
        {
            mockPersonService = new Mock<IPersonService>();

            personController = new PersonController(mockPersonService.Object);
        }

        [Fact]
        public async void Should_Call_Get_Persons()
        {
            Init();
            var filter = new PersonFilter();

            await personController.GetPersonDtos(filter);

            mockPersonService.Verify(m => m.GetPersons(filter), Times.Once);
        }
    }
}
