//sarcastic
-> main

===main===
#speaker:Angeline #layout:left
Hm? #portrait:Angeline_idle #layout:left
Oh hey! #portrait:Angeline_surprised #layout:left
She rushes over to the player with a hot cup of coffee. She trips and accidentally spills it all over the table, though thankfully the player wasn’t affected as he was able to quickly get up.
Agh- Sorry, sorry! Damn heels...! #portrait:Angeline_scared #layout:left

    +[It's okay]
        It’s okay, it was an accident. Are you alright? #speaker: Player
             “I’m glad you’re not hurt. Sorry for spilling your coffee, glad to see you’re okay at least.” #speaker:Angeline #portrait:Angeline_happy #layout:left
    She cleans up the mess with a sheepish smile, feeling bad for what happened but appreciative of the player’s forgiveness and understanding.
    
    “I’ll be back with your food after I clean this up.” #speaker:Angeline #portrait:Angeline_scared #layout:left
        ->DONE
    
    +[Be careful!]
        “Jeez! I could’ve gotten hurt by that, klutz!” #speaker: Player
         “Okay, okay! I know I messed up, but you don’t have to be a jerk about it.” #speaker:Angeline #portrait:Angeline_angry #layout:left
    Angeline clearly feels hurt about the player’s reaction. She knows it was her fault but the player didn’t need to rub it in.
     “I’ll be back with your food after I clean this up.” #speaker:Angeline #portrait:Angeline_scared #layout:left
    ->DONE
    
    +[Woah]
        "Woah! Almost became a coffee cup, don’t think that would’ve gone well.” #speaker: Player
        “Haha! Well, it makes me glad that at least you’re not hurt. I’m sorry again for what happened, I’ll get you a new cup after I clean this up.” #speaker:Angeline #layout:left #portrait:Angeline_happy #layout:left
        She cleans up the mess with a smile, appreciative of the player’s lightheartedness on the situation.
        
        “I’ll be back with your food after I clean this up.” #speaker:Angeline #portrait:Angeline_scared #layout:left
        ->DONE
        
    
->END