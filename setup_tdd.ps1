mkdir csharp-tdd -ErrorAction SilentlyContinue | Out-Null
cd csharp-tdd

function Setup-Project {
    param([string]$taskdir, [string]$sln, [string]$lib, [string]$test)
    mkdir $taskdir -ErrorAction SilentlyContinue | Out-Null
    cd $taskdir
    dotnet new sln -n $sln
    dotnet new classlib -n $lib
    dotnet new nunit -n $test
    dotnet sln add $lib/$lib.csproj
    dotnet sln add $test/$test.csproj
    dotnet add $test/$test.csproj reference $lib/$lib.csproj
    rm $lib/Class1.cs -ErrorAction SilentlyContinue
    rm $test/UnitTest1.cs -ErrorAction SilentlyContinue
    cd ..
}

Setup-Project 0-add 0-add MyMath MyMath.Tests
Setup-Project 1-divide 1-divide MyMath MyMath.Tests
Setup-Project 2-max_int 2-max_int MyMath MyMath.Tests
Setup-Project 3-palindrome 3-palindrome Text Text.Tests
Setup-Project 4-unique 4-unique Text Text.Tests
Setup-Project 5-camelcase 5-camelcase Text Text.Tests
