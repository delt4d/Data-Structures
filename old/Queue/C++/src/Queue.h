#ifndef QUEUE_H
#define QUEUE_H

#include "Node.h"
#include <cstddef>

template <typename T>
class Queue
{
public:
    Node<T>* start;
    Node<T>* end;
    Queue(): start(nullptr), end(nullptr) {}
    ~Queue();
    void enqueue(const T value);
    bool is_empty();
    bool query(const T value, Node<T>** currentNode, Node<T>** previousNode) const;
    T* toArray(size_t& size) const;
    T dequeue();
};

#include "Queue.cpp"

#endif