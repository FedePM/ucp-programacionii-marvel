public class Superheroe{
    
    #region Atributos
    private string Nombre;
    private int AnioCreacion;
    private string Universo;
    private int Stamina;
    private int CantidadVidas;
    private Superpoder Superpoder;
    #endregion

    #region Constructor
    // constructor default
    public Superheroe(){
        this.Nombre = "";
        this.AnioCreacion = 0;
        this.Universo = "";
        this.Stamina = 0;
        this.CantidadVidas = 0;
        this.Superpoder = new Superpoder();
    }
    // constructor 1
    public Superheroe(string nombre, int aniocreacion, string universo, int stamina, int cantidadvidas, Superpoder superpoder){
        this.Nombre = nombre;
        this.AnioCreacion = aniocreacion;
        this.Universo = universo;
        this.Stamina = stamina;
        this.CantidadVidas = cantidadvidas;
        this.Superpoder = superpoder;
    }
    #endregion

    #region setters y getters
    // set
    public void SetNombre(string nombre){
        this.Nombre = nombre;
    }
    public void SetAnioCreacion(int aniocreacion){
        this.AnioCreacion = aniocreacion;
    }
    public void SetUniverso(string universo){
        this.Universo = universo;
    }
    public void SetStamina(int stamina){
        this.Stamina = stamina;
    }
    public void SetCantidadVidas(int cantidadvidas){
        this.CantidadVidas = cantidadvidas;
    }
    public void SetSuperpoder(Superpoder superpoder){
        this.Superpoder = superpoder;
    }

    // get
    public string GetNombre(){
        return this.Nombre;
    }
    public int GetAnioCreacion(){
        return this.AnioCreacion;
    }
    public string GetUniverso(){
        return this.Universo;
    }
    public int GetStamina(){
        return this.Stamina;
    }
    public int GetCantidadVidas(){
        return this.CantidadVidas;
    }
    public Superpoder GetSuperpoder(){
        return this.Superpoder;
    }
    #endregion

    #region Metodo
    public void Atacar(){
    }
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