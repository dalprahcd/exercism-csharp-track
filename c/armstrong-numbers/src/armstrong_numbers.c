#include "armstrong_numbers.h"

static int count_digits(int number);
static int power(int value, int factor);

bool is_armstrong_number(int candidate)
{
    int result = 0;
    int expected = candidate;
    int digits = count_digits(candidate);
    int factor = digits;

    while (digits--)
    {
        result += power(candidate % 10 , factor);
        candidate /= 10;
    }
    
    return result == expected;
}

static int count_digits(int number)
{
    int digits = 1;
    while (number/=10) { digits++; }
    return digits;
}

static int power(int value, int factor)
{
    int result = 1;
    for (int i = 0; i < factor; i++)
    {
        result *= value;
    }

    return result;
}