using MementoExample.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExample
{
    class Program
    { 
    
        private static HistoryManager<SimpleState> _manager = new HistoryManager<SimpleState>();  
        static void Main(string[] args)
        { 
            Console.WriteLine("THis is example of IMemento Pattern ") ;

            for (int i = 0; i < 10; i++)
            {
                var step =  new SimpleState{  Price =i , ProductName = $"Product selected {i}"} ; 
                _manager.SaveState(step); 
                Console.WriteLine($"Added Product{i} "); 
            } 
            for (int i = 0; i < 10; i++)
            { 
                var prev =  _manager.Undo();
                Console.WriteLine($"UNDO  Previous  Product{prev.ProductName} "); 
            } 

               for (int i = 0; i < 10; i++)
            { 
                var prev =   _manager.Redo();
                Console.WriteLine($"Redo Product{prev.ProductName} "); 
            }  
             
            Console.ReadLine(); 
        }
    }
}
