n=5
for i in range(1,n+1):
    for j in range(1,i+1):
        print("*",end=" ")
    print()
rows = 4
for i in range(0, rows + 1):
    for j in range(rows - i, 0, -1):
        print("*", end=' ')
    print()