﻿using AlgExam;

class Program
{
    /*
    Level 1:
        1)BubbleSort    +
        2)InsertionSort +
        3)SelectionSort +
        4)ShakerSort    +
        5)BinarySearch  +

    Level 2:
        6)ShellSort     
        7)QuickSort        
        8)Stack        
        9)Queue        
    */ 
    static void Main()
    {
        /*
        BUBBLE SORT:
        | ОПИСАНИЕ |
        Простейший алгоритм сортировки, который многократно меняет местами соседние элементы, 
        если они расположены в неправильном порядке. Проход по списку повторяется до тех пор,
        пока список не будет отсортирован.
        | Шаги работы |
        1. Берём пару элементов сравниваем их
        2. Если первый больше второго меняем их местами
        3. Повторям 1,2 шаг пока массив не будет отсортирован
        | СЛОЖНОСТЬ |
        Лучший случай: O(n), возникает в случае, если массив уже отсортирован;
        Средний случай: O(n^2), элементы перемешаны в порядке так, что порядок не является должным образов возрастающим или убывающим;
        Худший случай: O(n^2), возникает в случае, когда массив уже отсортирован в обратном порядке;
        */

        BubbleSort.Start(10);

        /*
        INSERTION SORT:
        | ОПИСАНИЕ |
        Сортировка вставками является простым алгоритмом сортировки, который работает 
        путем прохода по массиву и "вставки" каждого элемента на свое правильное место. 
        На каждом шаге текущий элемент сравнивается с элементами, уже находящимися в отсортированной части массива.
        | Шаги работы |
        1. Начинаем с предположения, что первый элемент массива уже отсортирован.
        2. Берем следующий элемент и сравниваем его с предыдущим элементом.
        3. Если текущий элемент меньше предыдущего, меняем их местами.
        4. Продолжаем сравнивать текущий элемент с предыдущими элементами, пока не найдем 
        его правильное местоположение в отсортированной части массива или не дойдем до начала массива.
        5. Переходим к следующему элементу и повторяем процесс.
        | СЛОЖНОСТЬ |
        Лучший случай: O(n), возникает в случае, если массив уже отсортирован;
        Средний случай: O(n^2), элементы перемешаны в порядке так, что порядок не является должным образов возрастающим или убывающим;
        Худший случай: O(n^2), возникает в случае, когда массив уже отсортирован в обратном порядке;
        */

        InsertionSort.Start(10);

        /*
        SELECTION SORT:
        | ОПИСАНИЕ |
        Простой алгоритм сортировки, который на каждом шаге ищет минимальный (или максимальный) 
        элемент из неотсортированной части массива и меняет его местами с первым элементом в неотсортированной части.
        | Шаги работы |
        1. Начинаем с того, что весь массив считается неотсортированным.
        2. Проходим по неотсортированной части массива и ищем минимальный элемент.
        3. Меняем минимальный элемент с первым элементом в неотсортированной части массива.
        4. Считаем первый элемент отсортированным и двигаем границу между отсортированной и неотсортированной частью вправо.
        5. Повторяем процесс для оставшейся неотсортированной части массива, пока весь массив не будет отсортирован.
        | СЛОЖНОСТЬ |
        Лучший случай: O(n^2)
        Средний случай: O(n^2)
        Худший случай: O(n^2)
        */

        SelectionSort.Start(10);

        /*
        SHAKER SORT:
        | ОПИСАНИЕ |
        Шейкерная сортировка – это вариация сортировки пузырьком, которая двигается в обе стороны.
        Идя вправо по массиву выталкивает наибольше элементы в конец, идя в лево выталкивает наименьшие элементы в начало.
        | Шаги работы |
        1. Начинаем с границы, которая находится на первом и последнем элементах массива.
        2. Повторяем следующие шаги, пока границы не встретятся:
            Проходим по массиву с левой границы до правой, сравнивая соседние элементы и меняя их местами, если необходимо.
            После прохода справа налево, сдвигаем правую границу на один элемент влево.
            Проходим по массиву с правой границы до левой, сравнивая соседние элементы и меняя их местами, если необходимо.
            После прохода слева направо, сдвигаем левую границу на один элемент вправо.
        3. Повторяем процесс, пока необходимо.
        | СЛОЖНОСТЬ |
        Лучший случай: O(n)
        Средний случай: O(n^2)
        Худший случай: O(n^2)
        */

        ShakerSort.Start(10);

        /*
        BINARY SEARCH:
        | ОПИСАНИЕ |
        Бинарный поиск — это алгоритм поиска элемента в отсортированном массиве путем разделения массива на две части 
        и последующего сокращения диапазона поиска вдвое. Основная идея заключается в том, 
        чтобы на каждом шаге сравнивать искомый элемент с элементом в середине массива 
        и исключать из дальнейшего рассмотрения половину элементов.
        | Шаги работы |
        1. Установить два указателя: левый (начальный) и правый (конечный) границы диапазона поиска.
        2. Найти середину диапазона (средний индекс).
        3. Сравнить искомый элемент с элементом по середине.
        4. Если элемент найден, завершить поиск.
        5. Если искомый элемент меньше элемента по середине, установить правую границу на индексе середины минус один.
        6. Если искомый элемент больше элемента по середине, установить левую границу на индексе середины плюс один.
        7. Повторять процесс с шага 2 до тех пор, пока левая граница не станет больше правой.
        | СЛОЖНОСТЬ |
        O(log (n))
        */

        BinarySearch.Start(100);
    }
}
