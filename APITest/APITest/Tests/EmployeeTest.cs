using APITest.Controllers;
using NUnit.Framework;
using System.Threading.Tasks;
using APITest.Models;
using Newtonsoft.Json;
using APITest.Constants;
using System;

namespace APITest.Tests
{
    [TestFixture]
    public class EmployeeTest : EmployeeController
    {
        [Test]
        public async Task CheckThatEmployeeControllerReturnsResponse()
        {
            var response = await this.GetEmployeeAsync();
            var jsonContent = JsonConvert.DeserializeObject<RootMult>(response.Content);
            var actualStatus = jsonContent.status;
            var expectedStatus = "success";

            Assert.AreEqual(expectedStatus, actualStatus, "The records has not been found");
        }
        [Test]
        public async Task CheckThatEmployeeControllerReturnsResponseDelete()
        {
            var response = await this.DeleteEmployee();
            var jsonContent = JsonConvert.DeserializeObject<Data>(response.Content);
            var actualMessage = jsonContent.message;

            Assert.AreEqual(ConfigConstants.SuccessMessage, actualMessage, "The message is not match to expected message");
            var jsonStatus = JsonConvert.DeserializeObject<Status>(response.Content);
            var actualStatus = jsonStatus.status;

            Assert.AreEqual(ConfigConstants.ExpectedStatus, actualStatus, "The status is not match to expected status");
        }
        [Test]
        public async Task CheckThatEmployeeControllerReturnsResponsePost()
        {
            var response = await this.PostEmployeeAsync();
            var jsonContent = JsonConvert.DeserializeObject<RootSingle>(response.Content);
            var actualStatus = jsonContent.status;

            Assert.AreEqual(ConfigConstants.ExpectedStatus, actualStatus, "Status fail");
            var id = jsonContent.data.id;
            if (id != null)
            {
                Console.WriteLine(id);
            }

            Assert.IsTrue(id != null, "Record has not been added");
        }
        [Test]
        public async Task CheckThatEmployeeControllerReturnsResponseById()
        {
            var response = await this.GetEmployeeByIdAsync();
            var jsonContent = JsonConvert.DeserializeObject<RootSingle>(response.Content);
            var actualStatus = jsonContent.status;

            Assert.AreEqual(ConfigConstants.ExpectedStatus, actualStatus, "The status does not match the expected status");
            var actualId = jsonContent.data.id;

            Assert.AreEqual(ConfigConstants.ExpectedId, actualId, "The record has not been found");
        }
        [Test]
        public async Task CheckThatEmployeesDataWasChanged()
        {
            var body = new Data()
            {
                id = "2",
                employee_name = "Stiwen Smith",
                employee_salary = "170750",
                employee_age = "63",
                profile_image = "",
            };
            var response = await this.PutEmployeeAsync(body);
            var jsonContent = JsonConvert.DeserializeObject<RootMult>(response.Content);
            jsonContent.data.Add(body);
            var actualStatus = jsonContent.status;

            Assert.AreEqual(ConfigConstants.ExpectedStatus, actualStatus, "The status does not match to expected status");
            var actualName = body.employee_name;

            Assert.AreEqual(ConfigConstants.ExpectedName, actualName, "The name does not match to expected name");
        }
        [Test]
        public async Task GetNonExistentEmployeById()
        {
            var response = await this.GetNonExistentEmployeeAsync();
            var jsonContent = JsonConvert.DeserializeObject<RootSingle>(response.Content);
            var actualData = jsonContent.data;
            string expectedData = null;

            Assert.AreEqual(expectedData, actualData, "The employee record has been added");
        }

    }
}



