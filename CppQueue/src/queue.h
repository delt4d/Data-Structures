#ifndef QUEUE_H
#define QUEUE_H

#include "node.h"
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
    bool is_empty() const;
    bool query(const T value, Node<T>** current, Node<T>** previousNode) const;
    T* to_array(size_t& size) const;
    T dequeue();
};

#include "queue.cpp"

#endif