
// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные



// *Задача 2*

// Создаем массив

int [] array = new int [15];

 int index = 0;

 // Задаем массив случайными числами 

while (index < 15)
{
     array[index] = new Random().Next(10,100);
     index++;
}

// Вывод элементлв массива в консоль  

 index = 0;
while (index < 15)
{
 Console.WriteLine(array[index]);
 index++;    
}


Console.WriteLine();
int [] A = new int [15];

 int num = 0;

 // Задаем массив случайными числами 

while (num < 15)
{
     A[num] = new Random().Next(10,100);
     num++;
}

// Вывод элементлв массива в консоль  

 num = 0;
while (num < 15)
{
 Console.WriteLine(A[num]);
 num++;    
}

index = 0;
int sum=0; 
int sum1=0;
int avr=0;
int avr1=0;
num = 0; 
while (index<15)
{
    sum=array[index] + array[index+1];
       
          
     index++;
         
}
avr=(sum%15);
Console.WriteLine(avr);
while (num<15)
{
     sum1=A[num] + A [num+1];
     num++;
     
}
avr1=(sum1%15);
Console.WriteLine(avr1);
if (avr > avr1 )
          {
               Console.WriteLine(avr);
          }


// *Задача 3*

// Задать массив


int index1 = 0;

int[] array1 = new int[10];
// Заполняет массив
while (index < 10)
{
    array[index1] = new Random().Next(10, 100); // [10, 99]
    index1++;
}
index = 0;
// печатаем массив

while (index <= 9)
{
    Console.WriteLine(array[index]); // выводит случайные эллементы массива в консоль 
    index++;
}

Console.WriteLine();
index = 0;
while (index <= 9)
{
    if(array[index]%2==0)
    {
        Console.WriteLine(array[index]);
        
    }
    index++;
}





