#include <math.h>
#include "darts.h"

#define SCORE_OUTSIDE           0
#define SCORE_OUTER_CIRCLE      1
#define SCORE_MIDDLE_CIRCLE     5
#define SCORE_INNER_CIRCLE      10

#define RADIUS_OUTER_CIRCLE     10.0F
#define RADIUS_MIDDLE_CIRCLE    5.0F
#define RADIUS_INNER_CIRCLE     1.0F

static float get_radius(coordinate_t landing_position);

uint8_t score(coordinate_t landing_position)
{
    float landing_radius = get_radius(landing_position);

    if (landing_radius <= RADIUS_INNER_CIRCLE)
    {
        return SCORE_INNER_CIRCLE;
    }
    else if (landing_radius <= RADIUS_MIDDLE_CIRCLE)
    {
        return SCORE_MIDDLE_CIRCLE;
    }
    else if (landing_radius <= RADIUS_OUTER_CIRCLE)
    {
        return SCORE_OUTER_CIRCLE;
    }

    return SCORE_OUTSIDE;
}

static float get_radius(coordinate_t landing_position)
{
    return sqrtf(powf(landing_position.x, 2.0f) + powf(landing_position.y, 2.0f));
}
