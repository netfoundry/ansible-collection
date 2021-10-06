/*
 * untitled API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 5229
 * 
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct CoreV2ServicesServiceIdModelClientIngress {
    #[serde(rename = "addresses")]
    pub addresses: Vec<String>,
    #[serde(rename = "ports")]
    pub ports: Vec<crate::models::CoreV2ServicesModelClientIngressPorts>,
    #[serde(rename = "protocols")]
    pub protocols: Vec<String>,
}

impl CoreV2ServicesServiceIdModelClientIngress {
    pub fn new(addresses: Vec<String>, ports: Vec<crate::models::CoreV2ServicesModelClientIngressPorts>, protocols: Vec<String>) -> CoreV2ServicesServiceIdModelClientIngress {
        CoreV2ServicesServiceIdModelClientIngress {
            addresses,
            ports,
            protocols,
        }
    }
}

