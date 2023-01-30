using System;



namespace Library
{
    public class Customer
    { 
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        
        
        //Constructors
        public Customer() {
            ID = Guid.NewGuid();
            Code= 001;
            Description ="Retail Customer";
        }


        //Methods
        

        


    }

   

    
     

}



