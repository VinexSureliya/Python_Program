#Write a program to count the total number of digits in a number using a while loop

num = 75869
count = 0

while num != 0:
    num //= 10
    count += 1

print("Number of digits: " + str(count))