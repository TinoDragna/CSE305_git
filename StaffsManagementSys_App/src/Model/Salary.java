/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Model;

import java.math.BigDecimal;
import java.time.LocalDate;

public class Salary {
    private int id;
    private int securityStaffId; // Referencing SecurityStaff
    private LocalDate monthYear;
    private BigDecimal amount;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getSecurityStaffId() {
        return securityStaffId;
    }

    public void setSecurityStaffId(int securityStaffId) {
        this.securityStaffId = securityStaffId;
    }

    public LocalDate getMonthYear() {
        return monthYear;
    }

    public void setMonthYear(LocalDate monthYear) {
        this.monthYear = monthYear;
    }

    public BigDecimal getAmount() {
        return amount;
    }

    public void setAmount(BigDecimal amount) {
        this.amount = amount;
    }

    public void calculateSalary(SecurityStaff staff) {
        // Logic to calculate salary based on duties and leaves
    }
}