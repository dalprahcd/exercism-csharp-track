#include <string.h>
#include "hamming.h"

size_t compute(const char *lhs, const char *rhs)
{
    size_t hamming = 0;

    for (; *lhs != '\0';)
    {
        if (*lhs != *rhs)
        {
            hamming++;
        }

        lhs++;
        rhs++;
    }
    
    if (*rhs == '\0')
    {
        return hamming;
    }
    else
    {
        return -1;
    }
}