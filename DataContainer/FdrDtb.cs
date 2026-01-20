using System.Data;

namespace OrakUtilDotNetFrm.DataContainer
{
  public class FdrDtb : Fdr<DataTable>
  {
    public FdrDtb(bool boResult) : base(boResult)
    {
    }
    public FdrDtb(int prmLnRowsAffected) : base(prmLnRowsAffected)
    {
    }
    public FdrDtb()
    {
    }

  }
}