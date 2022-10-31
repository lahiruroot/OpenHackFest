#include <stdio.h>
int binNum(int);

int main()
{
	int num;
	printf("Enter the number: ");
	scanf("%d",&num);
	printf("Binary number of %d is: %d\n\n",num,binNum(num));
	return 0;
}

int binNum(int decNum)
{
	if(decNum<=0)
	{
		return 0;
	}
	else
	{
		return decNum%2 + 10*binNum(decNum/2);
	}
}