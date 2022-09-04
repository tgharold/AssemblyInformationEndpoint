using System;
using System.Collections.Generic;
using System.Reflection;

namespace AssemblyInformationEndpoint
{
    public static class InformationValues
    {
        /// <inheritdoc cref="AssemblyName.FullName"/>
        public static readonly string AssemblyNameFullName = "AssemblyNameFullName";

        /// <inheritdoc cref="AssemblyName.Name"/>
        public static readonly string AssemblyNameName = "AssemblyNameName";

        /// <inheritdoc cref="AssemblyName.Version"/>
        public static readonly string AssemblyNameVersion = "AssemblyNameVersion";

        /// <inheritdoc cref="Version.Major"/>
        public static readonly string AssemblyNameVersionMajor = "AssemblyNameVersionMajor";

        /// <inheritdoc cref="Version.Minor"/>
        public static readonly string AssemblyNameVersionMinor = "AssemblyNameVersionMinor";

        /// <inheritdoc cref="Version.Revision"/>
        public static readonly string AssemblyNameVersionRevision = "AssemblyNameVersionRevision";

        /// <inheritdoc cref="Version.Build"/>
        public static readonly string AssemblyNameVersionBuild = "AssemblyNameVersionBuild";

        /// <summary>The default set of information values to be returned.</summary>
        public static readonly Lazy<IReadOnlyCollection<string>> Default = 
            new Lazy<IReadOnlyCollection<string>>(() =>
            {
                return new[]
                {
                    AssemblyNameName,
                    AssemblyNameVersion,
                };
            });
    }
}