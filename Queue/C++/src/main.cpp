#include <iostream>
#include <vector>
#include "Queue.h"

template <typename T>
void display_queues(const Queue<T>& queue) {
    size_t size;
    int *array = queue.toArray(size);

    std::cout << "QUEUE [";
    for (size_t i=0; i < size; i++) {
        std::cout << array[i] << (i == size - 1 ? "" : ", ");
    }
    std::cout << "]\n";

    delete [] array;
}

template <typename T>
void query(const Queue<T>& queue, T value) {
    Node<T>* currentNode = nullptr;
    Node<T>* previousNode = nullptr;

    bool found = queue.query(value, &currentNode, &previousNode);

    std::cout << "FOUND: " << (found ? "YES" : "NO") << std::endl;
    
    if (found == true) {
        std::cout << "FOUND NODE: " << currentNode->value << "\n";
        if (previousNode != nullptr) std::cout << "PREVIOUS NODE: " << previousNode->value << "\n";
    }
}

int main() {
    auto queue = Queue<int>();
    bool stop = false;

    while (!stop) {
        display_queues(queue);

        std::cout << "1) Enqueue\n";
        std::cout << "2) Dequeue\n";
        std::cout << "3) Find\n";
        std::cout << "4) Exit\n:";

        int option, value;
        std::cin >> option;

        switch (option) {
            case 1:
                std::cin >> value;
                queue.enqueue(value);
                break;
            case 2:
                std::cout << queue.dequeue() << std::endl;
                break;
            case 3:
                std::cin >> value;
                query(queue, value);
                break;
            case 4:
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
