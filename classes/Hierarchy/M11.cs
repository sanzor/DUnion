using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit {

    partial class M
    {
        
        partial class M1
        {
            public class M11 : M1
            {
                public static void Process(M11 message){
                    Console.WriteLine(message.Value);
                }
               
                public bool Value{get;set;}


                protected override Discriminator M1Kind => Discriminator.M11;

                public override Leaf LeafKind => Leaf.M11;
            }
        }
    }
}
