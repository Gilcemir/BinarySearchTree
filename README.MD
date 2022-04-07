# <center> BINARY SEARCH TREE (BST) </center>
    Simple implementation of a generic Binary Search Tree, which accepts repeated values.

## <center> Definition </center>
------------
> A binary Search Tree (BST) is a variant of a Binary Tree, which satisfies the following properties:

> - The value in each node must be greater than (in our case strictly) any values stored in its left subtree;
> - The value in each node must be less than (strictly) any values in its right subtree;

## <center> Remarks </center>
----------
> - Since a Binary Search Tree has comparison between values, this implementation only accepts objects T where T implements the Interface IComparable and IEquatable.
> - This BST accepts repeated values. It means that for every value T repeated in the tree, the TreeNode itself will store the number of occurrencies of the value T.

## <center> Constructors </center>
--------------
### BinarySearchTree()
    Initializes an empty BST.
### BinarySearchTree(T)
    Initializes a Tree with one element T.
### BinarySearchTree(T[])
    Initializes a Tree containing every element of an array of T.
### BinarySearchTree(IList\<T\>)
    Initializes a Tree containing every element of a collection that implements the Interface IList<T>.


## Properties
-------------
    This Binary Search Tree does not have any public property.

## <center> Methods </center>
-------------

### Length()
    This method return the number of nodes in the BST.

#### Parameters
    This Method takes no argument.
#### Returns

**int**

> Number of nodes in the BST
_______________
### Height()
    This method return the Height of the BST.

#### Parameters
    This Method takes no argument.
#### Returns
- **int**
> Return the height of the BST
_______________
### Search(T)
    Check if element T is present in the BST.

#### Parameters
- **T**
> Element **T** to be searched.
#### Returns
- **bool**
> Return if either the element T is present in the BST or not.
_______________
### Insert(T)
    This method insert element T in the BST.

#### Parameters
- **T**
> Element **T** to be inserted.
#### Returns
- **bool**
> Return true if element is inserted in the BST.
_______________
### Delete(T)
> This method deletes an instance of T in the BST.

#### Parameters
- **T**
> Element **T** to be inserted.
#### Returns
- **bool**
> Return true if element is deleted in the BST.
_______________
### Print()
    This method prints in the Console the BST by level.

#### Parameters
    This Method takes no argument.
#### Returns
    This method has no return;