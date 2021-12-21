namespace SamarPro
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;

    public class db_model : DbContext
    {
        static db_model()
        {
            Database.SetInitializer<db_model>(null);
        }

        // Your context has been configured to use a 'db_model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SamarPro.db_model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'db_model' 
        // connection string in the application configuration file.
        public db_model()
            : base("name=db_model")
        {
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 

        public DbSet<TBLuser> TBLusers { get; set; }
        public DbSet<PosProduct> PosProducts { get; set; }
        public DbSet<ShowPos> ShowPos { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<SupCategory> SupCategorys { get; set; }
        public DbSet<ParentCategory> ParentCategorys { get; set; }
        public DbSet<Supplayier> Supplayiers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Adversary> Adversarys { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<TBLempoyee> TBLempoyees { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<RentPos> RentPoss { get; set; }
        public DbSet<Logs> Logss { get; set; }
        public DbSet<Stores> Storess { get; set; }
        public DbSet<PosService> PosServices { get; set; }
        public DbSet<TBL_Attendance> TBL_Attendances { get; set; }
        public DbSet<TBL_EmpPayRoll> TBL_EmpPayRolls { get; set; }
        public DbSet<Complainte> Complaintes { get; set; }
        public DbSet<Resource_Products> Resource_Productss { get; set; }
        public DbSet<Resource_Pos> Resource_Poss { get; set; }
        public DbSet<Tutorials> Tutorialss { get; set; }
        public DbSet<TutorialRegs> TutorialRegs { get; set; }
        public DbSet<THE_BOX> THE_BOXS { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
    }

    // Users
    public class TBLuser
    {
        [Key]
        public int ID { get; set; }
        public int Em_ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string PassWord { get; set; }    
        public Boolean Product { get; set; }
        public Boolean Service { get; set; }
        public Boolean Rent { get; set; }
        public Boolean Show { get; set; }
        public Boolean Gategory { get; set; }
        public Boolean Bank { get; set; }
        public Boolean Expenses { get; set; }
        public Boolean Employee { get; set; }
        public Boolean Supplaier { get; set; }
        public Boolean Storage { get; set; }
        public Boolean Pos { get; set; }
        public Boolean Rent_Pos { get; set; }
        public Boolean User { get; set; }
        public Boolean Employee_Add { get; set; }
        public Boolean PayRoll { get; set; }
        public Boolean Permiation { get; set; }
        public Boolean Logs { get; set; }
        public Boolean Reservation { get; set; }
        public Boolean Bac_Res { get; set; }
        public Boolean Res_Paid { get; set; }
        public Boolean Attend { get; set; }
        public Boolean show_Pos { get; set; }
    }

    // Employee
    public class TBLempoyee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Jop_Type { get; set; }
        public string Adress { get; set; }
        public string Note { get; set; }
        public double Salary { get; set; }
        public string Phone { get; set; }
        public DateTime HDate { get; set; }
    }

    // Reservation 
    public class Reservation
    {
        [Key]
        public int Code { get; set; }
        public int My_ID { get; set; }
        public string REStype { get; set; }
        public int SERTYPE { get; set; }
        public string CUSname { get; set; }
        public DateTime RESdate { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }
        public int EmpID { get; set; }
        public DateTime dayDate { get; set; }
        public double Paid { get; set; }
        public double withdrow { get; set; }
        public string Reservation_Time { get; set; }
        public string Reservation_Time1 { get; set; }
    }

    // Expenses
    public class Expense
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public double Money { get; set; }
        public string Note { get; set; }
        public DateTime E_date { get; set; }
    }

    // Bonus  
    public class Bonus
    {
        [Key]
        public int ID { get; set; }
        public string Note { get; set; }
        public int EM_ID { get; set; }
        public int RES_ID { get; set; }
        public double Money { get; set; }
        public DateTime DayDate { get; set; }
    }

    // Adversary 
    public class Adversary
    {
        [Key]
        public int ID { get; set; }
        public int EM_ID { get; set; }
        public double Money { get; set; }
        public string Note { get; set; }
        public DateTime DayDate { get; set; }
    }

    //  Products
    public class Product
    {
       
        [Key]
        public int ID { get; set; }
        public int  BarCode { get; set; }     
        public int PRDtype { get; set; }
        public string Name { get; set; }
        public int Quntity { get; set; }
        public int Uses { get; set; }
        public string SUP_name { get; set; }
        public DateTime DayDate { get; set; }
        public DateTime PayDate { get; set; }
        public DateTime ExperidDate { get; set; }
        public double PAYmoney { get; set; }
        public double PURCHERmoney { get; set; }
        public double JoumlaRmoney { get; set; }
        public double Commation { get; set; }
        public double Discount { get; set; }
        public string Status { get; set; }
    }

    // Supplayier
    public class Supplayier
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
    }

    // ParentCategory
    public class ParentCategory
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

    }

    // SupCategory
    public class SupCategory
    {
        [Key]
        public int ID { get; set; }
        public int PAR_id { get; set; }
        public string Name { get; set; }
    }

    // Services 
    public class Services
    {
        [Key]
        public int ID { get; set; }
        public int PRD_ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public double Money { get; set; }
    }

    // PosProducts 
    public class PosProduct
    {
        [Key]
        public int ID { get; set; }
        public int Bill_ID { get; set; }
        public int Barcode { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
        public string Sup_Name { get; set; }
        public double Money { get; set; }
        public string EmpName { get; set; }      
        public DateTime DayDate { get; set; }
    }
    // PosService
    public class PosService
    {
        [Key]
        public int ID { get; set; }
        public int SerID { get; set; }
        public int EmpID { get; set; }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public string Note { get; set; }
        public double Money { get; set; }
        public DateTime DayDate { get; set; }
    }  
    // Shows
    public class Show
    {
        [Key]
        public int ID { get; set; }
        public int quan { get; set; }
       public string Name { get; set; }
        public string Note { get; set; }
        public string Check_1 { get; set; }
        public int RES_ID_PRD_ID { get; set; }     
        public double Money { get; set; }
        public DateTime Sdate { get; set; }
        public DateTime Edate { get; set; }
    }

    // Banks
    public class Resource
    {
        [Key]
        public int ID { get; set; }
        public string Note { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
      }
    // Rent
    public class Rent
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public Double Price { get; set; }
    }
    // RentPos
    public class RentPos
    {
        [Key]
        public int ID { get; set; }
        public string EmpName { get; set; }
        public int Type { get; set; }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public string ReSave { get; set; }
        public Double Paid { get; set; }
        public Double Withdrow { get; set; }
        public DateTime DayDate { get; set; }
    }
    // Logs
    public class Logs
    {
        [Key]
        public int ID { get; set; }
        public string EmpName { get; set; }
        public string Process { get; set; }
        public DateTime Dtime { get; set; }
    }
    // ShowsPos
    public class ShowPos
    {
        [Key]
        public int ID { get; set; }
        public int Bill_Id { get; set; }
        public int quan { get; set; }
        public int RES_ID_PRD_ID { get; set; }
        public double Money { get; set; }
        public string Emp_Name { get; set; }
        public DateTime Entery_date { get; set; }

    }
    //Atendance
    public class TBL_Attendance
    {
        [Key]
        public int ID { get; set; }
        public int EmpID { get; set; }
        public string Status { get; set; }
        public DateTime Entery_Date { get; set; }
        public DateTime Lave_Date { get; set; }
        public DateTime Attend_Time { get; set; }
        public DateTime Lave_Time { get; set; }     
    }

    //Store
    public class Stores
    {
        [Key]
        public int Id { get; set; }
        public int Bar_Code { get; set; }
        public int Frist_Quantity { get; set; }
    }

    // TBL_EmpPayRoll
    public class TBL_EmpPayRoll
    {
        [Key]
        public int Id { get; set; }
        public int EMP_Id { get; set; }
        public int Adv_Hours { get; set; }
        public int Bonus_Persent { get; set; }
        public double Salary { get; set; }
        public double Dion { get; set; }
        public double Adv_Money { get; set; }
        public double Adv_Total { get; set; }
        public double Bonus_Money { get; set; }
        public double Bonus_Total { get; set; }
        public double Set_Total { get; set; }
        public double Get_Total { get; set; }
        public double Net_Salary { get; set; }
        public double Over_Money { get; set; }
        public double Over_Hours { get; set; }
        public double Total_Overs { get; set; }
        public DateTime Date_Pay { get; set; }
    }
    // complainte
    public class Complainte
    {
        [Key]
        public int ID { get; set; }
        public int SH_ID { get; set; }
        public string Name { get; set; }
        public int E_ID { get; set; }      
        public string Note { get; set; }
        public double Money { get; set; }
        public DateTime S_date { get; set; }
    }

    // Resource_Product
    public class Resource_Products
    {
        [Key]
        public int ID { get; set; }
        public int Barcode { get; set; }
        public string Name { get; set; }
        public int Stored_No { get; set; }
        public int Resource_Id { get; set; }
        public int Quantity { get; set; }
        public int Unit_Size { get; set; }
        public string Unit_type { get; set; }
        public double Money { get; set; }
        public DateTime EnteryDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int First_Quan { get; set; }
        public string Note { get; set; }
    }
    // Resource_Pos
    public class Resource_Pos
    {
        [Key]
        public int ID { get; set; }
        public int Bill_ID { get; set; }
        public int Resource_Id { get; set; }
        public int Barcode { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public double Money { get; set; }
        public double Total { get; set; }
        public DateTime BillDate { get; set; }
    }
    // table toturials
    public class Tutorials
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
    // table ToturialReg
    public class TutorialRegs
    {
        [Key]
        public int ID { get; set; }
        public int Tutorial_ID { get; set; }
        public string Name { get; set; }
        public string Tutorial_Name { get; set; }
        public string Phone_Number { get; set; }
        public string Another_Phone { get; set; }
        public double Paid { get; set; }
        public double Withdrow { get; set; }
        public double Price { get; set; }
        public DateTime E_Date { get; set; }
        public string Note { get; set; }
    }
    // table THE_BOX
    public class THE_BOX
    {
        [Key]
        public int ID { get; set; }
        public string RES_NAME { get; set; }
        public string PRD_NAME { get; set; }
        public string NOTE { get; set; }
        public DateTime N_DATE { get; set; }
    }
    //  Contract
    public class Contracts
    {

        [Key]
        public int ID { get; set; }
        public DateTime Day_Date { get; set; }
        public string Company { get; set; }
        public int Reg_No { get; set; }
        public int Fax { get; set; }
        public string Admin { get; set; }
        public string Com_Phone { get; set; }
        public string Com_Address { get; set; }
        public int Zip_Code { get; set; }
        public string Com_Email { get; set; }
        public string Employee { get; set; }
        public string Nationality { get; set; }
        public string PassPort { get; set; }
        public string Export_Owner { get; set; }
        public string Export_Date { get; set; }
        public int Card_Id { get; set; }
        public string Emp_Email { get; set; }
    }
}
