class program{

    static void Main(string[] args){

        Car bmw = new Car();
        bmw.brand = "BMW";
        bmw.miles = 4000;
        bmw.color = "Black";
        
        bmw.move_forward();
        bmw.display_info();
      
       
    }
}