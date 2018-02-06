using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResources : MonoBehaviour {

    public Text textMetal;
    public Text textEnergy;
    public Text textOxygen;
    public Text text4th;

    public int playerMetal;
    public int playerEnergy;
    public int playerOxygen;
    public int player4th;

    private void Start() {
        player4th = 0;
        playerEnergy = 100;
        playerOxygen = 100;
        playerMetal = 0;
    }

    private void Update() {
        Write();
    }

    private void Write() {
        textMetal.text = "Metal: " + playerMetal.ToString();
        textEnergy.text = "Energy: " + playerEnergy.ToString();
        textOxygen.text = "Oxygen: " + playerOxygen.ToString();
        text4th.text = "4th: " + player4th.ToString();
    }
}
