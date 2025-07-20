using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public paddle computerpaddle;
    public paddle playerpaddle;

    public Text playerscoretext;
    public Text computerscoretext;
    
    public ball ball;
    private int _playerscore;
    private int _computerscore;
    public void playerscores() {
        _playerscore++;
        this.playerscoretext.text = this._playerscore.ToString();
        this.playerpaddle.resetposition();
        this.computerpaddle.resetposition();
        this.ball.resetposition();
        this.ball.AddStartingForce();
        
    }
    public void computerscores()
    {
        _computerscore++;
        this.computerscoretext.text = this._computerscore.ToString();
        this.playerpaddle.resetposition();
        this.computerpaddle.resetposition();
        this.ball.resetposition();
        this.ball.AddStartingForce();
    }
}
