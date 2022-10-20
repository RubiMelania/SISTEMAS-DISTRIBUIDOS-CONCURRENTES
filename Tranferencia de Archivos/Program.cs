using System.IO;
using System.Net.Sockets;
using System.Net;
using System;

utilizando el sistema;
usando System.Collections.Generic;
utilizando System.Net;
utilizando System.Net.Sockets;
utilizando System.IO;
usando Sistema.Texto;

Transferencia de   archivos de espacio de nombres
{  
     programa de   clase
    {  
         vacío estático  principal ( cadena [] args )  
        {
    // Escuchar en el puerto 1234    
    TcpListener tcpListener = new TcpListener(IPAddress.Any, 1234);
    tcpListener.Start();

    Console.WriteLine("Servidor iniciado");

    //Bucle infinito para conectarse a  nuevos  clientes    
    mientras(verdadero)
            {
        // Aceptar un  TcpClient    
        TcpClient tcpClient = tcpListener.AcceptTcpClient();

        Consola.WriteLine("Conectado al cliente");

        Stream Reader  lector = nuevo  Stream Reader(tcpClient.GetStream ( ) );

        // El primer mensaje del cliente es el tamaño del archivo    
        cadena cmdFileSize = lector.ReadLine();

        // El primer mensaje del cliente es el nombre del archivo    
        cadena cmdFileName = lector.ReadLine();

        longitud int  = Convert.ToInt32(cmdFileSize);
        byte[] búfer = nuevo  byte[longitud];
        int recibido = 0;
        lectura int  = 0;
        tamaño int  = 1024;
        int restante = 0;

        // Lee  los bytes del cliente  usando  la longitud enviada por el cliente    
        while (recibido < longitud)
        {
            restante = longitud - recibido;
            si(restante < tamaño)
                    {
                tamaño = restante;
            }

            read = tcpClient.GetStream().Read(búfer, recibido, tamaño);
            recibido += leído;
        }

        // Guarda el archivo  usando  el nombre de archivo enviado por el cliente    
        usando(Flujo de archivos fStream = nuevo Flujo de archivos(Ruta.GetFileName(cmdFileName), Modo de archivo.Crear))
                {
            fStream.Write(buffer, 0, buffer.Length);
            fStream.Flush();
            fStream.Cerrar();
        }

        Console.WriteLine("Archivo recibido y guardado en" + Environment.CurrentDirectory);
    }
}  
    }  
} 