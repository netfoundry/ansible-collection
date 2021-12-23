//
// CoreV2ServicesServiceIdModelClientIngress.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation


public struct CoreV2ServicesServiceIdModelClientIngress: Codable { 


    public var addresses: [String]
    public var ports: [CoreV2ServicesModelClientIngressPorts]
    public var protocols: [String]

    public init(addresses: [String], ports: [CoreV2ServicesModelClientIngressPorts], protocols: [String]) {
        self.addresses = addresses
        self.ports = ports
        self.protocols = protocols
    }

}