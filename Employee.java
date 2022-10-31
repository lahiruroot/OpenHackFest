import java.util.Scanner;

public class Employee{
    String name;
    int age;
    boolean married;
    String address;
    int per_hour;

    public void myFunction(String name, int age, boolean married, String address, double working_hours, int per_hour){
        double salary= working_hours*per_hour;

        System.out.println("Employee name:" +name);
        System.out.println("Employee age:"+ age);
        System.out.println("Married or unmarried:"+ married);
        System.out.println("Employee Address:"+ address);
        System.out.println("Employee Salary:"+ salary);
    }

    public static void main(String[] args) {
        Scanner type= new Scanner(System.in);
        System.out.print("Enter the type of position(Employee: 1/ Coustomer: 0): ");

        int position = type.nextInt();

        if (position==1){
            Employee myobj_1= new Employee();
            myobj_1.myFunction("Anura kumara Disanayake", 47, true, "No.123, Galleface Road, colombo", 12, 2000); 
        }

        else if(position==0){
            Customer myobj_2= new Customer();
            myobj_2.myFunction_1("Binara Tennakoon", 23, false, "No 540/1, negombo road, mahabage, ragama", 35500);
        }

        else{
            System.out.println("plese enter the valid number...");
        }
    }
}

class Customer extends Employee{
    double bill;

    public void myFunction_1(String name, int age, boolean married, String address, double bill){
        this. name= name;
        this. age= age; 
        this.married= married;
        this.address= address;
        this.bill=bill;

        System.out.println("Coustomer name:" +name);
        System.out.println("Coustomer age:"+ age);
        System.out.println("Married or unmarried:"+ married);
        System.out.println("Coustomer Address:"+ address);
        System.out.println("Coustomer Bill:"+ bill);
    }

}