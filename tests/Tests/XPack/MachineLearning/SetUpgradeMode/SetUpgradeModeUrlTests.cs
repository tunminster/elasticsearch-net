// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Threading.Tasks;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.MachineLearning.SetUpgradeMode
{
	public class SetUpgradeModeUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await POST("/_ml/set_upgrade_mode")
			.Fluent(c => c.MachineLearning.SetUpgradeMode())
			.Request(c => c.MachineLearning.SetUpgradeMode(new SetUpgradeModeRequest()))
			.FluentAsync(c => c.MachineLearning.SetUpgradeModeAsync())
			.RequestAsync(c => c.MachineLearning.SetUpgradeModeAsync(new SetUpgradeModeRequest()));
	}
}
