/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.cse305.services;

import com.cse305.models.LeaveRequest; 
import com.cse305.repositories.LeaveRequestRepository; 
import java.util.List; 

public class LeaveRequestService {
    private LeaveRequestRepository leaveRequestRepository = new LeaveRequestRepository();

    public void saveLeaveRequest(LeaveRequest leaveRequest) {
        leaveRequestRepository.save(leaveRequest); 
    } 
    public List<LeaveRequest> getLeaveRequests() {
        return leaveRequestRepository.findAll(); 
    } 
    public void updateLeaveRequestStatus(int id, String status) {
        leaveRequestRepository.updateStatus(id, status); 
    }
} 
