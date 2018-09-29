using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pterasaur : MonoBehaviour {
	private void OnMouseDown()
	{
		//allow player to select pterasaur
		//match pterasaurs
		//probably should decide if this is tetris with pterasaurs or 3-13 with pterasaurs
		//or both?
		//So people have to match the pterasaurs with each other in different combinations before there's no room left, 
		//and if they match the right combinations, they beat the level. If they take to long, the liopleurodon/mosasaur/
		//t-rex/whatever comes by and starts eating the pterasaurs, so they can't beat it. 
		//Meteor? Can I do the meteor? Is that too dark? Then again, I've already got a aquatic reptiles coming in and eating the 
		//pterasaurs. 
		//Okay change of tack. 
		
		//Pterasaur flight game. The objective is to get the pterasaur to fly. In order to fly, the pterasaur must 
		//have enough speed and enough points. Points are gained by collecting lizards and fish. Speed is gained by changing 
		//the slope of the ground.  The player can drag a point at the end of the ground and 
		//draw the horizon. The must do this in the time allotted, or the ground will run out and the pterasaur with jump off 
		//of a cliff and get eaten by a liopleurodon or something. Winning a level unlocks a different kind of pterasaur;
		//each pterasaur has its own way of getting up in the air. 
		
		//So, for this, I'll need: a way for the player to drag the dot and draw the ground; a way for the ground to be run on; 
		//run cycles for the different pterasaurs; destroy and point scripts for the lizards and fish; worlds; a countdown;
		//if or switch statements for the speed and the points
	}
}
