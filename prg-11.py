#Use a loop to display elements from a given list present at odd index

a= [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
b=[]
c=0
for i in a:
    if c%2==0:
        print(i)
    c+=1