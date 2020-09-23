using System;
public class Combate{
    
    #region Atributos
    private Superheroe Superheroe;
    private Villano Villano;
    private Superheroe Ganador;
    private int CantidadDeUsosSuperpoder;
    #endregion

    #region Constructor
    // constructor default
    public Combate(){
        this.Superheroe = new Superheroe();
        this.Villano = new Villano();
        this.Ganador = new Superheroe();
        this.CantidadDeUsosSuperpoder = 0;
    }
    // constructor 1
    public Combate(Superheroe superheroe, Villano villano, Superheroe ganador, int cantidadusos){
        this.Superheroe = superheroe;
        this.Villano = villano;
        this.Ganador = superheroe;
        this.CantidadDeUsosSuperpoder = cantidadusos;
    }
    #endregion

    #region setters y getters
    // set
    public void SetSuperheroe(Superheroe superheroe){
        this.Superheroe = superheroe;
    }
    public void SetVillano(Villano villano){
        this.Villano = villano;
    }
    public void SetGanador(Superheroe ganador){
        this.Ganador = ganador;
    }
    public void SetCantidadDeUsosSuperpoder(int cantidadusos){
        this.CantidadDeUsosSuperpoder = cantidadusos;
    }

    // get
    public Superheroe GetSuperheroe(){
        return this.Superheroe;
    }
    public Villano GetVillano(){
        return this.Villano;
    }
    public Superheroe GetGanador(){
        return this.Ganador;
    }
    public int GetCantidadDeUsosSuperpoder(){
        return this.CantidadDeUsosSuperpoder;
    }
    #endregion

    #region Metodo
    public void Comenzar(){
    }
    public void Terminar(){
    }
    public void Turno(Superheroe p){
    }
    #endregion
}