#include "ctype.h"
#include "string.h"

#include "isogram.h"

bool is_isogram(const char phrase[])
{
    if (!phrase)
    {
        return false;
    }
    
    int length = strlen(phrase);
    
    for (int i = 0; i < length; i++)
    {
        if (!isalpha(phrase[i]))
        {
            continue;
        }
        
        for (int j = i + 1; j < length; j++)
        {
            if (tolower(phrase[i]) == tolower(phrase[j]))
            {
                return false;
            } 
        }
    }

    return true;
}