using System;
using JsonSubTypes;
using Newtonsoft.Json;

namespace TestSubmit
{
    [JsonConverter(typeof(JsonSubTypes.JsonSubtypes), propType)]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M1.M11),Leaf.M11)]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M1.M12), Leaf.M12)]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M2.M21), Leaf.M21)]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M2.M22), Leaf.M22)]
    public abstract partial class M
    {
        public static void Process(M message){
            
            switch(message.MKind){
                case M.Discriminator.M1 : M.M1.Process(message.AsM1);break;
                case M.Discriminator.M2: M.M2.Process(message.AsM2);break;
            }
        }
        [JsonIgnore]
        public bool IsM1=>this.MKind==Discriminator.M1;
        [JsonIgnore]
        public bool IsM2=>this.MKind==Discriminator.M2;
        [JsonIgnore]
        public M1 AsM1=>this as M1;
        [JsonIgnore]
        public M2 AsM2=>this as M2;
        private const string propType="$LeafKind";
       
        public enum Discriminator {
            M1=0,
            M2=1
        }
        public enum Leaf {
            M11=M1.Discriminator.M11*10,
            M12=M1.Discriminator.M12*10,
            M21=M2.Discriminator.M21*10,
            M22=M2.Discriminator.M22*10
        }
        
      
        
        [JsonProperty(propType)]
        public abstract Leaf LeafKind{get;}



        protected abstract Discriminator MKind{get;}
        public Discriminator Kind=>this.MKind;

        public DateTime timestamp { get;}
    }
}
