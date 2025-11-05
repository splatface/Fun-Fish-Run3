using System.Collections.Generic;
using UnityEngine;

public class PlayerFish : MonoBehaviour
{

    //IMAGE VARIABLES
    // an array of all sprite images for evolution (in order by index)
    public Sprite[] sprites;
    private int _currentIndex; // current index of the sprites array
    // current sprite icon equipped
    private SpriteRenderer _currentSprite;

    //LOGISTICS VARIABLES
    private int _stepValue = 3; // the exponential amount of extra exp needed to evolve
    private int _currentExpToEvolve = 100;
    private int _exp; // how much exp the playerfish currently has

    // logic behind sprite evolution
    private void SpriteEvol()
    {
    }

    void Start()
    {
        //sets the sprite to the first evolution upon start up
        this._currentSprite = GetComponent<SpriteRenderer>();
        this._currentSprite.sprite = sprites[0];
        this._currentIndex = 0;
        this._exp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SpriteEvol();
    }

}