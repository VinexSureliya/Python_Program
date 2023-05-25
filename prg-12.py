#Write a program to calculate the sum of series up to n term. For example,
#if n =5 the series will becom

n=5
b=0
sum=0
for i in range(1,n+1):
	b=(b*10)+n-3
	sum=sum+b
	print(b,end=" ")

print()
print("Sum is: ", sum)
