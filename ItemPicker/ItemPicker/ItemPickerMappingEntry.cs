using System;
using PX.Data;
using System.Linq;
using System.Collections.Generic;

namespace ItemPicker
{
    public class ItemPickerMappingEntry : PXGraph<ItemPickerMappingEntry, IIProductLine>
    {
        public PXSelect<IIProductLine> IIProductLines;

        public PXSelect<IIProductLine, Where<IIProductLine.productLineID, Equal<Current<IIProductLine.productLineID>>>> SelectedProductLine;

        [PXImport(typeof(IIProductLine))]
        public PXSelect<ItemPickerMapping, Where<ItemPickerMapping.productLineID, Equal<Current<IIProductLine.productLineID>>>, OrderBy<Asc<ItemPickerMapping.inventoryID>>> ItemPickerMappings;

        protected virtual void IIProductLine_RowSelected(PXCache sender, PXRowSelectedEventArgs e)
        {
            IIProductLine cfg = e.Row as IIProductLine;
            if ((cfg == null) || (cfg.ProductLineID == null)) return;

            PXResultset<IIProductLineFilter> rsFilters = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<IIProductLine.productLineID>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(this, cfg.ProductLineID);

            cfg.UnboundColumn1 = (rsFilters?.Count >= 1) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(0)?.FilterID : null;
            string unboundColumn1 = (rsFilters?.Count >= 1) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(0)?.Descr : null;
            cfg.UnboundColumn2 = (rsFilters?.Count >= 2) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(1)?.FilterID : null;
            string unboundColumn2 = (rsFilters?.Count >= 2) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(1)?.Descr : null;
            cfg.UnboundColumn3 = (rsFilters?.Count >= 3) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(2)?.FilterID : null;
            string unboundColumn3 = (rsFilters?.Count >= 3) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(2)?.Descr : null;
            cfg.UnboundColumn4 = (rsFilters?.Count >= 4) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(3)?.FilterID : null;
            string unboundColumn4 = (rsFilters?.Count >= 4) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(3)?.Descr : null;
            cfg.UnboundColumn5 = (rsFilters?.Count >= 5) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(4)?.FilterID : null;
            string unboundColumn5 = (rsFilters?.Count >= 5) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(4)?.Descr : null;
            cfg.UnboundColumn6 = (rsFilters?.Count >= 6) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(5)?.FilterID : null;
            string unboundColumn6 = (rsFilters?.Count >= 6) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(5)?.Descr : null;
            cfg.UnboundColumn7 = (rsFilters?.Count >= 7) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(6)?.FilterID : null;
            string unboundColumn7 = (rsFilters?.Count >= 7) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(6)?.Descr : null;
            cfg.UnboundColumn8 = (rsFilters?.Count >= 8) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(7)?.FilterID : null;
            string unboundColumn8 = (rsFilters?.Count >= 8) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(7)?.Descr : null;
            cfg.UnboundColumn9 = (rsFilters?.Count >= 9) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(8)?.FilterID : null;
            string unboundColumn9 = (rsFilters?.Count >= 9) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(8)?.Descr : null;

            PXUIFieldAttribute.SetDisplayName<ItemPickerMapping.unboundValueColumn1>(this.ItemPickerMappings.Cache, unboundColumn1);
            PXUIFieldAttribute.SetVisible<ItemPickerMapping.unboundValueColumn1>(this.ItemPickerMappings.Cache, null, (cfg.UnboundColumn1 != null));

            PXUIFieldAttribute.SetDisplayName<ItemPickerMapping.unboundValueColumn2>(this.ItemPickerMappings.Cache, unboundColumn2);
            PXUIFieldAttribute.SetVisible<ItemPickerMapping.unboundValueColumn2>(this.ItemPickerMappings.Cache, null, (cfg.UnboundColumn2 != null));

            PXUIFieldAttribute.SetDisplayName<ItemPickerMapping.unboundValueColumn3>(this.ItemPickerMappings.Cache, unboundColumn3);
            PXUIFieldAttribute.SetVisible<ItemPickerMapping.unboundValueColumn3>(this.ItemPickerMappings.Cache, null, (cfg.UnboundColumn3 != null));

            PXUIFieldAttribute.SetDisplayName<ItemPickerMapping.unboundValueColumn4>(this.ItemPickerMappings.Cache, unboundColumn4);
            PXUIFieldAttribute.SetVisible<ItemPickerMapping.unboundValueColumn4>(this.ItemPickerMappings.Cache, null, (cfg.UnboundColumn4 != null));

            PXUIFieldAttribute.SetDisplayName<ItemPickerMapping.unboundValueColumn5>(this.ItemPickerMappings.Cache, unboundColumn5);
            PXUIFieldAttribute.SetVisible<ItemPickerMapping.unboundValueColumn5>(this.ItemPickerMappings.Cache, null, (cfg.UnboundColumn5 != null));

            PXUIFieldAttribute.SetDisplayName<ItemPickerMapping.unboundValueColumn6>(this.ItemPickerMappings.Cache, unboundColumn6);
            PXUIFieldAttribute.SetVisible<ItemPickerMapping.unboundValueColumn6>(this.ItemPickerMappings.Cache, null, (cfg.UnboundColumn6 != null));

            PXUIFieldAttribute.SetDisplayName<ItemPickerMapping.unboundValueColumn7>(this.ItemPickerMappings.Cache, unboundColumn7);
            PXUIFieldAttribute.SetVisible<ItemPickerMapping.unboundValueColumn7>(this.ItemPickerMappings.Cache, null, (cfg.UnboundColumn7 != null));

            PXUIFieldAttribute.SetDisplayName<ItemPickerMapping.unboundValueColumn8>(this.ItemPickerMappings.Cache, unboundColumn8);
            PXUIFieldAttribute.SetVisible<ItemPickerMapping.unboundValueColumn8>(this.ItemPickerMappings.Cache, null, (cfg.UnboundColumn8 != null));

            PXUIFieldAttribute.SetDisplayName<ItemPickerMapping.unboundValueColumn9>(this.ItemPickerMappings.Cache, unboundColumn9);
            PXUIFieldAttribute.SetVisible<ItemPickerMapping.unboundValueColumn9>(this.ItemPickerMappings.Cache, null, (cfg.UnboundColumn9 != null));
        }

