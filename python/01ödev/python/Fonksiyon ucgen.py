def ucgen(a):
    for i in range(1, a + 1):
        print('*' * i)

try:
    a = int(input("Değer girin: "))
    ucgen(a)
except ValueError:
    print("sayı yada rakam girin")
