n, m, h = map(int, input().split())

r = 1
while True:
	h -= n
	if h < 1:
		break
	h += m
	if m >= n:
		r = 'NO'
		break
	r += 1

print(r)