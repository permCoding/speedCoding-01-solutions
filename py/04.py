n = int(input())

r = 0
for i in range(n - 1):
	s = ' ' * i + 'X' + ' ' * (n-2-i) + 'X'
	print(s)

print('X'*n)