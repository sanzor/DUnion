using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit
{

    partial class M
    {
        partial class M1
        {
            public class M12 : M1
            {
                public static void Process(M12 message){
                    
                }
                public new const string _type=M1._type+"."+nameof(M1);
                public int value{get;set;}

                protected override string MessageKind => _type;
            }
        }
    }
}
