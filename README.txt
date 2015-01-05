=======
KeySAV2
=======

KeySAV 2.0

3DS X/Y/OR/AS SaveFile Box / Battle Video PKX cracking program.

KeySAV is a tool that can decrypt portions of encrypted Generation 6 Pokemon saves, including X, Y, Omega Ruby, and Alpha Sapphire.

With this tool you can view IVs/Nature/ESV/TSV and much more of Hatched/Unhatched Pokémon that are in your boxes or battle videos, as long as you follow the setup guide properly.

SUPPORTS BOTH RETAIL CARTRIDGES AND DIGITAL COPIES

If you have a digital copy, you only need an SD card reader to extract your encrypted save.

If you have a retail copy, you need additional hardware to extract your encrypted save from your cartridge, such as the Datel Action Replay PowerSaves 3DS.

CyberGadget encrypted save backups are also supported.


Thread:
http://projectpokemon.org/forums/showthread.php?41752

Originally created by Kaphotics

Modifications by
ViolentSpatula
Cu3PO42 (http://www.reddit.com/r/SVExchange/comments/2nun41/new_keysav2_build_with_more_features_that_does/)
Kaisonic (http://www.reddit.com/r/SVExchange/comments/2o4qiu/a_newer_keysav2_build_with_even_more_features/)

==============================
Changelog for Kaisonic's Build
==============================
KeySAV2 1.3.7 (2015-01-05)
- Fixed auto-open paths - battle videos and saves should now open automatically when the SD card is inserted
- Added support for CyberGadget backups
- Merged filter updates from Cu3PO42's version
- Filter options are only visible when filter is enabled
- Fixed level calculation (see change in PkHex)
- Added ball image column for the SVExchange subreddit

KeySAV2 1.3.6 (2014-12-14)
- CSV output file name now defaults to name of the SAV or BV you've opened
- Fixed: IV counter shows "1 IVs"
- Fixed: hatched date for eggs is "2000-00-00"
- Added: "Steps to Hatch" column for eggs
- Added: "Reset to Default" button for CSV custom output

KeySAV2 1.3.5 (2014-12-07)
- Added columns: OT gender, met level, OT friendship, OT affection
- Fixed newlines and file paths for better compatibility

KeySAV2 1.3.4 (2014-12-07)
- Fixed "Backup SAV" button size
- Fixed empty first line in text output if "Split Boxes" was checked
- Added more descriptive headers ("All Boxes", "Boxes 1-4", etc)
- Fixed shiny star appearing for eggs (it is now a checkmark, like it should be)
- Fixed Unown forms (will now show as "Unown-A", "Unown-D", "Unown-!", etc)
- Added a column for number in the dump (just goes from 1 to number of Pokémon dumped)
- Added Pokerus status columns (Infected and Cured)
- Re-ordered default CSV custom columns to make a little more sense
	- To reset your CSV custom format, erase the format from the text box, switch to another format, then switch back to CSV custom and the default will be filled in
	- This default is just a specific order of ALL available columns
	- This does NOT effect the "CSV default" option, so any program that parses the standard CSV output from this program will still work!
- README.txt file with changelog and full guide now included
- More code refactoring
- Updated guide so the breaking process is easier to follow

KeySAV2 1.3.3
- Removed legacy save breaking behavior option (confusing and unnecessary)
- Fixed output text box extending beyond window
- Remove unstable key-breaking code
- Changed CSV custom to allow custom formats
- Show headers once if "Split Boxes" is not checked
- Use "Box" instead of just "B" for headers
- Fixed brackets for ESV appearing in CSV data
- Added columns: experience
- Added translations for "Game" and "Region" columns ("Country" is still English for all)

KeySAV2 1.3.2
- Added "Egg Received" and "Met/Hatched" columns
- Fixed legacy break help box

KeySAV2 1.3.1
- Added option to use legacy save-twice file-breaking behavior (click "What's this?" in the app for more info)

KeySAV2 1.3
* Added available columns: Level, Region, Country, Held Item, Language, Game, Number, PID, Mark, Dex Number, Form
* Fixed "mark" - pentagon mark is now present for all Pokémon created in generation 6
* Fixed "Number" column to be 1-indexed
* Fixed help box to be resizable and able to be kept open while working in the main window
* Added ORAS game support for "Game" and "Region" values
* Fixed superfluous spaces in CSV data
* Added perfect IV marker columns
* Added perfect IV counter column
* Added IV and EV sum columns
* Changed pk6 file output to be in box order rather than species order (for better PkHex support)
* Code refactoring (combined dumpPKX_BV and dumpPKX_SAV)
* Added option to show ESV for hatched Pokémon
* Added option to enclose trainer and Pokémon nicknames in quotes for CSV exports (to prevent problems with commas in either)

===================================================
Cu3PO42's Full Usage Guide (from his reddit thread)
===================================================
Initial setup: breaking the encryption

Depending on your hardware and version of the game, you have the choice to use Battle Videos or save dumps to break the encryption.

Option 1: using save files
Extracting the saves

Two possibilities:

    If you have a digital version of the game, the saves are stored on the SD card of the 3DS.
	For X, the path is \title\00040000\00055d00.
	For Y, it is \title\00040000\00055e00.
	For OR, it is \title\00040000\0011C400\.
	For AS, it is \title\00040000\0011C500\.
    If you have a retail copy, you need to use the program that ships with the PowerSaves. The save files are stored in C:\Users\YourName\Powersaves3DS.

Breaking the encryption

If you keep checking from the same boxes, you will only have to do that step once.

    -Clear out boxes 1 & 2 by moving the Pokémon to other boxes.
	-If you plan on being able to fully decrypt ALL Pokémon from ALL boxes, it is advised (but optional) to have all other boxes empty as well (move them to the Bank if you can).
    -Capture or hatch 6 Pokémon. They have to come from your game.
    -Put those 6 Pokémon on the top row of the first box.
    -Save once, soft reset (hit Select + L + R), launch the game and save again.
    -Export your save. Locate your save on your PC. Rename the first save save2.bin or save2.sav, depending on its original extension. If you are using the downloaded copy of the game, remember to copy the save file to another location before renaming. Do not rename the save file on the SD Card.
    -Run the game, and move all 6 Pokémon to the top row of box 2.
    -Save once. Only once. Do not save twice.
    -Export your save. Locate your save on your PC and rename the second save save3.bin or save3.sav, depending on its original extension.
    -Run the game. Save once. Only once. Do not save twice.
    -Export your save. Locate your save on your PC and rename the third save save1.bin or save1.sav, depending on its original extension.
    -Run KeySAV2. On the Options tab, click on File 1 and load save1. Click on File 2 and load save2. Click on File 3 and load save3. Click on the upper Break button.
    -Save the file in the suggested folder.
    -This step is optional, but highly suggested: click on Folder, select the folder where you keep your save backups. This folder may contain backups from other games as well, this has no effect. Now click the lower Break.

Breaking the encryption for more boxes

After you initially broke the encryption you can dump any box. However since KeySAV2 will not yet have acquired the necessary information, some results may be inaccurate/wrong. In the Options tab you can therefore choose to hide or mark any results with a certainty less than 100% as such. The latter is recommended.

If you followed the last step of the guide, depending on the number of backups you have already created, a lot of slots will already be fully broken. If you don’t notice any marked slots in the output you may skip the next steps or only do them selectively for the marked slots.

To completely unlock each slot (a space in your boxes) you need three saves: one where the slot is empty, one with a Pokémon in the slot and one with a different Pokémon in the slot. Three more saves suffice to completely break everything!

    -Empty all boxes that you want to unlock.
    -Create a backup.
    -Fill the boxes with Pokémon.
    -Create a backup.
    -Fill the boxes, so that each slot holds a different Pokémon (easiest thing to do is just move all boxes over by one).
    -Create a backup again.
    -In the Options tab select the folder where you stored the saves and click on the lower Break.

Option 2: using Battle Videos
Additional prerequisites

You will need the following:

    A friend in your Friend List that would be willing to battle you,
    The Vs. Player, obtained in Kiloude City after beating the E4 (X/Y) or at the Battle Resort (OR/AS),
    Disable forced saving. Go to your game's options (the icon circled in red), scroll down to the bottom and disable forced saves.

Extracting the Battle Videos

Keep in mind that Battle Videos might not be sorted chronologically, so check the files' modification dates to make sure you picked the correct one.

    The Battle Videos are stored on the SD card of the 3DS. KeySAV2 should automatically load the correct video. If not, the path is either \Nintendo 3DS\*\*\extdata\00000000\0000055d\00000000 or \Nintendo 3DS\*\*\extdata\00000000\0000055e\00000000 for X/Y, or \extdata\00000000\0011c400\00000000\ or \extdata\00000000\0011c500\00000000\ for OR/AS.

Breaking the encryption

Note: up to 100 Battle Videos can be stored on the SD card. Before being able to dump the contents of your team, you will need to break the encryption of one Battle Video slot. Battle Videos are always saved to the lowest available slot, and being able to decrypt one slot will not help you break another. KeySAV2 remembers the slots you have unlocked, so either make sure to always use the same Battle Video slot and delete each new Battle Video from your SD card once you have copied it to your PC, or only use slots that you have unlocked before.

    -Be in a Pokémon Center, in front of the PC. Don't move anymore.
    -Battle your friend in a Singles match and enter only 1 Pokémon from your party.
    -Forfeit the battle and save the Battle Video.
    -Plug the SD card in your computer, copy the file to a safe place on your computer, add -1 to its name.
    -Delete the Battle Video from the SD card only.
    -Plug the SD card back in the 3DS.
    -Battle your friend in a Singles match with 2 Pokémon from your party. The first one doesn't matter, but make sure the second one you enter is the original Pokémon you used for the first Battle Video.
    -Forfeit the battle and save the Battle Video.
    -Plug the SD card in your computer, copy the file to a safe place on your computer, add -2 to its name.
    -Delete the Battle Video from the SD card only.
    -Plug the SD card back in the 3DS.
    -Open KeySAV2, go to the Options tab, load the two videos.
    -Click on Break, and save the resulting file in the suggested folder.

Checking ESVs and TSVs
Option 1: using save files

KeySAV2 will check ESVs and TSVs for a single box or a range of boxes.

    -Have your eggs or Pokémon laid out in a box that you have unlocked before.
    -Save. Once is enough.
    -Export your save.
    -Run KeySAV2. On the SAV tab, click on Open SAV to load the newly-exported save file.
    -Select the box number or range you wish to rip and add any filters that you may find useful.
    -Click on Go. The results are displayed and copied in the clipboard.

Option 2: using Battle Videos

You can now dump as many Pokémon as you wish from Battle Videos, as long as the Battle Videos are saved in the same slot.

    -If you want to check ESVs, get up to 6 eggs, save the game, hatch them, put them in your party and battle your friend.
    -If you want to check TSVs, put the 6 Pokémon you want to check in your party and battle your friend.
    -Forfeit the battle and save the Battle Video. Do not switch off the 3DS.
    -Plug the SD card in your computer, KeySAV2 should load it automatically. If not, copy the file to your computer.
    -Delete the Battle Video from the SD card only.
    -Plug the SD card back in the 3DS.
    -Open KeySAV2, go to the BV tab, and load your video.
    -Click on Go.
    -If you were checking eggs, you can now either reset your 3DS to "unhatch" the eggs, or save your game and release those.
