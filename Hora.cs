public class Hora{

	//Bytes
	private byte hora;
	private byte minuto;
	private byte segundo;

	//consturctor de mi Hora
	public Hora(int hora,int minuto,int segundo){

		this.hora = (byte) hora;
		this.minuto = (byte) minuto;
		this.segundo = (byte) segundo;
	}

	
	public  override String ToString(){

		String Hora = "";
		if(hora < 10)
			Hora = "0" + hora;
		else
			Hora = ""+hora;
		if(minuto < 10)
			Hora+= ":0"  + minuto;
		else
			Hora+= ":"+minuto;
		if(segundo < 10)
			Hora += ":0" + segundo;
		else
			Hora += ":"+segundo;
		return Hora;
	}

	public void sumarHoras(byte hora){

		this.hora += hora;
		if(this.hora<=0)
		{
			this.hora=0;
		}
	}

	public void sumarMinutos(byte minuto){
		this.minuto += minuto;
		if(this.minuto >=60)
		{
			this.minuto=0;
			sumarHoras((byte)1);
		}
		
	}

	public void sumarSegundos(byte segundo){
		this.segundo +=segundo;
		if(this.segundo>=60)
		{
			this.segundo=0;
			sumarMinutos((byte)1);
		}


	}
}