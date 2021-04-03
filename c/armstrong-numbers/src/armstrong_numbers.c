#include <math.h>

#include "armstrong_numbers.h"

static int count_digits(int number);

bool is_armstrong_number(int candidate)
{
    int result = 0;
    int expected = candidate;
    int digits = count_digits(candidate);
    int factor = digits;

    while (digits--)
    {
        result += pow(candidate % 10 , factor);
        candidate /= 10;
    }
    
    return result == expected;
}

static int count_digits(int number)
{
    int digits = 1;
    while (number /= 10) { digits++; }
    return digits;
}