public class Superheroe : Personaje{
    
    #region Atributos
    private int CantidadVidas;
    private Superpoder Superpoder;
    #endregion

    #region Constructor
    // constructor default
    public Superheroe() : base(){
        this.CantidadVidas = 0;
        this.Superpoder = new Superpoder();
    }
    // constructor 1
    public Superheroe(string nombre, int aniocreacion, string universo, int stamina,int cantidadvidas, Superpoder superpoder):base(nombre, aniocreacion, universo, stamina){
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
    public override void Atacar(){
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