        public virtual void IIProductLine_RowPersisting(PXCache sender, PXRowPersistingEventArgs e)
        {
            IIProductLine cfg = e.Row as IIProductLine;
            if ((cfg == null) || (cfg.ProductLineID == null)) return;

            PXResultset<IIProductLineFilter> rsFilters = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<IIProductLine.productLineID>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(this, cfg.ProductLineID);

            foreach (ItemPickerMapping im in ItemPickerMappings.Select())
            {
                if (
                        (rsFilters?.Count >= 1) && (im.Column1 == "" || im.Column1 == null)
                   ||   (rsFilters?.Count >= 2) && (im.Column2 == "" || im.Column2 == null)
                   ||   (rsFilters?.Count >= 3) && (im.Column3 == "" || im.Column3 == null)
                   ||   (rsFilters?.Count >= 4) && (im.Column4 == "" || im.Column4 == null)
                   ||   (rsFilters?.Count >= 5) && (im.Column5 == "" || im.Column5 == null)
                   ||   (rsFilters?.Count >= 6) && (im.Column6 == "" || im.Column6 == null)
                   ||   (rsFilters?.Count >= 7) && (im.Column7 == "" || im.Column7 == null)
                   ||   (rsFilters?.Count >= 8) && (im.Column8 == "" || im.Column8 == null)
                   ||   (rsFilters?.Count >= 9) && (im.Column9 == "" || im.Column9 == null)
                   )
                    throw new PXException("All values in mapping columns must be specified. Provide correct values for mapping and then save the form.");
            }
        }            
        protected virtual void ItemPickerMapping_RowSelecting(PXCache sender, PXRowSelectingEventArgs e)
        {
            ItemPickerMapping im = e.Row as ItemPickerMapping;
            if ((im == null) || (im.ProductLineID == null)) return;

            _GetUnboundValues(im);
        }
        protected virtual void ItemPickerMapping_RowInserting(PXCache sender, PXRowInsertingEventArgs e)
        {
            ItemPickerMapping im = e.Row as ItemPickerMapping;
            if ((im == null) || (im.ProductLineID == null)) return;

            _SetUnboundValues(im);

            if (!_CheckUniqueness(im))
            {
                sender.RaiseExceptionHandling<ItemPickerMapping.column1>(im, im.Column1, new PXSetPropertyException("A combination of mapping values and inventory ID must be unique. Make the combination of values unique and save."));
                e.Cancel = true;
            }
        }
        protected virtual void ItemPickerMapping_RowUpdating(PXCache sender, PXRowUpdatingEventArgs e)
        {
            ItemPickerMapping im = e.NewRow as ItemPickerMapping;
            if ((im == null) || (im.ProductLineID == null)) return;

            _SetUnboundValues(im);

            if (!_CheckUniqueness(im))
            {
                sender.RaiseExceptionHandling<ItemPickerMapping.unboundValueColumn1>(im, im.UnboundValueColumn1, new PXSetPropertyException("A combination of mapping values and inventory ID must be unique. Make the combination of values unique and save."));
                e.Cancel = true;
            }
        }
        protected virtual void ItemPickerMapping_RowUpdated(PXCache sender, PXRowUpdatedEventArgs e)
        {
            ItemPickerMapping im = e.Row as ItemPickerMapping;
            if ((im == null) || (im.ProductLineID == null)) return;

            sender.SetDefaultExt<ItemPickerMapping.description>(e.Row);
        }

