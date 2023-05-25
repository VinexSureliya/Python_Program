#Reverse a given integer number

a=[7,6,5,4,2]
b=[]
for i in range(len(a)):
    b.insert(i,a[-1])
    a.pop(-1)
print(b)