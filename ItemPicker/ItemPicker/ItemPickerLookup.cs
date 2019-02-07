using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using PX.Api;
using PX.Common;
using PX.Data;
using PX.Data.Maintenance.GI;
using PX.Data.SQLTree;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Objects.AP;
using PX.Objects.AR;
using PX.Objects.CR;
using PX.Objects.CM;
using PX.Objects.CS;
using PX.Objects.IN;
using PX.Objects.GL;
using PX.Objects.GL.FinPeriods.TableDefinition;
using PX.Objects.GL.FinPeriods;
using PX.Objects.SO;
using PX.SM;

namespace ItemPicker
{
    [System.SerializableAttribute()]
    public partial class ItemPickerFilter : IBqlTable
    {
        #region SiteID
        public abstract class siteID : PX.Data.IBqlField
        {
        }
        protected Int32? _SiteID;
        [PXUIField(DisplayName = "Warehouse")]
        [SiteAttribute]
        [PXDefault(typeof(INRegister.siteID), PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Int32? SiteID
        {
            get
            {
                return this._SiteID;
            }
            set
            {
                this._SiteID = value;
            }
        }
        #endregion

        #region ProductLineID
        public abstract class productLineID : PX.Data.IBqlField { }
        [PXDBString(30, IsUnicode = true)]
        [PXUIField(DisplayName = "Product Line")]
        [PXDefault(typeof(Search<UserPreferencesExt.usrProductLineID, Where< UserPreferences.userID, Equal<Current<AccessInfo.userID>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXSelector(typeof(Search<IIProductLine.productLineID>))] 
        public virtual string ProductLineID { get; set; }
        #endregion

        #region Columns
        #region UnboundColumn1
        public abstract class unboundColumn1 : PX.Data.IBqlField { }
        [PXString(30, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumn1 { get; set; }
        #endregion
        #region UnboundColumnDescr1
        public abstract class unboundColumnDescr1 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumnDescr1 { get; set; }
        #endregion
        #region Column1
        public abstract class column1 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 1")]
        public virtual string Column1 { get; set; }
        #endregion
        #region UnboundValueColumn1
        public abstract class unboundValueColumn1 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 1", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<unboundColumn1>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>>))]
        public virtual string UnboundValueColumn1 { get; set; }
        #endregion

        #region UnboundColumn2
        public abstract class unboundColumn2 : PX.Data.IBqlField { }
        [PXString(30, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn2 { get; set; }
        #endregion
        #region UnboundColumnDescr2
        public abstract class unboundColumnDescr2 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumnDescr2 { get; set; }
        #endregion
        #region Column2
        public abstract class column2 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 2")]
        public virtual string Column2 { get; set; }
        #endregion
        #region UnboundValueColumn2
        public abstract class unboundValueColumn2 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 2", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<unboundColumn2>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>>))]
        public virtual string UnboundValueColumn2 { get; set; }
        #endregion

        #region UnboundColumn3
        public abstract class unboundColumn3 : PX.Data.IBqlField { }
        [PXString(30, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn3 { get; set; }
        #endregion
        #region UnboundColumnDescr3
        public abstract class unboundColumnDescr3 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumnDescr3 { get; set; }
        #endregion
        #region Column3
        public abstract class column3 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 3")]
        public virtual string Column3 { get; set; }
        #endregion
        #region UnboundValueColumn3
        public abstract class unboundValueColumn3 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 3", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<unboundColumn3>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>>))]
        public virtual string UnboundValueColumn3 { get; set; }
        #endregion

        #region UnboundColumn4
        public abstract class unboundColumn4 : PX.Data.IBqlField { }
        [PXString(30, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn4 { get; set; }
        #endregion
        #region UnboundColumnDescr4
        public abstract class unboundColumnDescr4 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumnDescr4 { get; set; }
        #endregion        
        #region Column4
        public abstract class column4 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 4")]
        public virtual string Column4 { get; set; }
        #endregion
        #region UnboundValueColumn4
        public abstract class unboundValueColumn4 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 4", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<unboundColumn4>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>>))]
        public virtual string UnboundValueColumn4 { get; set; }
        #endregion

        #region UnboundColumn5
        public abstract class unboundColumn5 : PX.Data.IBqlField { }
        [PXString(30, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumn5 { get; set; }
        #endregion
        #region UnboundColumnDescr5
        public abstract class unboundColumnDescr5 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumnDescr5 { get; set; }
        #endregion       
        #region Column5
        public abstract class column5 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 5")]
        public virtual string Column5 { get; set; }
        #endregion
        #region UnboundValueColumn5
        public abstract class unboundValueColumn5 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 5", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<unboundColumn5>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>>))]
        public virtual string UnboundValueColumn5 { get; set; }
        #endregion

        #region UnboundColumn6
        public abstract class unboundColumn6 : PX.Data.IBqlField { }
        [PXString(30, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumn6 { get; set; }
        #endregion
        #region UnboundColumnDescr6
        public abstract class unboundColumnDescr6 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumnDescr6 { get; set; }
        #endregion      
        #region Column6
        public abstract class column6 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 6")]
        public virtual string Column6 { get; set; }
        #endregion
        #region UnboundValueColumn6
        public abstract class unboundValueColumn6 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 6", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<unboundColumn6>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>>))]
        public virtual string UnboundValueColumn6 { get; set; }
        #endregion

        #region UnboundColumn7
        public abstract class unboundColumn7 : PX.Data.IBqlField { }
        [PXString(30, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumn7 { get; set; }
        #endregion
        #region UnboundColumnDescr7
        public abstract class unboundColumnDescr7 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumnDescr7 { get; set; }
        #endregion  
        #region Column7
        public abstract class column7 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 7")]
        public virtual string Column7 { get; set; }
        #endregion
        #region UnboundValueColumn7
        public abstract class unboundValueColumn7 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 7", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<unboundColumn7>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>>))]
        public virtual string UnboundValueColumn7 { get; set; }
        #endregion

        #region UnboundColumn8
        public abstract class unboundColumn8 : PX.Data.IBqlField { }
        [PXString(30, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumn8 { get; set; }
        #endregion
        #region UnboundColumnDescr8
        public abstract class unboundColumnDescr8 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumnDescr8 { get; set; }
        #endregion  
        #region Column8
        public abstract class column8 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 8")]
        public virtual string Column8 { get; set; }
        #endregion
        #region UnboundValueColumn8
        public abstract class unboundValueColumn8 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 8", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<unboundColumn8>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>>))]
        public virtual string UnboundValueColumn8 { get; set; }
        #endregion

        #region UnboundColumn9
        public abstract class unboundColumn9 : PX.Data.IBqlField { }
        [PXString(30, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumn9 { get; set; }
        #endregion
        #region UnboundColumnDescr9
        public abstract class unboundColumnDescr9 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(Enabled = false, IsReadOnly = true)]
        public virtual string UnboundColumnDescr9 { get; set; }
        #endregion  
        #region Column9
        public abstract class column9 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 9")]
        public virtual string Column9 { get; set; }
        #endregion
        #region UnboundValueColumn9
        public abstract class unboundValueColumn9 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 9", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<unboundColumn9>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>, OrderBy<Asc<IIProductLineFilterOpt.sortOrder>>>))]
        public virtual string UnboundValueColumn9 { get; set; }
        #endregion
        #endregion

        #region LocationID
        public abstract class locationID : PX.Data.IBqlField
        {
        }
        protected Int32? _LocationID;
        [Location(typeof(ItemPickerFilter.siteID), KeepEntry = false, DescriptionField = typeof(INLocation.descr), DisplayName = "Location")]
        public virtual Int32? LocationID
        {
            get
            {
                return this._LocationID;
            }
            set
            {
                this._LocationID = value;
            }
        }
        #endregion

        #region InventoryID
        public abstract class inventoryID : PX.Data.IBqlField
        {
        }
        protected Int32? _InventoryID;
        [Inventory()]
        public virtual Int32? InventoryID
        {
            get
            {
                return this._InventoryID;
            }
            set
            {
                this._InventoryID = value;
            }
        }
        #endregion

        #region SubItem
        public abstract class subItem : PX.Data.IBqlField
        {
        }
        protected String _SubItem;
        [SubItemRawExt(typeof(ItemPickerFilter.inventoryID), DisplayName = "Subitem")]
        public virtual String SubItem
        {
            get
            {
                return this._SubItem;
            }
            set
            {
                this._SubItem = value;
            }
        }
        #endregion

        #region SubItemCD Wildcard
        public abstract class subItemCDWildcard : PX.Data.IBqlField { };
        [PXDBString(30, IsUnicode = true)]
        public virtual String SubItemCDWildcard
        {
            get
            {
                //return SubItemCDUtils.CreateSubItemCDWildcard(this._SubItemCD);
                return this._SubItem == null ? null : SubCDUtils.CreateSubCDWildcard(this._SubItem, SubItemAttribute.DimensionName);
            }
        }
        #endregion

        #region BarCode
        public abstract class barCode : PX.Data.IBqlField
        {
        }
        protected String _BarCode;
        [PXDBString(IsUnicode = true)]
        [PXUIField(DisplayName = "Barcode")]
        public virtual String BarCode
        {
            get
            {
                return this._BarCode;
            }
            set
            {
                this._BarCode = value;
            }
        }
        #endregion

        #region BarCode Wildcard
        public abstract class barCodeWildcard : PX.Data.IBqlField { };
        [PXDBString(30, IsUnicode = true)]
        public virtual String BarCodeWildcard
        {
            get
            {
                return this._BarCode == null ? null : "%" + this._BarCode + "%";
            }
        }
        #endregion

        #region Inventory
        public abstract class inventory : PX.Data.IBqlField
        {
        }
        protected String _Inventory;
        [PXDBString(IsUnicode = true)]
        [PXUIField(DisplayName = "Inventory")]
        public virtual String Inventory
        {
            get
            {
                return this._Inventory;
            }
            set
            {
                this._Inventory = value;
            }
        }
        #endregion

        #region Inventory Wildcard
        public abstract class inventory_Wildcard : PX.Data.IBqlField { };
        [PXDBString(30, IsUnicode = true)]
        public virtual String Inventory_Wildcard
        {
            get
            {
                String wildcard = PXDatabase.Provider.SqlDialect.WildcardAnything;
                return this._Inventory == null ? null : wildcard + this._Inventory + wildcard;
            }
        }
        #endregion

        #region OnlyAvailable
        public abstract class onlyAvailable : PX.Data.IBqlField
        {
        }
        protected bool? _OnlyAvailable;
        [PXBool]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Show Available Items Only")]
        public virtual bool? OnlyAvailable
        {
            get
            {
                return _OnlyAvailable;
            }
            set
            {
                _OnlyAvailable = value;
            }
        }
        #endregion

        #region ItemClass
        public abstract class itemClass : PX.Data.IBqlField { }
        protected string _ItemClass;

        [PXDBString(30, IsUnicode = true)]
        [PXUIField(DisplayName = "Item Class ID", Visibility = PXUIVisibility.SelectorVisible)]
        [PXDimensionSelector(INItemClass.Dimension, typeof(INItemClass.itemClassCD), DescriptionField = typeof(INItemClass.descr), ValidComboRequired = true)]
        public virtual string ItemClass
        {
            get { return this._ItemClass; }
            set { this._ItemClass = value; }
        }
        #endregion
        #region ItemClassCDWildcard
        public abstract class itemClassCDWildcard : PX.Data.IBqlField { }
        [PXString(IsUnicode = true)]
        [PXUIField(Visible = false, Visibility = PXUIVisibility.Invisible)]
        [PXDimension(INItemClass.Dimension, ParentSelect = typeof(Select<INItemClass>), ParentValueField = typeof(INItemClass.itemClassCD))]
        public virtual string ItemClassCDWildcard
        {
            get { return ItemClassTree.MakeWildcard(ItemClass); }
            set { }
        }
        #endregion

/*        #region Inventory
        public new abstract class inventory : PX.Data.IBqlField
        {
        }
        #endregion
*/
        #region Mode
        public abstract class mode : PX.Data.IBqlField
        {
        }
        protected int? _Mode;
        [PXDBInt]
        [PXDefault(0)]
        [PXUIField(DisplayName = "Selection Mode")]
        [SOAddItemMode.List]
        public virtual int? Mode
        {
            get
            {
                return _Mode;
            }
            set
            {
                _Mode = value;
            }
        }
        #endregion
        #region HistoryDate
        public abstract class historyDate : PX.Data.IBqlField
        {
        }
        protected DateTime? _HistoryDate;
        [PXDBDate()]
        [PXUIField(DisplayName = "Sold Since")]
        public virtual DateTime? HistoryDate
        {
            get
            {
                return this._HistoryDate;
            }
            set
            {
                this._HistoryDate = value;
            }
        }
        #endregion
    }

    #region ItemPickerLookup
    public class ItemPickerLookup<Status, StatusFilter> : PXSelectBase<Status>
        where Status : class, IBqlTable, new()
        where StatusFilter : ItemPickerFilter, new()
    {
        protected class LookupView : PXView
        {
            public LookupView(PXGraph graph, BqlCommand command)
                : base(graph, true, command)
            {
            }

            public LookupView(PXGraph graph, BqlCommand command, Delegate handler)
                : base(graph, true, command, handler)
            {
            }

            protected PXSearchColumn CorrectFieldName(PXSearchColumn orig, bool idFound)
            {
                switch (orig.Column.ToLower())
                {
                    case "inventoryid":
                        if (!idFound)
                            return new PXSearchColumn("InventoryCD", orig.Descending, orig.OrigSearchValue ?? orig.SearchValue);
                        else
                            return null;
                    case "subitemid":
                        return new PXSearchColumn("SubItemCD", orig.Descending, orig.OrigSearchValue ?? orig.SearchValue);
                    case "siteid":
                        return new PXSearchColumn("SiteCD", orig.Descending, orig.OrigSearchValue ?? orig.SearchValue);
                    case "locationid":
                        return new PXSearchColumn("LocationCD", orig.Descending, orig.OrigSearchValue ?? orig.SearchValue);
                }
                return orig;
            }

            protected override List<object> InvokeDelegate(object[] parameters)
            {
                var context = PXView._Executing.Peek();
                var orig = context.Sorts;

                bool idFound = false;
                var result = new List<PXSearchColumn>();
                const string iD = "InventoryCD";
                for (int i = 0; i < orig.Length - this.Cache.Keys.Count; i++)
                {
                    result.Add(CorrectFieldName(orig[i], false));
                    if (orig[i].Column == iD)
                        idFound = true;
                }

                for (int i = orig.Length - this.Cache.Keys.Count; i < orig.Length; i++)
                {
                    var col = CorrectFieldName(orig[i], idFound);
                    if (col != null)
                        result.Add(col);
                }
                context.Sorts = result.ToArray();

                return base.InvokeDelegate(parameters);
            }
        }

        public const string Selected = "Selected";
        public const string QtySelected = "QtySelected";
        private PXView intView;
        #region Ctor
        public ItemPickerLookup(PXGraph graph)
        {
            this.View = new PXView(graph, false,
                BqlCommand.CreateInstance(BqlCommand.Compose(typeof(Select<>), typeof(Status))),
                new PXSelectDelegate(viewHandler));
            InitHandlers(graph);

            graph.RowSelecting.AddHandler(typeof(ItemPickerSelected), OnRowSelecting);
        }

        public ItemPickerLookup(PXGraph graph, Delegate handler)
        {
            this.View = new PXView(graph, false,
                BqlCommand.CreateInstance(typeof(Select<>), typeof(Status)),
                handler);
            InitHandlers(graph);

            graph.RowSelecting.AddHandler(typeof(SOSiteStatusSelected), OnRowSelecting);
        }
        #endregion

        #region Implementations

        private void InitHandlers(PXGraph graph)
        {
            graph.RowSelected.AddHandler(typeof(StatusFilter), OnFilterSelected);
            graph.RowSelected.AddHandler(typeof(Status), OnRowSelected);
            graph.FieldUpdated.AddHandler(typeof(Status), Selected, OnSelectedUpdated);
        }

        protected virtual void OnFilterSelected(PXCache sender, PXRowSelectedEventArgs e)
        {
            ItemPickerFilter row = e.Row as ItemPickerFilter;
            if (row != null)
                PXUIFieldAttribute.SetVisible(sender.Graph.Caches[typeof(Status)], typeof(ItemPickerSelected.siteID).Name, row.SiteID == null);

            ItemPickerFilter filter = (ItemPickerFilter)e.Row;
            PXUIFieldAttribute.SetVisible<ItemPickerFilter.historyDate>(sender, null, filter.Mode == SOAddItemMode.ByCustomer);
            PXCache status = sender.Graph.Caches[typeof(ItemPickerSelected)];
            PXUIFieldAttribute.SetVisible<ItemPickerSelected.qtyLastSale>(status, null, filter.Mode == SOAddItemMode.ByCustomer);
            PXUIFieldAttribute.SetVisible<ItemPickerSelected.curyID>(status, null, filter.Mode == SOAddItemMode.ByCustomer);
            PXUIFieldAttribute.SetVisible<ItemPickerSelected.curyUnitPrice>(status, null, filter.Mode == SOAddItemMode.ByCustomer);
            PXUIFieldAttribute.SetVisible<ItemPickerSelected.lastSalesDate>(status, null, filter.Mode == SOAddItemMode.ByCustomer);

            if (filter.HistoryDate == null)
                filter.HistoryDate = sender.Graph.Accessinfo.BusinessDate.GetValueOrDefault().AddMonths(-3);
        }


        protected virtual void OnSelectedUpdated(PXCache sender, PXFieldUpdatedEventArgs e)
        {
            bool? selected = (bool?)sender.GetValue(e.Row, Selected);
            decimal? qty = (decimal?)sender.GetValue(e.Row, QtySelected);
            if (selected == true)
            {
                if (qty == null || qty == 0m)
                    sender.SetValue(e.Row, QtySelected, 1m);
            }
            else
                sender.SetValue(e.Row, QtySelected, 0m);
        }

        protected virtual void OnRowSelecting(PXCache sender, PXRowSelectingEventArgs e)
        {
            if (sender.Fields.Contains(typeof(ItemPickerSelected.curyID).Name) &&
                    sender.GetValue<ItemPickerSelected.curyID>(e.Row) == null)
            {
                PXCache orderCache = sender.Graph.Caches[typeof(SOOrder)];
                sender.SetValue<ItemPickerSelected.curyID>(e.Row,
                    orderCache.GetValue<SOOrder.curyID>(orderCache.Current));
                sender.SetValue<ItemPickerSelected.curyInfoID>(e.Row,
                    orderCache.GetValue<SOOrder.curyInfoID>(orderCache.Current));
            }
        }

        protected virtual void OnRowSelected(PXCache sender, PXRowSelectedEventArgs e)
        {
            PXUIFieldAttribute.SetEnabled(sender, e.Row, false);
            PXUIFieldAttribute.SetEnabled(sender, e.Row, Selected, true);
            PXUIFieldAttribute.SetEnabled(sender, e.Row, QtySelected, true);
        }

        protected virtual PXView CreateIntView(PXGraph graph)
        {
            PXCache cache = graph.Caches[typeof(Status)];

            List<Type> select = new List<Type>();
            select.Add(typeof(Select<,>));
            select.Add(typeof(Status));
            select.Add(CreateWhere(graph));

            //select.Add(typeof(Aggregate<>));
            /*
			List<Type> groupFields = cache.BqlKeys;
			groupFields.AddRange(cache.BqlFields.Where(field => field.IsDefined(typeof (PXExtraKeyAttribute), false)));			

			for (int i = 0; i < groupFields.Count; i++)
			{
				select.Add((i != groupFields.Count - 1) ? typeof(GroupBy<,>) : typeof(GroupBy<>));
				select.Add(groupFields[i]);
			}
			*/
            Type selectType = BqlCommand.Compose(select.ToArray());

            return new LookupView(graph, BqlCommand.CreateInstance(selectType));
        }

        protected virtual IEnumerable viewHandler()
        {
            if (intView == null) intView = CreateIntView(this.View.Graph);
            var startRow = PXView.StartRow;
            var totalRows = 0;

            foreach (var rec in intView.Select(null, null, PXView.Searches, PXView.SortColumns, PXView.Descendings, PXView.Filters,
                                 ref startRow, PXView.MaximumRows, ref totalRows))
            {
                Status item = PXResult.Unwrap<Status>(rec);
                Status result = item;
                Status updated = this.Cache.Locate(item) as Status;
                if (updated != null && this.Cache.GetValue(updated, Selected) as bool? == true)
                {
                    Decimal? qty = this.Cache.GetValue(updated, QtySelected) as Decimal?;
                    this.Cache.RestoreCopy(updated, item);
                    this.Cache.SetValue(updated, Selected, true);
                    this.Cache.SetValue(updated, QtySelected, qty);
                    result = updated;
                }
                yield return result;
            }
            PXView.StartRow = 0;
        }

        protected static Type CreateWhere(PXGraph graph)
        {
            PXCache filter = graph.Caches[typeof(ItemPickerFilter)];
            PXCache cache = graph.Caches[typeof(Status)];

            Type where = typeof(Where<boolTrue, Equal<boolTrue>>);
            foreach (string field in filter.Fields)
            {
                if (cache.Fields.Contains(field))
                {
                    if (filter.Fields.Contains(field + "Wildcard")) continue;
                    if (field.Contains("SubItem") && !PXAccess.FeatureInstalled<FeaturesSet.subItem>()) continue;
                    if (field.Contains("Site") && !PXAccess.FeatureInstalled<FeaturesSet.warehouse>()) continue;
                    if (field.Contains("Location") && !PXAccess.FeatureInstalled<FeaturesSet.warehouseLocation>()) continue;
                    Type sourceType = filter.GetBqlField(field);

                    // replace Unbound field with bound for UnboundValueColumnX
                    string dstField = _FromUnboundToBound(graph, filter.Current as ItemPickerFilter, field);
                    if (dstField == "") continue;

                    Type destinationType = cache.GetBqlField(dstField);
                    if (sourceType != null && destinationType != null)
                    {
                        where = BqlCommand.Compose(
                            typeof(Where2<,>),
                            typeof(Where<,,>),
                            typeof(Current<>), sourceType, typeof(IsNull),
                            typeof(Or<,>), destinationType, typeof(Equal<>), typeof(Current<>), sourceType,
                            typeof(And<>), where
                        );
                    }
                }
                string f;
                if (field.Length > 8 && field.EndsWith("Wildcard") && cache.Fields.Contains(f = field.Substring(0, field.Length - 8)))
                {
                    if (field.Contains("SubItem") && !PXAccess.FeatureInstalled<FeaturesSet.subItem>()) continue;
                    if (field.Contains("Site") && !PXAccess.FeatureInstalled<FeaturesSet.warehouse>()) continue;
                    if (field.Contains("Location") && !PXAccess.FeatureInstalled<FeaturesSet.warehouseLocation>()) continue;
                    Type like = filter.GetBqlField(field);
                    Type dest = cache.GetBqlField(f);
                    where = BqlCommand.Compose(
                        typeof(Where2<,>),
                        typeof(Where<,,>), typeof(Current<>), like, typeof(IsNull),
                        typeof(Or<,>), dest, typeof(Like<>), typeof(Current<>), like,
                        typeof(And<>), where
                        );
                }
            }
            return where;
        }

        private static string _FromUnboundToBound(PXGraph graph, ItemPickerFilter cf, string field)
        {
            if (cf == null)
                return field;

            IIProductLineFilter filter = null;
            switch (field)
            {
                case "UnboundValueColumn1": filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<ItemPickerFilter.unboundColumn1>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cf.ProductLineID, field).RowCast<IIProductLineFilter>()?.FirstOrDefault(); break;
                case "UnboundValueColumn2": filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<ItemPickerFilter.unboundColumn2>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cf.ProductLineID, field).RowCast<IIProductLineFilter>()?.FirstOrDefault(); break;
                case "UnboundValueColumn3": filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<ItemPickerFilter.unboundColumn3>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cf.ProductLineID, field).RowCast<IIProductLineFilter>()?.FirstOrDefault(); break;
                case "UnboundValueColumn4": filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<ItemPickerFilter.unboundColumn4>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cf.ProductLineID, field).RowCast<IIProductLineFilter>()?.FirstOrDefault(); break;
                case "UnboundValueColumn5": filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<ItemPickerFilter.unboundColumn5>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cf.ProductLineID, field).RowCast<IIProductLineFilter>()?.FirstOrDefault(); break;
                case "UnboundValueColumn6": filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<ItemPickerFilter.unboundColumn6>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cf.ProductLineID, field).RowCast<IIProductLineFilter>()?.FirstOrDefault(); break;
                case "UnboundValueColumn7": filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<ItemPickerFilter.unboundColumn7>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cf.ProductLineID, field).RowCast<IIProductLineFilter>()?.FirstOrDefault(); break;
                case "UnboundValueColumn8": filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<ItemPickerFilter.unboundColumn8>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cf.ProductLineID, field).RowCast<IIProductLineFilter>()?.FirstOrDefault(); break;
                case "UnboundValueColumn9": filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<ItemPickerFilter.unboundColumn9>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cf.ProductLineID, field).RowCast<IIProductLineFilter>()?.FirstOrDefault(); break;

                default: return field;
            }

            switch (filter?.MappingColumnNbr)
            {
                case 1: return "Column1";
                case 2: return "Column2";
                case 3: return "Column3";
                case 4: return "Column4";
                case 5: return "Column5";
                case 6: return "Column6";
                case 7: return "Column7";
                case 8: return "Column8";
                case 9: return "Column9";
            }

            return "";
        }

        public void OnChooserFilterRowSelected <GraphType> (PXGraph gr, PXCache cache, ItemPickerFilter filter) 
            where GraphType : PXGraph
        {
            GraphType graph = gr as GraphType;
            if (graph == null) return;

            PXResultset<IIProductLineFilter> rsFilters = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, filter.ProductLineID);

            filter.UnboundColumn1 = (rsFilters?.Count >= 1) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(0)?.FilterID : null;
            filter.UnboundColumnDescr1 = (rsFilters?.Count >= 1) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(0)?.Descr : null;
            filter.UnboundColumn2 = (rsFilters?.Count >= 2) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(1)?.FilterID : null;
            filter.UnboundColumnDescr2 = (rsFilters?.Count >= 2) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(1)?.Descr : null;
            filter.UnboundColumn3 = (rsFilters?.Count >= 3) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(2)?.FilterID : null;
            filter.UnboundColumnDescr3 = (rsFilters?.Count >= 3) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(2)?.Descr : null;
            filter.UnboundColumn4 = (rsFilters?.Count >= 4) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(3)?.FilterID : null;
            filter.UnboundColumnDescr4 = (rsFilters?.Count >= 4) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(3)?.Descr : null;
            filter.UnboundColumn5 = (rsFilters?.Count >= 5) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(4)?.FilterID : null;
            filter.UnboundColumnDescr5 = (rsFilters?.Count >= 5) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(4)?.Descr : null;
            filter.UnboundColumn6 = (rsFilters?.Count >= 6) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(5)?.FilterID : null;
            filter.UnboundColumnDescr6 = (rsFilters?.Count >= 6) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(5)?.Descr : null;
            filter.UnboundColumn7 = (rsFilters?.Count >= 7) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(6)?.FilterID : null;
            filter.UnboundColumnDescr7 = (rsFilters?.Count >= 7) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(6)?.Descr : null;
            filter.UnboundColumn8 = (rsFilters?.Count >= 8) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(7)?.FilterID : null;
            filter.UnboundColumnDescr8 = (rsFilters?.Count >= 8) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(7)?.Descr : null;
            filter.UnboundColumn9 = (rsFilters?.Count == 9) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(8)?.FilterID : null;
            filter.UnboundColumnDescr9 = (rsFilters?.Count == 9) ? rsFilters.RowCast<IIProductLineFilter>()?.ElementAt(8)?.Descr : null;

            _OnChooserFilterRowSelectedFieldPresentation<GraphType, ItemPickerFilter.unboundValueColumn1, ItemPickerSelected.unboundValueColumn1> (graph, cache, filter, (filter.UnboundColumn1 != null), filter.UnboundColumnDescr1);
            _OnChooserFilterRowSelectedFieldPresentation<GraphType, ItemPickerFilter.unboundValueColumn2, ItemPickerSelected.unboundValueColumn2> (graph, cache, filter, (filter.UnboundColumn2 != null), filter.UnboundColumnDescr2);
            _OnChooserFilterRowSelectedFieldPresentation<GraphType, ItemPickerFilter.unboundValueColumn3, ItemPickerSelected.unboundValueColumn3> (graph, cache, filter, (filter.UnboundColumn3 != null), filter.UnboundColumnDescr3);
            _OnChooserFilterRowSelectedFieldPresentation<GraphType, ItemPickerFilter.unboundValueColumn4, ItemPickerSelected.unboundValueColumn4> (graph, cache, filter, (filter.UnboundColumn4 != null), filter.UnboundColumnDescr4);
            _OnChooserFilterRowSelectedFieldPresentation<GraphType, ItemPickerFilter.unboundValueColumn5, ItemPickerSelected.unboundValueColumn5> (graph, cache, filter, (filter.UnboundColumn5 != null), filter.UnboundColumnDescr5);
            _OnChooserFilterRowSelectedFieldPresentation<GraphType, ItemPickerFilter.unboundValueColumn6, ItemPickerSelected.unboundValueColumn6> (graph, cache, filter, (filter.UnboundColumn6 != null), filter.UnboundColumnDescr6);
            _OnChooserFilterRowSelectedFieldPresentation<GraphType, ItemPickerFilter.unboundValueColumn7, ItemPickerSelected.unboundValueColumn7> (graph, cache, filter, (filter.UnboundColumn7 != null), filter.UnboundColumnDescr7);
            _OnChooserFilterRowSelectedFieldPresentation<GraphType, ItemPickerFilter.unboundValueColumn8, ItemPickerSelected.unboundValueColumn8> (graph, cache, filter, (filter.UnboundColumn8 != null), filter.UnboundColumnDescr8);
            _OnChooserFilterRowSelectedFieldPresentation<GraphType, ItemPickerFilter.unboundValueColumn9, ItemPickerSelected.unboundValueColumn9> (graph, cache, filter, (filter.UnboundColumn9 != null), filter.UnboundColumnDescr9);
        }

        private void _OnChooserFilterRowSelectedFieldPresentation <GraphType, FilterField, SelectedField> (PXGraph gr, PXCache cache, ItemPickerFilter filter, bool enable, string displayName)
            where GraphType : PXGraph
            where FilterField : class, IBqlField
            where SelectedField : class, IBqlField
        {
            GraphType graph = gr as GraphType;
            if (graph == null) return;

            PXUIFieldAttribute.SetEnabled<FilterField>(cache, null, enable);
            PXUIFieldAttribute.SetDisplayName<SelectedField>(graph.Caches[typeof(Status)], displayName);
            PXUIFieldAttribute.SetVisible<SelectedField>(graph.Caches[typeof(Status)], null, enable);
        }
        public void GetUnboundValuesSelectedOnRowSelecting <GraphType> (PXGraph gr, ItemPickerSelected cs)
            where GraphType : PXGraph
        {
            cs.UnboundValueColumn1 = _GetUnboundValue<GraphType, ItemPickerFilter.unboundColumn1>(gr, cs);
            cs.UnboundValueColumn2 = _GetUnboundValue<GraphType, ItemPickerFilter.unboundColumn2>(gr, cs);
            cs.UnboundValueColumn3 = _GetUnboundValue<GraphType, ItemPickerFilter.unboundColumn3>(gr, cs);
            cs.UnboundValueColumn4 = _GetUnboundValue<GraphType, ItemPickerFilter.unboundColumn4>(gr, cs);
            cs.UnboundValueColumn5 = _GetUnboundValue<GraphType, ItemPickerFilter.unboundColumn5>(gr, cs);
            cs.UnboundValueColumn6 = _GetUnboundValue<GraphType, ItemPickerFilter.unboundColumn6>(gr, cs);
            cs.UnboundValueColumn7 = _GetUnboundValue<GraphType, ItemPickerFilter.unboundColumn7>(gr, cs);
            cs.UnboundValueColumn8 = _GetUnboundValue<GraphType, ItemPickerFilter.unboundColumn8>(gr, cs);
            cs.UnboundValueColumn9 = _GetUnboundValue<GraphType, ItemPickerFilter.unboundColumn9>(gr, cs);
        }
        private string _GetUnboundValue<GraphType, T>(PXGraph gr, ItemPickerSelected cs)
            where GraphType : PXGraph
            where T : class, IBqlField
        {
            GraphType graph = gr as GraphType;
            if (graph == null) return "";

            IIProductLineFilter filter = PXSelect<IIProductLineFilter, Where<IIProductLineFilter.productLineID, Equal<Current<ItemPickerFilter.productLineID>>, And<IIProductLineFilter.filterID, Equal<Current<T>>>>, OrderBy<Asc<IIProductLineFilter.sortOrder>>>.Select(graph, cs.ProductLineID).RowCast<IIProductLineFilter>()?.FirstOrDefault();

            switch (filter?.MappingColumnNbr)
            {
                case 1: return cs.Column1;
                case 2: return cs.Column2;
                case 3: return cs.Column3;
                case 4: return cs.Column4;
                case 5: return cs.Column5;
                case 6: return cs.Column6;
                case 7: return cs.Column7;
                case 8: return cs.Column8;
                case 9: return cs.Column9;
            }

            return "";
        }
        protected static Type GetTypeField<Source>(string field)
        {
            Type sourceType = typeof(Source);
            Type fieldType = null;
            while (fieldType == null && sourceType != null)
            {
                fieldType = sourceType.GetNestedType(field, System.Reflection.BindingFlags.Public);
                sourceType = sourceType.BaseType;
            }
            return fieldType;
        }

        private class Zero : Constant<Decimal>
        {
            public Zero() : base(0m) { }
        }
        #endregion
    }
    #endregion


    [System.SerializableAttribute()]
    [PXProjection(typeof(Select2<ItemPickerMapping,
        InnerJoin<InventoryItem,
                        On<ItemPickerMapping.inventoryID, Equal<InventoryItem.inventoryID>>,
        LeftJoin<INSiteStatus,
                        On<INSiteStatus.inventoryID, Equal<InventoryItem.inventoryID>,
                        And<InventoryItem.stkItem, Equal<boolTrue>>>,
        LeftJoin<INSubItem,
                        On<INSubItem.subItemID, Equal<INSiteStatus.subItemID>>,
        LeftJoin<INSite,
                        On<INSite.siteID, Equal<INSiteStatus.siteID>, And<INSite.siteID, NotEqual<SiteAttribute.transitSiteID>>>,
        LeftJoin<INItemClass,
                        On<INItemClass.itemClassID, Equal<InventoryItem.itemClassID>>,
        LeftJoin<INPriceClass,
                        On<INPriceClass.priceClassID, Equal<InventoryItem.priceClassID>>,
        LeftJoin<BAccountR,
                        On<BAccountR.bAccountID, Equal<InventoryItem.preferredVendorID>>,
        LeftJoin<INItemCustSalesStats,
                  On<CurrentValue<ItemPickerFilter.mode>, Equal<SOAddItemMode.byCustomer>,
                            And<INItemCustSalesStats.inventoryID, Equal<InventoryItem.inventoryID>,
                            And<INItemCustSalesStats.subItemID, Equal<INSiteStatus.subItemID>,
                            And<INItemCustSalesStats.siteID, Equal<INSiteStatus.siteID>,
                            And<INItemCustSalesStats.bAccountID, Equal<CurrentValue<SOOrder.customerID>>,
                            And<INItemCustSalesStats.lastDate, GreaterEqual<CurrentValue<ItemPickerFilter.historyDate>>>>>>>>,
    LeftJoin<INUnit,
                    On<INUnit.inventoryID, Equal<InventoryItem.inventoryID>,
                 And<INUnit.unitType, Equal<int1>,
                 And<INUnit.fromUnit, Equal<InventoryItem.salesUnit>,
                 And<INUnit.toUnit, Equal<InventoryItem.baseUnit>>>>>
                            >>>>>>>>>,
        Where<Null, IsNull,
          And2<CurrentMatch<InventoryItem, AccessInfo.userName>,
            And2<Where<INSiteStatus.siteID, IsNull, Or<INSite.branchID, IsNotNull, And<CurrentMatch<INSite, AccessInfo.userName>>>>,
            And2<Where<INSiteStatus.subItemID, IsNull, Or<CurrentMatch<INSubItem, AccessInfo.userName>>>,
            //And2<Where<CurrentValue<INSiteStatusFilter.onlyAvailable>, Equal<boolFalse>,
            //       Or<INSiteStatus.qtyAvail, Greater<decimal0>>>,
            And<InventoryItem.itemStatus, NotEqual<InventoryItemStatus.inactive>,
            And<InventoryItem.itemStatus, NotEqual<InventoryItemStatus.unknown>,
            And<InventoryItem.itemStatus, NotEqual<InventoryItemStatus.markedForDeletion>,
            And<InventoryItem.itemStatus, NotEqual<InventoryItemStatus.noSales>>>>>>>>>>), Persistent = false)]
    public partial class ItemPickerSelected : IBqlTable
    {
        #region Selected
        public abstract class selected : PX.Data.IBqlField
        {
        }
        protected bool? _Selected = false;
        [PXBool]
        [PXDefault(false)]
        [PXUIField(DisplayName = "Selected")]
        public virtual bool? Selected
        {
            get
            {
                return _Selected;
            }
            set
            {
                _Selected = value;
            }
        }
        #endregion

        #region InventoryID
        public abstract class inventoryID : PX.Data.IBqlField
        {
        }
        protected Int32? _InventoryID;
        [Inventory(BqlField = typeof(InventoryItem.inventoryID))]
        //[PXDBInt(BqlField = typeof(InventoryItem.inventoryID), IsKey = true)]
        [PXDefault()]
        public virtual Int32? InventoryID
        {
            get
            {
                return this._InventoryID;
            }
            set
            {
                this._InventoryID = value;
            }
        }
        #endregion

        #region InventoryCD
        public abstract class inventoryCD : PX.Data.IBqlField
        {
        }
        protected string _InventoryCD;
        [PXDefault()]
        [InventoryRaw(BqlField = typeof(InventoryItem.inventoryCD), IsKey = true)]
        public virtual String InventoryCD
        {
            get
            {
                return this._InventoryCD;
            }
            set
            {
                this._InventoryCD = value;
            }
        }
        #endregion

        #region Descr
        public abstract class descr : PX.Data.IBqlField
        {
        }

        protected string _Descr;
        [PXDBLocalizableString(60, IsUnicode = true, BqlField = typeof(InventoryItem.descr), IsProjection = true)]
        [PXUIField(DisplayName = "Description", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual String Descr
        {
            get
            {
                return this._Descr;
            }
            set
            {
                this._Descr = value;
            }
        }
        #endregion

        #region ItemClassID
        public abstract class itemClassID : PX.Data.IBqlField
        {
        }
        protected int? _ItemClassID;
        [PXDBInt(BqlField = typeof(InventoryItem.itemClassID))]
        [PXUIField(DisplayName = "Item Class ID", Visible = false)]
        [PXDimensionSelector(INItemClass.Dimension, typeof(INItemClass.itemClassID), typeof(INItemClass.itemClassCD), ValidComboRequired = true)]
        public virtual int? ItemClassID
        {
            get
            {
                return this._ItemClassID;
            }
            set
            {
                this._ItemClassID = value;
            }
        }
        #endregion

        #region ItemClassCD
        public abstract class itemClassCD : PX.Data.IBqlField
        {
        }
        protected string _ItemClassCD;
        [PXDBString(30, IsUnicode = true, BqlField = typeof(INItemClass.itemClassCD))]
        public virtual string ItemClassCD
        {
            get
            {
                return this._ItemClassCD;
            }
            set
            {
                this._ItemClassCD = value;
            }
        }
        #endregion

        #region ItemClassDescription
        public abstract class itemClassDescription : PX.Data.IBqlField
        {
        }
        protected String _ItemClassDescription;
        [PXDBLocalizableString(PX.Objects.Common.Constants.TranDescLength, IsUnicode = true, BqlField = typeof(INItemClass.descr), IsProjection = true)]
        [PXUIField(DisplayName = "Item Class Description", Visible = false, ErrorHandling = PXErrorHandling.Always)]
        public virtual String ItemClassDescription
        {
            get
            {
                return this._ItemClassDescription;
            }
            set
            {
                this._ItemClassDescription = value;
            }
        }
        #endregion

        #region PriceClassID
        public abstract class priceClassID : PX.Data.IBqlField
        {
        }

        protected string _PriceClassID;
        [PXDBString(10, IsUnicode = true, BqlField = typeof(InventoryItem.priceClassID))]
        [PXUIField(DisplayName = "Price Class ID", Visible = false)]
        public virtual String PriceClassID
        {
            get
            {
                return this._PriceClassID;
            }
            set
            {
                this._PriceClassID = value;
            }
        }
        #endregion

        #region PriceClassDescription
        public abstract class priceClassDescription : PX.Data.IBqlField
        {
        }
        protected String _PriceClassDescription;
        [PXDBString(PX.Objects.Common.Constants.TranDescLength, IsUnicode = true, BqlField = typeof(INPriceClass.description))]
        [PXUIField(DisplayName = "Price Class Description", Visible = false, ErrorHandling = PXErrorHandling.Always)]
        public virtual String PriceClassDescription
        {
            get
            {
                return this._PriceClassDescription;
            }
            set
            {
                this._PriceClassDescription = value;
            }
        }
        #endregion

        #region PreferredVendorID
        public abstract class preferredVendorID : PX.Data.IBqlField
        {
        }

        protected Int32? _PreferredVendorID;
        [PX.Objects.AP.VendorNonEmployeeActive(DisplayName = "Preferred Vendor ID", Required = false, DescriptionField = typeof(BAccountR.acctName), BqlField = typeof(InventoryItem.preferredVendorID), Visible = false, ErrorHandling = PXErrorHandling.Always)]
        public virtual Int32? PreferredVendorID
        {
            get
            {
                return this._PreferredVendorID;
            }
            set
            {
                this._PreferredVendorID = value;
            }
        }
        #endregion

        #region PreferredVendorDescription
        public abstract class preferredVendorDescription : PX.Data.IBqlField
        {
        }
        protected String _PreferredVendorDescription;
        [PXDBString(250, IsUnicode = true, BqlField = typeof(BAccountR.acctName))]
        [PXUIField(DisplayName = "Preferred Vendor Name", Visible = false, ErrorHandling = PXErrorHandling.Always)]
        public virtual String PreferredVendorDescription
        {
            get
            {
                return this._PreferredVendorDescription;
            }
            set
            {
                this._PreferredVendorDescription = value;
            }
        }
        #endregion

        #region BarCode
        public abstract class barCode : PX.Data.IBqlField
        {
        }
        protected String _BarCode;
        [PXDBString(255, BqlField = typeof(INItemXRef.alternateID), IsUnicode = true)]
        [PXUIField(DisplayName = "Barcode", Visible = false)]
        public virtual String BarCode
        {
            get
            {
                return this._BarCode;
            }
            set
            {
                this._BarCode = value;
            }
        }
        #endregion

        #region AlternateID
        public abstract class alternateID : PX.Data.IBqlField
        {
        }
        protected String _AlternateID;
        [PXDBString(225, IsUnicode = true, InputMask = "", BqlField = typeof(INItemPartNumber.alternateID))]
        [PXUIField(DisplayName = "Alternate ID")]
        [PXExtraKey]
        public virtual String AlternateID
        {
            get
            {
                return this._AlternateID;
            }
            set
            {
                this._AlternateID = value;
            }
        }
        #endregion

        #region AlternateType
        public abstract class alternateType : PX.Data.IBqlField
        {
        }
        protected String _AlternateType;
        [PXDBString(4, BqlField = typeof(INItemPartNumber.alternateType))]
        [INAlternateType.List()]
        [PXDefault(INAlternateType.Global)]
        [PXUIField(DisplayName = "Alternate Type")]
        public virtual String AlternateType
        {
            get
            {
                return this._AlternateType;
            }
            set
            {
                this._AlternateType = value;
            }
        }
        #endregion

        #region Descr
        public abstract class alternateDescr : PX.Data.IBqlField
        {
        }
        protected String _AlternateDescr;
        [PXDBString(60, IsUnicode = true, BqlField = typeof(INItemPartNumber.descr))]
        [PXUIField(DisplayName = "Alternate Description", Visible = false)]
        public virtual String AlternateDescr
        {
            get
            {
                return this._AlternateDescr;
            }
            set
            {
                this._AlternateDescr = value;
            }
        }
        #endregion

        #region SiteID
        public abstract class siteID : PX.Data.IBqlField
        {
        }
        protected int? _SiteID;
        [PXUIField(DisplayName = "Warehouse")]
        [SiteAttribute(BqlField = typeof(INSiteStatus.siteID))]
        public virtual Int32? SiteID
        {
            get
            {
                return this._SiteID;
            }
            set
            {
                this._SiteID = value;
            }
        }
        #endregion

        #region SiteCD
        public abstract class siteCD : PX.Data.IBqlField
        {
        }
        protected String _SiteCD;
        [PXDBString(IsUnicode = true, BqlField = typeof(INSite.siteCD), IsKey = true)]
        [PXDimension(SiteAttribute.DimensionName)]
        public virtual String SiteCD
        {
            get
            {
                return this._SiteCD;
            }
            set
            {
                this._SiteCD = value;
            }
        }
        #endregion
        #region ProductLineID
        public abstract class productLineID : PX.Data.IBqlField { }
        [PXDBString(IsUnicode = true, BqlField = typeof(ItemPickerMapping.productLineID), IsKey = true)]
        [PXUIField(DisplayName = "Product Line")]
        public virtual string ProductLineID { get; set; }
        #endregion

        #region LineNbr
        public abstract class lineNbr : PX.Data.IBqlField { }
        [PXDBInt(BqlField = typeof(ItemPickerMapping.lineNbr), IsKey = true)]
        public virtual int? LineNbr { get; set; }
        #endregion

        #region Columns
        #region Column1
        public abstract class column1 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true, BqlField = typeof(ItemPickerMapping.column1))]
        [PXUIField(DisplayName = "Column 1", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Column1 { get; set; }
        #endregion
        #region unboundValueColumn1
        public abstract class unboundValueColumn1 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 1")]
        public virtual String UnboundValueColumn1 { get; set; }
        #endregion

        #region Column2
        public abstract class column2 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true, BqlField = typeof(ItemPickerMapping.column2))]
        [PXUIField(DisplayName = "Column 2", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Column2 { get; set; }
        #endregion
        #region unboundValueColumn2
        public abstract class unboundValueColumn2 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 2")]
        public virtual String UnboundValueColumn2 { get; set; }
        #endregion

        #region Column3
        public abstract class column3 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true, BqlField = typeof(ItemPickerMapping.column3))]
        [PXUIField(DisplayName = "Column 3", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Column3 { get; set; }
        #endregion
        #region unboundValueColumn3
        public abstract class unboundValueColumn3 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 3")]
        public virtual String UnboundValueColumn3 { get; set; }
        #endregion

        #region Column4
        public abstract class column4 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true, BqlField = typeof(ItemPickerMapping.column4))]
        [PXUIField(DisplayName = "Column 4", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Column4 { get; set; }
        #endregion
        #region unboundValueColumn4
        public abstract class unboundValueColumn4 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 4")]
        public virtual String UnboundValueColumn4 { get; set; }
        #endregion

        #region Column5
        public abstract class column5 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true, BqlField = typeof(ItemPickerMapping.column5))]
        [PXUIField(DisplayName = "Column 5", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Column5 { get; set; }
        #endregion
        #region unboundValueColumn5
        public abstract class unboundValueColumn5 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 5")]
        public virtual String UnboundValueColumn5 { get; set; }
        #endregion

        #region Column6
        public abstract class column6 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true, BqlField = typeof(ItemPickerMapping.column6))]
        [PXUIField(DisplayName = "Column 6", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Column6 { get; set; }
        #endregion
        #region unboundValueColumn6
        public abstract class unboundValueColumn6 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 6")]
        public virtual String UnboundValueColumn6 { get; set; }
        #endregion

        #region Column7
        public abstract class column7 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true, BqlField = typeof(ItemPickerMapping.column7))]
        [PXUIField(DisplayName = "Column 7", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Column7 { get; set; }
        #endregion
        #region unboundValueColumn7
        public abstract class unboundValueColumn7 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 7")]
        public virtual String UnboundValueColumn7 { get; set; }
        #endregion

        #region Column8
        public abstract class column8 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true, BqlField = typeof(ItemPickerMapping.column8))]
        [PXUIField(DisplayName = "Column 8", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Column8 { get; set; }
        #endregion
        #region unboundValueColumn8
        public abstract class unboundValueColumn8 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 8")]
        public virtual String UnboundValueColumn8 { get; set; }
        #endregion

        #region Column9
        public abstract class column9 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true, BqlField = typeof(ItemPickerMapping.column9))]
        [PXUIField(DisplayName = "Column 9", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Column9 { get; set; }
        #endregion
        #region unboundValueColumn9
        public abstract class unboundValueColumn9 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 9")]
        public virtual String UnboundValueColumn9 { get; set; }
        #endregion
        #endregion

        #region SubItemID
        public abstract class subItemID : PX.Data.IBqlField
        {
        }
        protected int? _SubItemID;
        [SubItem(typeof(ItemPickerSelected.inventoryID), BqlField = typeof(INSubItem.subItemID))]
        public virtual Int32? SubItemID
        {
            get
            {
                return this._SubItemID;
            }
            set
            {
                this._SubItemID = value;
            }
        }
        #endregion

        #region SubItemCD
        public abstract class subItemCD : PX.Data.IBqlField
        {
        }
        protected String _SubItemCD;
        [PXDBString(BqlField = typeof(INSubItem.subItemCD), IsUnicode = true)]
        [PXDimension(SubItemAttribute.DimensionName)]
        public virtual String SubItemCD
        {
            get
            {
                return this._SubItemCD;
            }
            set
            {
                this._SubItemCD = value;
            }
        }
        #endregion

        #region BaseUnit
        public abstract class baseUnit : PX.Data.IBqlField
        {
        }

        protected string _BaseUnit;
        [INUnit(DisplayName = "Base Unit", Visibility = PXUIVisibility.Visible, BqlField = typeof(InventoryItem.baseUnit))]
        public virtual String BaseUnit
        {
            get
            {
                return this._BaseUnit;
            }
            set
            {
                this._BaseUnit = value;
            }
        }
        #endregion

        #region CuryID
        public abstract class curyID : PX.Data.IBqlField
        {
        }
        protected String _CuryID;
        [PXString(5, IsUnicode = true, InputMask = ">LLLLL")]
        [PXUIField(DisplayName = "Currency", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual String CuryID
        {
            get
            {
                return this._CuryID;
            }
            set
            {
                this._CuryID = value;
            }
        }
        #endregion

        #region CuryInfoID
        public abstract class curyInfoID : PX.Data.IBqlField
        {
        }
        protected Int64? _CuryInfoID;
        [PXLong()]
        [CurrencyInfo()]
        public virtual Int64? CuryInfoID
        {
            get
            {
                return this._CuryInfoID;
            }
            set
            {
                this._CuryInfoID = value;
            }
        }
        #endregion

        #region SalesUnit
        public abstract class salesUnit : PX.Data.IBqlField
        {
        }
        protected string _SalesUnit;
        [INUnit(typeof(ItemPickerSelected.inventoryID), DisplayName = "Sales Unit", BqlField = typeof(InventoryItem.salesUnit))]
        public virtual String SalesUnit
        {
            get
            {
                return this._SalesUnit;
            }
            set
            {
                this._SalesUnit = value;
            }
        }
        #endregion

        #region QtySelected
        public abstract class qtySelected : PX.Data.IBqlField
        {
        }
        protected Decimal? _QtySelected;
        [PXQuantity]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Qty. Selected")]
        public virtual Decimal? QtySelected
        {
            get
            {
                return this._QtySelected ?? 0m;
            }
            set
            {
                if (value != null && value != 0m)
                    this._Selected = true;
                this._QtySelected = value;
            }
        }
        #endregion

        #region QtyOnHand
        public abstract class qtyOnHand : PX.Data.IBqlField
        {
        }
        protected Decimal? _QtyOnHand;
        [PXDBQuantity(BqlField = typeof(INSiteStatus.qtyOnHand))]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Qty. On Hand")]
        public virtual Decimal? QtyOnHand
        {
            get
            {
                return this._QtyOnHand;
            }
            set
            {
                this._QtyOnHand = value;
            }
        }
        #endregion

        #region QtyAvail
        public abstract class qtyAvail : PX.Data.IBqlField
        {
        }
        protected Decimal? _QtyAvail;
        [PXDBQuantity(BqlField = typeof(INSiteStatus.qtyAvail))]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Qty. Available")]
        public virtual Decimal? QtyAvail
        {
            get
            {
                return this._QtyAvail;
            }
            set
            {
                this._QtyAvail = value;
            }
        }
        #endregion

        #region QtyLast
        public abstract class qtyLast : PX.Data.IBqlField
        {
        }
        protected Decimal? _QtyLast;
        [PXDBQuantity(BqlField = typeof(INItemCustSalesStats.lastQty))]
        [PXDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? QtyLast
        {
            get
            {
                return this._QtyLast;
            }
            set
            {
                this._QtyLast = value;
            }
        }
        #endregion

        #region BaseUnitPrice
        public abstract class baseUnitPrice : PX.Data.IBqlField
        {
        }
        protected Decimal? _BaseUnitPrice;
        [PXDBPriceCost(BqlField = typeof(INItemCustSalesStats.lastUnitPrice))]
        [PXDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? BaseUnitPrice
        {
            get
            {
                return this._BaseUnitPrice;
            }
            set
            {
                this._BaseUnitPrice = value;
            }
        }
        #endregion

        #region CuryUnitPrice
        public abstract class curyUnitPrice : PX.Data.IBqlField
        {
        }
        protected Decimal? _CuryUnitPrice;
        [PXUnitPriceCuryConv(typeof(ItemPickerSelected.curyInfoID), typeof(ItemPickerSelected.baseUnitPrice))]
        [PXUIField(DisplayName = "Last Unit Price", Visibility = PXUIVisibility.SelectorVisible)]
        [PXDefault(TypeCode.Decimal, "0.0")]
        public virtual Decimal? CuryUnitPrice
        {
            get
            {
                return this._CuryUnitPrice;
            }
            set
            {
                this._CuryUnitPrice = value;
            }
        }
        #endregion

        #region QtyAvailSale
        public abstract class qtyAvailSale : PX.Data.IBqlField
        {
        }
        protected Decimal? _QtyAvailSale;
        [PXDBCalced(typeof(Switch<Case<Where<INUnit.unitMultDiv, Equal<MultDiv.divide>>,
            Mult<INSiteStatus.qtyAvail, INUnit.unitRate>>,
            Div<INSiteStatus.qtyAvail, INUnit.unitRate>>), typeof(decimal))]
        [PXQuantity()]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Qty. Available")]
        public virtual Decimal? QtyAvailSale
        {
            get
            {
                return this._QtyAvailSale;
            }
            set
            {
                this._QtyAvailSale = value;
            }
        }
        #endregion

        #region QtyOnHandSale
        public abstract class qtyOnHandSale : PX.Data.IBqlField
        {
        }
        protected Decimal? _QtyOnHandSale;
        [PXDBCalced(typeof(Switch<Case<Where<INUnit.unitMultDiv, Equal<MultDiv.divide>>,
            Mult<INSiteStatus.qtyOnHand, INUnit.unitRate>>,
            Div<INSiteStatus.qtyOnHand, INUnit.unitRate>>), typeof(decimal))]
        [PXQuantity()]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Qty. On Hand")]
        public virtual Decimal? QtyOnHandSale
        {
            get
            {
                return this._QtyOnHandSale;
            }
            set
            {
                this._QtyOnHandSale = value;
            }
        }
        #endregion

        #region QtyLastSale
        public abstract class qtyLastSale : PX.Data.IBqlField
        {
        }
        protected Decimal? _QtyLastSale;
        [PXDBCalced(typeof(Switch<Case<Where<INUnit.unitMultDiv, Equal<MultDiv.divide>>,
            Mult<INItemCustSalesStats.lastQty, INUnit.unitRate>>,
            Div<INItemCustSalesStats.lastQty, INUnit.unitRate>>), typeof(decimal))]
        [PXQuantity()]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Qty. Last Sales")]
        public virtual Decimal? QtyLastSale
        {
            get
            {
                return this._QtyLastSale;
            }
            set
            {
                this._QtyLastSale = value;
            }
        }
        #endregion

        #region LastSalesDate
        public abstract class lastSalesDate : PX.Data.IBqlField
        {
        }
        protected DateTime? _LastSalesDate;
        [PXDBDate(BqlField = typeof(INItemCustSalesStats.lastDate))]
        [PXUIField(DisplayName = "Last Sales Date")]
        public virtual DateTime? LastSalesDate
        {
            get
            {
                return this._LastSalesDate;
            }
            set
            {
                this._LastSalesDate = value;
            }
        }
        #endregion
        #region NoteID
        public abstract class noteID : PX.Data.IBqlField
        {
        }
        protected Guid? _NoteID;
        [PXNote(BqlField = typeof(ItemPickerMapping.noteID))]
        public virtual Guid? NoteID
        {
            get
            {
                return this._NoteID;
            }
            set
            {
                this._NoteID = value;
            }
        }
        #endregion
    }
}
