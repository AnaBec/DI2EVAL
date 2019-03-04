/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package informejava;

import java.util.ArrayList;
import java.util.List;
import net.sf.jasperreports.engine.JRException;

/**
 *
 * @author Annie
 */
public class TestDataSource {

    public static List<Coche> listCoches() throws JRException {//metodo llamado "listCoches"

        /*Esta clase devuelve la lista de coches para el modo "Preview".
        En el informe se van a mostrar coches. Tendremos que configurar el
        IReport para que sea capaz de acceder al método de esta clase que 
        hace que devuelva una lsita de objetos en nuestro programa (coches)*/
        
        //Tenemos que añadir las librerias "JasperReports y HSQLDB" 
        //y poner el JDK 1.7 (MUY IMPORTANTE)
        
        List<Coche> listaCoches = new ArrayList<>();
        listaCoches.add(new Coche("Peugeot", "206", "O-6834-CC"));
        listaCoches.add(new Coche("Seat", "Ibiza", "9366DHV"));
        listaCoches.add(new Coche("Opel", "Astra", "7345DXK"));
        listaCoches.add(new Coche("Opel", "Astra", "O-6253-BM"));
       
        return listaCoches;

    }

}
