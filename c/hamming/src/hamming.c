#include <string.h>
#include "hamming.h"

int compute(const char *lhs, const char *rhs)
{
    size_t lhsLen = strlen(lhs);
    size_t rhsLen = strlen(rhs);

    if (lhsLen != rhsLen)
    {
        return -1;
    }

    size_t hamming = 0;

    for (size_t i = 0; i < lhsLen; i++)
    {
        if (lhs[i] != rhs[i])
        {
            hamming++;
        }
    }
    
    return hamming;
}