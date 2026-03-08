mkdir csharp-inheritance -ErrorAction SilentlyContinue | Out-Null
cd csharp-inheritance

function Setup-Project {
    param([string]$taskdir, [string]$projName)
    mkdir $taskdir -ErrorAction SilentlyContinue | Out-Null
    cd $taskdir
    dotnet new console -n $projName -f net7.0 --force
    rm Program.cs -ErrorAction SilentlyContinue
    cd ..
}

Setup-Project 0-is 0-is
Setup-Project 1-instance 1-instance
Setup-Project 2-subclass 2-subclass
Setup-Project 3-type_get 3-type_get
Setup-Project 4-inherit 4-inherit
Setup-Project 5-shape 5-shape
Setup-Project 6-shape 6-shape
Setup-Project 7-shape 7-shape
Setup-Project 8-shape 8-shape
Setup-Project 9-shape 9-shape
