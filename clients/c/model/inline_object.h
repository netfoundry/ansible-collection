/*
 * inline_object.h
 *
 * 
 */

#ifndef _inline_object_H_
#define _inline_object_H_

#include <string.h>
#include "../external/cJSON.h"
#include "../include/list.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"

typedef struct inline_object_t inline_object_t;




typedef struct inline_object_t {
    char *name; // string
    char *size; // string
    char *location_code; // string
    char *product_version; // string
    char *network_group_id; // string

} inline_object_t;

inline_object_t *inline_object_create(
    char *name,
    char *size,
    char *location_code,
    char *product_version,
    char *network_group_id
);

void inline_object_free(inline_object_t *inline_object);

inline_object_t *inline_object_parseFromJSON(cJSON *inline_objectJSON);

cJSON *inline_object_convertToJSON(inline_object_t *inline_object);

#endif /* _inline_object_H_ */

