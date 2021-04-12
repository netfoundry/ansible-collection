#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include "inline_response_200_9.h"



inline_response_200_9_t *inline_response_200_9_create(
    char *expires_at,
    char *registration_key
    ) {
    inline_response_200_9_t *inline_response_200_9_local_var = malloc(sizeof(inline_response_200_9_t));
    if (!inline_response_200_9_local_var) {
        return NULL;
    }
    inline_response_200_9_local_var->expires_at = expires_at;
    inline_response_200_9_local_var->registration_key = registration_key;

    return inline_response_200_9_local_var;
}


void inline_response_200_9_free(inline_response_200_9_t *inline_response_200_9) {
    if(NULL == inline_response_200_9){
        return ;
    }
    listEntry_t *listEntry;
    free(inline_response_200_9->expires_at);
    free(inline_response_200_9->registration_key);
    free(inline_response_200_9);
}

cJSON *inline_response_200_9_convertToJSON(inline_response_200_9_t *inline_response_200_9) {
    cJSON *item = cJSON_CreateObject();

    // inline_response_200_9->expires_at
    if (!inline_response_200_9->expires_at) {
        goto fail;
    }
    
    if(cJSON_AddStringToObject(item, "expiresAt", inline_response_200_9->expires_at) == NULL) {
    goto fail; //String
    }


    // inline_response_200_9->registration_key
    if (!inline_response_200_9->registration_key) {
        goto fail;
    }
    
    if(cJSON_AddStringToObject(item, "registrationKey", inline_response_200_9->registration_key) == NULL) {
    goto fail; //String
    }

    return item;
fail:
    if (item) {
        cJSON_Delete(item);
    }
    return NULL;
}

inline_response_200_9_t *inline_response_200_9_parseFromJSON(cJSON *inline_response_200_9JSON){

    inline_response_200_9_t *inline_response_200_9_local_var = NULL;

    // inline_response_200_9->expires_at
    cJSON *expires_at = cJSON_GetObjectItemCaseSensitive(inline_response_200_9JSON, "expiresAt");
    if (!expires_at) {
        goto end;
    }

    
    if(!cJSON_IsString(expires_at))
    {
    goto end; //String
    }

    // inline_response_200_9->registration_key
    cJSON *registration_key = cJSON_GetObjectItemCaseSensitive(inline_response_200_9JSON, "registrationKey");
    if (!registration_key) {
        goto end;
    }

    
    if(!cJSON_IsString(registration_key))
    {
    goto end; //String
    }


    inline_response_200_9_local_var = inline_response_200_9_create (
        strdup(expires_at->valuestring),
        strdup(registration_key->valuestring)
        );

    return inline_response_200_9_local_var;
end:
    return NULL;

}
