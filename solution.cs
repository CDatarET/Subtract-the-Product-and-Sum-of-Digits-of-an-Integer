public class Solution {
    private int product(int n){
        int ret = 1;
        while(n > 0){
            ret = ret * (n % 10);
            n = n / 10;
        }

        return(ret);
    }

    private int sum(int n){
        int ret = 0;
        while(n > 0){
            ret = ret + (n % 10);
            n = n / 10;
        }

        return(ret);
    }
    
    public int SubtractProductAndSum(int n) {
        return(product(n) - sum(n));
    }
}
