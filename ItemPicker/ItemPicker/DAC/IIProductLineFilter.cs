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
    public class IIProductLineFilter : PX.Data.IBqlTable
    {
        #region ProductLineID
        public abstract class productLineID : PX.Data.IBqlField { }
        [PXDBString(30, IsUnicode = true, IsKey = true)]
        [PXDBDefault(typeof(IIProductLine.productLineID))]
        [PXParent(typeof(Select<IIProductLine,
            Where<IIProductLine.productLineID,
            Equal<Current<IIProductLineFilter.productLineID>>>>))
        ]
        public virtual string ProductLineID { get; set; }
        #endregion
        #region FilterID
        public abstract class filterID : PX.Data.IBqlField { }
        [PXDBString(30, IsUnicode = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Label", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string FilterID { get; set; }
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
        [PXUIField(DisplayName = "Sort Order")]
        public virtual int? SortOrder { get; set; }
        #endregion
        #region MappingColumnNbr
        public abstract class mappingColumnNbr : PX.Data.IBqlField { }
        [PXDBInt(MinValue = 1, MaxValue = 9)]
        [PXDefault]
        [PXUIField(DisplayName = "Mapping Column Nbr")]
        public virtual int? MappingColumnNbr { get; set; }
        #endregion

        #region NoteID
        public abstract class noteID : PX.Data.IBqlField { }
        [PXNote]
        public virtual Guid? NoteID { get; set; }
        #endregion

        #region LastFilterOptNbr
        public abstract class lastFilterOptNbr : PX.Data.IBqlField { }
        protected int? _LastFilterOptNbr;
        [PXDBInt()]
        [PXDefault(0)]
        public virtual int? LastFilterOptNbr
        {
            get
            {
                return this._LastFilterOptNbr;
            }
            set
            {
                this._LastFilterOptNbr = value;
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

