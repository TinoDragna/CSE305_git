/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.cse305.repositories;

import com.cse305.models.Duty; 

import java.util.ArrayList; 
import java.util.List; 

public class DutyRepository { 
    private List<Duty> duties = new ArrayList<>();
    
    public void save(Duty duty) {
        duties.add(duty); 
    } 
    
    public List<Duty> findAll() {
        return duties; 
    } 
}