//
// InlineResponse200Links.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation


public struct InlineResponse200Links: Codable { 


    public var network: InlineResponse200LinksNetwork
    public var _self: InlineResponse200LinksSelf

    public init(network: InlineResponse200LinksNetwork, _self: InlineResponse200LinksSelf) {
        self.network = network
        self._self = _self
    }

    public enum CodingKeys: String, CodingKey { 
        case network
        case _self = "self"
    }

}