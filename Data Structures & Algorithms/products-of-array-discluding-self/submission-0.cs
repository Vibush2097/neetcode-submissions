public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] products = new int[nums.Length];

        int totalProduct = 1, zeroCount = 0, zeroIndex = -1;

        for (int i=0; i < nums.Length; i++) {
            if (nums[i] != 0)
                totalProduct *= nums[i];
            else {
                zeroCount++;
                zeroIndex = i;
            }
        }

        if (zeroCount > 1)
            return products;

        else if (zeroCount == 1) {
            products[zeroIndex] = totalProduct;
        }
        else {
            for (int i=0; i < nums.Length; i++) {
                products[i] = totalProduct / nums[i];
            }
        }

        return products;
    }
}
