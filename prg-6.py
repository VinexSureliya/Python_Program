#Write a program to use for loop to print the following reverse number pattern.
rows = 5
for i in range(0, rows + 1):
    for j in range(rows - i, 0, -1):
        print(j, end=' ')
    print()