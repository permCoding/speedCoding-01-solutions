n = int(input())

numbers = sorted(input().split())

count_zero = numbers.count('0')

print(numbers[count_zero] + '0'*count_zero + ''.join(numbers[count_zero+1:]))