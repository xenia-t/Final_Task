## Итоговая проверочная работа.

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

**Описание решения**

Были выделены следующие подзадачи:

1. Заполнение исходного массива с клавиатуры
2. Печать заданного массива
3. Создание массива из элементов, длина которых меньше либо равна 3 символа
4. Вывод созданного массива

Блок-схема алгоритма нарисована по основной содержательной части - третьей подзадаче.

Каждая подзадача выделена в отдельный метод.

Однако, в процессе написания программы для удобства третья подзадача разделена на 2 метода:
- *поиск длины нового массива*;
- *создание массива найденной размерности из искомых элементов*.

**Описание программы**

Размерность исходного массива ограничена вводом количества элементов данного массива

Ввод и вывод массива осуществляется через циклы.

Для поиска длины массива, элементы которого состоят из не более 3 символов, создаем метод, принимающий на вход заданный массив. Данный метод осуществляет проверку длины каждого элемента исходного массива (<= 3) и подсчет их количества через цикл.

Для записи элементов искомого массива создаем метод, который на вход принимает заданный массив и найденное значение количества элементов из предыдущего метода. Данный метод осуществляет поиск элементов, длина которых меньше или равна 3 символа, и запись их в новый массив найденной размерности.