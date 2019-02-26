using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit
{

    partial class M
    {
        partial class M2
        {
            public class M22 : M2
            {
                public string val{get;set;}
                public new  const string _type=M2._type+"."+nameof(M22);
                protected override string MessageKind => _type;
            }
        }
    }
}
