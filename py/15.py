n, k = map(int, input().split())

def get(N, K):
    if K == 0:
        return 1 if N == 0 else 0
    if N == 0:
        return 0
    return get(N-1, K-1) + get(N+1, K-1)

print(get(n,k))