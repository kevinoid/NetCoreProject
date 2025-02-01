// <copyright file="AssemblyInfo.cs" company="Kevin Locke">
// Copyright 2019-2025 Kevin Locke.  All rights reserved.
// </copyright>

// Note: Most assembly properties now defined in .csproj
// See https://stackoverflow.com/q/42138418/503410

// Mark the types in this assembly as not CLS-compliant.
// Although CLS-compliance is preferable, applying Xunit.InlineDataAttribute
// is not compliant because it uses arrays as attribute arguments (CS3016).
// Since the UnitTests assembly is very unlikely to be used from languages
// other than C#, the cost of applying CLSCompliant to individual classes is
// expected to outweigh the benefits.
[assembly: System.CLSCompliant(false)]
