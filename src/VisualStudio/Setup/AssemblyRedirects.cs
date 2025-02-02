// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.VisualStudio.Shell;
using Roslyn.VisualStudio.Setup;

[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.CSharp.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.CSharp.EditorFeatures.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.CSharp.Features.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.CSharp.Workspaces.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.EditorFeatures.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.EditorFeatures.Text.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.Features.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.VisualBasic.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.VisualBasic.EditorFeatures.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.VisualBasic.Features.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.VisualBasic.Workspaces.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.Workspaces.Desktop.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.CodeAnalysis.Workspaces.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.VisualStudio.LanguageServices.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.VisualStudio.LanguageServices.Implementation.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.VisualStudio.LanguageServices.VisualBasic.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.VisualStudio.LanguageServices.CSharp.dll")]
[assembly: ProvideRoslynBindingRedirection("Microsoft.VisualStudio.LanguageServices.SolutionExplorer.dll")]

[assembly: ProvideBindingRedirection(
    AssemblyName = "System.Reflection.Metadata",
    OldVersionLowerBound = "1.0.0.0",
    OldVersionUpperBound = "1.0.99.0",
    NewVersion = "1.1.0.0",
    PublicKeyToken = "b03f5f7f11d50a3a",
    GenerateCodeBase = ProvideRoslynBindingRedirectionAttribute.GenerateCodeBase)]