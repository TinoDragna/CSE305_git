/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

import com.cse305.controllers.DutyController; 
import com.cse305.controllers.LeaveRequestController; 
import com.cse305.models.Duty; 
import com.cse305.models.LeaveRequest; 
import java.util.Date; 
import java.util.List; 
public class TestConsole { 
    public static void main(String[] args) {
        // Create controllers 
        DutyController dutyController = new DutyController(); 
        LeaveRequestController leaveRequestController = new LeaveRequestController();
        
        // Create and save a duty 
        Duty duty = new Duty(); 
        duty.setDate(new Date()); 
        duty.setStartTime(new Date()); 
        duty.setEndTime(new Date()); 
        dutyController.createDuty(duty); 
        
        // Create and save a leave request 
        LeaveRequest leaveRequest = new LeaveRequest(); 
        leaveRequest.setStartDate(new Date()); 
        leaveRequest.setEndDate(new Date()); 
        leaveRequest.setReason("Personal"); 
        leaveRequest.setStatus("Pending"); 
        leaveRequestController.createLeaveRequest(leaveRequest); 
        
        // Print all duties 
        List<Duty> duties = dutyController.getAllDuties();
        for (Duty d : duties) { 
        System.out.println(d);
        } 
        
        // Print all leave requests 
        List<LeaveRequest> leaveRequests = leaveRequestController.getAllLeaveRequests(); 
        for (LeaveRequest lr : leaveRequests) {
        System.out.println(lr); 
        }
    }  
} 
    
