using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace TestSubmit
{
    class Program
    {
        static void Main(string[] args)
        {
           var a=Get().ToArray();
           var str=JsonConvert.SerializeObject(a);
           var clone=JsonConvert.DeserializeObject<M[]>(str);
           foreach (var item in clone)
           {
               M.Process(item);
           }
           Console.WriteLine("Hello World!");
        }
        static IEnumerable<TestSubmit.M> Get(){
            yield return new M.M1.M11{Value=false};
            yield return new M.M1.M12{value=33};
            yield return new M.M2.M22{val="ASAS"};
            yield return new M.M2.M21{value=new int[]{1,2,3}};
        }
       
        
    }
}
