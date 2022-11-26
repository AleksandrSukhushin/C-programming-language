// Лекция 7. Рекурсия: продолжение.

// Игра в блины с переставлением из по стойкам (палочкам)

// void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
// {
//     if (count > 1) Towers(with, some, on, count -1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count -1);
// }

// Обход разных структур
// Пример. ((4 - 2) * (1 + 3)) / 10 - Бинарное дерево:

string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();
