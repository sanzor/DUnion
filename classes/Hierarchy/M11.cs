using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit
{

    partial class M
    {
        [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M1.M11),M.M1.M11._type)]
        [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M1.M12), M.M1.M12._type)]    
        partial class M1
        {
            public class M11 : M1
            {
                public static void Process(M11 message){
                    Console.WriteLine(message.Value);
                }
                public  new const string _type=M1._type+"."+nameof(M11);
                public bool Value{get;set;}

                protected override string MessageKind => _type;
            }
        }
    }
}
