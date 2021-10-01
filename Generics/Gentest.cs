using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public class Gentest<T>
    {
       private T data;

       public T value
       {
           set
           {
             data = value;
           }
           get
           {
            return data;
           }       
       }
    }
}
