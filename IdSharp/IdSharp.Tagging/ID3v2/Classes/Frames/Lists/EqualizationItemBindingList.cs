using System.Collections.Generic;
using System.ComponentModel;
using IdSharp.Tagging.ID3v2.Frames.Items;

namespace IdSharp.Tagging.ID3v2.Frames.Lists
{
    internal sealed class EqualizationItemBindingList : BindingList<IEqualizationItem>
    {
        public EqualizationItemBindingList()
        {
            AllowNew = true;
        }

        public EqualizationItemBindingList(IList<IEqualizationItem> equalizationItemList)
            : base(equalizationItemList)
        {
            AllowNew = true;
        }

        protected override object AddNewCore()
        {
            IEqualizationItem equalizationItem = new EqualizationItem();
            Add(equalizationItem);

            // Not necessary to hook up event handlers, base class calls InsertItem

            return equalizationItem;
        }

        protected override void InsertItem(int index, IEqualizationItem item)
        {
            //item.DescriptionChanging += new EventHandler<CancelDataEventArgs<String>>(AttachedPicture_DescriptionChanging);
            //item.PictureTypeChanging += new EventHandler<CancelDataEventArgs<PictureType>>(AttachedPicture_PictureTypeChanging);

            base.InsertItem(index, item);
        }
    }
}
