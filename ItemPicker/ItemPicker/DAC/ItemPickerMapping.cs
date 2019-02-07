using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PX.Data;
using PX.Objects.AR;
using PX.Objects.CS;
using PX.Objects.IN;

namespace ItemPicker
{
    [System.SerializableAttribute()]
    public class ItemPickerMapping : PX.Data.IBqlTable
    {
        #region ProductLineID
        public abstract class productLineID : PX.Data.IBqlField { }
        [PXDBString(30, IsUnicode = true, IsKey = true)]
        [PXDBDefault(typeof(IIProductLine.productLineID))]
        [PXParent(typeof(Select<IIProductLine,
            Where<IIProductLine.productLineID,
            Equal<Current<productLineID>>>>))
        ]
        public virtual string ProductLineID { get; set; }
        #endregion
        #region LineNbr
        public abstract class lineNbr : PX.Data.IBqlField { }
        [PXDBInt(IsKey = true)]
        [PXLineNbr(typeof(IIProductLine.lastItemMappingNbr))]
        public virtual int? LineNbr { get; set; }
        #endregion
        #region InventoryID
        public abstract class inventoryID : PX.Data.IBqlField { }
        [PXDBInt()]
        [PXDefault()]
        [PXUIField(DisplayName = "Inventory ID", Enabled = true)]
        [PXSelector(
             typeof(Search<InventoryItem.inventoryID>),
                 //[AnyInventory(typeof(Search<InventoryItem.inventoryID, Where<InventoryItem.stkItem, NotEqual<boolFalse>, And<InventoryItem.itemStatus, NotEqual<InventoryItemStatus.unknown>, And<Where<Match<Current<AccessInfo.userName>>>>>>>), typeof(InventoryItem.inventoryCD), typeof(InventoryItem.descr))]
                   //     And2 < Where<INSiteStatus.siteID, IsNull, Or<INSite.branchID, IsNotNull, And<CurrentMatch<INSite, AccessInfo.userName>>>>,
             typeof(InventoryItem.inventoryCD),
             typeof(InventoryItem.descr),
             SubstituteKey = typeof(InventoryItem.inventoryCD)
            )
        ]
        public virtual int? InventoryID { get; set; }
        #endregion
        #region Description
        public abstract class description : PX.Data.IBqlField { }
        [PXDefault(typeof(Search<InventoryItem.descr, Where<InventoryItem.inventoryID, Equal<Current<inventoryID>>>>))]
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Description", Enabled = true, IsReadOnly = true)]
        public virtual string Description { get; set; }
        #endregion

