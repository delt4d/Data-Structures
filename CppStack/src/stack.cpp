#ifndef STACK_CPP
#define STACK_CPP

#include "stack.h"
#include "node.h"
#include <cstddef>

template <typename T>
Stack<T>::~Stack()
{
    Node<T> *current = top;

    while (top != nullptr)
    {
        Node<T> *next_node = current->next;
        delete current;
        current = next_node;
    }
};

template <typename T>
void Stack<T>::push(const T value)
{
    Node<T> *new_node = new Node<T>(value);

    if (top != nullptr)
        new_node->next = top;

    top = new_node;
}

template <typename T>
T Stack<T>::pop()
{
    if (!is_empty())
    {
        T value = top->value;
        top = top->next;
        return value;
    }

    return T();
}

template <typename T>
bool Stack<T>::is_empty() const
{
    return top == nullptr;
}

template <typename T>
bool Stack<T>::query(const T value, Node<T> **currentNode, Node<T> **previousNode) const
{
    *currentNode = start;
    *previousNode = nullptr;

    while (*currentNode != nullptr)
    {
        if ((*currentNode)->value == value)
        {
            return true;
        }

        *previousNode = *currentNode;
        *currentNode = (*currentNode)->next;
    }

    return false;
}

template <typename T>
T *Stack<T>::to_array(size_t &size) const
{
    size = 0;
    Node<T> *current = top;

    while (current != nullptr)
    {
        size++;
        current = current->next;
    }

    T *values = new T[size];
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
