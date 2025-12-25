class Solution:
    def product(self, n):
        s = str(n)
        ret = 1
        for c in s: ret = ret * int(c) 
        return ret

    def add(self, n):
        s = str(n)
        ret = 0
        for c in s: ret += int(c)
        return ret

    def subtractProductAndSum(self, n):
        return self.product(n) - self.add(n)
