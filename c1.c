#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n, i, scalar_sum1=0, scalar_prod_sum=0, scalar_sum2=0;

    printf("Enter the size of the array : ");
    scanf("%d",&n);

    int arr1[n], arr2[n], vector_sum[n], vector_prod[n], scalar_prod[n];

    printf("\nEnter values for array 1\n");

    for(i=0; i<n; i++){
        printf("Enter a value : ");
        scanf("%d",&arr1[i]);
    }

    printf("\nEnter values for array 2\n");

    for(i=0; i<n; i++){
        printf("Enter a value : ");
        scanf("%d",&arr2[i]);
    }

    for(i=0; i<n; i++){
        scalar_sum1=scalar_sum1+arr1[i];
        scalar_sum2=scalar_sum2+arr2[i];
    }

    for(i=0; i<n; i++){
        vector_sum[i]=arr1[i]+arr2[i];
    }

    for(i=0; i<n; i++){
        vector_prod[i]=arr1[i]*arr2[i];
    }

    for(i=0; i<n; i++){
        scalar_prod[i]=arr1[i]*arr2[i];
    }

    for(i=0; i<n; i++){
        scalar_prod_sum=scalar_prod_sum+scalar_prod[i];
    }

    printf("\n\nArray 1 scalar sum : %d\n\n",scalar_sum1);
    printf("\n\nArray 2 scalar sum : %d\n\n",scalar_sum2);
    printf("\n\nVector sum : ");

    for(i=0; i<n; i++){
        printf("%d",vector_sum[i]);

    }
     printf("\n\nVector product : ");

     for(i=0; i<n; i++){
        printf("%d",vector_prod[i]);
     }

     printf("\n\nScalar product : %d\n\n",scalar_prod_sum);


    return 0;
}
