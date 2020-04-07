using System.Collections.Generic;

namespace Abc.Core.Units {

    public class Data {

        public Data(string id, string code, string name, string definition) {
            Id = id;
            Name = name ?? Id;
            Code = code ?? Name;
            Definition = definition;
            Terms = new List<TermData>();
        }

        public Data(string id, double factor) : this(id, null, null, null, factor) { }

        public Data(string id, string code, double factor) : this(id, code, null, null, factor) { }

        public Data(string id, string code, string name, double factor) : this(id, code, name, null, factor) { }

        public Data(string id, string code, string name, string definition, double factor) :
            this(id, code, name, definition) => Factor = factor;

        public Data(string id, params TermData[] terms) : this(id, null, null, null, terms) { }

        public Data(string id, string code, params TermData[] terms) : this(id, code, null, null, terms) { }

        public Data(string id, string code, string name, params TermData[] terms) :
            this(id, code, name, null, terms) { }

        public Data(string id, string code, string name, string definition, params TermData[] terms) : this(id, code,
            name, definition) =>
            Terms.AddRange(terms);

        public string Id;
        public string Code;
        public string Name;
        public string Definition;
        public double Factor;
        public List<TermData> Terms;

    }

}
