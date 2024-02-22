#ifndef STACK_H
#define STACK_H

#include "node.h"
#include <cstddef>

template <typename T>
class Stack
{
public:
    Node<T>* top;

    Stack(): top(nullptr) {}
    ~Stack();

    void push(const T value);
    T pop();
    bool is_empty() const;
    bool query(const T value, Node<T>** currentNode, Node<T>** previousNode) const;
    T* to_array(size_t& size) const;
};

#include "stack.cpp"

#endif