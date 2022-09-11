int []startArray = GetArray(123,0 , 1000);
Console.WriteLine($"Коичество элементов в отрезке[10,99] = {GetCountElements(startArray,10 , 99)}");

int [] GetArray(int size,int minValue, int maxValue)
{
int []res = new int [size];
for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue,maxValue +1);
}
return res;
}
int GetCountElements(int[]array,int leftRange,int rigtRange)
{
int count =0;
foreach (var item in array)
{
if(item>=leftRange && item<=rigtRange)count++;
}
return count;
}
