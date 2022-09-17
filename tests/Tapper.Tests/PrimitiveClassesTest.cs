// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY Tapper.Test
// </auto-generated>
#nullable enable
using System;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Tapper.Tests.SourceTypes;
using Tapper.TypeMappers;
using Xunit;
using Xunit.Abstractions;

namespace Tapper.Tests;

public class PrimitiveMapTest
{
    private readonly ITestOutputHelper _output;

    public PrimitiveMapTest(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemBoolean()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemBoolean);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemBoolean)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemByte()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemByte);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemByte)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemSByte()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemSByte);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemSByte)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemChar()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemChar);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemChar)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemDecimal()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemDecimal);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemDecimal)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemDouble()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemDouble);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemDouble)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemSingle()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemSingle);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemSingle)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemInt32()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemInt32);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemInt32)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemUInt32()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemUInt32);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemUInt32)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemInt64()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemInt64);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemInt64)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemUInt64()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemUInt64);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemUInt64)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemInt16()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemInt16);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemInt16)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemUInt16()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemUInt16);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemUInt16)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemObject()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemObject);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemObject)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemString()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemString);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemString)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemUri()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemUri);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemUri)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemGuid()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemGuid);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemGuid)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitiveFieldSystemDateTime()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitiveFieldSystemDateTime);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitiveFieldSystemDateTime)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }



    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemBoolean()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemBoolean);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemBoolean)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemByte()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemByte);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemByte)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemSByte()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemSByte);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemSByte)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemChar()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemChar);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemChar)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemDecimal()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemDecimal);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemDecimal)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemDouble()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemDouble);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemDouble)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemSingle()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemSingle);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemSingle)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemInt32()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemInt32);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemInt32)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemUInt32()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemUInt32);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemUInt32)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemInt64()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemInt64);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemInt64)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemUInt64()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemUInt64);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemUInt64)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemInt16()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemInt16);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemInt16)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemUInt16()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemUInt16);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemUInt16)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemObject()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemObject);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemObject)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemString()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemString);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemString)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemUri()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemUri);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemUri)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemGuid()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemGuid);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemGuid)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

    [Fact]
    public void Test_ClassIncludePrimitivePropertySystemDateTime()
    {
        var compilation = CompilationSingleton.Compilation;

        var codeGenerator = new TypeScriptCodeGenerator(compilation, Environment.NewLine, 2, false, SerializerOption.Json, NamingStyle.None, EnumNamingStyle.None, Logger.Empty);

        var type = typeof(ClassIncludePrimitivePropertySystemDateTime);
        var typeSymbol = compilation.GetTypeByMetadataName(type.FullName!)!;

        var writer = new CodeWriter();

        codeGenerator.AddType(typeSymbol, ref writer);

        var code = writer.ToString();
        var gt = PrimitiveTypeTranspilationAnswer.Dict[nameof(ClassIncludePrimitivePropertySystemDateTime)];

        _output.WriteLine(code);
        _output.WriteLine(gt);

        Assert.Equal(gt, code, ignoreLineEndingDifferences: true);
    }

}