        private void _GetUnboundValues(ItemPickerMapping im)
        {
            im.UnboundValueColumn1 = _GetUnboundValue<IIProductLine.unboundColumn1>(im);
            im.UnboundValueColumn2 = _GetUnboundValue<IIProductLine.unboundColumn2>(im);
            im.UnboundValueColumn3 = _GetUnboundValue<IIProductLine.unboundColumn3>(im);
            im.UnboundValueColumn4 = _GetUnboundValue<IIProductLine.unboundColumn4>(im);
            im.UnboundValueColumn5 = _GetUnboundValue<IIProductLine.unboundColumn5>(im);
            im.UnboundValueColumn6 = _GetUnboundValue<IIProductLine.unboundColumn6>(im);
            im.UnboundValueColumn7 = _GetUnboundValue<IIProductLine.unboundColumn7>(im);
            im.UnboundValueColumn8 = _GetUnboundValue<IIProductLine.unboundColumn8>(im);
            im.UnboundValueColumn9 = _GetUnboundValue<IIProductLine.unboundColumn9>(im);
        }
        private string _GetUnboundValue<T>(ItemPickerMapping im) where T : class, IBqlField 
        {
            IIProductLineFilter filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<T>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(this, im.ProductLineID).RowCast<IIProductLineFilter>()?.FirstOrDefault();

            switch (filter?.MappingColumnNbr)
            {
                case 1: return im.Column1;
                case 2: return im.Column2;
                case 3: return im.Column3;
                case 4: return im.Column4;
                case 5: return im.Column5;
                case 6: return im.Column6;
                case 7: return im.Column7;
                case 8: return im.Column8;
                case 9: return im.Column9;
            }

            return "";
        }
        private void _SetUnboundValues(ItemPickerMapping im)
        {
            _SetUnboundValue<IIProductLine.unboundColumn1>(im, im.UnboundValueColumn1);
            _SetUnboundValue<IIProductLine.unboundColumn2>(im, im.UnboundValueColumn2);
            _SetUnboundValue<IIProductLine.unboundColumn3>(im, im.UnboundValueColumn3);
            _SetUnboundValue<IIProductLine.unboundColumn4>(im, im.UnboundValueColumn4);
            _SetUnboundValue<IIProductLine.unboundColumn5>(im, im.UnboundValueColumn5);
            _SetUnboundValue<IIProductLine.unboundColumn6>(im, im.UnboundValueColumn6);
            _SetUnboundValue<IIProductLine.unboundColumn7>(im, im.UnboundValueColumn7);
            _SetUnboundValue<IIProductLine.unboundColumn8>(im, im.UnboundValueColumn8);
            _SetUnboundValue<IIProductLine.unboundColumn9>(im, im.UnboundValueColumn9);
        }
        private void _SetUnboundValue<T>(ItemPickerMapping im, string value) where T : class, IBqlField
        {
            IIProductLineFilter filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<T>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(this, im.ProductLineID).RowCast<IIProductLineFilter>()?.FirstOrDefault();

            switch (filter?.MappingColumnNbr)
            {
                case 1: im.Column1 = value; return;
                case 2: im.Column2 = value; return; 
                case 3: im.Column3 = value; return;
                case 4: im.Column4 = value; return;
                case 5: im.Column5 = value; return;
                case 6: im.Column6 = value; return;
                case 7: im.Column7 = value; return;
                case 8: im.Column8 = value; return;
                case 9: im.Column9 = value; return;
            }
        }

