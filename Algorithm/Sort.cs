using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Sort
    {
        public void BubbleSort(int[] nums)
        {
            for(int i = 0; i < nums.Length-1; i++)
            {
                for(int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        Swap(ref nums[j], ref nums[j + 1]);
                    }
                }
            }
        }

        public void SelectionSort(int[] nums)
        {
            
            for(int i = 0; i < nums.Length - 1; i++)
            {
                int minIndex = i;
                for(int j = i+1; j < nums.Length; j++)
                {
                    minIndex = nums[minIndex] < nums[j] ? minIndex : j;
                }
                Swap(ref nums[i], ref nums[minIndex]);
            }
        }

        public void InsertionSort(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                int index = i-1;
                int current = nums[i];
                while (index > 0 && current < nums[index])
                {
                    nums[index + 1] = nums[index];
                    index--;
                }
                nums[index+1] = current;
                
            }
        }

        public void ShellSort(int[] nums)
        {
            int gap = nums.Length / 2;
            while (gap >= 1)
            {
                for(int i = gap; i < nums.Length; i++)
                {
                    int j = i;
                    int curr = nums[i];
                    while (j - gap >= 0 && curr < nums[j-gap])
                    {
                        nums[j] = nums[j - gap];
                        j -= gap;
                    }
                    nums[j] = curr;
                }
                gap /= 2;
            }
        }
        
        public void MergeSort(int[] nums)
        {
            if (nums.Length < 2) return;
            int[] tmp = new int[nums.Length];
            MergeSort(nums, 0, nums.Length - 1, tmp);
        }
        
        private void MergeSort(int[] nums,int left,int right,int[] tmp)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(nums, left, mid, tmp);
                MergeSort(nums, mid + 1, right, tmp);
                Merge(nums, left, mid, right, tmp);
            }
        }

        private void Merge(int[] nums, int left, int mid, int right, int[] tmp)
        {
            int i = left;
            int j = mid + 1;
            int t = 0;
            while (i<=mid&&j<=right)
            {
                if (nums[i] > nums[j])
                {
                    tmp[t++] = nums[j++];
                }
                else
                {
                    tmp[t++] = nums[i++];
                }
            }

            while (i <= mid)
            {
                tmp[t++] = nums[i++];
            }
            while (j <= right)
            {
                tmp[t++] = nums[j++];
            }
            t = 0;
            while (left <= right)
            {
                nums[left++] = tmp[t++];
            }

        }

        public void QuickSort(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
        }

        private void QuickSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int pivot = left;
                int i = left;
                int j = right;
                while (i != j)
                {
                    while (nums[j] > nums[pivot])
                    {
                        j--;
                    }
                    while (nums[i] < nums[pivot])
                    {
                        i++;
                    }
                    Swap(ref nums[i], ref nums[j]);
                }
                Swap(ref nums[pivot], ref nums[i]);
                pivot = i;
                QuickSort(nums, left, pivot);
                QuickSort(nums, pivot + 1, right);
                
            }
        }

        public void Swap(ref int a,ref int b)
        {
            if (a == b)
                return;
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }
    }
}
