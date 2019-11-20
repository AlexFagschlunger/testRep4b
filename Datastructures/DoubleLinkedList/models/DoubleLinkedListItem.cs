using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.models
{
    class DoubleLinkedListItem<T> where T : class
    {
        public T Item { get; set; }
        public DoubleLinkedListItem<T> BeforeItem { get; set; }
        public DoubleLinkedListItem<T> NextItem { get; set; }

        public DoubleLinkedListItem() : this(null, null, null) { }
        public DoubleLinkedListItem(T item, DoubleLinkedListItem<T> beforeItem, DoubleLinkedListItem<T> nextItem)
        {
            this.Item = item;
            this.BeforeItem = beforeItem;
            this.NextItem = nextItem;
        }

        public override string ToString()
        {
            return this.Item.ToString();
        }
    }
}
