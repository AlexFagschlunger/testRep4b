using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree.models
{
    class BinaryTreeItem
    {
        public int item { get; set; }
        public int Count { get; set; }
        public BinaryTreeItem rightItem { get; set; }
        public BinaryTreeItem leftItem { get; set; }

        public BinaryTreeItem() : this(0, 0, null, null) { }
        public BinaryTreeItem(int Item, int count, BinaryTreeItem RightItem, BinaryTreeItem LeftItem)
        {
            this.item = Item;
            this.Count = count;
            this.rightItem = RightItem;
            this.leftItem = LeftItem;
        }

        public override string ToString()
        {
            return this.item.ToString();
        }

    }
}