        #region Columns
        #region Column1
        public abstract class column1 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 1", Visibility = PXUIVisibility.Invisible)]
        [PXDBDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual string Column1 { get; set; }
        #endregion
        #region UnboundValueColumn1
        public abstract class unboundValueColumn1 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 1", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLine.unboundColumn1>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>>))]
        public virtual string UnboundValueColumn1 { get; set; }
        #endregion

        #region Column2
        public abstract class column2 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 2", Visibility = PXUIVisibility.Invisible)]
        [PXDBDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual string Column2 { get; set; }
        #endregion
        #region UnboundValueColumn2
        public abstract class unboundValueColumn2 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 2", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLine.unboundColumn2>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>>))]
        public virtual string UnboundValueColumn2 { get; set; }
        #endregion

        #region Column3
        public abstract class column3 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 3", Visibility = PXUIVisibility.Invisible)]
        [PXDBDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual string Column3 { get; set; }
        #endregion
        #region UnboundValueColumn3
        public abstract class unboundValueColumn3 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 3", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLine.unboundColumn3>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>>))]
        public virtual string UnboundValueColumn3 { get; set; }
        #endregion

        #region Column4
        public abstract class column4 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 4", Visibility = PXUIVisibility.Invisible)]
        [PXDBDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual string Column4 { get; set; }
        #endregion
        #region UnboundValueColumn4
        public abstract class unboundValueColumn4 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 4", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLine.unboundColumn4>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>>))]
        public virtual string UnboundValueColumn4 { get; set; }
        #endregion

        #region Column5
        public abstract class column5 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 5", Visibility = PXUIVisibility.Invisible)]
        [PXDBDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual string Column5 { get; set; }
        #endregion
        #region UnboundValueColumn5
        public abstract class unboundValueColumn5 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 5", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLine.unboundColumn5>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>>))]
        public virtual string UnboundValueColumn5 { get; set; }
        #endregion

        #region Column6
        public abstract class column6 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 6", Visibility = PXUIVisibility.Invisible)]
        [PXDBDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual string Column6 { get; set; }
        #endregion
        #region UnboundValueColumn6
        public abstract class unboundValueColumn6 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 6", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLine.unboundColumn6>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>>))]
        public virtual string UnboundValueColumn6 { get; set; }
        #endregion

        #region Column7
        public abstract class column7 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 7", Visibility = PXUIVisibility.Invisible)]
        [PXDBDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual string Column7 { get; set; }
        #endregion
        #region UnboundValueColumn7
        public abstract class unboundValueColumn7 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 7", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLine.unboundColumn7>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>>))]
        public virtual string UnboundValueColumn7 { get; set; }
        #endregion

        #region Column8
        public abstract class column8 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 8", Visibility = PXUIVisibility.Invisible)]
        [PXDBDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual string Column8 { get; set; }
        #endregion
        #region UnboundValueColumn8
        public abstract class unboundValueColumn8 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 8", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLine.unboundColumn8>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>>))]
        public virtual string UnboundValueColumn8 { get; set; }
        #endregion

        #region Column9
        public abstract class column9 : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Column 9", Visibility = PXUIVisibility.Invisible)]
        [PXDBDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual string Column9 { get; set; }
        #endregion
        #region UnboundValueColumn9
        public abstract class unboundValueColumn9 : PX.Data.IBqlField { }
        [PXString(255, IsUnicode = true)]
        [PXUIField(DisplayName = "Unbound Value Column 9", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLineFilterOpt.valueID, Where<IIProductLineFilterOpt.productLineID, Equal<Current<IIProductLine.productLineID>>, And<IIProductLineFilterOpt.filterID, Equal<Current<IIProductLine.unboundColumn9>>, And<IIProductLineFilterOpt.disabled, NotEqual<True>>>>>))]
        public virtual string UnboundValueColumn9 { get; set; }
        #endregion
        #endregion

        #region NoteID
        public abstract class noteID : PX.Data.IBqlField { }
        [PXNote]
        public virtual Guid? NoteID { get; set; }
        #endregion
        #region Audit fields

        #region CreatedByID
        public abstract class createdByID : PX.Data.IBqlField { }
        [PXDBCreatedByID()]
        public virtual Guid? CreatedByID { get; set; }
        #endregion
        #region CreatedByScreenID
        public abstract class createdByScreenID : PX.Data.IBqlField { }
        [PXDBCreatedByScreenID()]
        public virtual String CreatedByScreenID { get; set; }
        #endregion
        #region CreatedDateTime
        public abstract class createdDateTime : PX.Data.IBqlField { }
        [PXDBCreatedDateTime()]
        public virtual DateTime? CreatedDateTime { get; set; }
        #endregion
        #region LastModifiedByID
        public abstract class lastModifiedByID : PX.Data.IBqlField { }
        [PXDBLastModifiedByID()]
        public virtual Guid? LastModifiedByID { get; set; }
        #endregion
        #region LastModifiedByScreenID
        public abstract class lastModifiedByScreenID : PX.Data.IBqlField { }
        [PXDBLastModifiedByScreenID()]
        public virtual String LastModifiedByScreenID { get; set; }
        #endregion
        #region LastModifiedDateTime
        public abstract class lastModifiedDateTime : PX.Data.IBqlField { }
        [PXDBLastModifiedDateTime()]
        public virtual DateTime? LastModifiedDateTime { get; set; }
        #endregion
        #region tstamp
        public abstract class Tstamp : PX.Data.IBqlField { }
        [PXDBTimestamp]
        public virtual Byte[] tstamp { get; set; }
        #endregion

        #endregion
    }
}
