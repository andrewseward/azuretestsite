using NUnit.Framework;

namespace AzureTestSite.Test
{
	[TestFixture]
    public class AzureTestSiteTests
    {
		[Test]
		public void DoesThatThingWork()
		{
			var result = new DumbClass().DoDumbThing();
			Assert.That(result, Is.EqualTo("D'yer want the usual?"));
		}
    }
}
