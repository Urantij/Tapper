// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY Tapper
// </auto-generated>
#nullable enable
using System;
using Microsoft.CodeAnalysis;

namespace Tapper.TypeMappers;

public class Dictionary2TypeMapper : ITypeMapper
{
    public ITypeSymbol Assign { get; }

    public Dictionary2TypeMapper(Compilation compilation)
    {
        Assign = compilation.GetTypeByMetadataName("System.Collections.Generic.Dictionary`2")!;
    }

    public string MapTo(ITypeSymbol typeSymbol, ITranspilationOptions options)
    {
        if (typeSymbol is INamedTypeSymbol namedTypeSymbol
            && namedTypeSymbol.IsGenericType
            && SymbolEqualityComparer.Default.Equals(namedTypeSymbol.ConstructedFrom, Assign))
        {
            var mapper0 = options.TypeMapperProvider.GetTypeMapper(namedTypeSymbol.TypeArguments[0]);
            var mapper1 = options.TypeMapperProvider.GetTypeMapper(namedTypeSymbol.TypeArguments[1]);

            return $"{{ [key: {mapper0.MapTo(namedTypeSymbol.TypeArguments[0], options)}]: {mapper1.MapTo(namedTypeSymbol.TypeArguments[1], options)} }}";
        }

        throw new InvalidOperationException($"Dictionary2TypeMapper is not support {typeSymbol.ToDisplayString()}.");
    }
}

public class IDictionary2TypeMapper : ITypeMapper
{
    public ITypeSymbol Assign { get; }

    public IDictionary2TypeMapper(Compilation compilation)
    {
        Assign = compilation.GetTypeByMetadataName("System.Collections.Generic.IDictionary`2")!;
    }

    public string MapTo(ITypeSymbol typeSymbol, ITranspilationOptions options)
    {
        if (typeSymbol is INamedTypeSymbol namedTypeSymbol
            && namedTypeSymbol.IsGenericType
            && SymbolEqualityComparer.Default.Equals(namedTypeSymbol.ConstructedFrom, Assign))
        {
            var mapper0 = options.TypeMapperProvider.GetTypeMapper(namedTypeSymbol.TypeArguments[0]);
            var mapper1 = options.TypeMapperProvider.GetTypeMapper(namedTypeSymbol.TypeArguments[1]);

            return $"{{ [key: {mapper0.MapTo(namedTypeSymbol.TypeArguments[0], options)}]: {mapper1.MapTo(namedTypeSymbol.TypeArguments[1], options)} }}";
        }

        throw new InvalidOperationException($"IDictionary2TypeMapper is not support {typeSymbol.ToDisplayString()}.");
    }
}

public class IReadOnlyDictionary2TypeMapper : ITypeMapper
{
    public ITypeSymbol Assign { get; }

    public IReadOnlyDictionary2TypeMapper(Compilation compilation)
    {
        Assign = compilation.GetTypeByMetadataName("System.Collections.Generic.IReadOnlyDictionary`2")!;
    }

    public string MapTo(ITypeSymbol typeSymbol, ITranspilationOptions options)
    {
        if (typeSymbol is INamedTypeSymbol namedTypeSymbol
            && namedTypeSymbol.IsGenericType
            && SymbolEqualityComparer.Default.Equals(namedTypeSymbol.ConstructedFrom, Assign))
        {
            var mapper0 = options.TypeMapperProvider.GetTypeMapper(namedTypeSymbol.TypeArguments[0]);
            var mapper1 = options.TypeMapperProvider.GetTypeMapper(namedTypeSymbol.TypeArguments[1]);

            return $"{{ [key: {mapper0.MapTo(namedTypeSymbol.TypeArguments[0], options)}]: {mapper1.MapTo(namedTypeSymbol.TypeArguments[1], options)} }}";
        }

        throw new InvalidOperationException($"IReadOnlyDictionary2TypeMapper is not support {typeSymbol.ToDisplayString()}.");
    }
}

public static class DictionalyTypeMappers
{
    public static ITypeMapper[] Create(Compilation compilation)
    {
        var mappers = new ITypeMapper[3];

        mappers[0] = new Dictionary2TypeMapper(compilation);
        mappers[1] = new IDictionary2TypeMapper(compilation);
        mappers[2] = new IReadOnlyDictionary2TypeMapper(compilation);
        return mappers;
    }
}
