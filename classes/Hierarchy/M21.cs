using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit
{

    partial class M
    {
        partial class M2
        {
            public class M21 : M2
            {
                public int [] value{get;set;}

                protected override string MessageKind =>_type;
                public new const string _type=M2._type+"."+nameof(M21);
            }
        }
    }
}
