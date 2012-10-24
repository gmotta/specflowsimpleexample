using TechTalk.SpecFlow;

namespace specflowspike.StepDefinitions
{
    [Binding]
    public class SimpleSearchStepDefinition
    {
        [Given(@"I am on the Bing Home Page")]
        public void GivenIAmOnTheBingHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I search for ""Eloquent Ruby""")]
        public void WhenISearchForEloquentRuby()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I follow the ""Eloquent Ruby"" link")]
        public void WhenIFollowTheEloquentRubyLink()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the title ""Eloquent Ruby \| Companion site to the book Eloquent Ruby""")]
        public void ThenIShouldSeeTheTitleEloquentRubyCompanionSiteToTheBookEloquentRuby()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
