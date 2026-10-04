using System.Data;

namespace OrakUtilDotNetFrm.FiContainer
{
  public class FdrDtb : FdrGen<DataTable>
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