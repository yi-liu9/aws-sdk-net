﻿// ------------------------------------------------------------------------------
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
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class AWSQueryEC2ResponseUnmarshaller : BaseResponseUnmarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

    AddLicenseHeader();

    AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 11 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Response U" +
                    "nmarshaller for ");
            
            #line 14 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" operation\r\n    /// </summary>  \r\n    public class ");
            
            #line 16 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@"ResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name=""context""></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ");
            
            #line 25 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write("Response response = new ");
            
            #line 25 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("Response();\r\n\r\n");
            
            #line 27 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
 if (this.HasSuppressedResult)
   {

            
            #line default
            #line hidden
            this.Write("            while (context.Read())\r\n            {\r\n\t\t\t\r\n\t\t\t}\r\n");
            
            #line 34 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

   }
   else
   {

            
            #line default
            #line hidden
            this.Write(@"            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

");
            
            #line 49 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

		if(this.Structure != null)
		{
			if(this.IsWrapped)
			{

            
            #line default
            #line hidden
            this.Write("                    if ( context.TestExpression(\".\", targetDepth))\r\n             " +
                    "       {\r\n                        response.");
            
            #line 57 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MemberAccessorFor(this.Structure.Name)));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 57 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("Unmarshaller.Instance.Unmarshall(context);\r\n                        continue;\r\n  " +
                    "                  }\r\n");
            
            #line 60 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
 
			}
			else
			{
				foreach (var member in this.Structure.Members)
				{
					var testExpression= GeneratorHelpers.DetermineAWSQueryTestExpression(member);

            
            #line default
            #line hidden
            this.Write("                    if (context.TestExpression(\"");
            
            #line 68 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(testExpression));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n                    {\r\n                        var unmarshaller" +
                    " = ");
            
            #line 70 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 71 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

					if (member.IsList)
					{

            
            #line default
            #line hidden
            this.Write("                        var item = unmarshaller.Unmarshall(context);\r\n           " +
                    "             response.");
            
            #line 76 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MemberAccessorFor(member.PropertyName)));
            
            #line default
            #line hidden
            this.Write(".Add(item);\r\n");
            
            #line 77 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

					}
					else
					{

            
            #line default
            #line hidden
            this.Write("                        response.");
            
            #line 82 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MemberAccessorFor(member.PropertyName)));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n");
            
            #line 83 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

	                }

            
            #line default
            #line hidden
            this.Write("                        continue;\r\n                    }\r\n");
            
            #line 88 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

				}
			}
		}

            
            #line default
            #line hidden
            this.Write("                } \r\n            }\r\n");
            
            #line 95 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

	}

            
            #line default
            #line hidden
            this.Write(@"
            return response;
        }

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
            
            #line 112 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

    foreach (var exception in this.Operation.Exceptions)
    {

            
            #line default
            #line hidden
            this.Write("            if (errorResponse.Code != null && errorResponse.Code.Equals(\"");
            
            #line 116 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Code));
            
            #line default
            #line hidden
            this.Write("\"))\r\n            {\r\n                return new ");
            
            #line 118 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Name));
            
            #line default
            #line hidden
            this.Write("(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, e" +
                    "rrorResponse.RequestId, statusCode);\r\n            }\r\n");
            
            #line 120 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

    }

            
            #line default
            #line hidden
            this.Write("            return new ");
            
            #line 123 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BaseException));
            
            #line default
            #line hidden
            this.Write("(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, e" +
                    "rrorResponse.RequestId, statusCode);\r\n        }\r\n");
            
            #line 125 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

	    this.AddResponseSingletonMethod();

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 130 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryEC2ResponseUnmarshaller.tt"

// if the result fields have been wrapped in a subordinate structure, wire the accessor
// to use it when addressing a member
string MemberAccessorFor(string memberName)
{
	return string.IsNullOrEmpty(WrappedResultMember) ? memberName : WrappedResultMember;
}	

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
