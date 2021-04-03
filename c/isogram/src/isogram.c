#include <ctype.h>
#include <string.h>

#include "isogram.h"

#define MAX_LETTER 26

bool is_isogram(const char phrase[])
{
    if (phrase == NULL)
    {
        return false;
    }

    bool usedLetters[MAX_LETTER] = { false };

    for (size_t i = 0; i < strlen(phrase); i++)
    {
        unsigned char letter = phrase[i];

        if (!isalpha(letter))
        {
            continue;
        }
        
        int index = tolower(letter) - 'a';

        if (usedLetters[index])
        {
            return false;
        }
        
        usedLetters[index] = true;
    }
    
    return true;
}