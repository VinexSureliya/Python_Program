#Write a program to display only those numbers from a list that satisfy the following conditions
#The number must be divisible by five
#If the number is greater than 150, then skip it and move to the next number 
#If the number is greater than 500, then stop the loop

no = int(input("Enter a number:"))
a = no + 1
n=0
for a in range(no):
    i = a % 5
    if i == 0 :
        for n in range(1):
            if a == 0:
                print()
            elif a == 150:
                print()
            else:
                print(a)
    
    