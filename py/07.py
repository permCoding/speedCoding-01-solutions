n = input()

r = 'fail'
a = set()
for i in range(len(n)):
	a.add(n[i])
	if len(a) > 9:
		r = i + 1
		break

print(r)