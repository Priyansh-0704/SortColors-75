public class Solution {
    public void SortColors(int[] arr) {
        int low = 0, mid = 0, high = arr.Length - 1;
        while(mid <= high)
        {
            switch(arr[mid])
            {
                case 0:
                    // if zero comes then place zero at low index and swap the value at the low index to mid index, now as the low index will always store zero, we will increase the mid and low index both
                    int temp = arr[low];
                    arr[low] = arr[mid];
                    arr[mid] = temp;
                    mid++;
                    low++;
                    break;
                case 1:
                    // if one comes then it is already atr correct place, just increment mid
                    mid++;
                    break;
                case 2:
                    // if 2 comes then place it at high index and swap the value at the high index to the mid index, but now we have to check the swapped no. cause it might be 0, so just decrement high
                    temp = arr[high];
                    arr[high] = arr[mid];
                    arr[mid] = temp;
                    high--;
                    break;
            }
        }
    }
}

// Idea is to hypothetically imagine the array being divided in three parts
// 1st part is from i = 0 to i = low - 1 (and it contains only zeroes)
// 2nd part is from i = low to i = mid - 1 (and it conatins only ones)
// 3rd part is from i = high to i = arr.Length - 1 (and it contains only twos)

// The space from i = mid to i = high - 1 is empty and we use it store our array
