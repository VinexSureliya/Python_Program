#Display Fibonacci series up to 10 terms
a=0
b=1
c=a+b
print(a)
print(b)
for i in range(1, 9):
    print(c)
    a = b
    b = c
    c= a + b