using System;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            // Your code here ...

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public int[] LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            // Your code here ...
            // ...
            for (int r = 0; r < array.GetLength(0); r++)
            {
                // r = 0, 1, 2
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    // c = 0, 1, 2
                    if (array[r, c] == target)
                    {
                        row = r;
                        col = c;
                        break;
                    }
                }
            }

            return new[] { row, col };
        }

        public int LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            // Your code here ...
            // ...
            int left = 0;
            int right = array.Length - 1;
            while(left <= right)
            {
                var mid = (left + right)/2;
                if(array[mid] == target)
                {
                    index = mid;
                    break;
                }   
                else if(array[mid] < target)
                {
                    left = mid - 1;
                }
                else if(array[mid] > target)
                {
                    right = mid + 1;
                }
                else
                {
                    break;
                }
            }
            return index;
        }

        #endregion

        #region Assignment

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int[] arrayTarget;

            int first = -1;
            int last = -1;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == target)
                {
                    if(first == -1)
                    {
                        first = i;
                    }
                    last = i;
                }
            }
            
            if(first == -1)
            {
                arrayTarget = new int[]{first};
            }
            else
            {
                arrayTarget = new int[]{first, last};
            }
            return arrayTarget;
        }

        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            int value;

            int lessThanTagetIndex = -1;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < target && array[i] > lessThanTagetIndex)
                {
                    lessThanTagetIndex = i;
                }
            }

            if(lessThanTagetIndex == -1)
            {
                value = -1;
            }
            else
            {
                value = array[lessThanTagetIndex];
            }

            return value;
        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if(min <= array[i] && array[i] <= max)
                {
                    result.Add(array[i]);
                }
            }

            int[] arrayTarget = result.ToArray();

            return arrayTarget;
        }

        #endregion

        #region Extra

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            List<int> target = new List<int>();
            int currentMana = mana;
            for (int i = 0; i < enemyHPs.Length; i++)
            {
                if(enemyHPs[i] < currentMana)
                {
                    target.Add(enemyHPs[i]);
                    currentMana -= enemyHPs[i];
                }
            }

            int[] arrayTarget = target.ToArray();
            return arrayTarget;
        }

        #endregion
    }
}
