# NodeLab

NodeLab — это приложение Windows Forms для интерактивной работы с односвязными списками. Приложение предназначено для образовательных целей и позволяет пользователям визуально изучать операции создания, редактирования и удаления элементов в односвязных списках.

## Содержание
* [Введение](#введение)
* [Возможности](#возможности)
* [Установка](#установка)
* [Использование](#использование)
* [Структура проекта](#структура-проекта)
* [Зависимости](#зависимости)
* [Конфигурация](#конфигурация)
* [Примеры](#примеры)
* [Устранение неполадок](#устранение-неполадок)
* [Особенности реализации](#особенности-реализации)

## Введение

NodeLab помогает пользователям понять принципы работы с односвязными списками через интуитивно понятный графический интерфейс. Приложение предоставляет полный набор операций для манипулирования структурой данных, включая создание, вставку, удаление элементов и выполнение специальных задач.

## Возможности

* 📋 **Создание списков**: Создание односвязного списка из массива чисел
* ➕ **Добавление элементов**:
  * Вставка в начало списка
  * Вставка в конец списка
  * Вставка в произвольную позицию
* ❌ **Удаление элементов**:
  * Удаление первого элемента
  * Удаление последнего элемента
  * Удаление элемента по позиции
* 🎯 **Основная задача**: Удаление элементов между двумя заданными значениями
* 🔍 **Визуализация**: Отображение содержимого списка в удобном формате
* 🛡️ **Обработка ошибок**: Валидация ввода и информативные сообщения об ошибках
* 📊 **Дополнительные операции**: Подсчет элементов, поиск, проверка сортировки

## Установка

1. Клонируйте репозиторий или загрузите исходный код:
   ```bash
   git clone <repository-url>
   ```

2. Откройте решение в **Visual Studio 2019** или новее.

3. Соберите проект:
   ```
   Ctrl+Shift+B
   ```

4. Запустите приложение:
   ```
   F5
   ```

## Использование

### Основное меню

После запуска приложения используйте главное меню для доступа к функциям:

* **Задания** → **Создать список**: Создание нового списка из чисел
* **Задания** → **Редактировать список**:
  * **Добавить элемент** → В начало/В конец/В позицию
  * **Удалить элемент** → Первый/Последний/По позиции
* **Задания** → **Основная задача**: Удаление элементов между границами
* **Задания** → **Разрушить список**: Полная очистка списка
* **Выход**: Завершение работы приложения

### Создание списка

1. Выберите "Создать список" в меню
2. Введите числа через пробел (например: `1 2 3 4 5`)
3. Нажмите "OK" для создания списка

### Редактирование списка

Для добавления или удаления элементов:
1. Убедитесь, что список создан
2. Выберите соответствующую операцию в меню
3. Введите необходимые данные в диалоговом окне
4. Результат будет отображен в новом окне

## Структура проекта

```
NodeLab/
├── About.cs                    # Компонент информации о программе
├── Main.cs                     # Главная форма приложения
├── Node.cs                     # Классы Node и SingleLinkedList
├── CreateListForm.cs           # Форма создания списка
├── PrintListForm.cs            # Форма отображения списка
├── Program.cs                  # Точка входа в приложение
├── AddElement/                 # Формы добавления элементов
│   ├── InsertFirstForm.cs      # Добавление в начало
│   ├── InsertLastForm.cs       # Добавление в конец
│   └── InsertCustomForm.cs     # Добавление в позицию
├── DeleteElement/              # Формы удаления элементов
│   └── DeleteCustomForm.cs     # Удаление по позиции
└── MainTask/                   # Основная задача
    └── MainTaskForm.cs         # Удаление между границами
```

## Зависимости

* **.NET 6.0** или новее
* **System.Windows.Forms**
* **System.Drawing**

Внешние пакеты NuGet не требуются.

## Конфигурация

Приложение не требует дополнительной конфигурации. Все настройки встроены в пользовательский интерфейс.

## Примеры

### Создание списка программно

```csharp
SingleLinkedList list = new SingleLinkedList();
int[] data = {1, 2, 3, 4, 5};
list.Create_2(data);
```

### Добавление элементов

```csharp
// Добавить в начало
list.InsertBeforeFirst(10);

// Добавить в конец
list.InsertLast(20);

// Добавить в позицию
list.InsertCustom(15, 3, out string error);
```

### Удаление элементов

```csharp
// Удалить первый элемент
list.DeleteFirst1();

// Удалить последний элемент
list.DeleteLast();

// Удалить по позиции
list.DeleteCustom(2, out string error);

// Удалить элементы между значениями
list.DeleteBetween(2, 8, out string error);
```

### Поиск и проверки

```csharp
// Поиск элемента
Node found = list.Find(5);
if (found != null)
{
    Console.WriteLine($"Найден элемент: {found.Info}");
}

// Подсчет элементов
int count = list.Count();

// Проверка сортировки
bool sorted = list.IsSorted();
```

## Устранение неполадок

### Общие ошибки:
* **"Неверная позиция"**: Убедитесь, что позиция больше или равна 0
* **"Вы вышли за пределы!"**: Проверьте, что позиция не превышает размер списка
* **"Ошибка ввода"**: Вводите только целые числа
* **"Список пуст, позиция вне диапазона"**: Создайте список перед выполнением операций

### Основная задача - специфические ошибки:
* **"Левая граница не найдена"**: Первое значение отсутствует в списке
* **"Правая граница не найдена"**: Второе значение отсутствует в списке
* **"Между границами нет элементов"**: Граничные элементы находятся рядом
* **"Правая граница должна находиться после левой"**: Неверный порядок границ в списке

## Особенности реализации

### Односвязный список
* Использует указатель на первый элемент (`first`)
* Каждый узел содержит данные и ссылку на следующий элемент
* Поддерживает навигацию только в одном направлении

### Класс Node
```csharp
public class Node
{
    public int Info { get; set; }    // Данные узла
    public Node Link { get; set; }   // Ссылка на следующий узел
}
```

### Класс SingleLinkedList
Основные методы:
- `Create_1()` и `Create_2()` - создание списка из массива
- `InsertBeforeFirst()`, `InsertLast()`, `InsertCustom()` - вставка элементов
- `DeleteFirst1()`, `DeleteLast()`, `DeleteCustom()` - удаление элементов
- `Find()` - поиск элемента по значению
- `Count()` - подсчет количества элементов
- `IsSorted()` - проверка сортировки списка
- `Print()` - преобразование в строку для отображения

### Визуализация
* Список отображается в `ListBox` через метод `PrintListBox()`
* Каждый элемент показывается в отдельной строке
* Обновление происходит после каждой операции
