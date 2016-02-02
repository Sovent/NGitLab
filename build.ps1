Task default -Depends Compile, Tests

properties {
  $path = ".\NGitLab\NGitLab.sln"
  $thisVersion = $version
}

Task Compile -Depends Restore {
	msbuild $path /t:Build /p:Configuration=Debug /verbosity:minimal

	if ($lastexitcode -ne 0) {
    	throw "Compilation failed"
	}
}

Task Restore {
	NuGet.exe restore $path
}

Task Clear {
	Get-ChildItem .\ -include bin,obj -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse }
    Remove-Item *.nupkg
    Remove-Item *TestResult.xml
}

Task Tests {
    # currently only with a running vm :( 
    # if you have an idea for a proper tests, please issue a pull request
	.\NGitLab\packages\NUnit.Runners.2.6.4\tools\nunit-console.exe .\NGitLab\NGitLab.Tests\NGitLab.Tests.csproj /config=Debug /framework=4.6 /Output=foo.xml /trace=Verbose /timeout=10000
}

Task Pack {
    $specs = @("NGitLab")

    Foreach ($spec in $specs){
    	# override version number
    	$tempFileName = $spec + "_temp.nuspec"
        $originalFileName = $spec + ".nuspec"

    	Copy-Item $originalFileName $tempFileName
    	$tempFile = gi $tempFileName

    	[xml] $spec = gc $tempFileName
        $spec.package.metadata.version = $thisVersion
        Write-Host $tempFile
        $spec.Save($tempFile.FullName)

        # run packaging
        NuGet.exe pack $tempFile.FullName -Verbosity normal
        
        # remove temp nuspec
        ri $tempFile.FullName
    }
}