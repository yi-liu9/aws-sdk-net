﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ServiceEnumerations : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\nusing System;\r\n\r\nusing Amazon.Runtime;\r\n\r\nnamespace ");
            
            #line 14 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 16 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"

foreach(var enumeration in this.Config.ServiceModel.Enumerations(false))
{

            
            #line default
            #line hidden
            this.Write("\r\n    /// <summary>\r\n    /// Constants used for properties of type ");
            
            #line 22 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumeration.Name));
            
            #line default
            #line hidden
            this.Write(".\r\n    /// </summary>\r\n    public class ");
            
            #line 24 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumeration.Name));
            
            #line default
            #line hidden
            this.Write(" : ConstantClass\r\n    {\r\n\r\n");
            
            #line 27 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"

    foreach(var enumValue in enumeration.EnumerationValues)
    {

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Constant ");
            
            #line 32 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumValue.PropertyName));
            
            #line default
            #line hidden
            this.Write(" for ");
            
            #line 32 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumeration.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n        public static readonly ");
            
            #line 34 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumeration.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 34 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumValue.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = new ");
            
            #line 34 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumeration.Name));
            
            #line default
            #line hidden
            this.Write("(\"");
            
            #line 34 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumValue.MarshallName));
            
            #line default
            #line hidden
            this.Write("\");\r\n");
            
            #line 35 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"
        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ");
            
            #line 47 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumeration.Name));
            
            #line default
            #line hidden
            this.Write(@"(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name=""value"">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ");
            
            #line 57 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumeration.Name));
            
            #line default
            #line hidden
            this.Write(" FindValue(string value)\r\n        {\r\n            return FindValue<");
            
            #line 59 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumeration.Name));
            
            #line default
            #line hidden
            this.Write(@">(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name=""value"">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ");
            
            #line 67 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumeration.Name));
            
            #line default
            #line hidden
            this.Write("(string value)\r\n        {\r\n            return FindValue(value);\r\n        }\r\n    }" +
                    "\r\n\r\n");
            
            #line 73 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceEnumerations.tt"

}

            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
