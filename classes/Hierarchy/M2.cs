using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit
{

    partial class M
    {

        public partial class M2 : M
        {
            public static void Process(M1 message)
            {
                switch (message.MessageKind)
                {
                   
                }
            }
            [JsonIgnore]
            public bool IsM21 => this.MessageKind == M21._type;
            [JsonIgnore]
            public bool IsM22 => this.MessageKind == M22._type;
            [JsonIgnore]
            public M21 AsM11 => this as M21;
            [JsonIgnore]
            public M22 AsM12 => this as M22;
            public new const string _type = M._type + "." + nameof(M2);
            protected override string MessageKind => _type;
        }
    }
}
