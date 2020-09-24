public class Superpoder{
    
    #region Atributos
    private bool Tipo;
    private int CantidadUsos;
    #endregion

    #region Constructor
    // constructor default
    public Superpoder(){
        this.Tipo = true;
        this.CantidadUsos = 0;
    }
    // constructor 1
    public Superpoder(bool tipo, int cantidadusos){
        this.Tipo = tipo;
        this.CantidadUsos = cantidadusos;
    }
    #endregion

    #region setters y getters
    // set
    public void SetTipo(bool tipo){
        this.Tipo = tipo;
    }
    public void SetCantidadUsos(int cantidadusos){
        this.CantidadUsos = cantidadusos;
    }

    // get
    public bool GetTipo(){
        return this.Tipo;
    }
    public int GetCantidadUsos(){
        return this.CantidadUsos;
    }
    #endregion

    #region Metodo
    public void Usar(Superheroe s){
    }
    #endregion
}