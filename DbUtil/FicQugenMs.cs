using OrakUtilDotNetFrm.DbGeneric;
using OrakYazilimLib.Util.Collection;
using OrakYazilimLib.Util.ColStruct;
using OrakYazilimLib.Util.core;
using System.Text;

namespace OrakUtilDotNetFrm.DbUtil
{
  /// <summary>
  /// FiCols Query Generator - Sorgu oluşturma yardımcı metodlar
  /// </summary>
  public static class FicQugenMs
  {

    public static string Select(FicList list, IFiTableMeta iFiTableMeta)
    {
      StringBuilder sb = new StringBuilder();

      sb.Append("SELECT ");

      for (int index = 0; index < list.Count; index++)
      {
        FiCol fiCol = list[index];

        if (index > 0) sb.Append(",");

        sb.Append($" {iFiTableMeta.GetITxPrefix()}.{fiCol.GetOfcTxDbFieldOr()} {fiCol.fcTxFieldName} ");
      }

      sb.Append($" FROM {iFiTableMeta.GetITxTableName()} {iFiTableMeta.GetITxPrefix()}");

      return sb.ToString();
    }

    public static string Insert(FicList list, IFiTableMeta iFiTableMeta)
    {
      string template = "INSERT INTO {{tableName}} ( {{csvFields}} ) \n"
        + " VALUES ( {{paramFields}} )";

      StringBuilder queryFields = new StringBuilder();
      StringBuilder queryParams = new StringBuilder();

      int indexFields = 1;
      int indexParams = 1;

      foreach (FiCol fiCol in list)
      {
        if (fiCol.CheckFiColIfPrimaryKey())
        {
          continue;
        }

        if (indexFields != 1) queryFields.Append(", ");
        queryFields.Append(fiCol.GetOfcTxDbFieldOr());

        if (indexParams != 1) queryParams.Append(", ");
        queryParams.Append("@").Append(fiCol.GetOfcTxDbFieldOr());

        indexFields++;
        indexParams++;
      }

      Fkb fkbTemplate = new Fkb();
      fkbTemplate.Add("tableName", iFiTableMeta.GetITxTableName());
      fkbTemplate.Add("csvFields", queryFields.ToString());
      fkbTemplate.Add("paramFields", queryParams.ToString());

      return FiTemplate.ReplaceTemplateParameters(template, fkbTemplate);
    }
  }


}