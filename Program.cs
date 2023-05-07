// Домашнее занадние №5
// Задача 34: Задайте массив заполненный случайными положительными
// трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве.
// Пример:
// [345,897,568,234]->2

int[] numArr = new int[4];
int positiveNum=0;
for(int i=0; i<numArr.Length;i++)
{
    numArr[i] = new Random().Next(100,999);
    if(numArr[i]%2==0)
    {
        positiveNum=positiveNum+1;
    }
}
Console.WriteLine(String.Join(",",numArr)+
"\n Колличество четных чисел: "+positiveNum);
 
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
// Пример:
// [3,7,23,12]->19 
// [-4,-6,89,6]->0


int[] numArr = new int[4];
int negativeNum=0;
for(int i=0; i<numArr.Length;i++)
{
    numArr[i] = new Random().Next(0,99);
    if(i%2==1)
    {
        negativeNum=negativeNum+numArr[i];
    }
}
Console.WriteLine(String.Join(",",numArr)+
"\n Сумма нечетных чисел чисел: "+negativeNum);
 
// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.
// [3,7,22,2,78]->76

int[] numArr = new int[]{3,7,22,2,78};
int maxNum= numArr[0];
int minNum= numArr[0];
int A=0;
for(int i=0; i<numArr.Length;i++)
{
    if(numArr[i]>maxNum)
    {
        maxNum=numArr[i];
    }
   }
for(int i=0; i<numArr.Length;i++)
{
    if(numArr[i]<minNum)
    {
        minNum=numArr[i];
    }
   }
A=maxNum-minNum;
Console.WriteLine(A);
// Console.WriteLine(String.Join(",",numArr));
