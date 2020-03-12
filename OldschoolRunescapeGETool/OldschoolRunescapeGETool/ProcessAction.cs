using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldschoolRunescapeGETool
{
    class ProcessAction
    {
        public Item BaseItem { get; private set; }
        public Item TargetItem { get; private set; }
        public int ProcessingCost { get; private set; }

        public ProcessAction(Item bBaseItem, Item bTargetItem, int bProcessingCost)
        {
            BaseItem = bBaseItem;
            TargetItem = bTargetItem;
            ProcessingCost = bProcessingCost;
        }

        public int GetProcessProfit()
        {
            int targetItemCost;
            int baseItemCost;
            switch(TargetItem.current.price[TargetItem.current.price.Length - 1])
            {
                case 'k':
                    targetItemCost = Convert.ToInt32(TargetItem.current.price.Remove(TargetItem.current.price.Length - 1));
                    targetItemCost *= 1000000;
                    break;

                case 'm':
                    targetItemCost = Convert.ToInt32(TargetItem.current.price.Remove(TargetItem.current.price.Length - 1));
                    targetItemCost *= 1000;
                    break;

                default:
                    targetItemCost = Convert.ToInt32(TargetItem.current.price);
                    break;
            }

            switch (TargetItem.current.price[TargetItem.current.price.Length - 1])
            {
                case 'k':
                    baseItemCost = Convert.ToInt32(TargetItem.current.price.Remove(BaseItem.current.price.Length - 1));
                    baseItemCost *= 1000;
                    break;

                case 'm':
                    baseItemCost = Convert.ToInt32(TargetItem.current.price.Remove(BaseItem.current.price.Length - 1));
                    baseItemCost *= 1000000;
                    break;

                default:
                    baseItemCost = Convert.ToInt32(BaseItem.current.price);
                    break;
            }

            return targetItemCost - baseItemCost - ProcessingCost;
        }

        public override string ToString()
        {
            return (BaseItem.name + " -> " + TargetItem.name);
        }
    }
}
