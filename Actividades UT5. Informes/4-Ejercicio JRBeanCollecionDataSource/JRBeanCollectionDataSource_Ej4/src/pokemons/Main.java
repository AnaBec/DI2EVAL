/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pokemons;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.logging.Level;
import java.util.logging.Logger;
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
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            List<Pokemon> listaPokemons = new ArrayList<Pokemon>();
            
            listaPokemons.add(new Pokemon("Dragonite", "Dragón", "Enfado"));
            listaPokemons.add(new Pokemon("Pikachu", "Eléctrico", "Chispazo"));
            listaPokemons.add(new Pokemon("Vaporeon", "Agua", "Hidrobomba"));
            listaPokemons.add(new Pokemon("Charmander", "Fuego", "Nitrocarga"));
            
            System.out.println(listaPokemons.size());
            JRDataSource dataSource = new JRBeanCollectionDataSource(listaPokemons);
            Map parametros = new HashMap();
            JasperPrint print;
            print = JasperFillManager.fillReport("C:\\Users\\Annie\\Documents\\NetBeansProjects\\Nueva Carpeta\\JRBeanCollectionDataSource_Ej4\\informes\\informePokemons.jasper", parametros, dataSource);
            JasperExportManager.exportReportToPdfFile(print, "C:\\Users\\Annie\\Documents\\NetBeansProjects\\Nueva Carpeta\\JRBeanCollectionDataSource_Ej4\\informes\\informePokemons.pdf");
        } catch (JRException ex) {
            Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

}
