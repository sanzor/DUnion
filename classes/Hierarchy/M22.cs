using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit {

    partial class M
    {
        partial class M2
        {
            public class M22 : M2
            {
                 public static void Process(M22 message){
                    Console.WriteLine(message.val);
                }
                public string val{get;set;}

                protected override Discriminator M2Kind => Discriminator.M22;

                public override Leaf LeafKind => Leaf.M22;

               
               
            }
        }
    }
}
