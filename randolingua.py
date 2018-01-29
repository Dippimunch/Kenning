import random

consonant = 'bcdfghjklmnpqrstvwxz'
vowel = 'aeiou'
syllable = []
word = []
wordCount = 10
dictionary = ['cat', 'dog', 'fox', 'water', 'air']
# poly = True
# CV/CVV/CVC/etc

# consonantNumber = random.randint(0, 2)
# vowelNumber = random.randint(0, 2)

#Syllable Construction
for x in range(0, 3):
    for y in range(0, 2):
        syllable.append(random.choice(consonant) + random.choice(vowel))

# need to add variable number of syllables to words
#for z in range(0, 5):
#    if len(set(word)) < 5:
#        word.append(syllable[random.randint(0, 5)] + syllable[random.randint(0, 5)])
    # word[random.randint(0, len(word))].append(syllable[random.randint(0, 5)])

# Wordlist Construction
for i in range(0, len(dictionary)):
    word.append(syllable[random.randint(0, 5)])
    for j in range(0, random.randint(0, 5)):
        print(word[i] + syllable[random.randint(0, 5)])

print('Syllables:')
print(set(syllable))
print('Words:')
#print(set(word))
print(word)
