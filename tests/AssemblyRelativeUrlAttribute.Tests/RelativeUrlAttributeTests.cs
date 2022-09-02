using System;
using AssemblyInformationEndpoint;
using Xunit;

namespace AssemblyRelativeUrlAttribute.Tests;

public class RelativeUrlAttributeTests
{
    [Fact]
    public void IsValid_returns_true_if_value_is_null()
    {
        var value = (Uri) null;
        var sut = new RelativeUrlAttribute();
        Assert.True(sut.IsValid(value));
    }
    
    [Theory]
    [InlineData(false, "https://example.com")]
    [InlineData(false, "https://example.com/_version")]
    [InlineData(true, "")]
    [InlineData(true, "/_version?someArgument=someValue")]
    [InlineData(true, "/_version")]
    public void IsValid_returns_expected_for_input(
        bool expected, 
        string inputUrl
        )
    {
        var value = new Uri(inputUrl, UriKind.RelativeOrAbsolute);
        var sut = new RelativeUrlAttribute();
        Assert.Equal(expected, sut.IsValid(value));
    }
}