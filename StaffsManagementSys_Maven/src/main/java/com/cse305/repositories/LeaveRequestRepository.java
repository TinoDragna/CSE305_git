/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.cse305.repositories;

import com.cse305.models.LeaveRequest; 
import java.util.ArrayList; 
import java.util.List; 
public class LeaveRequestRepository {
    private List<LeaveRequest> leaveRequests = new ArrayList<>();
    public void save(LeaveRequest leaveRequest) {
        leaveRequests.add(leaveRequest); 
    } 
    public List<LeaveRequest> findAll() {
        return leaveRequests; 
    } 
    public void updateStatus(int id, String status) {
        for (LeaveRequest leaveRequest : leaveRequests) {
            if (leaveRequest.getId() == id) {
                leaveRequest.setStatus(status); break; 
            } 
        } 
    } 
}