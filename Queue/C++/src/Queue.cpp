#ifndef QUEUE_C
#define QUEUE_C

#include "Queue.h"
#include "Node.h"

template <typename T>
Queue<T>::~Queue() {
    Node<T>* current = start;

    while (current != nullptr) {
        Node<T>* next_node = current->next;
        delete current;
        current = next_node;
    }
}

template <typename T>
void Queue<T>::enqueue(const T value) {
    auto* new_node = new Node<T>(value);

    if (is_empty()) {
        start = new_node;
        end = new_node;
        return;
    }

    end->next = new_node;
    end = new_node;
}

template <typename T>
T Queue<T>::dequeue() {
    if (!is_empty()) {
        auto removed_node = start->value;

        if (start == end) {
            start = nullptr;
            end = nullptr;
        } else start = start->next;

        return removed_node;
    }

    return T{};
}

template <typename T>
bool Queue<T>::is_empty() {
    return start == nullptr || end == nullptr;
}

template <typename T>
bool Queue<T>::query(const T value, Node<T>* currentNode, Node<T>* previousNode) {
    currentNode = start;

    while (currentNode != nullptr) {
        if (currentNode->value == value) {
            return true;
        }

        previousNode = currentNode;
        currentNode = currentNode->next;
    }

    return false;
}

template <typename T>
T* Queue<T>::toArray(size_t& size) const {
    size = 0;
    Node<T>* current = top;

    while (current != nullptr)
    {
        size++;
        current = current->next;
    }

    T* values = new T[size];
    current = top;
    int index = 0;

    while (current != nullptr)
    {
        values[index] = current->value;
        index++;
        current = current->next;
    }

    return values;
}

#endif
