using AdditionalAPITask.Constants;
using AdditionalAPITask.Model;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static AdditionalAPITask.Model.EmployeeModel;

namespace AdditionalAPITask
{
    [Binding]
    public class Feature1StepDefinitions
    {
        SharedSteps sharedSteps = new SharedSteps();
        private readonly ScenarioContext _scenarioContext;
        public Feature1StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"the user sends GET request for all employees")]
        public async Task WhenTheUserSendsGETRequestForAllEmployees()
        {
            var response = await this.sharedSteps.GetEmployeeAsync();
            var jsonContent = JsonConvert.DeserializeObject<RootMult>(response.Content);
            this._scenarioContext.Add("ActualStatus", jsonContent.status);
        }

        [Then(@"appeared response with successful status")]
        public void ThenAppearedResponseWithSuccessfulStatusAsync()
        {
            var actualStatus = _scenarioContext.Get<string>("ActualStatus");

            Assert.AreEqual(ConfigConstants.ExpectedStatus, actualStatus, "The records has not been found");
        }

        [When(@"the user sends GET request for single employee by id")]
        public async Task WhenTheUserSendsGETRequestForSingleEmployeeById()
        {
            var response = await this.sharedSteps.GetEmployeeByIdAsync();
            var jsonContent = JsonConvert.DeserializeObject<RootSingle>(response.Content);
            this._scenarioContext.Add("ActualStatus", jsonContent.status);
        }

        [When(@"the user sends Post request for single employee")]
        public async Task WhenTheUserSendsPostRequestForSingleEmployee()
        {
            var response = await this.sharedSteps.PostEmployeeAsync();
            var jsonContent = JsonConvert.DeserializeObject<RootSingle>(response.Content);
            this._scenarioContext.Add("ActualStatus", jsonContent.status);
            this._scenarioContext.Add("ActualId", jsonContent.data.id);
        }

        [Then(@"id in data is not null")]
        public void ThenIdInDataIsNotNull()
        {
            var actualId = this._scenarioContext.Get<string>("ActualId");
            if (actualId != null)
            {
                Console.WriteLine(actualId);
            }

            Assert.IsTrue(actualId != null, "Record has not been added");
        }

        [When(@"the user sends DELETE request")]
        public async Task WhenTheUserSendsDELETERequest()
        {
            var response = await this.sharedSteps.DeleteEmployee();
            var jsonContent = JsonConvert.DeserializeObject<ResponseDelete>(response.Content);
            this._scenarioContext.Add("ActualMessage", jsonContent.message);
            this._scenarioContext.Add("ResponseDeleteStatus", jsonContent.status);
        }

        [Then(@"appeared response with successful message")]
        public void ThenAppearedResponseWithSuccessfulMessage()
        {
            var actualMessage = _scenarioContext.Get<string>("ActualMessage");

            Assert.AreEqual(ConfigConstants.ExpectedMessage, actualMessage, "The message is not match to expected message");
        }

        [Then(@"appeared DELETE response with successful status")]
        public void ThenAppearedDELETEResponseWithSuccessfulStatus()
        {
            var actualStatus = _scenarioContext.Get<string>("ResponseDeleteStatus");

            Assert.AreEqual(ConfigConstants.ExpectedStatus, actualStatus, "");
        }

        [When(@"the user sends PUT request")]
        public async Task WhenTheUserSendsPUTRequest()
        {
            var body = new Data()
            {
                id = "2",
                employee_name = "Stiwen Smith",
                employee_salary = "170750",
                employee_age = "63",
                profile_image = "",
            };
            var response = await this.sharedSteps.PutEmployeeAsync(body);
            var jsonContent = JsonConvert.DeserializeObject<RootMult>(response.Content);
            jsonContent.data.Add(body);
            this._scenarioContext.Add("ChangedName", body.employee_name);
            this._scenarioContext.Add("SuccessfullPutStatus", jsonContent.status);
        }

        [Then(@"appeared response with successful status (.*)")]
        public void ThenAppearedResponseWithSuccessfulStatus(int p0)
        {
            var actualStatus = _scenarioContext.Get<string>("SuccessfullPutStatus");

            Assert.AreEqual(ConfigConstants.ExpectedStatus, actualStatus, "");
        }

        [Then(@"the employee_name has been changed")]
        public void ThenTheEmployee_NameHasBeenChanged()
        {
            var actualName = _scenarioContext.Get<string>("ChangedName");


            Assert.AreEqual(ConfigConstants.ExpectedName, actualName, "The name does not match to expected name");
        }

        [When(@"the user sends Delete request with non exist id")]
        public async Task WhenTheUserSendsDeleteRequestWithNonExistId()
        {
            var response = await this.sharedSteps.GetNonExistentEmployeeAsync();
            var jsonContent = JsonConvert.DeserializeObject<RootSingle>(response.Content);

            this._scenarioContext.Add("ExpectedData", jsonContent.data);
        }

        [Then(@"appeared response with empty data")]
        public void ThenAppearedResponseWithEmptyData()
        {
            var actualData = this._scenarioContext.Get<string>("ExpectedData");
            string expectedData = null;

            Assert.AreEqual(expectedData, actualData, "The employee record has been added");
        }
    }
}
