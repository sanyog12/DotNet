﻿namespace BOL;

public class Student
{
    public int id{get;set;}
    public string name{get;set;} 
    public string email{get;set;}
    public Student(){
        
    }


    public Student(int id , string name, string email){
        this.id = id;
        this.name = name;
        this.email = email; 
    }
}
