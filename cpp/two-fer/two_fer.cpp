#include "two_fer.h"

using namespace std;

namespace two_fer
{
    string two_fer(string name)
    {
        if (name.empty())
        {
            name = "you";
        }
        
        return "One for " + name + ", one for me.";
    }
} // namespace two_fer

