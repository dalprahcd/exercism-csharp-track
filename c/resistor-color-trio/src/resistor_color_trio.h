#ifndef RESISTOR_COLOR_TRIO_H
#define RESISTOR_COLOR_TRIO_H

#define OHMS        1
#define KILOOHMS    1000

typedef enum {
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
} resistor_band_t;

typedef struct
{
    int value;
    int unit;
} resistor_value_t;

resistor_value_t color_code(const resistor_band_t* bands);

#endif
