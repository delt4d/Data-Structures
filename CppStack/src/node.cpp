#ifndef NODE_CPP
#define NODE_CPP

#include "node.h"

template <typename T>
Node<T>::Node(const T value) : value(value), next(nullptr) {}

#endif