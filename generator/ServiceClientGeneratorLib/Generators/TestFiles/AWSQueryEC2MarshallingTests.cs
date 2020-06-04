﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.TestFiles
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AWSQueryEC2MarshallingTests : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 7 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.IO;\r\nusing System.Text;\r\nusing Microsoft.VisualSt" +
                    "udio.TestTools.UnitTesting;\r\n\r\nusing ");
            
            #line 17 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 18 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\nusing ");
            
            #line 19 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(@".Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;
using ServiceClientGenerator.Generators.SourceFiles;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class ");
            
            #line 30 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("MarshallingTests\r\n    {\r\n        static readonly ServiceModel service_model = Uti" +
                    "ls.LoadServiceModel(\"");
            
            #line 32 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceDirectoryName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t");
            
            #line 33 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"

		foreach(var operation in this.Config.ServiceModel.Operations)
		{
		
            
            #line default
            #line hidden
            this.Write("\r\n\r\n        [TestMethod]\r\n\t\t[TestCategory(\"UnitTest\")]\r\n\t\t[TestCategory(\"Query\")]" +
                    "\r\n\t\t[TestCategory(\"");
            
            #line 42 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.TestCategory));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public void ");
            
            #line 43 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("MarshallTest()\r\n        {\r\n            var operation = service_model.FindOperatio" +
                    "n(\"");
            
            #line 45 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n\r\n            var request = InstantiateClassGenerator.Execute<");
            
            #line 47 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>();\r\n            var marshaller = new ");
            
            #line 48 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller();\r\n            var internalRequest = marshaller.Marshall(reque" +
                    "st);\r\n            var validator = new AWSQueryValidator(internalRequest.Paramete" +
                    "rs, request, service_model, operation);\r\n            validator.Validate();\r\n\r\n\r\n" +
                    "");
            
            #line 54 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"

            if(operation.ResponseStructure != null)
            {

            
            #line default
            #line hidden
            this.Write(@"            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
			UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ");
            
            #line 60 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance.Unmarshall(context)\r\n\t\t\t\tas ");
            
            #line 61 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response;   \r\n            InstantiateClassGenerator.ValidateObjectFullyInstantiat" +
                    "ed(response);       \r\n");
            
            #line 63 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"

            }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n\t\t");
            
            #line 68 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\TestFiles\AWSQueryEC2MarshallingTests.tt"

		}
		
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
