using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PX.Data;
using PX.Objects.AR;
using PX.Objects.CS;

namespace ItemPicker
{
    [System.SerializableAttribute()]
    public class IIProductLine : PX.Data.IBqlTable
    {
        #region ProductLineID
        public abstract class productLineID : PX.Data.IBqlField { }
        [PXDBString(30, IsUnicode = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Product Line ID", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Search<IIProductLine.productLineID>))]
        public virtual string ProductLineID { get; set; }
        #endregion
        #region Descr
        public abstract class descr : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXDefault]
        [PXUIField(DisplayName = "Description", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Descr { get; set; }
        #endregion
        #region FilterID
        public abstract class filtersCount : PX.Data.IBqlField { }
        [PXDBInt]
        [PXIntList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            new string[] { "1", "2", "3", "4", "5", "6", "7", "8" , "9"})]
        [PXDefault(3)]
        [PXUIField(DisplayName = "Filters")]
        public virtual int? FiltersCount { get; set; }
        #endregion
        /*
         #region Status
        public abstract class status : PX.Data.IBqlField { }
        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Active", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual bool? Status { get; set; }
        #endregion
        #region AllowNSItems
        public abstract class allowNSItems : PX.Data.IBqlField { }
        [PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Allow Non-Stock Items", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual bool? AllowNSItems { get; set; }
        #endregion
        */

        #region UnboundColumns
        #region UnboundColumn1
        public abstract class unboundColumn1 : PX.Data.IBqlField { }
        [PXString(10, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn1 { get; set; }
        #endregion

        #region UnboundColumn2
        public abstract class unboundColumn2 : PX.Data.IBqlField { }
        [PXString(10, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn2 { get; set; }
        #endregion

        #region UnboundColumn3
        public abstract class unboundColumn3 : PX.Data.IBqlField { }
        [PXString(10, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn3 { get; set; }
        #endregion

        #region UnboundColumn4
        public abstract class unboundColumn4 : PX.Data.IBqlField { }
        [PXString(10, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn4 { get; set; }
        #endregion

        #region UnboundColumn5
        public abstract class unboundColumn5 : PX.Data.IBqlField { }
        [PXString(10, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn5 { get; set; }
        #endregion

        #region UnboundColumn6
        public abstract class unboundColumn6 : PX.Data.IBqlField { }
        [PXString(10, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn6 { get; set; }
        #endregion

        #region UnboundColumn7
        public abstract class unboundColumn7 : PX.Data.IBqlField { }
        [PXString(10, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn7 { get; set; }
        #endregion

        #region UnboundColumn8
        public abstract class unboundColumn8 : PX.Data.IBqlField { }
        [PXString(10, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn8 { get; set; }
        #endregion

        #region UnboundColumn9
        public abstract class unboundColumn9 : PX.Data.IBqlField { }
        [PXString(10, IsUnicode = true)]
        [PXUIField(IsReadOnly = true)]
        public virtual string UnboundColumn9 { get; set; }
        #endregion
        #endregion

        #region NoteID
        public abstract class noteID : PX.Data.IBqlField { }
        [PXNote]
        public virtual Guid? NoteID { get; set; }
        #endregion

        #region LastItemMappingNbr
        public abstract class lastItemMappingNbr : PX.Data.IBqlField { }
        protected int? _LastItemMappingNbr;
        [PXDBInt()]
        [PXDefault(0)]
        public virtual int? LastItemMappingNbr
        {
            get
            {
                return this._LastItemMappingNbr;
            }
            set
            {
                this._LastItemMappingNbr = value;
            }
        }
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
