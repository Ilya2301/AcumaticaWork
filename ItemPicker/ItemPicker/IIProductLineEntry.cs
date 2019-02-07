using System;
using PX.Data;
using System.Linq;

namespace ItemPicker
{
    public class IIProductLineEntry : PXGraph<IIProductLineEntry, IIProductLine>
    {
        public PXSelect<IIProductLine> IIProductLines;

        [PXImport(typeof(IIProductLine))]
        public PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<IIProductLine.productLineID>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>> IIFilters;

        [PXImport(typeof(IIProductLine))]
        public PXSelect<IIProductLineFilterOpt, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLineFilter.productLineID>>, 
            And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLineFilter.filterID>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>> IIFilterOptions;

        protected virtual void IIProductLine_RowSelected(PXCache sender, PXRowSelectedEventArgs e)
        {
            IIProductLine cfg = e.Row as IIProductLine;
            if ((cfg == null) || (cfg.ProductLineID == null)) return;

            PXResultset<IIProductLineFilter> rsFilters = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<IIProductLine.productLineID>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(this, cfg.ProductLineID);

            cfg.UnboundColumn1 = (rsFilters?.Count >= 1) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(0)?.FilterID : null;
            cfg.UnboundColumn2 = (rsFilters?.Count >= 2) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(1)?.FilterID : null;
            cfg.UnboundColumn3 = (rsFilters?.Count >= 3) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(2)?.FilterID : null;
            cfg.UnboundColumn4 = (rsFilters?.Count >= 4) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(3)?.FilterID : null;
            cfg.UnboundColumn5 = (rsFilters?.Count >= 5) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(4)?.FilterID : null;
            cfg.UnboundColumn6 = (rsFilters?.Count >= 6) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(5)?.FilterID : null;
            cfg.UnboundColumn7 = (rsFilters?.Count >= 7) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(6)?.FilterID : null;
            cfg.UnboundColumn8 = (rsFilters?.Count >= 8) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(7)?.FilterID : null;
            cfg.UnboundColumn9 = (rsFilters?.Count == 9) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(8)?.FilterID : null;
        }
        protected virtual void IIProductLine_RowDeleting(PXCache sender, PXRowDeletingEventArgs e)
        {
            IIProductLine c = e.Row as IIProductLine;

            if (sender.GetStatus(c) == PXEntryStatus.InsertedDeleted)
                return; // if inserted and then immediately deleted - the checks below are not needed

            if (IIFilters.Select().Count > 0)
                throw new PXException("Product line {0} cannot be deleted while it has filters. Delete all filters for the product line, after that you'll be able to delete the product line", c.ProductLineID);
        }
        protected virtual void IIProductLineFilter_RowInserting(PXCache sender, PXRowInsertingEventArgs e)
        {
            IIProductLineFilter cf = (IIProductLineFilter)e.Row;
            if ((cf == null) || (cf.ProductLineID == null)) return;

            if (IIFilters.Select().Count >= IIProductLines.Current?.FiltersCount)
                throw new PXException ("You cannot add more that '{0}' filters. If you want to add more, change value in the 'Filters' combo", IIProductLines.Current?.FiltersCount);
        }
        public virtual void IIProductLineFilter_RowPersisting(PXCache sender, PXRowPersistingEventArgs e)
        {
            IIProductLineFilter cf = (IIProductLineFilter)e.Row;
            if ((cf == null) || (cf.ProductLineID == null)) return;

            if ((e.Operation & PXDBOperation.Command) != PXDBOperation.Insert)
                return;

            PXResultset<IIProductLineFilter> rsFilters = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Required<IIProductLineFilter.productLineID>>, And<IIProductLineFilter.filterID, NotEqual<Required<IIProductLineFilter.filterID >>, And<IIProductLineFilter.mappingColumnNbr, IsNotNull>>>, OrderBy<Asc<IIProductLineFilter.mappingColumnNbr>>>.Select(this, cf.ProductLineID, cf.FilterID);
            if ((rsFilters?.Count == null) || (rsFilters?.Count == 0))
                cf.MappingColumnNbr = 1;
            else if (rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(rsFilters.Count - 1)?.MappingColumnNbr < 9)
                cf.MappingColumnNbr = rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(rsFilters.Count - 1)?.MappingColumnNbr + 1;
            else if (rsFilters?.Count == 9)
                throw new PXRowPersistingException("Mapping Column Nbr", cf.MappingColumnNbr, "There are already 9 filters. You cannot have more than 9 filters.");
            else // find a hole 
            {
                int curNum = 0;
                foreach (IIProductLineFilter f in rsFilters)
                    if (f.MappingColumnNbr > (curNum + 1))
                    {
                        cf.MappingColumnNbr = curNum + 1;
                        break;
                    }
                    else
                        curNum++;
            }
        }
        protected virtual void IIProductLineFilter_RowDeleting(PXCache sender, PXRowDeletingEventArgs e)
        {
            IIProductLineFilter cf = (IIProductLineFilter)e.Row;
            // Checking whether the deletion has been initiated from the UI
            if (!e.ExternalCall) return;
            if (sender.GetStatus(cf) == PXEntryStatus.InsertedDeleted)
                return; // if inserted and then immediately deleted - the checks below are not needed

            // Asking for confirmation on an attempt to delete a
            // shipment line other than the gift card line
            if (IIFilters.Ask("Confirm Delete", "Are you sure you want to delete the filter?",  MessageButtons.YesNo) != WebDialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            ItemPickerMappingEntry im_graph = PXGraph.CreateInstance<ItemPickerMappingEntry>();
            im_graph.ItemPickerMappings.Current = im_graph.ItemPickerMappings.Search<IIProductLine.productLineID>(cf.ProductLineID);
            PXResultset<ItemPickerMapping> rsMappings = PXSelect<ItemPickerMapping, Where<ItemPickerMapping.productLineID, Equal<Required<ItemPickerMapping.productLineID>>>, OrderBy<Asc<ItemPickerMapping.inventoryID>>>.Select(im_graph, cf.ProductLineID);

            foreach (ItemPickerMapping im in rsMappings)
            {
                bool bError = false;
                if (cf.FilterID == IIProductLines.Current.UnboundColumn1)
                    bError = (im.UnboundValueColumn1 != null);
                else if (cf.FilterID == IIProductLines.Current.UnboundColumn2)
                    bError = (im.UnboundValueColumn2 != null);
                else if (cf.FilterID == IIProductLines.Current.UnboundColumn3)
                    bError = (im.UnboundValueColumn3 != null);
                if (cf.FilterID == IIProductLines.Current.UnboundColumn4)
                    bError = (im.UnboundValueColumn4 != null);
                else if (cf.FilterID == IIProductLines.Current.UnboundColumn5)
                    bError = (im.UnboundValueColumn5 != null);
                else if (cf.FilterID == IIProductLines.Current.UnboundColumn6)
                    bError = (im.UnboundValueColumn6 != null);
                if (cf.FilterID == IIProductLines.Current.UnboundColumn7)
                    bError = (im.UnboundValueColumn7 != null);
                else if (cf.FilterID == IIProductLines.Current.UnboundColumn8)
                    bError = (im.UnboundValueColumn8 != null);
                else if (cf.FilterID == IIProductLines.Current.UnboundColumn9)
                    bError = (im.UnboundValueColumn9 != null);

                if (bError)
                    throw new PXException("The filter '{0}' cannot be deleted while some values for it are in mappings. Clear values for the filter in the mappings, after that you'll be able to delete the filter", cf.FilterID);
            }
        }

        protected virtual void IIProductLineFilterOpt_RowDeleting(PXCache sender, PXRowDeletingEventArgs e)
        {
            IIProductLineFilterOpt cfo = (IIProductLineFilterOpt) e.Row;
            // Checking whether the deletion has been initiated from the UI
            if (!e.ExternalCall) return;
            if (sender.GetStatus(cfo) == PXEntryStatus.InsertedDeleted)
                return; // if inserted and then immediately deleted - the checks below are not needed

            // Asking for confirmation on an attempt to delete a
            // shipment line other than the gift card line
            if (IIFilterOptions.Ask("Confirm Delete", "Are you sure you want to delete the option?", MessageButtons.YesNo) != WebDialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            ItemPickerMappingEntry im_graph = PXGraph.CreateInstance<ItemPickerMappingEntry>();
            im_graph.IIProductLines.Current = im_graph.IIProductLines.Search<IIProductLine.productLineID>(cfo.ProductLineID);
            PXResultset<ItemPickerMapping> rsMappings = PXSelect<ItemPickerMapping, Where<ItemPickerMapping.productLineID, Equal<Required<ItemPickerMapping.productLineID>>>, OrderBy<Asc<ItemPickerMapping.inventoryID>>>.Select(im_graph, cfo.ProductLineID);

            foreach (ItemPickerMapping im in rsMappings)
            {
                bool bError = false;
                if ((cfo.FilterID == IIProductLines.Current.UnboundColumn1) && (cfo.ValueID == im.UnboundValueColumn1))
                    bError = (im.UnboundValueColumn1 != null);
                else if ((cfo.FilterID == IIProductLines.Current.UnboundColumn2) && (cfo.ValueID == im.UnboundValueColumn2))
                    bError = (im.UnboundValueColumn2 != null);
                else if ((cfo.FilterID == IIProductLines.Current.UnboundColumn3) && (cfo.ValueID == im.UnboundValueColumn3))
                    bError = (im.UnboundValueColumn3 != null);
                else if ((cfo.FilterID == IIProductLines.Current.UnboundColumn4) && (cfo.ValueID == im.UnboundValueColumn4))
                    bError = (im.UnboundValueColumn4 != null);
                else if ((cfo.FilterID == IIProductLines.Current.UnboundColumn5) && (cfo.ValueID == im.UnboundValueColumn5))
                    bError = (im.UnboundValueColumn5 != null);
                else if ((cfo.FilterID == IIProductLines.Current.UnboundColumn6) && (cfo.ValueID == im.UnboundValueColumn6))
                    bError = (im.UnboundValueColumn6 != null);
                else if ((cfo.FilterID == IIProductLines.Current.UnboundColumn7) && (cfo.ValueID == im.UnboundValueColumn7))
                    bError = (im.UnboundValueColumn7 != null);
                else if ((cfo.FilterID == IIProductLines.Current.UnboundColumn8) && (cfo.ValueID == im.UnboundValueColumn8))
                    bError = (im.UnboundValueColumn8 != null);
                else if ((cfo.FilterID == IIProductLines.Current.UnboundColumn9) && (cfo.ValueID == im.UnboundValueColumn9))
                    bError = (im.UnboundValueColumn9 != null);

                if (bError)
                    throw new PXException("The option '{0}' cannot be deleted while some values for it are in mappings. Clear values for the option in the mappings, after that you'll be able to delete the option", cfo.ValueID);
            }
        }
    }
}