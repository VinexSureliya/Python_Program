#Print list in reverse order using a loop
a=[10,20,30,40,50]
b=[]
for i in range(len(a)):
    b.insert(i,a[-1])
    a.pop(-1)
print(b)