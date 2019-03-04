/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pokemons;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Annie
 */
public class TestDataSource {
     public static List<Pokemon> listarPokemons() {

       
        List<Pokemon> listaPokemons = new ArrayList<>();
        listaPokemons.add(new Pokemon("Dragonite", "Dragón", "Enfado"));
        listaPokemons.add(new Pokemon("Pikachu", "Eléctrico", "Chispazo"));
        listaPokemons.add(new Pokemon("Vaporeon", "Agua", "Hidrobomba"));
        listaPokemons.add(new Pokemon("Charmander", "Fuego", "Nitrocarga"));
       
        return listaPokemons;

    }
}
