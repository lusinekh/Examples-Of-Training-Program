using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharing_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            do{
Random rd = new Random();
int n = rd.Next(5, 20);
int []a=new int[n=rd.Next(5,20)];

for (int i = 0; i < a.Length; i++)
{
a[i] = rd.Next(-999, 1000);
Console.Write(a[i] );
}


for(int i=0;i<a.Length;++i)
{

int start = 0;
int end = i;
int mid=end/2;
while(end>=start)
{
if(a[i+1]==a[mid])

break;

if (a[i + 1] > a[mid])
start = mid + 1;
else
if (a[i + 1] > a[mid])
end = mid - 1;
mid = start + mid / 1;

int temp = a[i + 1];

for(int k=i+1;k>mid;k--)
{
a[k] = a[k - 1];


}
a[mid] = temp;
}

}
}

while(Console.ReadKey().Key==ConsoleKey.Enter);
}
}




        
   
}
