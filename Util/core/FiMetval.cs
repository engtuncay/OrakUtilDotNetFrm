namespace OrakUtilDotNetFrm.Util.core
{
    public class FiMetval
    {
        /**
         * TxCode (TxKodu)
        */
        public string txKey { get; set; }

        public string txValue { get; set; }

        /**
         * LnCode (LnKodu)
         * <p>
         * Key Meta Karşılık Gelen Integer Kod varsa
         */
        public int lnKey { get; set; }

        /**
         * Açıklama (Description) gibi düşünebiliriz
         */
        public string txLabel { get; set; }

        public string txType { get; set; }

        public FiMetval() {}

        public FiMetval(string txValue)
        {
            this.txValue = txValue;
        }


    }
}