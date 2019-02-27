using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit
{
    partial class M
    {
        [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M1.M11), M.Leaf.M11)]
        [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M1.M12),M.Leaf.M12)]
        public abstract partial class M1:M
        {
            public static   void  Process(M1 message){
                switch(message.M1Kind){
                    case M1.Discriminator.M11 : M1.M11.Process(message.AsM11);break;
                    case M1.Discriminator.M12:  M1.M12.Process(message.AsM12);break;
                }
            }
            protected override M.Discriminator MKind => M.Discriminator.M1;
            public new enum Discriminator {
                M11=10,
                M12=11
            }
            public new Discriminator Kind => this.M1Kind;
           
            protected abstract Discriminator M1Kind { get; }
            [JsonIgnore]
            public bool IsM11=>this.M1Kind==M1.Discriminator.M11;
            [JsonIgnore]
            public bool IsM12=>this.M1Kind==M1.Discriminator.M12;
            [JsonIgnore]
            public M11 AsM11=>this as M11;
            [JsonIgnore]
            public M12 AsM12=>this as M12;
            
            
        }
    }
}
