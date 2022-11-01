using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValues : MonoBehaviour
{
    public string characterName = "Lex Luthor";
    private int startLevel = 1;
    public int addedLevel = 1;
    public int currentLevel;
    

    private void Start()
    {
        Debug.Log(characterName);
        PrintValues(characterName, startLevel);
        ComputeLevel();
    }

    /// <summary>
    /// prints character name and level
    /// </summary>
    /// <param name="name"></param>
    /// <param name="level"></param>
    public void PrintValues(string name, int level)
    {
        Debug.Log($"Your character is {name} - Level {level}");
            
    }

    public void ComputeLevel()
    
    {
        currentLevel = startLevel + addedLevel;
        Debug.Log($"Level {currentLevel}");
    }
}


    
    
