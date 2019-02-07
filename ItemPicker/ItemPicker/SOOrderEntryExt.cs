using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PX.Common;
using PX.Data;
using PX.Objects.SO;

namespace ItemPicker
{
    public class SOOrderEntryExt : PXGraphExtension<SOOrderEntry>
    {

        #region Item Picker
        public PXFilter<ItemPickerFilter> itempickerfilter;
        //[PXPreview(typeof(ItemPickerFilter), typeof(ItemPickerSelected))]
        //[PXViewName("itempickerstatus")]
        [PXFilterable]
        [PXCopyPasteHiddenView]
        public ItemPickerLookup<ItemPickerSelected, ItemPickerFilter> itempickerstatus;

        public PXSelect<ItemPickerSelected, Where<ItemPickerSelected.productLineID, Equal<Current<ItemPickerSelected.productLineID>>, And <ItemPickerSelected.lineNbr, Equal<Current<ItemPickerSelected.lineNbr>>>>> itempickerCurrentLine;

        public PXAction<SOOrder> itemPicker;
        [PXUIField(DisplayName = "ITEM PICKER")]
        [PXLookupButton]
        protected virtual IEnumerable ItemPicker(PXAdapter adapter)
        {
            itempickerfilter.Cache.Clear();
            if (itempickerstatus.AskExt() == WebDialogResult.OK)
            {
                return AddInvSelBySiteItemPicker(adapter);
            }
            itempickerfilter.Cache.Clear();
            itempickerstatus.Cache.Clear();
            return adapter.Get();
        }

        public PXAction<SOOrder> addInvSelBySiteItemPicker;
        [PXUIField(DisplayName = "ADD", MapEnableRights = PXCacheRights.Select, MapViewRights = PXCacheRights.Select, Visible = false)]
        [PXLookupButton]
        public virtual IEnumerable AddInvSelBySiteItemPicker(PXAdapter adapter)
        {
            foreach (ItemPickerSelected line in itempickerstatus.Cache.Cached)
            {
                if (line.Selected == true && line.QtySelected > 0)
                {
                    SOLine newline = PXCache<SOLine>.CreateCopy(Base.Transactions.Insert(new SOLine()));
                    newline.SiteID = line.SiteID;
                    newline.InventoryID = line.InventoryID;
                    newline.SubItemID = line.SubItemID;
                    newline.UOM = line.SalesUnit;
                    newline.AlternateID = line.AlternateID;
                    newline = PXCache<SOLine>.CreateCopy(Base.Transactions.Update(newline));
                    if (newline.RequireLocation != true)
                        newline.LocationID = null;
                    newline = PXCache<SOLine>.CreateCopy(Base.Transactions.Update(newline));
                    newline.Qty = line.QtySelected;
                    // cnt = 0;
                    Base.Transactions.Update(newline);
                }
            }
            itempickerstatus.Cache.Clear();
            return adapter.Get();
        }
        protected virtual void ItemPickerFilter_RowSelected(PXCache cache, PXRowSelectedEventArgs e)
        {
            ItemPickerFilter row = (ItemPickerFilter)e.Row;
            if (row == null) return;

            itempickerstatus.OnChooserFilterRowSelected <SOOrderEntry> (Base, cache, row);
        }
        protected virtual void ItemPickerSelected_RowSelecting(PXCache sender, PXRowSelectingEventArgs e)
        {
            ItemPickerSelected cs = e.Row as ItemPickerSelected;
            if ((cs == null) || (cs.ProductLineID == null)) return;

            itempickerstatus.GetUnboundValuesSelectedOnRowSelecting<SOOrderEntry>(Base, cs);
        }
        #endregion

        #region Event Handlers
        protected virtual void SOOrder_RowSelected(PXCache cache, PXRowSelectedEventArgs e)
        {
            itemPicker.SetEnabled(Base.Transactions.Cache.AllowInsert);
        }
        #endregion
    }
}