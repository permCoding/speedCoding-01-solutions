n, m, h = map(int, input().split())

r = 1  # if n >= h
if n < h:
	if n <= m:
		r = 'NO'
	else:
		r = (h-n-1)//(n-m)+2
        
print(r)