﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> leftNode;
        public Node<T> rightNode;

        public Node(T data)
        {
            Data = data;
        }
    }
}
