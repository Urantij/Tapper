using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace Tapper.Tests.AsmReference;

public class UnitTest1
{
    private readonly ITestOutputHelper _outputHelper;

    public UnitTest1(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public async Task Test1()
    {
        var generatorProject = Path.GetFullPath("../../../../../src/Tapper.Generator/Tapper.Generator.csproj");
        var fullPath = Path.GetFullPath("../../../../Tapper.Tests.AsmReference.SourceTypes1/Tapper.Tests.AsmReference.SourceTypes1.csproj");
        var outputFullPath = Path.GetFullPath("OutAsmReference");

        _outputHelper.WriteLine(fullPath);
        _outputHelper.WriteLine(File.Exists(fullPath).ToString());

        await ExecCommand(generatorProject, fullPath, outputFullPath, _outputHelper);

        var outputFilePaths = Directory.GetFiles(outputFullPath);

        Assert.Equal(2, outputFilePaths.Length);

        foreach (var outputFilePath in outputFilePaths)
        {
            var output = await File.ReadAllTextAsync(outputFilePath);

            if (outputFilePath.Contains("Tapper.Tests.AsmReference.SourceTypes1.ts"))
            {
                Assert.Equal(SourceTypes1Ans, output, ignoreLineEndingDifferences: true);
                File.Delete(outputFilePath);
            }
            else if (outputFilePath.Contains("Tapper.Tests.AsmReference.SourceTypes2.ts"))
            {
                Assert.Equal(SourceTypes2Ans, output, ignoreLineEndingDifferences: true);
                File.Delete(outputFilePath);
            }
            else
            {
                Assert.True(false);
            }
        }
    }

    private static async Task ExecCommand(string generatorProject, string projectFullPath, string outputFullPath, ITestOutputHelper outputHelper)
    {
        outputHelper.WriteLine($"run --project {generatorProject} --framework net8.0 -- --project {projectFullPath} --output {outputFullPath} -asm true");
        var startInfo = new ProcessStartInfo
        {
            FileName = "dotnet",
            Arguments = $"run --project {generatorProject} -- --project {projectFullPath} --output {outputFullPath} -asm true"
        };

        var process = new Process { StartInfo = startInfo };
        var result = process.Start();

        if (!result)
        {
            throw new InvalidOperationException("process cannot start.");
        }

        await process.WaitForExitAsync();
    }

    private const string SourceTypes1Ans = @"/* THIS (.ts) FILE IS GENERATED BY Tapper */
/* eslint-disable */
/* tslint:disable */

/** Transpiled from Tapper.Tests.AsmReference.SourceTypes1.Class1 */
export type Class1 = {
    /** Transpiled from System.DateTime */
    dateTime: (Date | string);
    /** Transpiled from byte[] */
    data: string;
}

";

    private const string SourceTypes2Ans = @"/* THIS (.ts) FILE IS GENERATED BY Tapper */
/* eslint-disable */
/* tslint:disable */

/** Transpiled from Tapper.Tests.AsmReference.SourceTypes2.Class2 */
export type Class2 = {
    /** Transpiled from int */
    value: number;
    /** Transpiled from string */
    name: string;
    /** Transpiled from string? */
    name2?: string;
    /** Transpiled from System.Guid */
    id: string;
}

/** Transpiled from Tapper.Tests.AsmReference.SourceTypes2.NestedTypeParentRequest */
export type NestedTypeParentRequest = {
    /** Transpiled from System.Collections.Generic.IReadOnlyList<Tapper.Tests.AsmReference.SourceTypes2.NestedTypeParentRequest.NestedTypeNestedTypeParentRequestItem> */
    items: NestedTypeNestedTypeParentRequestItem[];
}

/** Transpiled from Tapper.Tests.AsmReference.SourceTypes2.NestedTypeParentRequest.NestedTypeNestedTypeParentRequestItem */
export type NestedTypeNestedTypeParentRequestItem = {
    /** Transpiled from int */
    value: number;
    /** Transpiled from string? */
    message?: string;
}

";
}
