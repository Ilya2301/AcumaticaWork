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
    public class IIProductLineFilterOpt : PX.Data.IBqlTable
    {
        #region ProductLineID
        public abstract class productLineID : PX.Data.IBqlField { }
        [PXDBString(30, IsUnicode = true, IsKey = true)]
        [PXDBDefault(typeof(IIProductLineFilter.productLineID))]
        public virtual string ProductLineID { get; set; }
        #endregion
        #region FilterID
        public abstract class filterID : PX.Data.IBqlField { }
        [PXDBString(30, IsUnicode = true, IsKey = true)]
        [PXDBDefault(typeof(IIProductLineFilter.filterID))]
        [PXParent(typeof(Select<IIProductLineFilter,
            Where<IIProductLineFilter.filterID,
            Equal<Current<IIProductLineFilterOpt.filterID>>>>))
        ]
        public virtual string FilterID { get; set; }
        #endregion
        #region LineNbr
        public abstract class lineNbr : PX.Data.IBqlField { }
        [PXDBInt(IsKey = true)]
        [PXLineNbr(typeof(IIProductLineFilter.lastFilterOptNbr))]
        public virtual int? LineNbr { get; set; }
        #endregion
        #region ValueID
        public abstract class valueID : PX.Data.IBqlField { }
        [PXDBString(255, IsKey = true, IsUnicode = true)]
        [PXDefault]
        [PXUIField(DisplayName = "Value ID", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string ValueID { get; set; }
        #endregion
        #region Descr
        public abstract class descr : PX.Data.IBqlField { }
        [PXDBString(255, IsUnicode = true)]
        [PXDefault]
        [PXUIField(DisplayName = "Description", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Descr { get; set; }
        #endregion
        #region SortOrder
        public abstract class sortOrder : PX.Data.IBqlField { }
        [PXDBInt(MinValue = 1, MaxValue = 9)]
        [PXDefault]
        [PXUIField(DisplayName = "Sort Order", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual int? SortOrder { get; set; }
        #endregion
        #region Status
        public abstract class disabled : PX.Data.IBqlField { }
        [PXDBBool()]
        [PXDefault(false)]
        [PXUIField(DisplayName = "Disabled")]
        public virtual bool? Disabled { get; set; }
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

