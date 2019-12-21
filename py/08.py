n = int(input())

lst = []
for i in range(n):
	s = input()
	if len(set(s)) == len(s):
		lst.append(s)

print(len(lst))