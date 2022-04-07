### BINARY SEARCH TREE (BST)
    Simple implementation of a generic Binary Search Tree, which accepts repeated values.

## Definition
------------
> A binary Search Tree (BST) is a variant of a Binary Tree, which satisfies the following properties:

> - The value in each node must be greater than (in our case strictly) any values stored in its left subtree;
> - The value in each node must be less than (strictly) any values in its right subtree;

## Remarks
----------
> - Since a Binary Search Tree has comparison between values, this implementation only accepts objects T where T implements the Interface IComparable and IEquatable.
> - This BST accepts repeated values. It means that for every value T repeated in the tree, the TreeNode itself will store the number of occurrencies of the value T.