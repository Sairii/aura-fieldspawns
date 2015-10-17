//--- Aura Script -----------------------------------------------------------
// Rabbie Arena (97)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Rabbie Arena.
//---------------------------------------------------------------------------

public class RabbieArenaRegionScript : RegionScript
{
	public override void LoadWarps()
	{

	}

	public override void LoadSpawns()
	{	
		// Rabbie Arena Center (Group 251)
		CreateSpawner(race: 13007, amount: 3, region: 97, delay: 3600, delayMin: 1200, delayMax: 1200, coordinates: A(4453,4948, 4453,6272, 5889,6272, 5889,4948));  // Arena_Sahuagin_Lost
		CreateSpawner(race: 190004, amount: 2, region: 97, delay: 3600, delayMin: 1200, delayMax: 1200, coordinates: A(4453,4948, 4453,6272, 5889,6272, 5889,4948));  // Arena_FlyingSword

		// Rabbie Arena East (Group 252)
		CreateSpawner(race: 10607, amount: 2, region: 97, delay: 600, delayMin: 120, delayMax: 180, coordinates: A(6290,5328, 6290,5858, 6865,5858, 6865,5328));  // Arena_Imp
		CreateSpawner(race: 20023, amount: 2, region: 97, delay: 600, delayMin: 120, delayMax: 180, coordinates: A(6290,5328, 6290,5858, 6865,5858, 6865,5328));  // Arena_WhiteWolf

		// Rabbie Arena West(Group 253)
		CreateSpawner(race: 10607, amount: 2, region: 97, delay: 600, delayMin: 120, delayMax: 180, coordinates: A(3514,5372, 3514,5902, 4089,5902, 4089,5372));  // Arena_Imp
		CreateSpawner(race: 70014, amount: 2, region: 97, delay: 600, delayMin: 120, delayMax: 180, coordinates: A(3514,5372, 3514,5902, 4089,5902, 4089,5372));  // Arena_WhiteBear

		// Rabbie Arena North (Group 254)
		CreateSpawner(race: 80102, amount: 3, region: 97, delay: 1200, delayMin: 600, delayMax: 600, coordinates: A(4938,4146, 4938,4676, 5513,4676, 5513,4146));  // Arena_Wisp

		// Rabbie Arena South (Group 255)
		CreateSpawner(race: 90007, amount: 3, region: 97, delay: 1200, delayMin: 600, delayMax: 600, coordinates: A(4889,6391, 4889,6920, 5464,6920, 5464,6391));  // Arena_Mimic
	}
}