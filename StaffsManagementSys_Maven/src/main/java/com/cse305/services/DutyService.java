/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.cse305.services;

import com.cse305.models.Duty; 
import com.cse305.repositories.DutyRepository; 
import java.util.List; 
public class DutyService {
    private DutyRepository dutyRepository = new DutyRepository(); 
    
    public void saveDuty(Duty duty) {
        dutyRepository.save(duty); 
    } 
    public List<Duty> getDuties() {
        return dutyRepository.findAll(); 
    } 
}