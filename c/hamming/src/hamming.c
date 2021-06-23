#include <string.h>
#include "hamming.h"

long long compute(const char *lhs, const char *rhs)
{
    long long hamming = 0;

    while (*lhs != '\0' && *rhs != '\0')
    {      
        if (*lhs != *rhs)
        {
            hamming++;
        }

        lhs++;
        rhs++;
    }
       
    if (*lhs == '\0' && *rhs == '\0')
    {
        return hamming;
    }
    else
    {
        return -1;
    }
}