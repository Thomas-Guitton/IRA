using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Attic[] attics;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Plant(int id, int player)
    {
        if ((player == 0 && id < 6) || (player == 1 && id >= 6))
        {
            //Calculate where will the last seed wil be plant
            int finalAtticId = (id + attics[id].number) % 12;

            //Save the initial amount of rocks in the choosen attic and empty it
            int number = attics[id].number;
            attics[id].number = 0;
            
            //Drop every rocks in attics
            for (int i = 1; i < number + 1; i++)
            {
                attics[(id + i) % 12].number++;
            }

            //Checks if we are in the harvesting condition
            bool onOpponentSide = (player == 0 && finalAtticId > 6) || (player == 1 && finalAtticId <= 6);
            if (onOpponentSide && (attics[finalAtticId].number == 2 || attics[finalAtticId].number == 3))
            {
                Harvest(finalAtticId, player);
            }
        }
        else
        {
            //TODO: Demander de rejouer au joueur en question
        }
    }

    public void Harvest(int id, int player)
    {
        if (player == 0)
        {
            //TOOD: Empty attics[id] and check its direct neighboor to see if you can chain then increment Player1Score
        }
        else
        {
            //TOOD: Empty attics[id] and check its direct neighboor to see if you can chain then increment Player2Score
        }
    }


}
