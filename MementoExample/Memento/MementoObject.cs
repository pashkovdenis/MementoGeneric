using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
 
 
namespace MementoExample
{ 
    public class MementoObject<T> where T: class
    {
        private readonly string _internalState; 

        public MementoObject(T state)
        {
            _internalState=  JsonConvert.SerializeObject(state) ;  
        }  
        public T GetState()
        { 
              if (string.IsNullOrEmpty(_internalState))
                throw new Exception("State is null"); 
              return JsonConvert.DeserializeObject<T>(_internalState) ; 
        }  
    }
}
