using System;

class Person {
    private string name;
    private int age;
    
    public void setName(string name)
    {
        this.name = name;
    }
    
    public string getName()
    {
        return this.name;
    }
    
    public void setAge(int age)
    {
        if(age >= 0)
        {
            this.age = age;
        }
        else
        {
            this.age = 0;
        }
    }
    
    public int getAge()
    {
        return this.age;
    }

}
