using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lv1Controller : MonoBehaviour
{
    public AudioController musicPlayer;
    public catMovement catBossWindow;
    public catMovement2 catBossHallway;


    public void CreepyTime()
    {
        musicPlayer.CreepyTime(1);
        catBossWindow.StopMovement();
        catBossHallway.D3();
<<<<<<< Updated upstream
    }
=======
        screenController.CreepyTime();
        fightDialogue.CreepyTime();
    }



    // void Start()
    // {
    //     StartCoroutine(Testingg());
    // }

    // IEnumerator Testingg() {
    //     yield return new WaitForSeconds(5);
    //     CreepyTime();
    //     print("activating Creepy Time");
    // }
>>>>>>> Stashed changes
}
