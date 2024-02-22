@echo off

if not exist .\build (
    mkdir build
    cd build
    cmake ..
    cd ..
)

cmake --build .\build

if exist .\build\Debug\CppQueue.exe (
    cls
    .\build\Debug\CppQueue.exe
) else (
    echo Project executable not found
)