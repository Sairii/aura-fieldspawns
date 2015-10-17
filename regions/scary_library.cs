//--- Aura Script -----------------------------------------------------------
// Scary Library (76)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Dunbarton Scary Library.
//---------------------------------------------------------------------------

public class ScaryLibraryRegionScript : RegionScript
{
	public override void LoadSpawns()
	{
		// Scary Library (Group 211)
		CreateSpawner(race: 17603, amount: 4, region: 76, delay: 60, delayMin: 10, delayMax: 10, coordinates: A(9522,8252, 9522,10343, 10764,10343, 10764,8252));  // Ghost
		CreateSpawner(race: 17604, amount: 4, region: 76, delay: 60, delayMin: 10, delayMax: 10, coordinates: A(9522,8252, 9522,10343, 10764,10343, 10764,8252));  // Ghost2
		CreateSpawner(race: 17701, amount: 4, region: 76, delay: 10, delayMin: 10, delayMax: 10, coordinates: A(9522,8252, 9522,10343, 10764,10343, 10764,8252));  // Hollow_Knight
		CreateSpawner(race: 80301, amount: 10, region: 76, delay: 10, delayMin: 5, delayMax: 5, coordinates: A(9522,8252, 9522,10343, 10764,10343, 10764,8252));  // Cloaker
	}
}


