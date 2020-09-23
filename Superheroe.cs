using System;
public class Superheroe{
    
    #region Atributos
    private int CantidadVidas;
    private Superpoder Superpoder;
    #endregion

    #region Constructor
    // constructor default
    public Superheroe(){
        this.CantidadVidas = 0;
        this.Superpoder = new Superpoder();
    }
    // constructor 1
    public Superheroe(int cantidadvidas, Superpoder superpoder){
        this.CantidadVidas = cantidadvidas;
        this.Superpoder = superpoder;
    }
    #endregion

    #region setters y getters
    // set
    public void SetCantidadVidas(int cantidadvidas){
        this.CantidadVidas = cantidadvidas;
    }
    public void SetSuperpoder(Superpoder superpoder){
        this.Superpoder = superpoder;
    }

    // get
    public int GetCantidadVidas(){
        return this.CantidadVidas;
    }
    public Superpoder GetSuperpoder(){
        return this.Superpoder;
    }
    #endregion

    #region Metodo
    public Item ObtenerItem(){
        Item item = new Item();
        return item;
    }
    public void UsarItem(Item item){
    }
    public void Defender(int ataque){
    }
    public void UsarSuperPoder(){
    }
    #endregion
}