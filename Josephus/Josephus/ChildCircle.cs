using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Josephus.Resources;

namespace Josephus
{
    public class ChildCircle
    {
        private readonly int _eliminatePosition;
        private readonly Queue<int> _children;
        private List<int> _eliminatedChildren;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numberOfChildren">Number of children in the circle, must be greater than zero</param>
        /// <param name="eliminatePosition">Position to eliminate children at, must be greater than zero</param>
        public ChildCircle(int numberOfChildren, int eliminatePosition)
        {            
            if (numberOfChildren <= 0)
                throw new ArgumentException(JosephusTestResources.NumberOfChildrenArgumentException);

            if (eliminatePosition <= 0)
                throw new ArgumentException(JosephusTestResources.EliminatePositionArgumentException);           

            _eliminatePosition = eliminatePosition;
            _children = new Queue<int>(Enumerable.Range(1, numberOfChildren));
            _eliminatedChildren = new List<int>();
        }

        /// <summary>
        /// List of Removed Children
        /// </summary>
        public ReadOnlyCollection<int> RemovedChildren
        {
            get { return _eliminatedChildren.AsReadOnly(); }
        }


        /// <summary>
        /// Get the winner - the last child standing, based on the eliminated position.
        /// Performance Notes: Each iteration of the while loop will remove a child for n times (number of children)
        /// Each iteration of the for loop will run k times (eliminate every kth child)
        /// individual Queue enqueue and dequeue operations are O(1)
        /// both loops are O(n) - linear degradation
        /// Given O(n) is the highest of the two operations, the overall
        /// algorithm performance will be O(n)
        /// </summary>
        /// <returns>The winning child sequential id</returns>
        public int GetWinner()
        {
            var sequentialId = 0;
            _eliminatedChildren = new List<int>();
            
            while (_children.Count != 0)
            {
                if (_children.Count == 1)
                {
                    sequentialId = _children.Peek();
                    break;
                }

                for (var j = 1; j < _eliminatePosition; j++)
                {
                    _children.Enqueue(_children.Dequeue());
                }

                _eliminatedChildren.Add(_children.Dequeue());
            }

            return sequentialId;
        }
    }
}
