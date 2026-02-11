using OrakUtilDotNetFrm.DbGeneric;
using OrakYazilimLib.Util.Collection;
using System.Collections.Generic;

namespace OrakUtilDotNetFrm.DataContainer
{
  public class DtoFiCol
  {
    public static List<dynamic> ImportDtoFiCol2(FicList ficList)
    {
      List<dynamic> list = new List<dynamic>();

      foreach (var ficol in ficList)
      {
        dynamic obj = CreateDynamicFiCol2(ficol);
        list.Add(obj);
      }

      return list;
    }
    public static dynamic CreateDynamicFiCol2(FiCol ficol)
    {
      dynamic obj = new System.Dynamic.ExpandoObject();

      if(ficol.fcTxFieldName != null) obj.fcTxFieldName = ficol.fcTxFieldName;
      if(ficol.fcTxHeader != null) obj.fcTxHeader = ficol.fcTxHeader;
      if(ficol.fcLnLength != null) obj.fcLength = ficol.fcLnLength;
      if(ficol.fcLnPrecision != null) obj.fcPrecision = ficol.fcLnPrecision;
      if(ficol.fcTxFieldDesc != null) obj.fcFieldDesc = ficol.fcTxFieldDesc;

      return obj;
    }
  }
}