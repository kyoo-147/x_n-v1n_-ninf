from collections import defaultdict

char_counter = defaultdict(int)
text = "Xin chào các bạn, Mình là Bùi Minh Cường"
for c in text:
    char_counter[c] += 1

print(char_counter)