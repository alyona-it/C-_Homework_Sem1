// Написать программу, которая на вход получает массив, 
// а на выходе собирает новый массив только из чисел, кратных 5ти 

// метод создания массива 
    // блок-схема
// метод заполнения массива
    // блок-схема
// метод подсчета чисел кратных 5 
    // блок-схема
// решение задачи (получение нового массива)
   // блок-схема
// метод печати

int[] array = { 2, 5, 6, 10, 32, 30 };

int count = 0;
int index;
index = 0;


while (index < array.Length)
{
  if (array[index] % 5 == 0)
  {
    count++;
  }
  index++;
}

int[] arrayNew = new int[count];
index = 0;
int indexNew = 0;

while (index < array.Length)
{
  if (array[index] % 5 == 0)
  {
    arrayNew[indexNew] = array[index];
    indexNew++;
  }
  index++;
}

Console.WriteLine(arrayNew);
index = 0;
while (index < arrayNew.Length)
{
  System.Console.WriteLine(arrayNew[index]);
  index++;
}

