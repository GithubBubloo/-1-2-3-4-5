﻿ - A (3,6); B (2,1) -> 5,09
- A (7,-5); B (1,-1) -> 7,21

ax = float(input('Введите координаты точки a по оси x:'))
ay = float(input('Введите координаты точки a по оси y:'))
bx = float(input('Введите координаты точки b по оси x:'))
by = float(input('Введите координаты точки b по оси y:'))

import math
distans = math.sqrt((ax-bx)**2+(ay-by)**2)
print(f'Растояние между точкой A до точки B = {distans}' )