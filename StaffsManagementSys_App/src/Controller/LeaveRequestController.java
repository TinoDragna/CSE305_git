/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Controller;

import java.util.List; 
public class LeaveRequestController {
    private LeaveRequestService leaveRequestService = new LeaveRequestService();
    public void createLeaveRequest(LeaveRequest leaveRequest) {
        leaveRequestService.saveLeaveRequest(leaveRequest); 
    } 
    
    public List<LeaveRequest> getAllLeaveRequests() {
        return leaveRequestService.getLeaveRequests(); 
    } 
    
    public void updateLeaveRequestStatus(int id, String status) {
        leaveRequestService.updateLeaveRequestStatus(id, status); 
    } 
}