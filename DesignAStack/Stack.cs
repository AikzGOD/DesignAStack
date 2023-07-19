 using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAStack
{

    internal class Stack
    {
        private static List<object> StackList = new List<object>();

        /// <summary>
        /// Stores the given object on top of the stack.
        /// Remember the object class is the base of all classes
        /// Make sure to take into account the scenario that null is passed to this object
        /// We should not store null references in the stack
        /// So if null is passed to this object, you should throw an InvalidOperationException.
        /// Remember, when coding every method, you should think of all possibilities
        /// and make sure the method behaves properly in all these edge cases
        /// </summary>
        /// <param name="obj"></param>
        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException();
            }
            StackList.Add(obj);
            Console.WriteLine("Object Pushed!\n");
        }

        /// <summary>
        /// Method removes the object on top of the stack and returns it.
        /// Make sure to take into account the scenario that we call the Pop()
        /// Method on an empty stack.
        /// In this case this method should throw an InvalidOperationException.
        /// </summary>
        public object Pop()
        {
            if(StackList.Count.Equals(0))
            {
                throw new InvalidOperationException();
            }

            int removeIndex = StackList.Count - 1;
            object objRemoved  = StackList[removeIndex];
            StackList.RemoveAt(removeIndex);

            return objRemoved;
        }

        /// <summary>
        /// Remove all the objects from the stack
        /// </summary>
        public void Clear()
        {
            StackList.Clear();
        }

    }
}
