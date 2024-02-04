#ifndef NODE_H
#define NODE_H

template <typename T>
class Node
{
public:
    Node(const T value);
    const T value;
    Node<T>* next;
};

#include "Node.cpp"

#endif
