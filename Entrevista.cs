namespace Extra1;

public class Entrevista{
    private string candidato;
    private DateTime fechaHora;
    private int duracion;
    private string puesto;
    private string entrevistador;

    public Entrevista(){
        this.candidato = "";
        this.fechaHora = new DateTime();
        this.duracion = 0;
        this.puesto = "";
        this.entrevistador = "";
    }

    public DateTime getFechaHora(){
        return this.fechaHora;
    }

    public void modificarFechaHora(DateTime nuevaFechaHora){
        this.fechaHora = nuevaFechaHora;
    }

    public void modificarDuracion(int nuevaDuracion){
        this.duracion = nuevaDuracion;
    }

    public void moverEntrevista(int dias){
        this.fechaHora.AddDays(dias);
    }
}