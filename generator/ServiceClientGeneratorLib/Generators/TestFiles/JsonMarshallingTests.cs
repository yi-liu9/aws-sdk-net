﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by JetBrains T4 Processor
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.TestFiles
{
    using System;
    #line 3 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
using System.IO;
    #line default
    #line hidden
    #line 4 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
using System.Linq;
    #line default
    #line hidden
    #line 5 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
using System.Text;
    #line default
    #line hidden
    #line 6 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
using System.Collections.Generic;
    #line default
    #line hidden
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("JetBrains.ForTea.TextTemplating", "42.42.42.42")]
    public partial class JsonMarshallingTests : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 7 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.IO;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing Microsoft.VisualStudio.TestTools.UnitTesting;\r\n\r\nusing ");
            
            #line 18 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 19 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\nusing ");
            
            #line 20 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations;\r\nusing Amazon.Runtime.Internal.Transform;\r\n\r\nusing ServiceClientGenerator;\r\n\r\nusing AWSSDK_DotNet35.UnitTests.TestTools;\r\n\r\nnamespace AWSSDK_DotNet35.UnitTests.Marshalling\r\n{\r\n    [TestClass]\r\n    public class ");
            
            #line 30 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("MarshallingTests\r\n    {\r\n        static readonly ServiceModel service_model = Utils.LoadServiceModel(\"");
            
            #line 32 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceDirectoryName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t");
            #line 33 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

		foreach(var operation in this.Config.ServiceModel.Operations)
		{
		
            
            #line default
            #line hidden
            this.Write("\r\n        [TestMethod]\r\n        [TestCategory(\"UnitTest\")]\r\n        [TestCategory(\"");
            
            #line 40 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.Type));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        [TestCategory(\"");
            
            #line 41 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.TestCategory));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public void ");
            
            #line 42 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("MarshallTest()\r\n        {\r\n            var request = InstantiateClassGenerator.Execute<");
            
            #line 44 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>();\r\n            var marshaller = new ");
            
            #line 45 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller();\r\n\r\n            var internalRequest = marshaller.Marshall(request);\r\n");
            #line 48 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

            if(operation.RequestStructure != null)
            {

            
            #line default
            #line hidden
            this.Write("            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);\t\t\t            \r\n\t\t\tComparer.CompareObjectToJson<");
            
            #line 53 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>(request,jsonRequest);\r\n\r\n");
            #line 55 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

            }

            if(operation.ResponseStructure != null)
            {

            
            #line default
            #line hidden
            this.Write("\t\t\tvar webResponse = new WebResponseData\r\n\t\t\t{\r\n\t\t\t\tHeaders = {\r\n\t\t\t\t\t{\"x-amzn-RequestId\", Guid.NewGuid().ToString()},\r\n\t\t\t\t\t{\"x-amz-crc32\",\"0\"}\r\n\t\t\t\t}\r\n\t\t\t};\r\n            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation(\"");
            
            #line 68 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\").ResponseStructure).Execute();\r\n\t\t\twebResponse.Headers.Add(\"Content-Length\", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());\r\n            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);\r\n            var response = ");
            
            #line 71 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance.Unmarshall(context)\r\n\t\t\t\tas ");
            
            #line 72 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response;\r\n\t\t\tInstantiateClassGenerator.ValidateObjectFullyInstantiated(response);\r\n");
            #line 74 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

            }

            
            #line default
            #line hidden
            this.Write("        }\r\n");
            #line 78 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

            foreach (var exception in operation.Exceptions)
            {

            
            #line default
            #line hidden
            this.Write("\r\n        [TestMethod]\r\n        [TestCategory(\"UnitTest\")]\r\n        [TestCategory(\"");
            
            #line 85 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.Type));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        [TestCategory(\"");
            
            #line 86 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.TestCategory));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public void ");
            
            #line 87 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("_");
            
            #line 87 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Name));
            
            #line default
            #line hidden
            this.Write("MarshallTest()\r\n        {\r\n            var operation =  service_model.FindOperation(\"");
            
            #line 89 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n\r\n            var request = InstantiateClassGenerator.Execute<");
            
            #line 91 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>();\r\n            var marshaller = new ");
            
            #line 92 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller();\r\n            var internalRequest = marshaller.Marshall(request);\r\n            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);\r\n\r\n            Comparer.CompareObjectToJson<");
            
            #line 96 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>(request,jsonRequest);\r\n\r\n            var exception = operation.Exceptions.First(e => e.Name.Equals(\"");
            
            #line 98 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Name));
            
            #line default
            #line hidden
            this.Write("\"));\r\n            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();\r\n            var webResponse = new WebResponseData\r\n            {\r\n                Headers = {\r\n                    {\"x-amzn-RequestId\", Guid.NewGuid().ToString()},\r\n                    {\"x-amz-crc32\",\"0\"},\r\n                    {\"x-amzn-ErrorType\",\"");
            
            #line 105 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Name));
            
            #line default
            #line hidden
            this.Write("\"},\r\n                    {\"Content-Length\", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}\r\n                }\r\n            };\r\n            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);\r\n            var response = ");
            
            #line 110 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);\r\n\r\n            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);\r\n        }\r\n");
            #line 114 "C:\Dev\Repos\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

            }
        }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
}
