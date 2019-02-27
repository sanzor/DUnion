using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit {

    partial class M
    {
        [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M2.M21), M.Leaf.M21)]
        [JsonSubTypes.JsonSubtypes.KnownSubType(typeof(M.M2.M22), M.Leaf.M22)]
        public abstract partial class M2 : M
        {
            public static void Process(M2 message)
            {
                switch (message.M2Kind)
                {
                   case M2.Discriminator.M21 : M2.M21.Process(message.AsM21);break;
                   case M2.Discriminator.M22 : M2.M22.Process(message.AsM22);break;
                }
            }

            protected abstract Discriminator M2Kind { get; }
            public new Discriminator Kind => M2Kind;
            [JsonIgnore]
            public bool IsM21 => this.Kind == Discriminator.M21;
            [JsonIgnore]
            public bool IsM22 => this.Kind == Discriminator.M22;
            [JsonIgnore]
            public M21 AsM21 => this as M21;
            [JsonIgnore]
            public M22 AsM22 => this as M22;

            protected override M.Discriminator MKind => M.Discriminator.M2;
            public new enum Discriminator {
                M21=0,
                M22=1
            }
           

        }
    }
}
