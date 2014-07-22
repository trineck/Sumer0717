using UnityEngine;
using System.Collections;

public class TextWorld : MonoBehaviour {

	string currentRoom = "Living Room";
	bool hasBedroomKey = false;
	bool hasMailboxKey = false;
	// Update is called once per frame
	void Update () {
		string textBuffer = "You are currently in " + currentRoom;
		if (currentRoom == "Living Room") {
						textBuffer += "\nYou awake suddenly in a small couch.\nWhat happened last night?\nYou feel sick and get headache.\nYou really want to go to bed.";
						textBuffer += "\nPress [W] to go to Bedroom";
						textBuffer += "\nPress [S] to get out of the Living room";

						if (Input.GetKeyDown (KeyCode.W)) {
								currentRoom = "Bedroom";
						} else if (Input.GetKeyDown (KeyCode.S)) {
								currentRoom = "Hallway";
						}
				} else if (currentRoom == "Bedroom") {

						if (hasBedroomKey == false) {
								textBuffer += "\nYou cannot open the door without your Key.";
								textBuffer += "\nPress [S] to go back to Living Room.";
								if (Input.GetKeyDown (KeyCode.S)) {
										currentRoom = "Living Room";
								} 
						} else {
								textBuffer += "\nYou unlock the door and get into your lovely bedroom.\nThough there is something on your bed that doesn't\nbelong to you,\nyou're dying to get some rest.\nYou decide to figure out what's going on\nwhen you awake again.\nGood night!";
						}

				} else if (currentRoom == "Hallway") {
						textBuffer += "\nThere is nothing but a Storage and a Mailbox";
						textBuffer += "\nPress [S] to go back inside.";
						textBuffer += "\nPress [D] to go to the Storage.";
						textBuffer += "\nPress [A] to go to the Mailbox.";

						if (Input.GetKeyDown (KeyCode.S)) {
								currentRoom = "Living Room";
						} else if (Input.GetKeyDown (KeyCode.D)) {
								currentRoom = "Storge";
						} else if (Input.GetKeyDown (KeyCode.A)) {
								currentRoom = "front of the Mailbox";
						}
				} else if (currentRoom == "Storge") {
						textBuffer += "\nIt is so dark here,\nyou get your lighter out\nand look around.\nOn the floor, you found your Mailbox key.";
						textBuffer += "\nPress [S] to go back to the Hallway.";
						hasMailboxKey = true;

						if (Input.GetKeyDown (KeyCode.S)) {
								currentRoom = "Hallway";
						}
				} else if (currentRoom == "front of the Mailbox") {
						if (hasMailboxKey == false) {
								textBuffer += "\nYou cannot open the Mailbox without your Key.";
								textBuffer += "\nPress [S] to go back to Hallway.";
								if (Input.GetKeyDown (KeyCode.S)) {
										currentRoom = "Hallway";
								} 
						} else {
								textBuffer += "\nYou open the Mailbox which is on the wall.\nIt's full of envelops.\nYou pull out all of them\nand you found your bedroom key\non the bottom of the Mailbox.";
								textBuffer += "\nPress [S] to go back to living room.";
								hasBedroomKey = true;
			
								if (Input.GetKeyDown (KeyCode.S))
										currentRoom = "Living Room";
						}
				}
		GetComponent<TextMesh>().text = textBuffer;
	
	}
}