namespace OrakUtilDotNetFrm.FiContainer
{

  public class Fdr : FdrGen<object>
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