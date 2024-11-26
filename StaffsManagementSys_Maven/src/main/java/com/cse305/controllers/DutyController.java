/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.cse305.controllers;

import com.cse305.models.Duty; 
import com.cse305.services.DutyService; 
import java.util.List; 
public class DutyController {
    private DutyService dutyService = new DutyService();
    
    public void createDuty(Duty duty) {
        dutyService.saveDuty(duty); 
        
    } public List<Duty> getAllDuties() {
        return dutyService.getDuties(); 
    } 
}