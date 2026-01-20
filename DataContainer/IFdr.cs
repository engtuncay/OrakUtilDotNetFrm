using OrakYazilimLib.Util.FiEntity;
using System;
using System.Collections.Generic;

namespace OrakUtilDotNetFrm.DataContainer
{
  public interface IFdr
  {
    bool? boResult { get;set; }
    bool? boExecution { get;set; }
    Exception refException { get; set; }
    string txMessage { get; set; }
    List<FieLog> GetListFieLogInit();
  }
}