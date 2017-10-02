using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
//using UnityEngine.Random;

public class Tarot : MonoBehaviour
{

    public Text tarot;
    public List<string> deck = new List<string>()
    {
        "The Fool",
        "The Magician",
        "The High Priestess",
        "The Empress",
        "The Emperor",
        "The Hierophant",
        "The Lovers",
        "The Chariot",
        "Strength",
        "The Hermit",
        "The Wheel of Fortune",
        "Justice",
        "The Hanged Man",
        "Death",
        "Temperance",
        "The Devil",
        "The Tower",
        "The Star",
        "The Moon",
        "The Sun",
        "Judgment",
        "The World",
    };

    public string card;
    public int pull;
    private string[] minor = { "King", "Queen", "Knight", "Page" };
    private string[] suit = { " of Wands", " of Cups", " of Swords", " of Pentacles" };

    void Start()
    {
        tarot = GetComponent<Text>();
        pull = Random.Range(0, deck.Count);

        for (int i = 0; i < 10; i++)
        {
            deck.Add((i + 1) + " of Wands");
        }

        for (int i = 0; i < 10; i++)
        {
            deck.Add((i + 1) + " of Cups");
        }

        for (int i = 0; i < 10; i++)
        {
            deck.Add((i + 1) + " of Swords");
        }

        for (int i = 0; i < 10; i++)
        {
            deck.Add((i + 1) + " of Pentacles");
        }

        for (int i = 0; i < 4; i++)
        {
            deck.Add(minor[i] + " of Wands");
        }

        for (int i = 0; i < 4; i++)
        {
            deck.Add(minor[i] + " of Cups");
        }
        
        for (int i = 0; i< 4; i++)
        {
            deck.Add(minor[i] + " of Swords");
        }

        for (int i = 0; i< 4; i++)
        {
            deck.Add(minor[i] + " of Pentacles");
        }
    }

    void Update()
    {
        card = deck[pull];
        tarot.text = card;

        if (Input.GetButtonDown("Fire1"))
        {
            pull = Random.Range(0, deck.Count);
        };
    }
}
