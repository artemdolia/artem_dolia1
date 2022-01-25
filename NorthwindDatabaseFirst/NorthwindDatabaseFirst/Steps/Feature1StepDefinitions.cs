using NorthwindDatabaseFirst.Steps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NorthwindDatabaseFirst
{
    [Binding]
    public class Feature1StepDefinitions
    {
        SharedSteps sharedSteps = new SharedSteps();
        static void Main()
        {
        }

        [When(@"the user adds record to table")]
        public void WhenTheUserAddedRecordInTheTable(Table table)
        {
            sharedSteps.AddRecordInTheTable();
        }

        [Then(@"the record '([^']*)' has been added to table")]
        public void ThenTheRecordHasBeenAddedToTable(string record)
        {
             sharedSteps.CheckThatTheRecordHasBeenAdded();
            
            Assert.IsNotNull(record);
        }

        [When(@"the user deletes record from table '([^']*)'")]
        public void WhenTheUserDeletesRecordFromTable(string step)
        {
            sharedSteps.DeleteRecordFromTable();
        }

        [Then(@"the record has been deleted from table")]
        public void ThenTheRecordHasBeenDeletedFromTable()
        {
            sharedSteps.CheckThatRecordHasBeenDeleted();

            Assert.IsNull(sharedSteps);
        }
    }
}
