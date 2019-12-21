n = int(input())
numbers = input()

d = [numbers.count(str(i)) for i in range(10)]
first = '9'
for i in range(1, 10):
	if d[i] > 0:
		first = str(i)
		d[i] -= 1
		break

print(first + '0'*d[0] + ''.join([str(i)*d[i] for i in range(1,10) if d[i]>0]))