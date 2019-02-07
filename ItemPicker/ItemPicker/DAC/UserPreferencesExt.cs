using PX.Data;
using PX.Objects;
using PX.SM;
using System;

namespace ItemPicker
{
  public class UserPreferencesExt : PXCacheExtension<PX.SM.UserPreferences>
  {
    #region UsrProductLineID
    public abstract class usrProductLineID : IBqlField { }
    [PXDBString(30)]
    [PXUIField(DisplayName="Default Item Picker Product Line")]
    [PXSelector(typeof(Search<IIProductLine.productLineID>),
             typeof(IIProductLine.descr)
            )]
    public virtual string UsrProductLineID { get; set; }
    #endregion
    }
}