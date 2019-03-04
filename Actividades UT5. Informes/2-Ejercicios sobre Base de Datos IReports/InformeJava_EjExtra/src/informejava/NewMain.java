/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package informejava;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import net.sf.jasperreports.engine.JRDataSource;
import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.data.JRBeanCollectionDataSource;

/**
 *
 * @author Annie
 */
public class NewMain {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws JRException {
        //Para generar el informe desde aquí:

        //Obtenemos la lista a mostrar
        List<Coche> listaCoches = new ArrayList<Coche>();
        
        listaCoches.add(new Coche("Peugeot", "206", "O-6834-CC"));
        listaCoches.add(new Coche("Seat", "Ibiza", "9366DHV"));
        listaCoches.add(new Coche("Opel", "Astra", "7345DXK"));
        listaCoches.add(new Coche("Opel", "Astra", "O-6253-BM"));
        
        System.out.println(listaCoches.size());
        JRDataSource dataSource = new JRBeanCollectionDataSource(listaCoches);
        Map parametros = new HashMap();
        JasperPrint print;
        print = JasperFillManager.fillReport("C:\\Users\\Annie\\Google Drive\\DI\\2ª EVAL\\Tema 5\\Tema 5\\Ejercicios DI Tema 5\\Ejercicios\\2-Ejercicios sobre Base de Datos IReports\\InformeJava_EjExtra\\informes\\informeJava.jasper", parametros, dataSource);
        JasperExportManager.exportReportToPdfFile(print, "C:\\Users\\Annie\\Google Drive\\DI\\2ª EVAL\\Tema 5\\Tema 5\\Ejercicios DI Tema 5\\Ejercicios\\2-Ejercicios sobre Base de Datos IReports\\InformeJava_EjExtra\\informes\\informeJava.pdf");
    }

}
