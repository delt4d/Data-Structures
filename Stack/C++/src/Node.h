#ifndef C___NODE_H
#define C___NODE_H

template <typename T>
class Node
{
public:
    const T value;
    Node<T>* next;
    Node(const T value);
};

#include "Node.cpp"

#endif //C___NODE_H
