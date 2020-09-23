public class Item{
    
    #region Atributos
    private string Tipo;
    #endregion

    #region Constructor
    // constructor default
    public Item(){
        this.Tipo = "";
    }
    // constructor 1
    public Item(string tipo){
        this.Tipo = tipo;
    }
    #endregion

    #region setters y getters
    // set
    public void SetTipo(string tipo){
        this.Tipo = tipo;
    }

    // get
    public string GetTipo(){
        return this.Tipo;
    }
    #endregion

    #region Metodo
    public string SortearTipoItem(){
        return this.GetTipo();
    }
    #endregion
}