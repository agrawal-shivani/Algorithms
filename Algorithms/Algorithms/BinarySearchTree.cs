using Algorithms.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class BinarySearchTree<T> : IEnumerable<T>
    {
        private BinaryTreeNode<T> _root;

        public BinarySearchTree()
        {
        }

        public BinarySearchTree(T data)
        {
            throw new NotImplementedException();
        }

        public BinarySearchTree(BinaryTreeNode<T> root)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty => _root == null;

        public bool Contains(T data)
        {
            throw new NotImplementedException();
        }

        public void Insert(T data)
        {
            throw new NotImplementedException();
        }

        public void Remove(T data)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (_root == null)
            {
                return Enumerable.Empty<T>().GetEnumerator();
            }
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}