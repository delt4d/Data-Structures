#ifndef STACK_H
#define STACK_H

#include <cstdio>
#include "Node.h"

template <typename T>
class Stack
{
public:
    Node<T>* top;
    ~Stack();
    Stack() : top(nullptr) {}
    void push(const T value);
    T* toArray(size_t& size) const;
    T pop();
};

#include "stack.cpp" // Include template implementation

#endif // STACK_H
