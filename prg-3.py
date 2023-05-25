#Write a program to print multiplication table of a given number
n = int(input("Enter a number: "))
no = n
for i in range(1, 11):
    no= n * i
    print(no)