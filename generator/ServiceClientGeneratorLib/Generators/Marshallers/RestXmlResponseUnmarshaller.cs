// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class RestXmlResponseUnmarshaller : BaseResponseUnmarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

    AddLicenseHeader();

    AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 12 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Response U" +
                    "nmarshaller for ");
            
            #line 15 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" operation\r\n    /// </summary>  \r\n    public class ");
            
            #line 17 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@"ResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name=""context""></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ");
            
            #line 26 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write("Response response = new ");
            
            #line 26 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("Response();\r\n");
            
            #line 27 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

    var payload= this.Operation.ResponsePayloadMember;
    var shouldMarshallPayload = (payload != null && payload.IsStructure);
    if( this.Operation.ResponseHasBodyMembers || shouldMarshallPayload)
    {

            
            #line default
            #line hidden
            this.Write("            UnmarshallResult(context,response);\r\n");
            
            #line 34 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
    
	}
	UnmarshallHeaders();
	ProcessStatusCode();

            
            #line default
            #line hidden
            this.Write("            \r\n            return response;\r\n\t\t}\t\t\r\n");
            
            #line 41 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

    if( this.Operation.ResponseHasBodyMembers || shouldMarshallPayload)
    {

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 46 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

    	if (this.Operation.ResponseBodyMembers.Count == 0 && !shouldMarshallPayload)
	    {

            
            #line default
            #line hidden
            this.Write("\t\t[System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Usage\", \"CA1801:Rev" +
                    "iewUnusedParameters\", MessageId=\"response\")]\r\n");
            
            #line 51 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

	    }

            
            #line default
            #line hidden
            this.Write("\t\tprivate static void UnmarshallResult(XmlUnmarshallerContext context, ");
            
            #line 54 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("Response response)\r\n        {\r\n            int originalDepth = context.CurrentDep" +
                    "th;\r\n            int targetDepth = originalDepth + 1;\r\n");
            
            #line 58 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

	if (payload == null)
	{

            
            #line default
            #line hidden
            this.Write("\t\t\tif (context.IsStartOfDocument) \r\n\t\t\t\t   targetDepth += 1;\r\n");
            
            #line 64 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

	}

            
            #line default
            #line hidden
            this.Write("\r\n            while (context.Read())\r\n            {\r\n\t\t\t\tif (context.IsStartEleme" +
                    "nt || context.IsAttribute)\r\n                {\r\n");
            
            #line 72 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
    
        foreach (var member in this.Operation.ResponseBodyMembers)
        {
			if(member.Shape.IsList)
			{
				var listMarshallName = member.Shape.ListMarshallName ?? "member";

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\tif (context.TestExpression(\"");
            
            #line 79 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallName));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 79 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(listMarshallName));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tvar unmarshaller = ");
            
            #line 81 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t\t\t\tresponse.");
            
            #line 82 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(".Add(unmarshaller.Unmarshall(context));\r\n\t\t\t\t\t\tcontinue;\r\n\t\t\t\t\t}\r\n");
            
            #line 85 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

			}
			else
			{

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\tif (context.TestExpression(\"");
            
            #line 90 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallName));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tvar unmarshaller = ");
            
            #line 92 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t\t\t\tresponse.");
            
            #line 93 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n\t\t\t\t\t\tcontinue;\r\n\t\t\t\t\t}\r\n");
            
            #line 96 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

			}
        }

        if (shouldMarshallPayload)
        {

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\tif (context.TestExpression(\"");
            
            #line 103 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.MarshallName));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tvar unmarshaller = ");
            
            #line 105 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t\t\t\tresponse.");
            
            #line 106 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n\t\t\t\t\t\tcontinue;\r\n\t\t\t\t\t}\r\n");
            
            #line 109 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

        }

            
            #line default
            #line hidden
            this.Write("\t\t\t\t}\r\n\t\t\t\telse if (context.IsEndElement && context.CurrentDepth < originalDepth)" +
                    "\r\n                {\r\n                    return;\r\n                }\r\n           " +
                    " }\r\n          \r\n            return;\r\n        }\r\n");
            
            #line 121 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name=""context""></param>
        /// <param name=""innerException""></param>
        /// <param name=""statusCode""></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
");
            
            #line 135 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

    foreach (var exception in this.Operation.Exceptions)
    {

            
            #line default
            #line hidden
            this.Write("            if (errorResponse.Code != null && errorResponse.Code.Equals(\"");
            
            #line 139 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Code));
            
            #line default
            #line hidden
            this.Write("\"))\r\n            {\r\n                return new ");
            
            #line 141 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Name));
            
            #line default
            #line hidden
            this.Write("(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, e" +
                    "rrorResponse.RequestId, statusCode);\r\n            }\r\n");
            
            #line 143 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

    }

            
            #line default
            #line hidden
            this.Write("            return new ");
            
            #line 146 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BaseException));
            
            #line default
            #line hidden
            this.Write("(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, e" +
                    "rrorResponse.RequestId, statusCode);\r\n        }\r\n\r\n");
            
            #line 149 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\RestXmlResponseUnmarshaller.tt"

    this.AddResponseSingletonMethod();

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
