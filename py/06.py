n = int(input())

r = 2 * n + 3
z = 'X' * r

for i in range(r):
	if i == 0 or i == r - 1 or i == n + 1:
		print(z)
	else:
		print('X' + ' '*n + 'X' + ' '*n + 'X')