using OrakUtilDotNetFrm.DbGeneric;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrakYazilimLib.DbGeneric;

namespace OrakYazilimLib.DbUtil
{
    public class FiListFiSqlParam : List<FiSqlParameter>
    {
        public void AddSqlParam(String value,Object objValue)
        {
            Add(new FiSqlParameter(value, objValue));
        }


        public void AddFi(FiCol fiField, Object objValue)
        {
            Add(new FiSqlParameter(fiField.fcTxFieldName, objValue));
        }

        public FiListFiSqlParam BuildAddFi(FiCol fiField, Object objValue)
        {
            Add(new FiSqlParameter(fiField.fcTxFieldName, objValue));
            return this;
        }
    }
}
