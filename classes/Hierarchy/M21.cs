using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit {

    partial class M
    {
        partial class M2
        {
            public class M21 : M2
            {
                public static void Process(M21 message){
                    Console.WriteLine("Array:"+"["+string.Join(",",message.value.ToString())+"]");
                }
                public int [] value{get;set;}

                protected override Discriminator M2Kind => M2.Discriminator.M21;

                public override Leaf LeafKind => Leaf.M21;

                
            }
        }
    }
}
