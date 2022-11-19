class numeros{
    private int numero1 {get;set;}
    private int numero2 {get;set;}
    public  numeros(int numero1,int numero2){
        this.numero1=numero1;
        this.numero2=numero2;

    }
    public void imprimir(){
    Console.WriteLine(" el numero ingresado es : " + numero1 + " el numero ingresado es : " + numero2); 
}
}