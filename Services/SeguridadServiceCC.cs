namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        static string abecedari = ("abcdefghijklmnñopqrstuvwxyz");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        
        public string DesEncriptar(string Mensaje, int clave)
        {
            return Mensaje;
        }
        public string Encriptar(string Mensaje,int clave)
        {
            int i=0;
            int x=0;
            string igualdad=Mensaje;
            for (i=0; i<Mensaje.Length;i++){
            for(x=0; x<=26;x++){
                if(Mensaje[i]==ABECEDARIO[x]){
                    igualdad=igualdad.Replace(igualdad[i],ABECEDARIO[x-clave]);

                }
                if(Mensaje[i]==abecedari[x]){
                    igualdad=igualdad.Replace(igualdad[i],abecedari[x-clave]);
                }}}
            Mensaje=igualdad;
            return Mensaje;

        }
    }
}  
        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {
            int i=0,x=0;
            char[] CC=new char[Mensaje.Length];
            for(int L=0;L<Mensaje.Length;L++){
                CC[L]=Mensaje[L];
            }
            for(i=0;i<Mensaje.Length;i++){
                for (x=0;x<27;x++){
                    if(Mensaje[i]==ABECEDARIO[x]){
                        CC[i]=ABECEDARIO[x+clave];
                    }
                    if(Mensaje[i]==abecedari[x]){
                    CC[i]=abecedari[x+clave];
                    }
                }
            }
            string frase=new string(CC);
            Mensaje=frase;
            return Mensaje;
        }
    }


}