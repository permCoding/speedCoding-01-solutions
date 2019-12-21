n = int(input())

r = 0
input()
for i in range(n-2):
	s = input()
	r += s[1:-1].count('X')
input()

print(r)