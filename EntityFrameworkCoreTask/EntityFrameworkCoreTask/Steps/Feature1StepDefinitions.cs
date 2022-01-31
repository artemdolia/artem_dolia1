using EntityFrameworkCoreTask.Steps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EntityFrameworkCoreTask
{
    [Binding]
    public class Feature1StepDefinitions
    {
        SharedSteps sharedSteps = new SharedSteps();
        static void Main()
        { }

        [When(@"the user adds record to table")]
        public void WhenTheUserAddsRecordToTable()
        {
            sharedSteps.AddRecordInTheTable();
        }

        [Then(@"the record has been added to table")]
        public void ThenTheRecordHasBeenAddedToTable()
        {
            var actualRecord = sharedSteps.CheckThatTheRecordHasBeenAdded();

            Assert.IsNotNull(actualRecord.ToString(), "The record has not been found");
        }

        [When(@"the user deletes record from table")]
        public void WhenTheUserDeletesRecordFromTable()
        {
            sharedSteps.DeleteRecordFromTable();
        }

        [Then(@"the record has been deleted from table")]
        public void ThenTheRecordHasBeenDeletedFromTable()
        {
            var expectedRecord = sharedSteps.CheckThatRecordHasBeenDeleted();

            Assert.IsNull(expectedRecord, "The record has not been deleted");
        }

        [Given(@"the user adds record to table")]
        public void GivenTheUserAddsRecordToTable()
        {
            sharedSteps.AddRecordInTheTable();
        }

        [When(@"the user updates record")]
        public void WhenTheUserUpdatesRecord()
        {
            sharedSteps.UpdateRecord();
        }

        [Then(@"the record is updated")]
        public void ThenTheRecordIsUpdated()
        {
            var actualUpdatedRecord = sharedSteps.CheckThatRecordHasBeenUpdated();
            var expectedUpdatedRecord = "Adidas";

            Assert.AreEqual(expectedUpdatedRecord, actualUpdatedRecord, "The record has not been found");
        }

        [Given(@"the user has existing table brands")]
        public void GivenTheUserHasExistingTableBrands()
        {
            sharedSteps.AddBrandsInTable();
        }

        [When(@"the user selects records where BrandName = Nike")]
        public void WhenTheUserSelectsRecordsWhereBrandNameNike()
        {
            sharedSteps.GetRecordsWithBrandNameNike();
        }

        [Then(@"records with BrandName = '([^']*)' are appeared")]
        public void ThenRecordsWithBrandNameAreAppeared(string expectedRecord)
        {
            var actualRecords = sharedSteps.GetRecordsWithBrandNameNike().ToString();

            Assert.AreEqual(expectedRecord, actualRecords, "The record has not been found");
        }

        [When(@"when the user selects a record from the database by a certain attribute")]
        public void WhenTheUserSelectsRecordWith()
        {
            sharedSteps.GetDataFromDB();
        }

        [Then(@"the user gets record with this attribute")]
        public void ThenSomethingHappends()
        {
            var actualRecord = sharedSteps.GetDataFromDB();
            var expectedRecord = "Cactus Comidas para llevar";
            Assert.AreEqual(expectedRecord, actualRecord, "The record has not been found");
        }

    }
}
