public class Personaje{
    
    #region Atributos
    private string Nombre;
    private int AnioCreacion;
    private string Universo;
    private int Stamina;
    #endregion

    #region Constructor
    // constructor default
    public Personaje(){
        this.Nombre = "";
        this.AnioCreacion = 0;
        this.Universo = "";
        this.Stamina = 0;
    }
    // constructor 1
    public Personaje(string nombre, int aniocreacion, string universo, int stamina){
        this.Nombre = nombre;
        this.AnioCreacion = aniocreacion;
        this.Universo = universo;
        this.Stamina = stamina;
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
    #endregion

    #region Metodo
    // "Atacar()" es virtual porque en caso de que necesitemos declarar un objeto de la clase Personaje, 
    // éste deberá detectar que Atacar() tiene un cuerpo definido, de lo contrario, generaría un error.
    public virtual void Atacar(){}
    #endregion
}