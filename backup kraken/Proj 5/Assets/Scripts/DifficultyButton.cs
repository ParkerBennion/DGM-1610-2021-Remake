using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button _button;
    private GameManager _gameManager;
    public int difficulty;
    void Start()
    {
        _button = GetComponent<Button>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        _button.onClick.AddListener(SetDifficulty);
        
    }
    void SetDifficulty()
    {
        Debug.Log(_button.gameObject.name + " was clicked");
        _gameManager.StartGame(difficulty);
    }
}
