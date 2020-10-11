public class Combate{
    
    #region Atributos
    private Superheroe Superheroe;
    private Villano Villano;
    private Personaje Ganador;
    private int CantidadDeUsosSuperpoder;
    #endregion

    #region Constructor
    // constructor default
    public Combate(){
        this.Superheroe = new Superheroe();
        this.Villano = new Villano();
        this.Ganador = new Personaje();
        this.CantidadDeUsosSuperpoder = 0;
    }
    // constructor 1
    public Combate(Superheroe superheroe, Villano villano, Personaje ganador, int cantidadusos){
        this.Superheroe = superheroe;
        this.Villano = villano;
        this.Ganador = ganador;
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
    public void SetGanador(Personaje ganador){
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
    public Personaje GetGanador(){
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
    public void Turno(Personaje p){
    }
    #endregion
}