//
// InlineObject5.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation


public struct InlineObject5: Codable { 


    public var attributes: [String]
    public var enrollmentMethod: CoreV2EndpointsEnrollmentMethod
    public var name: String
    public var networkId: String

    public init(attributes: [String], enrollmentMethod: CoreV2EndpointsEnrollmentMethod, name: String, networkId: String) {
        self.attributes = attributes
        self.enrollmentMethod = enrollmentMethod
        self.name = name
        self.networkId = networkId
    }

}