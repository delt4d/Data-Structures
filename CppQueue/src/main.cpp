#include <iostream>
#include <vector>
#include "queue.h"

template <typename T>
void display_queues(const Queue<T> &queue)
{
    if (queue.is_empty())
    {
        std::cout << "[]";
        return;
    }

    size_t size;
    auto *arr = queue.to_array(size);

    std::cout << "[ START -> ";
    for (size_t i=0; i<size; i++)
    {
        bool isLastNode = i == size-1;
        std::cout << arr[i];

        if (!isLastNode)
        {
            std::cout << " -> ";
        }
    }
    std::cout << " -> END]";

    delete [] arr;
}

int main() {
    Queue<int> queue;

    std::cout << "Insert 1, 2, 3 and 4\n";
    
    queue.enqueue(1);
    queue.enqueue(2);
    queue.enqueue(3);
    queue.enqueue(4);

    display_queues<int>(queue);

    std::cout << "\n\nRemove 3 elements\n";
    
    queue.dequeue();
    queue.dequeue();
    queue.dequeue();

    display_queues<int>(queue);

    std::cout << "\n\nInsert 5, 6 and 7\n";
    
    queue.enqueue(5);
    queue.enqueue(6);
    queue.enqueue(7);

    display_queues<int>(queue);

    std::cout << "\n\nRemove 2 elements\n";

    queue.dequeue();
    queue.dequeue();

    display_queues<int>(queue);
}
