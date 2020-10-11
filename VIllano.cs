public class Villano:Personaje{
    
    #region Atributos
    #endregion

    #region Constructor
    // constructor default
    public Villano():base(){
    }
    // constructor 1
    public Villano(string nombre, int aniocreacion, string universo, int stamina):base(nombre, aniocreacion, universo, stamina){
    }
    #endregion

    #region setters y getters
    #endregion

    #region Metodo
    public override void Atacar(){
    }
    #endregion
}