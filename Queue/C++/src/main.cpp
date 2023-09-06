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

int main() {
    auto queue = Queue<int>();
    bool stop = false;

    while (!stop) {
        display_queues(queue);

        std::cout << "1) Enqueue\n";
        std::cout << "2) Dequeue\n";
        std::cout << "3) Exit\n:";

        int option;
        std::cin >> option;

        switch (option) {
            case 1:
                int value;
                std::cin >> value;
                queue.enqueue(value);
                break;
            case 2:
                std::cout << queue.dequeue() << std::endl;
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
