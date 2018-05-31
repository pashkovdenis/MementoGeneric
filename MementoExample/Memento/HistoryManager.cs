using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoExample.Memento
{ 
     
    public class HistoryManager<T> where T : class
    {
        private MementoCareTaker<T> _undo;
        private MementoCareTaker<T> _redo;
        public HistoryManager(int capacity = 10)
        {
            _undo = new MementoCareTaker<T>(capacity);
            _redo = new MementoCareTaker<T>(capacity);
        } 
        public void SaveState(T state)
        => _undo.SaveState(state); 
        public T Undo()
        {
            var state = _undo.GetPreviousState();
            if (state != null)
                _redo.SaveState(state);
            return state;
        } 
        public T Redo()
             => _redo.GetPreviousState();  
    }

}
