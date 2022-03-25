create database Payroll_servive_115

create table employee_payroll
(
EmployeeId int Identity,
EmployeeName varchar(255),
Address varchar(255),
PhoneNumber varchar(255),
Department varchar(255),
Gender char(1),
BasicPay float,
Deductions float,
TaxablePay float,
Tax float,
NetPay float,
StartDate Date,
City varchar(255),
Country varchar(255),
)
select * from employee_payroll