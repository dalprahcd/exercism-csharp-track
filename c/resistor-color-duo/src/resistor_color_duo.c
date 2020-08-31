#include "resistor_color_duo.h"

uint16_t color_code(const resistor_band_t *bands)
{
    return 10 * bands[0] + bands[1];
}
