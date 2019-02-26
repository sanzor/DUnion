using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit
{
    partial class M
    {
        public abstract partial class M1:M
        {
            public static   void  Process(M1 message){
                switch(message.MessageKind){
                    case M11._type : M1.M11.Process(message.AsM11);break;
                    case M12._type:M1.M11.Process(message.AsM12);break;
                }
            }
            [JsonIgnore]
            public bool IsM11=>this.MessageKind==M11._type;
            [JsonIgnore]
            public bool IsM12=>this.MessageKind==M12._type;
            [JsonIgnore]
            public M11 AsM11=>this as M11;
            [JsonIgnore]
            public M12 AsM12=>this as M12;
            public new const string _type=M._type+"."+nameof(M);
            
        }
    }
}
