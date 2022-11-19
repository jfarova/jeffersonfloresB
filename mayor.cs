class mayor:numeros{
     private int numero1 {get;set;}
    private int numero2 {get;set;}
    public  mayor(int numero1,int numero2):base(numero1,numero2){
        this.numero1=numero1;
        this.numero2=numero2;
        if(numero1>numero2){
            Console.WriteLine("el numero mayor es:" +numero1);

        }
        else{
            Console.WriteLine("el numero mayor es:" +numero2);
        }

}
}