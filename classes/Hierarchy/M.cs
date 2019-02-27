using System;
using JsonSubTypes;
using Newtonsoft.Json;

namespace TestSubmit
{
    [JsonConverter(typeof(JsonSubTypes.JsonSubtypes), propType)]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M1.M11),M.M1.M11._type)]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M1.M12), M.M1.M12._type)]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M2.M21), M.M2.M21._type)]
    [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M2.M22), M.M2.M22._type)]
    public abstract partial class M
    {
        public static void Process(M message){
            
            switch(message.MKind){
                case M.M1._type : M.M1.Process(message.AsM1);break;
                case M.M2._type: M.M2.Process(message.AsM2);break;
            }
        }
        [JsonIgnore]
        public bool IsM1=>this.MKind==M1._type;
        [JsonIgnore]
        public bool IsM2=>this.MKind==M2._type;
        [JsonIgnore]
        public M1 AsM1=>this as M1;
        [JsonIgnore]
        public M2 AsM2=>this as M2;
        private const string propType="$LeafKind";
        public const string _type=nameof(M);

        
        ///Final type
        
        [JsonProperty(propType)]
        public abstract string LeafKind{get;}



        protected abstract string MKind{get;}
        public string Kind=>this.MKind;

        public DateTime timestamp { get;}
    }
}
