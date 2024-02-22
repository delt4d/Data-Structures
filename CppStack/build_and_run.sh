#!/bin/bash

mkdir -p build
cd build

cmake ..
cmake --build .

if [ "$(uname)" == "linux" ]; then
    clear
    ./CppStack
else
    echo "This script is intended for linux
fi