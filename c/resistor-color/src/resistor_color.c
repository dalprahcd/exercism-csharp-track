#include "resistor_color.h"

static resistor_band_t all_colors[] =
{
    BLACK,
    BROWN,
    RED,
    ORANGE,
    YELLOW,
    GREEN,
    BLUE,
    VIOLET,
    GREY,
    WHITE
};

int color_code(resistor_band_t color)
{
    return color;
}

resistor_band_t* colors()
{
    return all_colors;
}