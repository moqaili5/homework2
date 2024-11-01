using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi");

        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };

        string sentence = ""; 
        int count = 0;

        // Generate a random sentence with 7 words
        while (count < 7)
        {
            int randomIndex = Random.Range(0, words.Length);

            sentence += words[randomIndex];

            if (count < 6)
            {
                sentence += " ";
            }

            count++;
        }

        Debug.Log("Funny Random Sentence: " + sentence);

        // A predefined funny sentence
        string fixedSentence = "The monkey wore a hat while driving a car full of pizza.";
        Debug.Log("Fixed Funny Sentence: " + fixedSentence);
    }
}
