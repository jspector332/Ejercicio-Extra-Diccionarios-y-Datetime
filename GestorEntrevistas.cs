namespace Extra1;

public class GestorEntrevistas{
    private Dictionary<int, Entrevista> dicEntrevistas;

    public GestorEntrevistas(){
        this.dicEntrevistas = new Dictionary<int,Entrevista>();
    }

    public string agregarEntrevista(int dni, Entrevista entrevista){
        resu = "No se pudo agregar la entrevista.";
        if (dicEntrevistas.ContainsKey(dni) == false){
            dicEntrevistas.Add(dni, entrevista);
            resu = "Entrevista agregada correctamente.";
        }
        return resu;
    }

    public bool eliminarEntrevista(int dni){
        bool resu = false;
        if (dicEntrevistas.ContainsKey(dni)){
            dicEntrevistas.Remove(dni);
            resu = true;
        }
        return resu;
    }

    public bool modificarEntrevista(int dni, DateTime nuevaFechaHora, int nuevaDuracion){
        bool resu = false;
        if (dicEntrevistas.ContainsKey(dni)){
            dicEntrevistas[dni].modificarFechaHora(nuevaFechaHora);
            dicEntrevistas[dni].modificarDuracion(nuevaDuracion);
            resu = true;
        }
        return resu;
    }

    public int compararEntrevistas(int dni1, int dni2){
        int diferencia = -1;
        if (dicEntrevistas.ContainsKey(dni1) && dicEntrevistas.ContainsKey(dni2)){
            diferencia = (dicEntrevistas[dni1].getFechaHora()).Days() - (dicEntrevistas[dni2].getFechaHora()).Days();
        }
        return diferencia;
    }

    public bool moverEntrevista(int dni, int dias){
        bool resu = false;
        if (dicEntrevistas.ContainsKey(dni)){
            dicEntrevistas[dni].moverEntrevista(dias);
            resu = true;
        }
        return resu;
    }

    public Entrevista obtenerProximaEntrevista(){
        DateTime hoy = DateTime.Today;
    }
}