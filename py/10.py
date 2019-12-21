n = int(input())

a = n
if n>1:
    a *= n-1
if n > 2:
    a *= n-2

print(a)