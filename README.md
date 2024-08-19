

# **Remove Element**

## Problem Description

Given an integer array **nums** and an integer **val**, remove all occurrences of **val** in **nums** **in-place**. 
The order of the elements may be changed. 
Then return the number of elements in nums which are not equal to val.

## Requirements:

Modify the array **nums** such that the first **k** elements contain the elements which are not equal to **val**. 
The remaining elements of **nums** are not important.
Return **k** after placing the final result in the first **k** slots of **nums**.
**Note:** Do not allocate extra space for another array.
You must do this by modifying the input array **in-place** with O(1) extra memory.

## Custom Judge

The judge will test your solution with the following code:

    int[] nums = [...]; // Input array
    int val = ...; // Value to remove
    int[] expectedNums = [...]; // The expected answer with correct length.
    // It is sorted with no values equal to val.
    
    int k = removeElement(nums, val); // Calls your implementation
    
    assert k == expectedNums.length;
    Arrays.sort(nums, 0, k); // Sort the first k elements of nums
    for (int i = 0; i < k; i++) {
        assert nums[i] == expectedNums[i];
    }

If all assertions pass, then your solution will be **accepted**.
## Examples

### Example 1

**Input:**

    nums = [3,2,2,3] 
    val = 3
**Output:**

    2, nums = [2,2,_,_]

**Explanation:** Your function should return `k = 2`, with the first two elements of `nums` being `2`. It does not matter what you leave beyond the returned `k` (hence they are underscores).

### Example 2

**Input:**

    nums = [0,1,2,2,3,0,4,2] 
    val = 2
**Output:**

    5, nums = [0,1,4,0,3,_,_,_]

**Explanation:** Your function should return `k = 5`, with the first five elements of `nums` containing `0`, `1`, `4`, `0`, and `3`. Note that the five elements can be returned in any order. It does not matter what you leave beyond the returned `k` (hence they are underscores).

## Constraints

-   `0 <= nums.length <= 100`
-   `0 <= nums[i] <= 50`
-   `0 <= val <= 100`
## Approach

To solve this problem efficiently, we can use the **two-pointer technique**. The idea is to have one pointer (`i`) iterate through the array, and another pointer (`k`) keep track of the position of the next element that is not equal to `val`.

**Algorithm:**

1.  Initialize a pointer `k = 0`.
2.  Iterate through the array `nums` with index `i` from `0` to `nums.length - 1`.
3.  For each element `nums[i]`:
    -   If `nums[i]` is not equal to `val`:
        -   Assign `nums[k] = nums[i]`.
        -   Increment `k` by `1`.
4.  After the loop, `k` will be the number of elements not equal to `val`, and the first `k` elements of `nums` will contain these values.

## Solution
![alt](https://github.com/marhamatabadi/RemoveElementInplace/Images/Solution.jpg)

## Testing

You can test your implementation using the provided **Custom Judge** code snippet. Ensure that your function passes all assertions for different test cases, including edge cases such as empty arrays and arrays where all elements are equal to `val`.

**Example Test Case:**

![alt](https://github.com/marhamatabadi/RemoveElementInplace/Images/Test.jpg)

## Conclusion

This problem is a classic example of using the two-pointer technique to modify an array in-place. Understanding and applying such techniques are essential for optimizing time and space complexity in array manipulation problems.