using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Tapper;

public class TranspilationOptions : ITranspilationOptions
{
    public ITypeMapperProvider TypeMapperProvider { get; }

    public SpecialSymbols SpecialSymbols { get; }

    public IReadOnlyList<INamedTypeSymbol> SourceTypes { get; }

    public SerializerOption SerializerOption { get; }

    public NamingStyle NamingStyle { get; }

    public EnumStyle EnumStyle { get; }

    public NewLineOption NewLine { get; }

    public int Indent { get; }

    public bool ReferencedAssembliesTranspilation { get; }

    public bool EnableAttributeReference { get; }
    
    public string TargetNamespace { get; }

    public TranspilationOptions(
        Compilation compilation,
        SerializerOption serializerOption,
        NamingStyle namingStyle,
        EnumStyle enumStyle,
        NewLineOption newLineOption,
        int indent,
        bool referencedAssembliesTranspilation,
        bool enableAttributeReference, 
        string targetNamespace)
        : this(
              compilation,
              new DefaultTypeMapperProvider(compilation, referencedAssembliesTranspilation, targetNamespace),
              serializerOption,
              namingStyle,
              enumStyle,
              newLineOption,
              indent,
              referencedAssembliesTranspilation,
              enableAttributeReference, targetNamespace)
    {
    }

    public TranspilationOptions(
        Compilation compilation,
        ITypeMapperProvider typeMapperProvider,
        SerializerOption serializerOption,
        NamingStyle namingStyle,
        EnumStyle enumStyle,
        NewLineOption newLineOption,
        int indent,
        bool referencedAssembliesTranspilation,
        bool enableAttributeReference,
        string targetNamespace)
    {
        TypeMapperProvider = typeMapperProvider;
        SpecialSymbols = new SpecialSymbols(compilation);
        SourceTypes = compilation.GetSourceTypes(referencedAssembliesTranspilation, targetNamespace);
        SerializerOption = serializerOption;
        NamingStyle = namingStyle;
        EnumStyle = enumStyle;
        NewLine = newLineOption;
        Indent = indent;
        ReferencedAssembliesTranspilation = referencedAssembliesTranspilation;
        EnableAttributeReference = enableAttributeReference;
        this.TargetNamespace = targetNamespace;
    }
}
