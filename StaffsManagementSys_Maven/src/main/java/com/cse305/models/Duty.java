/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.cse305.models;

import java.util.Date;

public class Duty {
    private Date date; 
    private Date startTime; 
    private Date endTime; 
    private int placeId; // Referencing Place 
    private int securityStaffId; // Referencing SecurityStaff 

    public Date getDate() {
        return date; 
    } 
    public void setDate(Date date) {
        this.date = date; 
    } 
    public Date getStartTime() {
        return startTime; 
    } 
    public void setStartTime(Date startTime) {
        this.startTime = startTime; 
    } 
    public Date getEndTime() {
        return endTime; 
    } 
    public void setEndTime(Date endTime) {
        this.endTime = endTime; 
    } 
    public int getPlaceId() {
        return placeId; 
    } 
    public void setPlaceId(int placeId) {
        this.placeId = placeId; 
    } 
    public int getSecurityStaffId() {
        return securityStaffId; 
    } 
    public void setSecurityStaffId(int securityStaffId) {
        this.securityStaffId = securityStaffId; 
    }
   
}
