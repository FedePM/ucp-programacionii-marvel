using System.Collections.Generic;
public class Juego{
    
    #region Atributos
    private bool Resultado;
    private int Nivel;  
    private List<Combate> Combates;
    #endregion

    #region Constructor
    // constructor default
    public Juego(){
        this.Resultado = true;
        this.Nivel = 0;
    }
    // constructor 1
    public Juego(bool resultado, int nivel, List<Combate> combates){
        this.Resultado = resultado;
        this.Nivel = nivel;
        this.Combates = combates;
    }
    #endregion

    #region setters y getters
    // set
    public void SetResultado(bool resultado){
        this.Resultado = resultado;
    }
    public void SetNivel(int nivel){
        this.Nivel = nivel;
    }
    public void SetCombates(List<Combate> combates){
        this.Combates = combates;
    }

    // get
    public bool GetResultado(){
        return this.Resultado;
    }
    public int GetNivel(){
        return this.Nivel;
    }
    public List<Combate> GetCombates(){
        return this.Combates;
    }
    #endregion

    #region Metodo
    public void Comenzar(){
    }
    public void Terminar(){
    }
    #endregion
}