using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lv2Controller : MonoBehaviour
{
    public AudioController musicPlayer;
<<<<<<< Updated upstream
=======
    public ScoreController scoreController;
    
>>>>>>> Stashed changes
    //public TVController tV;
    //public ItemSpawner spawner;
    //public Conveyor conveyor;
    public CatMovementLevelTwo catBoss;
<<<<<<< Updated upstream

    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(Testingg());
=======
    [SerializeField] int boxesUntilCreepyTime = 3;
    public ScreenController screenController;
    public StopTheConveyor stopConveyor;
    public RandomSpawner spawner;

    int completedBoxes = 0;

    // Start is called before the first frame update
    // void Start()
    // {
    //     StartCoroutine(Testingg());
    // }

    // IEnumerator Testingg() {
    //     yield return new WaitForSeconds(5);
    //     CreepyTime();
    // }

    public void BoxNumberListener(Component sender, object data) { //called by both listeners, they're sending different data types
        
        if (data is bool) {
            BoxUpdate((bool)data);
            //print(data);
        }
        else if (data is int) {
            completedBoxes = (int)data;
            //print(data);
        }
    }



    public void BoxUpdate(bool completed) {

        if (completed) {
            scoreController.BoxComplete();
            //increase conveyor speed
        }
        else {
            scoreController.BoxFail();
            // redo the same box
        }

        if (completedBoxes == boxesUntilCreepyTime) {
            CreepyTime();
        }

        // if (completed) {
        //     scoreController.BoxComplete();
        //     //increase conveyor speed

        //     completedBoxes += 1;
        //     if (completedBoxes == boxesUntilCreepyTime) {
        //         CreepyTime();
        //     }
        // }
        // else {
        //     scoreController.BoxFail();
        //     // redo the same box
        // }
>>>>>>> Stashed changes
    }

    public void CreepyTime() {

        musicPlayer.CreepyTime(2);
        //tV.CreepyTime();
        catBoss.CreepyTime();
<<<<<<< Updated upstream
=======
        screenController.CreepyTime();


        stopConveyor.CreepyTime();
        spawner.CreepyTime();
        
        
>>>>>>> Stashed changes
        
        // grinder already has it by default; whenever rat head, spits out blue can
        //spawner.CreepyTime();
        //conveyor.CreepyTime();

    }



    void Start()
    {
        StartCoroutine(Testingg());
    }

    IEnumerator Testingg() {
        yield return new WaitForSeconds(5);
        CreepyTime();
        print("activating Creepy Time");
    }
}
