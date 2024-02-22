#include <iostream>
#include <vector>
#include "stack.h"

template <typename T>
void display_stacks(const Stack<T> &stack)
{
    if (stack.is_empty())
    {
        std::cout << "[]";
        return;
    }

    size_t size;
    auto *arr = stack.to_array(size);

    std::cout << "[ START -> ";
    for (size_t i = 0; i < size; i++)
    {
        bool isLastNode = i == size - 1;
        std::cout << arr[i];

        if (!isLastNode)
        {
            std::cout << " -> ";
        }
    }
    std::cout << " -> END]";

    delete[] arr;
}

int main()
{
    Stack<int> stack;

    std::cout << "Insert 1, 2, 3 and 4\n";

    stack.push(1);
    stack.push(2);
    stack.push(3);
    stack.push(4);

    display_stacks<int>(stack);

    std::cout << "\n\nRemove 3 elements\n";

    stack.pop();
    stack.pop();
    stack.pop();

    display_stacks<int>(stack);

    std::cout << "\n\nInsert 5, 6 and 7\n";

    stack.push(5);
    stack.push(6);
    stack.push(7);

    display_stacks<int>(stack);

    std::cout << "\n\nRemove 2 elements\n";

    stack.pop();
    stack.pop();

    display_stacks<int>(stack);
}
