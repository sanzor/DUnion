using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit {

    partial class M
    {
        partial class M1
        {
            public class M12 : M1
            {
                public static void Process(M12 message){
                    Console.WriteLine(message.value);
                }
                public new const int _type=112;
                public int value{get;set;}

                protected override Discriminator M1Kind => Discriminator.M12;

                public override Leaf LeafKind => Leaf.M12;
            }
        }
    }
}
