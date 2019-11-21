using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree.models
{

    class BinaryTree
    {
        public int counter { get; private set; }

        public void increaseCounter()
        {
            // Hallo
            this.counter++;
            counter = counter + 6;
            counter = 5;
            counter = counter * 2;
            // Fabi
            // Hokzi
        }
        private BinaryTreeItem _root;

        public BinaryTree()
        {
            this._root = null;
        }
        public BinaryTree(int Item)
        {
            this._root = new BinaryTreeItem(Item, 0, null, null);
        }
        public BinaryTree(BinaryTree bt)
        {
            this._root = bt._root;
        }

        public bool Add(int itemToAdd)
        {
            if (this._root == null)
            {
                this._root = new BinaryTreeItem(itemToAdd, 1, null, null);
                increaseCounter();
                return true;
            }
            else
            {
                BinaryTreeItem actItem = this._root;
                while (actItem != null)
                {
                    if (itemToAdd > actItem.item)
                    {
                        if (actItem.rightItem == null)
                        {
                            actItem.rightItem = new BinaryTreeItem(itemToAdd, 0, null, null);
                            increaseCounter();
                            return true;
                        }
                        actItem = actItem.rightItem;

                    }
                    else if (itemToAdd < actItem.item)
                    {
                        if (actItem.leftItem == null)
                        {
                            actItem.leftItem = new BinaryTreeItem(itemToAdd, 0, null, null);
                            increaseCounter();
                            return true;
                        }
                        actItem = actItem.leftItem;
                    }
                    else
                    {
                        increaseCounter();
                        actItem.Count = actItem.Count + 1;
                        return true;
                    }
                }
                return false;
            }
        }
        public BinaryTreeItem Find(int itemToFind)
        {
            if (itemToFind == 0)
            {
                return null;
            }
            BinaryTreeItem actItem = this._root;
            while (actItem != null)
            {
                if (itemToFind > actItem.item)
                {
                    actItem = actItem.rightItem;
                }
                else if (itemToFind < actItem.item)
                {
                    actItem = actItem.leftItem;
                }
                else
                {
                    return actItem;
                }
            }
            return null;
        }

        public BinaryTreeItem FindMin(int searchFrom = 0)
        {
            if (searchFrom == 0)
            {
                BinaryTreeItem actItem = this._root;
                while (actItem != null)
                {
                    if (actItem.leftItem == null)
                    {
                        return actItem;
                    }
                    actItem = actItem.leftItem;
                }
            }
            else
            {
                BinaryTreeItem actItem = Find(searchFrom);
                while (actItem != null)
                {
                    if (actItem.leftItem == null)
                    {
                        return actItem;
                    }
                    actItem = actItem.leftItem;
                }
            }
            return null;
        }

        public BinaryTreeItem FindMax(int searchFrom = 0)
        {
            if (searchFrom == 0)
            {
                BinaryTreeItem actItem = this._root;
                while (actItem != null)
                {
                    if (actItem.rightItem == null)
                    {
                        return actItem;
                    }
                    actItem = actItem.rightItem;
                }
            }
            else
            {
                BinaryTreeItem actItem = Find(searchFrom);
                while (actItem != null)
                {
                    if (actItem.rightItem == null)
                    {
                        return actItem;
                    }
                    actItem = actItem.rightItem;
                }
            }
            return null;
        }

        public BinaryTreeItem FindMaxRecursiv(int searchItem = 0, BinaryTreeItem actItem = null)
        {
            if (this._root == null)
            {
                return null;
            }
            if ((searchItem == 0) && (actItem == null))
            {
                actItem = this._root;
            }
            if (actItem == null)
            {
                actItem = Find(searchItem);
            }
            if (actItem.rightItem == null)
            {
                return actItem;
            }
            else
            {
                actItem = actItem.rightItem;
                return FindMaxRecursiv(searchItem, actItem);
            }
        }

        public BinaryTreeItem FindMinRecursiv(int searchItem = 0, BinaryTreeItem actItem = null)
        {
            if (this._root == null)
            {
                return null;
            }
            if ((searchItem == 0) && (actItem == null))
            {
                actItem = this._root;
            }
            if (actItem == null)
            {
                actItem = Find(searchItem);
            }
            if (actItem.leftItem == null)
            {
                return actItem;
            }
            else
            {
                actItem = actItem.leftItem;
                return FindMinRecursiv(searchItem, actItem);
            }
        }

        public BinaryTreeItem FindRecursiv(int itemToFind, BinaryTreeItem actItem = null)
        {
            if (this._root == null)
            {
                return null;
            }
            if (actItem == null)
            {
                actItem = this._root;
            }
            if (itemToFind > actItem.item)
            {
                actItem = actItem.rightItem;
            }
            else if (itemToFind < actItem.item)
            {
                actItem = actItem.leftItem;
            }
            else
            {
                return actItem;

            }
            return FindRecursiv(itemToFind, actItem);
        }

        public bool AddRekursiv(int itemToAdd, BinaryTreeItem actItem = null)
        {
            if (_root == null)
            {
                this._root = new BinaryTreeItem(itemToAdd, 1, null, null);
                increaseCounter();
                return true;
            }

            if (actItem == null)
            {
                actItem = _root;
            }

            if (itemToAdd > actItem.item)
            {
                if (actItem.rightItem == null)
                {
                    actItem.rightItem = new BinaryTreeItem(itemToAdd, 1, null, null);
                    increaseCounter();
                    return true;
                }
                actItem = actItem.rightItem;
            }
            else if (itemToAdd < actItem.item)
            {
                if (actItem.leftItem == null)
                {
                    actItem.leftItem = new BinaryTreeItem(itemToAdd, 1, null, null);
                    increaseCounter();
                    return true;
                }
                actItem = actItem.leftItem;
            }
            else
            {
                actItem.Count = actItem.Count + 1;
                increaseCounter();
                return true;
            }
            return AddRekursiv(itemToAdd, actItem);
        }

        public BinaryTreeItem FindItemBeforeItemToFind(int itemToFind)
        {
            if (itemToFind == 0)
            {
                return null;
            }
            BinaryTreeItem actItem = this._root;
            while (this._root != null)
            {
                if (itemToFind > actItem.item)
                {
                    if (itemToFind.Equals(actItem.rightItem.item))
                    {
                        return actItem;
                    }
                    actItem = actItem.rightItem;
                }
                else if (itemToFind < actItem.item)
                {
                    if (itemToFind.Equals(actItem.leftItem.item))
                    {
                        return actItem;
                    }
                    actItem = actItem.leftItem;
                }

            }
            return null;
        }

        public bool Remove(int itemToRemove)
        {
            //Fall a
            BinaryTreeItem actItem = Find(itemToRemove);
            if (actItem.Equals(_root))
            {
                return false;
            }
            BinaryTreeItem BeforeActItem = FindItemBeforeItemToFind(itemToRemove);
            if (actItem.leftItem == null)
            {
                if (actItem.item > BeforeActItem.item)
                {
                    BeforeActItem.rightItem = actItem.rightItem;
                    return true;
                }
                if (actItem.item < BeforeActItem.item)
                {
                    BeforeActItem.leftItem = actItem.rightItem;
                    return true;
                }
            }
            else if (actItem.rightItem == null)
            {
                if (actItem.item > BeforeActItem.item)
                {
                    BeforeActItem.rightItem = actItem.leftItem;
                    return true;
                }
                if (actItem.item < BeforeActItem.item)
                {
                    BeforeActItem.leftItem = actItem.leftItem;
                    return true;
                }
            }
            // Fall C:
            else if(actItem.rightItem.leftItem == null)
            {
                if (actItem.item > BeforeActItem.item)
                {
                    BeforeActItem.rightItem = actItem.rightItem;
                    actItem.rightItem.leftItem = actItem.leftItem;
                    return true;
                }
                if (actItem.item < BeforeActItem.item)
                {
                    BeforeActItem.leftItem = actItem.rightItem;
                    actItem.rightItem.leftItem = actItem.leftItem;
                    return true;
                }
            }
            else if (actItem.leftItem.rightItem == null)
            {
                if (actItem.item > BeforeActItem.item)
                {
                    BeforeActItem.rightItem = actItem.leftItem;
                    actItem.leftItem.rightItem = actItem.rightItem;
                    return true;
                }
                if (actItem.item < BeforeActItem.item)
                {
                    BeforeActItem.leftItem = actItem.leftItem;
                    actItem.leftItem.rightItem = actItem.rightItem;
                    return true;
                }
            }
            // Fall D:
            else 
            {
                BinaryTreeItem minItem = FindMin(actItem.rightItem.item);
                BinaryTreeItem beforeMinItem = FindItemBeforeItemToFind(minItem.item);
                if (actItem.item > BeforeActItem.item)
                {
                    minItem.leftItem = actItem.leftItem;
                    beforeMinItem.leftItem = minItem.rightItem;
                    minItem.rightItem = actItem.rightItem;
                    BeforeActItem.rightItem = minItem;
                    return true;
                }
                if (actItem.item < BeforeActItem.item)
                {
                    minItem.leftItem = actItem.leftItem;
                    beforeMinItem.leftItem = minItem.rightItem;
                    minItem.rightItem = actItem.rightItem;
                    BeforeActItem.leftItem = minItem;
                    return true;
                }

            }

            return false;
        }
    }
}
    


