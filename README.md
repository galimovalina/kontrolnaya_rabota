# Описание решения

С клавиатуры вводится массив, создается еще один массив такой же длины. Создаем метод, где во второй массив будут записаны строки из первого массива, длина которых <=3: 

* создаем переменную count, чтобы перемещаться по элементам второго массива, присваиваем ей 0. 
* далее цикл, чтобы перемещаться по первому массиву (переменную i увеличиваем на 1 пока она не будет равна длине цикла)
* проверяем условие - если элемент массива <=3, то во второй массив на позицию count записываем этот элемент первого массива, переменную count увеличиваем на 1 и возвращаемся к циклу. 