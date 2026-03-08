$projects = Get-ChildItem -Path "c:\Users\ifegw\alu-csharp-1\csharp-tdd", "c:\Users\ifegw\alu-csharp-1\csharp-inheritance" -Recurse -Filter *.csproj
foreach ($proj in $projects) {
    [xml]$xml = Get-Content $proj.FullName
    
    # Change TargetFramework to netcoreapp2.1
    $tf = $xml.SelectSingleNode("//TargetFramework")
    if ($tf) {
        $tf.InnerText = "netcoreapp2.1"
    }

    # Remove ImplicitUsings and Nullable
    $implicitUsings = $xml.SelectNodes("//ImplicitUsings")
    foreach ($node in $implicitUsings) { $node.ParentNode.RemoveChild($node) | Out-Null }
    
    $nullable = $xml.SelectNodes("//Nullable")
    foreach ($node in $nullable) { $node.ParentNode.RemoveChild($node) | Out-Null }

    # Add DocumentationFile
    $docFile = $xml.SelectSingleNode("//DocumentationFile")
    if (-not $docFile) {
        $propGroup = $xml.SelectSingleNode("//PropertyGroup")
        if ($propGroup) {
            $docelm = $xml.CreateElement("DocumentationFile")
            $docelm.InnerText = "bin\`$(Configuration)\`$(TargetFramework)\`$(AssemblyName).xml"
            $propGroup.AppendChild($docelm) | Out-Null
        }
    }

    $xml.Save($proj.FullName)
}
