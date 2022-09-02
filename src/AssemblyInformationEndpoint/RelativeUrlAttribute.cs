using System;
using System.ComponentModel.DataAnnotations;
using static System.AttributeTargets;

namespace AssemblyInformationEndpoint
{
    /// <summary>This URI must be a relative URI such as "/_version".</summary>
    [AttributeUsage(Property | Field | Parameter)]
    public sealed class RelativeUrlAttribute : DataTypeAttribute
    {
        public RelativeUrlAttribute() : base(DataType.Url)
        {
            ErrorMessage = "Value is not a relative URI.";
        }

        public override bool IsValid(object value)
        {
            if (value is null) return true;
            
            if (!(value is Uri valueAsUri))
                throw new ArgumentException("Type is not Uri.");

            return !valueAsUri.IsAbsoluteUri;
        }
    }
}