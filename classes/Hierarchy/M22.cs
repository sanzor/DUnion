using System;
using JsonSubTypes;
using Newtonsoft.Json;
namespace TestSubmit
{

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

                protected override string M2Kind => _type;

                public override string LeafKind => _type;

                public new  const string _type=M2._type+"."+nameof(M22);
               
            }
        }
    }
}
