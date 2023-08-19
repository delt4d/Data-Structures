#include "Stack.h"
#include <iostream>
#include <vector>

template <typename T>
void displayStock(const Stack<T>& stack) {
    size_t size;
    int *array = stack.toArray(size);

    std::cout << "STACK [";
    for (size_t i=0; i < size; i++) {
        std::cout << array[i] << (i == size - 1 ? "" : ", ");
    }
    std::cout << "]\n";

    delete [] array;
}

int main(int argc, char* argv[])
{
    auto stack = Stack<int>();
    bool stop = false;

    while (!stop) {
        displayStock(stack);

        std::cout << "1) Push\n";
        std::cout << "2) Pop\n";
        std::cout << "3) Exit\n:";

        int option;
        std::cin >> option;

        switch (option) {
            case 1:
                int value;
                std::cin >> value;
                stack.push(value);
                break;
            case 2:
                std::cout << stack.pop() << std::endl;
                break;
            case 3:
                stop = true;
                break;
            default:
                std::cout << "Invalid option\n";
                break;
        }

        std::cout << std::endl;
    }

    return 0;
}
