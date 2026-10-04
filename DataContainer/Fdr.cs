using OrakUtilDotNetFrm.FiContainer;
using OrakYazilimLib.Util;

namespace OrakUtilDotNetFrm.DataContainer
{

  public class Fdr : Fdr<object>
  {
    public Fdr()
    {

    }

    public Fdr(bool boResult)
    {
      base.boResult = boResult;
    }






    public static Fdr BuiBoResult(bool? boResult)
    {
      Fdr fdr = new Fdr
      {
        boResult = boResult
      };

      return fdr;
    }
  }
}