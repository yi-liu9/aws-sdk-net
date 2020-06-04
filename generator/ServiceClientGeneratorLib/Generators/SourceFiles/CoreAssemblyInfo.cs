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
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\CoreAssemblyInfo.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class CoreAssemblyInfo : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\nusing System;\r\nusing System.Reflection;\r\nusing System.Runtime.InteropServices;\r" +
                    "\nusing System.Runtime.CompilerServices;\r\n\r\n// General Information about an assem" +
                    "bly is controlled through the following \r\n// set of attributes. Change these att" +
                    "ribute values to modify the information\r\n// associated with an assembly.\r\n[assem" +
                    "bly: AssemblyTitle(\"AWSSDK.Core\")]\r\n#if BCL35\r\n[assembly: AssemblyDescription(\"T" +
                    "he Amazon Web Services SDK for .NET (3.5) - Core Runtime\")]\r\n#elif BCL45\r\n[assem" +
                    "bly: AssemblyDescription(\"The Amazon Web Services SDK for .NET (4.5) - Core Runt" +
                    "ime\")]\r\n#elif NETSTANDARD13\r\n[assembly: AssemblyDescription(\"The Amazon Web Serv" +
                    "ices SDK for .NET (NetStandard 1.3) - Core Runtime\")]\r\n#elif NETSTANDARD20\r\n[ass" +
                    "embly: AssemblyDescription(\"The Amazon Web Services SDK for .NET (NetStandard 2." +
                    "0) - Core Runtime\")]\r\n#elif NETCOREAPP31\r\n[assembly: AssemblyDescription(\"The Am" +
                    "azon Web Services SDK for .NET (.NET Core 3.1) - Core Runtime\")]\r\n#else\r\n#error " +
                    "Unknown platform constant - unable to set correct AssemblyDescription\r\n#endif\r\n\r" +
                    "\n[assembly: AssemblyConfiguration(\"\")]\r\n[assembly: AssemblyProduct(\"Amazon Web S" +
                    "ervices SDK for .NET\")]\r\n[assembly: AssemblyCompany(\"Amazon.com, Inc\")]\r\n[assemb" +
                    "ly: AssemblyCopyright(\"Copyright 2009-2015 Amazon.com, Inc. or its affiliates. A" +
                    "ll Rights Reserved.\")]\r\n[assembly: AssemblyTrademark(\"\")]\r\n[assembly: AssemblyCu" +
                    "lture(\"\")]\r\n\r\n// Setting ComVisible to false makes the types in this assembly no" +
                    "t visible \r\n// to COM components.  If you need to access a type in this assembly" +
                    " from \r\n// COM, set the ComVisible attribute to true on that type.\r\n[assembly: C" +
                    "omVisible(false)]\r\n\r\n// Version information for an assembly consists of the foll" +
                    "owing four values:\r\n//\r\n//      Major Version\r\n//      Minor Version \r\n//      B" +
                    "uild Number\r\n//      Revision\r\n//\r\n// You can specify all the values or you can " +
                    "default the Build and Revision Numbers \r\n// by using the \'*\' as shown below:\r\n//" +
                    " [assembly: AssemblyVersion(\"1.0.*\")]\r\n[assembly: AssemblyVersion(\"");
            
            #line 49 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\CoreAssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["Version"]));
            
            #line default
            #line hidden
            this.Write("\")]\r\n[assembly: AssemblyFileVersion(\"");
            
            #line 50 "C:\Users\costleya\Work\aws-sdk-net\generator\ServiceClientGeneratorLib\Generators\SourceFiles\CoreAssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["FileVersion"]));
            
            #line default
            #line hidden
            this.Write(@""")]

[assembly: System.CLSCompliant(true)]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif

#if BCL45
// Setting SecurityRules to level 1 to match .NET 2.0 rules and allow the
// Amazon.Util.Settings.UserCrypto methods to work in .NET 4.5
[assembly: System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
#endif");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
