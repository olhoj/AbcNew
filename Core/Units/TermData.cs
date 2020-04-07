namespace Abc.Core.Units {

    public class TermData {

        public TermData(string termId, sbyte power= 1) {
            TermId = termId;
            Power = power;
        }
        public string TermId;
        public sbyte Power;

    }

}