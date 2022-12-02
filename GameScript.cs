using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameScript : MonoBehaviour
{
    public TMP_Text storyText;
    public TMP_Text choiceText;
    public Sprite[] imageArray; 

    enum States {Beginning0, Lookaround0, AskingPartner0, CheckingCaseFiles0, EnteringDungeon0, AskingPartnersAfterEnteringDungeon0, TryingToExitThroughEntrance0, ContinueWalking0, 
        AskingWhatTheySee0, InvestigatingYourSurroundings0, ScorchJumpKicksSphinx0, WalkingPastOrWrong0, AttemptWalkPast0, TheRiddle0, StoneStatuesKill0, FindingExitOfRoom0, TheNextRoom1,
    };
    States myState;

    //make variables for all the enum states
    //put all your choice boxes/ paths in the enum sates

    // remember to go to unity after you've finished and updated everything and go to gameobject    
    // and drag button text mesh pro into the script and choose the story text and choice text options for the text  under the game script in the inspector
    // change the name of the enum states to just numbers to make it simpler
    // Rename your room in flow chart to the name of the code
    //input the code to change images depending on the room
    // doing all that color stuff in void checking case files gives that letter color, use unity to find out which color
    // to have something bold do this, '<b>'
    //create a lose scene and a main menu scene, and a win scene
    //create different script for scenes
    //so basically to code for a scene either make a string that makes the player go to a certain scene OR
    //another way is to just make a function or maaaaaaaaaaaybe possibly a slight chance an enum state and just put in the scene function there.
    //look at wizard script for intellectual guidance 
    //fix all this stuff 
    
    void Awake()
    {
        myState = States.Beginning0; 
    }

    // Update is called once per frame
    void Update()
    {
        if(myState == States.Beginning0)
        {
            beginning0();
        }else if(myState == States.EnteringDungeon0)
        {
            enteringdungeon0();
        }else if(myState == States.CheckingCaseFiles0)
        {
            checkingcasefiles0()
        }
    }

    void checkingcasefiles0()
    {
        storyText.SetText("Alright listen up Scorch, Aftershock, this place is known as the Kami's God of Repentance which probably means it's some sort of dangerous dungeon." +
            "This place was first discovered once a popular explorer went missing 2 weeks ago. And so a team of 4 navy seals entered to rescue them" +
            "However it's been one week since so they're missing as well. The most recent missing person is Seth, he's reported to be a loner with the " +
            "magical powers to create shockwaves" +
            " he has no family members and only one real friend, and said friend is the one who called us. So yeah, this is a missing persons case" +
            "and it is imperative we rescue them or atleast obtain the bodies. ");
        choiceText.SetText("Press <color=#00ff12>K</color> A to return to the beginning  options");

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.Beginning0;
        }
    }

    void enteringdungeon0()
    {
        storyText.SetText("As the three of you enter the dungeon the door automatically closes behind you, with the metal frame of the door slamming against its " +
            "casing causing the sound to reverberate throughout the one way stone hallway signifying the scope of the hallway to you.");

        choiceText.SetText("Press A to go back through the entrance / Press B to Continue walking / Press C to Ask your Partners what they think");

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.TryingToExitThroughEntrance0;
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.ContinueWalking0;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.AskingPartnersAfterEnteringDungeon0; 
        }

      

    }

    void tryingtoexitthroughentrance0()
    {
        storyText.SetText("You attempt to pull the handles of the door however you forgot your daily" +
            " intake of 1 gram of protein causing your attempt to fail.");
        choiceText.SetText("Press B to return to prior options / Press C to Continue Walking");

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.EnteringDungeon0;
        } else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.ContinueWalking0;
        }
    }

    void askingpartner0()
    {
        storyText.SetText("Scorch: Ugh, why are we just standing around?! " +
            "We should just enter already it's not like knowing what's gonnna happen is gonna change the outcome." +
            "Aftershock: That's exactly what it means!! It's called p r e v e n t i n g, we need to take our time and observe every possible detail.");
        choiceText.SetText("Press A to return to the prior options");
            GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[1];
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.Beginning0;
        }
    }

   
        void lookaround0()
        {
            storyText.SetText("You observe the outer architectural designs of the dungeon and notice that the materials are quite prestine and modern +
                "and even though it's embedded onto the side of a mountain the gold plating of the dungeon seems almost untouched.");
            choiceText.SetText("Press A to return to prior options");
            
            if (Input.GetKeyDown(KeyCode.A))
            {
                myState = States.Beginning0;
            }    
        }

    void askingPartnersafterEnteringdungeon0()
    {
        storyText.SetText("Scorch: Doesn't matter, let's go in guns blazing!!" +
            "Aftershock: Wait wha- no! Our only known exit just suddenly shut before us" +
            "This is definitely something we should worry about! UGHHH!!!");
        choiceText.SetText("Press A to go back to prior options / Press B to continue walking");

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.EnteringDungeon0;
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.ContinueWalking0;
        }

    }

        void continuewalking0()
        {
            storyText.SetText("You continue walking and are met with the gaze of dozens of human sized statues on the sides of a seemingly endless hallway" +
                " that is lit by torches in the hands of each statue. And the end of the hallway seems to be an exit but it's blocked by a large stone sphinx.");
            choiceText.SetText("Press A to attempt to walk past it / Press B to investigate your surrounddings / Press C to ask if your partners see any thing");
            
          if (Input.GetKeyDown(KeyCode.A))
        {
          myState = States.AttemptWalkPast0;
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.InvestigatingYourSurroundings0;
        }
          else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.AskingWhatTheySee0;
        }
     
    }

        void askingwhattheysee0()
        {
            storyText.SetText("Scorch: I don't see anything" +
                "Aftershock: Of COURSE you didn't see anything, you're not even looking!" +
                "Hmmm... OH! There are symbols encarved on the walls, one of a ball coming down on a man, another of a multitude of men with fangs" +
                "biting down on a man. and there is another one where a stick figure is getting stabbed from behind the back... I wonder what any of it means.");
            choiceText.SetText("Press A to go back to prior options / Press B to try to walk");
            //create the strings for this later 
                
        }

        void investigatingyoursurroundings0()
        {
            storyText.SetText("You see a spilled water bottle on the floor and " +
                "note that the moisture of the water has not evaporated thereby meaning that this was recent and there might be survivors.");
            choiceText.SetText("Press A to go back to prior options / Press B to try to walk past it");
            //create strings for this later 
        }

        void scorchjumpkickssphinx0()
        {
            storyText.SetText("Scorch attempted to jump-kick a large sphinx statue made of stone and severely twisted his ankle." +
                " The humanized stone statues awaken and attack due to not following the riddle.");
            choiceText.SetText("Press A to have Scorch create a ice walll to block the statue's path / Press B to try and kill the statues" +
                "/ Press C You hold them off while Aftershock searches for an exit");
            //create strings for this later 
        }



        void beginning0()
    {
        storyText.SetText("You and your two teammates arrive at a dungeon," + "for this rescue mission, what do you do first?");

        choiceText.SetText("Press A to just enter the dungeon / Press B to review case files / Press C to look around environment / Press D to ask partners about case");
        //copy the the game object get component image thing below to other functions and replace the 0 to another number but only do this if you want an image change
       
        GameObject.Find("Panel").GetComponent<Image>().sprite = imageArray[0];

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.CheckingCaseFiles0;
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.EnteringDungeon0; 
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.Lookaround0;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.AskingPartner0;
        }
    }

    //make some coding stuff for making the winnning, losing, and main menu scene for the script 

}
