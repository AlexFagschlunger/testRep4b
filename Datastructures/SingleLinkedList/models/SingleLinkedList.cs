using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedList.models
{
    class SingleLinkedList<T> where T : class
    {
        private SingleLinkedListItem<T> _firstItem;
        private SingleLinkedListItem<T> _lastItem;

        public SingleLinkedList()
        {
            this._firstItem = null;
            this._lastItem = null;
        }
        public SingleLinkedList(T item)
        {
            this._firstItem = new SingleLinkedListItem<T>(item, null);
            this._lastItem = _firstItem;
        }
        public SingleLinkedList(SingleLinkedList<T> list)
        {
            this._firstItem = list._firstItem;
            this._lastItem = list._lastItem;
        }

        // Methode Add
        public bool Add(T itemToAdd)
        {
            // 1. Parameter überprüfen
            if (itemToAdd == null)
            {
                return false;
            }

            // 1. Fall: die SLL ist leer
            if (this._firstItem == null)
            {
                this._firstItem = new SingleLinkedListItem<T>(itemToAdd, null);
                this._lastItem = this._firstItem;
            }
            // 2. Fall: die SLL ist nicht leer
            else
            {
                this._lastItem.NextItem = new SingleLinkedListItem<T>(itemToAdd, null);
                this._lastItem = this._lastItem.NextItem;
            }
            return true;
        }

        internal void FindItemBeforeItemToFind(Person p, out object isStartItem)
        {
            throw new NotImplementedException();
        }

        public bool AddAfter(T itemToAdd, T itemToFind)
        {
            if (itemToAdd == null)
            {
                return false;
            }

            SingleLinkedListItem<T> actItem = this._firstItem;
            do
            {
                if (actItem.Item.Equals(itemToFind))
                {
                    actItem.NextItem = new SingleLinkedListItem<T>(itemToAdd, actItem.NextItem);
                    actItem = actItem.NextItem;
                }
                else
                {
                    Add(itemToAdd);
                }
            } while (actItem == this._lastItem);
            return true;
        }

        public bool Remove(T itemToRemove)
        {
            if (itemToRemove == null)
            {
                return false;
            }
            // es existiert noch kein Eintrag in der Liste
            if (this._firstItem == null)
            {
                return false;
            }

            bool isFirstItem;
            SingleLinkedListItem<T> itemBeforeItemToRemove = this.FindItemBeforeItemToFind(itemToRemove, out isFirstItem);
            // 1. Fall: 1. Eintag
            // 1. Eintrag ist der gesuchte Eintrag
            if ((itemBeforeItemToRemove == null) && !isFirstItem)
            {
                return false;
            }
            if (isFirstItem)
            {
                this._firstItem = this._firstItem.NextItem;
                return true;
            }
            // 2. Fall:  es handelt sich um den letzten Eintrag
            SingleLinkedListItem<T> actItem = this._firstItem;
            if (itemBeforeItemToRemove.NextItem.NextItem == null)
            {
                this._lastItem = itemBeforeItemToRemove;
                this._lastItem.NextItem = null;
                return true;
            }
            // 3. Fall: irgentwo zwischen _firstItem und _lastItem
            else
            {
                itemBeforeItemToRemove.NextItem = itemBeforeItemToRemove.NextItem.NextItem;
                return true;
            }
        }
        
        public bool ChangeItem(T itemToChange, T itemNewData)
        {
            if(itemToChange == null)
            {
                return false;
            }
            if(itemNewData == null)
            {
                return false;
            }
            if(this._firstItem == null)
            {
                return false;
            }
            SingleLinkedListItem<T> foundItem = Find(itemToChange);
            // Item ist nicht vorhanden
            if (foundItem == null)
            {
                return false;
            }
            else
            {
                foundItem.Item = itemNewData;
                return true;
            }
        }

        public SingleLinkedListItem<T> Find(T itemToFind)
        {
            if(itemToFind == null)
            {
                return null;
            }
            if (this._firstItem == null)
            {
                return null;
            }
            SingleLinkedListItem<T> actItem = this._firstItem;
            while (actItem != null)
            {
                if (actItem.Item.Equals(itemToFind))
                {
                    return actItem;
                }
                actItem = actItem.NextItem;
            };
            return null;
        }

        public SingleLinkedListItem<T> FindItemBeforeItemToFind(T itemToFind, out bool isStartItem)
        {
            isStartItem = false;
            if(itemToFind == null)
            {
                return null;
            }
            if(this._firstItem == null)
            {
                return null;
            }
            if (this._firstItem.Item.Equals(itemToFind))
            {
                isStartItem = true;
                return null;
            }

            SingleLinkedListItem<T> actItem = this._firstItem;
            while(actItem != null)
            {
                if((actItem.NextItem != null) && (actItem.NextItem.Item.Equals(itemToFind)))
                {
                    return actItem;
                }
                actItem = actItem.NextItem;
            };
            return null;
        }

        public override string ToString()
        {
            string s = "";
            if (this._firstItem != null)
            {
                SingleLinkedListItem<T> actItem = this._firstItem;
                while (actItem != null)
                {
                    s += actItem.Item.ToString() + "\n";
                    actItem = actItem.NextItem;
                }
            }
            if (s == "")
            {
                return "no item";
            }

            return s;
        }
        
    }
}

   

