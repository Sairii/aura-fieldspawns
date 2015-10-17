//--- Aura Script -----------------------------------------------------------
// Tir Another World(35)
//--- Description -----------------------------------------------------------
// Warp and spawn definitions for Tir Another World.
//---------------------------------------------------------------------------

public class TirAnotherWorldArenaRegionScript : RegionScript
{
	public override void LoadWarps()
	{

	}

	public override void LoadSpawns()
	{	
		// Graveyard South (Group 77)
		CreateSpawner(race: 180001, amount: 8, region: 35, coordinates: A(16115,40531, 16115,46119, 19130,46119, 19130,40531));  // Male Zombie
		CreateSpawner(race: 180002, amount: 8, region: 35, coordinates: A(16115,40531, 16115,46119, 19130,46119, 19130,40531));  // Female Zombie

		// Near Inn (Group 87)
		CreateSpawner(race: 20401, amount: 8, region: 35, delay: 100, delayMin: 10, delayMax: 10, coordinates: A(19167,39826, 21138,38744, 19281,35358, 17310,36439));  // Timber Wolf

		// Near Healer (Group 83)
		CreateSpawner(race: 20401, amount: 8, region: 35, delay: 100, delayMin: 10, delayMax: 10, coordinates: A(9938,43120, 9923,47580, 13341,47591, 13356,43131));  // Timber Wolf
		CreateSpawner(race: 150001, amount: 1, region: 35, delay: 1000, delayMin: 10, delayMax: 10, coordinates: A(9938,43120, 9923,47580, 13341,47591, 13356,43131));  // Giant Worm

		// Near Church (Group 82)
		CreateSpawner(race: 20401, amount: 8, region: 35, delay: 100, delayMin: 10, delayMax: 10, coordinates: A(8280,40345, 8720,38521, 6689,38031, 6249,39855));  // Timber Wolf
		CreateSpawner(race: 150001, amount: 1, region: 35, delay: 1000, delayMin: 10, delayMax: 10, coordinates: A(8280,40345, 8720,38521, 6689,38031, 6249,39855));  // Giant Worm

		// Near School (Group 81)
		CreateSpawner(race: 20401, amount: 8, region: 35, delay: 100, delayMin: 10, delayMax: 10, coordinates: A(2252,27421, 2252,31750, 7759,31750, 7759,27421));  // Timber Wolf
		CreateSpawner(race: 150001, amount: 1, region: 35, delay: 1000, delayMin: 10, delayMax: 10, coordinates: A(2252,27421, 2252,31750, 7759,31750, 7759,27421));  // Giant Worm

		// Near Alby (Group 86)
		CreateSpawner(race: 20401, amount: 8, region: 35, delay: 100, delayMin: 10, delayMax: 10, coordinates: A(10625,49354, 8268,52432, 9059,53038, 11416,49960));  // Timber Wolf

		// Inn Road (Group 88)
		CreateSpawner(race: 20401, amount: 3, region: 35, delay: 100, delayMin: 10, delayMax: 10, coordinates: A(12269,34401, 12621,34971, 15021,33490, 14668,32919));  // Timber Wolf

		// South (Group 79)
		CreateSpawner(race: 20401, amount: 8, region: 35, delay: 100, delayMin: 10, delayMax: 10, coordinates: A(26930,37599, 21707,31426, 20500,32448, 25723,38621));  // Timber Wolf

		// Southern Plains (Group 80)
		CreateSpawner(race: 20401, amount: 8, region: 35, delay: 100, delayMin: 10, delayMax: 10, coordinates: A(13416,26080, 14125,24278, 7143,21533, 6434,23335));  // Timber Wolf
		CreateSpawner(race: 150001, amount: 1, region: 35, delay: 1000, delayMin: 10, delayMax: 10, coordinates: A(13416,26080, 14125,24278, 7143,21533, 6434,23335));  // Giant Worm

		// Graveyard North (Group 77)
		CreateSpawner(race: 180001, amount: 8, region: 35, coordinates: A(16115,40531, 16115,46119, 19130,46119, 19130,40531));  // Male Zombie
		CreateSpawner(race: 180002, amount: 8, region: 35, coordinates: A(16115,40531, 16115,46119, 19130,46119, 19130,40531));  // Female Zombie
	}
}


