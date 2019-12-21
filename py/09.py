n = int(input())
lst = list(map(int, input().split()[:n]))

for i in set(lst):
    if lst.count(i) == 1:
        print(i)
        break