        class MappingsForSet : IEquatable<MappingsForSet>
        {
            string column1;
            string column2;
            string column3;
            string column4;
            string column5;
            string column6;
            string column7;
            string column8;
            string column9;
            int?   inventoryID;

            public MappingsForSet()
            { }

            public MappingsForSet(string col1, string col2, string col3, string col4, string col5, string col6, string col7, string col8, string col9, int? invID)
            {
                column1 = col1;
                column2 = col2;
                column3 = col3;
                column4 = col4;
                column5 = col5;
                column6 = col6;
                column7 = col7;
                column8 = col8;
                column9 = col9;
                inventoryID = invID;
            }

            public bool Equals(MappingsForSet other)
            {
                return (
                            column1.ToUpper().Equals(other.column1.ToUpper())
                        &&  ((column2 != null) ? column2.ToUpper().Equals(other.column2.ToUpper()) : true)
                        &&  ((column3 != null) ? column3.ToUpper().Equals(other.column3.ToUpper()) : true)
                        &&  ((column4 != null) ? column4.ToUpper().Equals(other.column4.ToUpper()) : true)
                        &&  ((column5 != null) ? column5.ToUpper().Equals(other.column5.ToUpper()) : true)
                        &&  ((column6 != null) ? column6.ToUpper().Equals(other.column6.ToUpper()) : true)
                        &&  ((column7 != null) ? column7.ToUpper().Equals(other.column7.ToUpper()) : true)
                        &&  ((column8 != null) ? column8.ToUpper().Equals(other.column8.ToUpper()) : true)
                        &&  ((column9 != null) ? column9.ToUpper().Equals(other.column9.ToUpper()) : true)
                        &&  (inventoryID == other.inventoryID)
                       );
            }
            public override int GetHashCode()
            {
                return (
                            column1?.ToUpper()
                        +   (column2?.ToUpper() ?? "")
                        +   (column3?.ToUpper() ?? "")
                        +   (column4?.ToUpper() ?? "")
                        +   (column5?.ToUpper() ?? "")
                        +   (column6?.ToUpper() ?? "")
                        +   (column7?.ToUpper() ?? "")
                        +   (column8?.ToUpper() ?? "")
                        +   (column9?.ToUpper() ?? "")
                        +   (inventoryID?.ToString() ?? "")
                       ).GetHashCode();
            }
        };
        private bool _CheckUniqueness(ItemPickerMapping im)
        { 
            var mappingsSet = new HashSet<MappingsForSet>();
            foreach (ItemPickerMapping im1 in ItemPickerMappings.Select())
                if (im1 != im)
                    mappingsSet.Add(new MappingsForSet(im1.Column1, im1.Column2, im1.Column3, im1.Column4, im1.Column5, im1.Column6, im1.Column7, im1.Column8, im1.Column9, im1.InventoryID));

            return mappingsSet.Add(new MappingsForSet(im.Column1, im.Column2, im.Column3, im.Column4, im.Column5, im.Column6, im.Column7, im.Column8, im.Column9, im.InventoryID));
        }

    }
}