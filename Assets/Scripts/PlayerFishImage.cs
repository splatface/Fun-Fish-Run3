using System.Collections.Generic;
using UnityEngine;

public class PlayerFish : MonoBehaviour
{

    //IMAGE VARIABLES
    public Sprite[] Sprites; // array of all sprites
    private SpriteRenderer _currentSprite;
    public RuntimeAnimatorController[] AnimationsController; // all animations for sprites (same indexes as sprites array)
    private Animator _currentAnimation;
    private int _currentIndex; // current index of the sprites array


    //LOGISTICS VARIABLES
    private static int _stepValue = 3; // the exponential amount of extra exp needed to evolve
    private int _currentExpToEvolve = 50;
    private int _exp; // how much exp the playerfish currently has


    // logic behind sprite evolution
    private void SpriteEvol()
    {

        this._exp += 1;

        // get feedback exp from plants code

        // logic of evolution
        if (this._exp > this._currentExpToEvolve)
        {
            this._currentExpToEvolve *= _stepValue;
            _currentIndex += 1;
            // updates the sprites and animations
            this._currentSprite.sprite = Sprites[_currentIndex];
            this._currentAnimation.runtimeAnimatorController = AnimationsController[_currentIndex];
        }
    }

    void Start()
    {
        //sets the sprite to the first evolution upon start up
        this._currentSprite = GetComponent<SpriteRenderer>();
        this._currentAnimation = GetComponent<Animator>();
        this._currentSprite.sprite = Sprites[0];
        this._currentAnimation.runtimeAnimatorController = AnimationsController[0];
        this._currentIndex = 0;
        this._exp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SpriteEvol();
    }

}