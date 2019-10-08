// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.XPackApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for Info <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html</para></summary>
	public partial class XPackInfoDescriptor : RequestDescriptorBase<XPackInfoDescriptor, XPackInfoRequestParameters, IXPackInfoRequest>, IXPackInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.XPackInfo;
		// values part of the url path
		// Request parameters
		///<summary>Comma-separated list of info categories. Can be any of: build, license, features</summary>
		public XPackInfoDescriptor Categories(params string[] categories) => Qs("categories", categories);
	}

	///<summary>Descriptor for Usage <para>Retrieve information about xpack features usage</para></summary>
	public partial class XPackUsageDescriptor : RequestDescriptorBase<XPackUsageDescriptor, XPackUsageRequestParameters, IXPackUsageRequest>, IXPackUsageRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.XPackUsage;
		// values part of the url path
		// Request parameters
		///<summary>Specify timeout for watch write operation</summary>
		public XPackUsageDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
	}
}