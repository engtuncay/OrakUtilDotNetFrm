using System.Collections.Generic;

namespace OrakUtilDotNetFrm.FiContainer
{
    public class Fks : Dictionary<string, string>
    {
        
        //public HashSet<FiCol> setFiCol { get; set; }
        
        public Fks()
        {
        }

        public Fks(IDictionary<string, string> dictionary) : base(dictionary)
        {
        }
        
        // public void AddByFiCol(FiCol ficol, object objValue)
        // {
        //     GetSetFiColInit().Add(ficol);
        //     Add(ficol.ofcTxFieldName,objValue);
        // }

        // public HashSet<FiCol> GetSetFiColInit()
        // {
        //     return setFiCol ?? (setFiCol = new HashSet<FiCol>());
        // }

    }
}
