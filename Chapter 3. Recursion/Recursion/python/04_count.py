def count(arr):
    if not arr:
        return 0
    return 1 + count(arr[1:])

arr = [1, 2, 3, 4, 5]
print(count(arr)) 