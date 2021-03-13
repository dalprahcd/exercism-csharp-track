#include "resistor_color_trio.h"
#include "math.h"

resistor_value_t color_code(const resistor_band_t* bands)
{
    int factor = pow(10, (int)bands[2]);
    int value = factor * ((10 * bands[0]) + bands[1]);

    int unit = value > KILOOHMS ? KILOOHMS : OHMS;
    value /= unit;   

    resistor_value_t output; 
    output.value = value;
    output.unit = unit;

    return output;
}