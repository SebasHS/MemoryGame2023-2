using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonCard{
    public string pokemonName;

    public bool isShown;

    public PokemonCard(string name){
        pokemonName = name;
        isShown = false;
    }
}

public class GameManager : MonoBehaviour
{
    private List<PokemonCard> pokemonCardList;

    private void Start() {
        pokemonCardList= new List<PokemonCard>();

    PokemonCard card1 = new PokemonCard("pikachu");
    PokemonCard card2 = new PokemonCard("snorlax");
    PokemonCard card3 = new PokemonCard("bulbasaur");
    PokemonCard card4 = new PokemonCard("charmander");
    PokemonCard card5 = new PokemonCard("pidgey");
    PokemonCard card6 = new PokemonCard("pikachu");
    PokemonCard card7 = new PokemonCard("pidgey");
    PokemonCard card8 = new PokemonCard("jigglypuff");
    PokemonCard card9 = new PokemonCard("psyduck");
    PokemonCard card10 = new PokemonCard("squirtle");
    PokemonCard card11 = new PokemonCard("bulbasaur");
    PokemonCard card12 = new PokemonCard("jigglypuff");
    PokemonCard card13 = new PokemonCard("squirtle");
    PokemonCard card14 = new PokemonCard("charmander");
    PokemonCard card15 = new PokemonCard("psyduck");
    PokemonCard card16 = new PokemonCard("snorlax");

    pokemonCardList.Add(card1);
    pokemonCardList.Add(card2);
    pokemonCardList.Add(card3);
    pokemonCardList.Add(card4);
    pokemonCardList.Add(card5);
    pokemonCardList.Add(card6);
    pokemonCardList.Add(card7);
    pokemonCardList.Add(card8);
    pokemonCardList.Add(card9);
    pokemonCardList.Add(card10);
    pokemonCardList.Add(card11);
    pokemonCardList.Add(card12);
    pokemonCardList.Add(card13);
    pokemonCardList.Add(card14);
    pokemonCardList.Add(card15);
    pokemonCardList.Add(card16);
    }
}
