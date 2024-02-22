@echo off

if not exist .\build (
    mkdir build
    cd build
    cmake ..
    cd ..
)

cmake --build .\build

if exist .\build\Debug\CppStack.exe (
    cls
    .\build\Debug\CppStack.exe
) else (
    echo Project executable not found
)