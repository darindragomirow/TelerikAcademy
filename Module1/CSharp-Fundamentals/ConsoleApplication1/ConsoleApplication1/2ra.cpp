#include <stdio.h>
#include <stdlib.h>

int  main()
{

	int maxNumber = 0;
	int number;
	while (1)
	{
		scanf_s("%d", &number);
		if (number > maxNumber)
		{
			maxNumber = number;
		}
		else if (number < 0)
		{
			break;
		}
	}
	printf("%d", maxNumber);

	return 0;
}