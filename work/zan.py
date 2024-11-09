# spis1 = [0,1,2,3,'ksjbkjs','12312']
# spis2 = [1,2,3,4,'123123123']
# print(spis1 + spis2)

# spis3 = ['Hello','my','dear','friend']
# stroka = ', '.join(spis3)

# print(stroka)

# def schet(spis,chis):
#     print(spis.count(chis))


# print(schet([1,1,123,1231,411,1,1,1,1,11,1,1,1,1,1,1,1,1], 1))


# def is_palindrome(spis):
#     if spis == reversed(spis):
#         return True
    
# def is_palindrome1(spis):
#     if spis == spis[::-1]:
#         return True

# print(is_palindrome(spis1))
# print(is_palindrome1(spis2))



spis1 = [1,2,3,2,1]
spis2 = [34,56,76,56,23]

def merge_spis(spis_1,spis_2):
    return sorted(spis_1 + spis_2)

print(merge_spis(spis1,spis2))


